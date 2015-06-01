using System;
using System.Collections.Generic;
using TI.Reflection;
using System.IO;
using System.Linq;

namespace TI.DataSource
{
	public class DataSourceStrategy<T> : Strategy<T>
	{

		static DataSourceStrategy(){
			type = typeof(T);
			String name = type.Name;
			dataSource = new FileDataSource(new DirectoryInfo(Directory.GetCurrentDirectory () + Path.DirectorySeparatorChar + "data"  + Path.DirectorySeparatorChar + name), "Id");
			cachedDataSource = dataSource.getDataSource<T>();
		}
		
		private static readonly Type type;
		
		private static DataSource dataSource;
		
		private static List<T> cachedDataSource;

		private Func<T, String, Object, Boolean> equalityComparator = (listObject, propName, toCompare) => {
            Object obj = PropertyCallAdapterProvider<T>.GetInstance(propName).InvokeGet(listObject);
            return obj != null && obj.Equals(toCompare);
		};
		
		public List<T> getAll(){
			return cachedDataSource;
		}
		
		public T getById(Object id){
			
			return cachedDataSource.Find(listObject => equalityComparator(listObject, "Id", id));
			
		}

        public List<T> find(String propertyName, Object valueField){
			return cachedDataSource.FindAll(listObject => equalityComparator(listObject, propertyName, valueField));
		}
		
		public T findOne(String propertyName, Object valueField){
			return cachedDataSource.Find(listObject => equalityComparator(listObject, propertyName, valueField));
		}
		
		public Boolean delete(){
			return dataSource.setDataSource(new List<T>());
		}
		
		public Boolean delete(T item){
			return dataSource.delete(item);
		}

		public Boolean deleteOne(String propertyName, Object valueField){
			T toDelete = this.findOne(propertyName, valueField);

			if(toDelete != null){
				dataSource.delete(toDelete);
			}
			return true;
		}

		public Boolean addAll(List<T> list){
			cachedDataSource.AddRange (list);
			dataSource.setDataSource (cachedDataSource);
			Dictionary<Object, T> result = new Dictionary<Object, T> (list.Count);
			foreach(T item in cachedDataSource){
				Object id = PropertyCallAdapterProvider<T>.GetInstance ("Id").InvokeGet (item);
				result [id] = item;
			}
			cachedDataSource.Clear ();
			cachedDataSource.AddRange(result.Values.ToList());
			return true;
		}

        public Boolean add(T item)
        {
            List<T> list = this.getAll();
            list.Add(item);
			Object id = PropertyCallAdapterProvider<T>.GetInstance ("Id").InvokeGet (item);
			list.RemoveAll (x => equalityComparator(x, "Id", id));
			return dataSource.setDataSource (list);
        }

	}
}

