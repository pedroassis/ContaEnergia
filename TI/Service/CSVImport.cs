using System;
using System.Reflection;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace TI
{
	public class CSVImport
	{
		public CSVImport ()
		{
		}

		public List<T> Import<T>(String file, List<Func<string, T, object>> parsers, String[] colunms){
			Type type = typeof(T);

			string[] lines = File.ReadAllLines(file);

			return lines.ToList ().Select (line => Parse<T>(line, type, colunms, parsers)).ToList();
		}

        private T Parse<T>(String line, Type type, String[] colunms, List<Func<string, T, object>> parsers)
        {
			T dataSourceObject = (T)Activator.CreateInstance(type);
			String[] items = line.Split (';');
			for (int i = 0; i < items.Length; i++) {
                object toSet;
                try {
                    toSet = parsers.ElementAt(i)(items[i], dataSourceObject);
                }
                catch (Exception e)
                {
                    PropertyInfo propType = type.GetProperty(colunms[i]);
                    toSet = typeof(String).IsAssignableFrom(propType.PropertyType) ? items[i] : propType.PropertyType.GetMethod("Parse", new[] { typeof(string) }).Invoke(null, new String[] { (String)items[i] });
                }
				type.GetProperty(colunms[i]).SetValue (dataSourceObject, toSet);
			}
			return dataSourceObject;
		}
	}
}

