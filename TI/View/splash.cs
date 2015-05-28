using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI.View
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }
        MenuChooser menu = new MenuChooser();
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value =  progressBar1.Value + 4;
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                menu.Show();
            }
        }

        private void splash_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
