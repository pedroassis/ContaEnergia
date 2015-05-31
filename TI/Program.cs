using System;
using System.Collections.Generic;
using TI.Reflection;
using TI.Entidade;
using TI.Service;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace TI
{
	class MainClass
	{
        [STAThreadAttribute]
		public static void Main(){
			ContaCSVImporter csv = new ContaCSVImporter ();
			Stopwatch stopwatch = new Stopwatch();

			// Begin timing
			stopwatch.Start();

			List<Conta> c = csv.Import ("/Users/ac-passis/Downloads/contasV2.txt", new string[] { "TipoConta", "Consumidor", "Data", "LeituraAnterior", "LeituraAtual" });

			// Stop timing
			stopwatch.Stop();

			// Write result
			Console.WriteLine("Time elapsed: {0}",
				stopwatch.Elapsed);
			Console.WriteLine ("Numero " + c.Count);
			Console.ReadLine ();
//			Application.EnableVisualStyles();
//            Application.SetCompatibleTextRenderingDefault(false);
//            Application.Run(new TI.View.splash());
			           
        }
	}
}
