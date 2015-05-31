using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.IO;
using TI.Reflection;
using System.Reflection;
using System.Threading.Tasks;

namespace TI.DataSource
{
    class FileDataSource : DataSource
    {
        public DirectoryInfo folder;
		
		private String fileNameProperty;
		private String nameProperty;

        public FileDataSource(DirectoryInfo folder, String fileNameProperty)
        {
            this.folder = folder;
			this.fileNameProperty = fileNameProperty;
			if(!folder.Exists){
				folder.Create();
			}
        }

        public List<T> getDataSource<T>(){
            Type type = typeof(T);

            List<String> props = readProperties(type);

            List<T> dataSource = new List<T>();

			DirectoryInfo typeFolder = new DirectoryInfo(folder.FullName + Path.DirectorySeparatorChar + type.Name);

            if (!typeFolder.Exists) {
                typeFolder.Create();
            }

            FileInfo[] files = typeFolder.GetFiles();

            foreach (FileInfo file in files)
            {

				using (StreamReader reader = new StreamReader(folder.FullName + Path.DirectorySeparatorChar + type.Name + Path.DirectorySeparatorChar + file.Name))
                {

                    T dataSourceObject = (T) Activator.CreateInstance(type);

                    int currentProperty = 0;
                    while (!reader.EndOfStream && props.Count > currentProperty)
                    {
                        String line = reader.ReadLine();

						Object value = getValue<T>(type, props[currentProperty], line);

						PropertyCallAdapterProvider<T>.GetInstance (props [currentProperty]).InvokeSet (dataSourceObject, value);

                        currentProperty++;
                    }

                    dataSource.Add(dataSourceObject);
                }
                
            }
            return dataSource;
        }

        private Object getValue<T>(Type type, String name, Object value){
			Type fieldType = PropertyCallAdapterProvider<T>.GetInstance (name).getGetter().ReturnType;
            if (fieldType == typeof(String))
            {
                return value;
            }

            return fieldType.GetMethod("Parse", new[] { typeof(string) }).Invoke(null, new String[] { (String)value });
        }

        public bool setDataSource<T>(List<T> data){

            Type type = typeof(T);

            deleteFiles(type);

			BlockingCollection<T> c = new BlockingCollection<T> (data.Count);

			foreach(T t in data){
				c.Add (t);
			}

			var coresCount = Environment.ProcessorCount;

			while(coresCount > 0){
				coresCount--;
				Task.Run (() => {

					while(!c.IsCompleted){
						T obj = c.Take();
						using (TextWriter writer = new StreamWriter(folder.FullName + Path.DirectorySeparatorChar + type.Name + Path.DirectorySeparatorChar + getFileName(obj), true))
						{
							writer.Write(obj);
						}
					}

				});
			}
			
            return true;
        }
		
        public bool delete<T>(T dataSourceItem){
            Type type = typeof(T);

            FileInfo[] files = new DirectoryInfo(folder.FullName + type.Name).GetFiles();

			FileInfo toDelete = null;
			
			foreach(FileInfo file in files){
                if (getFileName<T>(dataSourceItem).Equals(getFileName(dataSourceItem)))
                {
					toDelete = file;
				}
			}
			
			if(toDelete != null) toDelete.Delete();
			return true;
		}

        private String getFileName<T>(T obj){
            Type type = typeof(T);
			String nameValue = null;
			
			if(nameProperty == null && fileNameProperty != null){
				nameValue = type.GetProperty(fileNameProperty).GetValue(obj).ToString();
			}
			
			return nameValue == null ? obj.GetHashCode().ToString() : nameValue;
		}
		
		private void deleteFiles(Type type){

			FileInfo[] files = new DirectoryInfo(folder.FullName + Path.DirectorySeparatorChar + type.Name).GetFiles();
			
            foreach (FileInfo file in files){
				file.Delete();
			}
		}

        private List<String> readProperties(Type type) {
            List<String> props = new List<string>();

            PropertyInfo[] fields = type.GetProperties();
         
			foreach(PropertyInfo field in fields){
                props.Add(field.Name);
            }
            return props;
        }
    }
}
