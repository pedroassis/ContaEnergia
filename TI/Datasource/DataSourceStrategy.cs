using System;
using System.Collections.Generic;
using TI.Reflection;
using System.IO;

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
		
		private static readonly List<T> cachedDataSource;

		private Func<T, String, Object, Boolean> equalityComparator = (listObject, propName, toCompare) => {
			return PropertyCallAdapterProvider<T>.GetInstance (propName).InvokeGet (listObject).Equals (toCompare);
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
			return dataSource.setDataSource (cachedDataSource);
		}

        public Boolean add(T item)
        {
            List<T> list = this.getAll();
            list.Add(item);
            return this.addAll(list);
        }

	}
}

