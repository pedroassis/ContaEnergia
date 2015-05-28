using System;
using System.Collections.Generic;
using TI.DataSource;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI
{
	class MainClass
	{
        [STAThreadAttribute]
		public static void Main(){
			DataSourceStrategy<Pessoa> data = new DataSourceStrategy<Pessoa> ();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TI.View.splash());
			           
        }
	}
}
