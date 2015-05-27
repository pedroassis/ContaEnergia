using System;
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

		public List<T> Import<T>(String file, String[] colunms){
			Type type = typeof(T);

			string[] lines = File.ReadAllLines(file);

			return lines.ToList ().Select (line => Parse<T>(line, type, colunms)).ToList();
		}

		private T Parse<T>(String line, Type type, String[] colunms){
			T dataSourceObject = (T)Activator.CreateInstance(type);
			String[] items = line.Split (';');
			for (int i = 0; i < items.Length; i++) {
				colunms.ToList ().ForEach (prop => type.GetProperty(colunms[i]).SetValue (dataSourceObject, items[i]));
			}
			return dataSourceObject;
		}
	}
}

