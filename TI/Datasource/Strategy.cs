using System;
using System.Collections.Generic;

namespace TI.DataSource
{
	public interface Strategy<T>
	{		
		List<T> getAll();

		List<T> getAll(bool cached);
		
		T getById(Object id);
		
		List<T> find(String propertyName, Object valueField);
		
		T findOne(String propertyName, Object valueField);
		
		Boolean delete();

        Boolean delete(T id);
		
		Boolean deleteOne(String propertyName, Object valueField);

        Boolean addAll(List<T> list);

        Boolean add(T item);
	}
}

