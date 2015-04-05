using System;
using System.Collections.Generic;
using SuperTrunfo;
namespace TI
{
	class MainClass
	{
		public static void Main(){
			DataSourceStrategy<Pessoa> data = new DataSourceStrategy<Pessoa> ();

//			List<Pessoa> p = new List<Pessoa> ();
//
//			p.Add (new Pessoa (1, "aa", "12345678", "FISICA"));
//			p.Add (new Pessoa (12, "ddd", "3", "FISICA"));
//			p.Add (new Pessoa (13, "eee", "12345", "FISICA"));
//			p.Add (new Pessoa (14, "nosdfghjme", "23456", "FISICA"));
//
//			data.addAll (p);

			data.getAll ().ForEach(x => Console.WriteLine(x.Nome));
		}
	}
}
