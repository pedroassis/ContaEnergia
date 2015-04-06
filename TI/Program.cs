using System;
using System.Collections.Generic;
using SuperTrunfo;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI
{
	class MainClass
	{
		public static void Main(){
			DataSourceStrategy<Pessoa> data = new DataSourceStrategy<Pessoa> ();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TI.View.splash());
			/*List<Pessoa> p = new List<Pessoa> ();

			p.Add (new Pessoa (1, "aa", "12345678", "FISICA"));
			p.Add (new Pessoa (12, "ddd", "3", "FISICA"));
			p.Add (new Pessoa (13, "eee", "12345", "FISICA"));
			p.Add (new Pessoa (14, "nosdfghjme", "23456", "FISICA"));

			data.addAll (p);

			data.getAll ().ForEach(x => Console.WriteLine(x.Nome));

			DataSourceStrategy<Conta> dataC = new DataSourceStrategy<Conta> ();
			ContaService cs = new ContaService ();

			List<Conta> c = new List<Conta> ();

			c.Add (new Conta (1, 1, 10, 0, 1));
			c.Add (new Conta (2, 12, 20, 0, 12));
			c.Add (new Conta (3, 13, 30, 10, 13));
			c.Add (new Conta (4, 14, 40, 30, 14));

			dataC.addAll (c);

			dataC.getAll ().ForEach(x => {
				Console.WriteLine(x.Consumidor);
				Console.WriteLine(cs.getConsumo(x));
				Console.WriteLine(cs.getTotalSemImposto(x));
                Console.WriteLine(cs.getTotal(x));
                Console.WriteLine();
			});
            */
            
        }
	}
}
