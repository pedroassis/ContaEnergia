using System;
using System.Collections.Generic;
using TI.Reflection;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TI.DataSource
{
    public class DataSourceStrategy<T> : Strategy<T>
    {

        static DataSourceStrategy()
        {
            type = typeof(T);
            String name = type.Name;
            dataSource = new FileDataSource(new DirectoryInfo(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "data" + Path.DirectorySeparatorChar + name), "Id");
            cachedDataSource = dataSource.getDataSource<T>();
        }

        private static readonly Type type;

        private static DataSource dataSource;

        private static List<T> cachedDataSource;

        private Func<T, String, Object, Boolean> equalityComparator = (listObject, propName, toCompare) =>
        {
            Object obj = listObject != null ? PropertyCallAdapterProvider<T>.GetInstance(propName).InvokeGet(listObject) : 0;
            return listObject != null && obj != null && obj.Equals(toCompare);
        };

        private Func<T, String, String, Boolean> containsComparator = (listObject, propName, toCompare) =>
        {
            Object obj = listObject != null ? PropertyCallAdapterProvider<T>.GetInstance(propName).InvokeGet(listObject) : 0;
            return listObject != null && obj != null && obj.ToString().ToLower().Contains(toCompare.ToLower());
        };

        public List<T> getAll()
        {
            return cachedDataSource;
        }

        public List<T> getAll(bool cached)
        {
            return cached ? cachedDataSource : cachedDataSource = dataSource.getDataSource<T>();
        }

        public T getById(Object id)
        {

            return cachedDataSource.Find(listObject => equalityComparator(listObject, "Id", id));

        }

        public List<T> find(String propertyName, Object valueField)
        {
            return cachedDataSource.FindAll(listObject => equalityComparator(listObject, propertyName, valueField));
        }

        public List<T> findContains(String propertyName, String valueField)
        {
            return cachedDataSource.FindAll(listObject => containsComparator(listObject, propertyName, valueField));
        }

        public T findOne(String propertyName, Object valueField)
        {
            return cachedDataSource.Find(listObject => equalityComparator(listObject, propertyName, valueField));
        }

        public Boolean delete()
        {
            return dataSource.setDataSource(new List<T>());
        }

        public Boolean delete(T item)
        {
            return dataSource.delete(item);
        }

        public Boolean deleteOne(String propertyName, Object valueField)
        {
            T toDelete = this.findOne(propertyName, valueField);

            if (toDelete != null)
            {
                dataSource.delete(toDelete);
            }
            return true;
        }

        public Boolean addAll(List<T> list)
        {
            cachedDataSource.AddRange(list);
            return dataSource.setDataSource(cachedDataSource);
        }

        public Boolean add(T itemToAdd)
        {
            cachedDataSource.Add(itemToAdd);
            return dataSource.add(itemToAdd);

        }

    }
}

