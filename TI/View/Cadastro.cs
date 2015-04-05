using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenda
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista.Add(txtNome.Text);
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNome.Clear();   
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Focus();
            txtCPF.Clear();
            txtCNPJ.Show();
            txtCPF.Hide();
            labelData.Text= "Data de Estabelecimento";
            lblTipoDoc.Text = "CNPJ";
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {

            txtNome.Focus();
            txtCNPJ.Hide();
            txtCNPJ.Clear();
            txtCPF.Show();
            labelData.Text = "Data de Nascimento";
            lblTipoDoc.Text = "CPF";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtTel2.Show();
            lblTel2.Show();
            pictureBox2.Show();
            pictureBox6.Show();
            txtTel2.Focus();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblTel3.Show();
            txtTel3.Show();
            pictureBox3.Show();
            pictureBox7.Show();
            txtTel3.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lblTel4.Show();
            txtTel4.Show();
            pictureBox4.Show();
            pictureBox8.Show();
            txtTel4.Focus();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lblTel5.Show();
            txtTel5.Show();
            pictureBox9.Show();
            txtTel5.Focus();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            txtTel5.Clear();
            txtTel5.Hide();
            lblTel5.Hide();
            pictureBox9.Hide();
            txtTel4.Focus();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            txtTel4.Clear();
            lblTel4.Hide();
            txtTel4.Hide();
            pictureBox8.Hide();
            pictureBox4.Hide();
            txtTel3.Focus();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            txtTel2.Focus();
            txtTel3.Clear();
            lblTel3.Hide();
            txtTel3.Hide();
            pictureBox7.Hide();
            pictureBox3.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            txtTel1.Focus();
            txtTel2.Clear();
            lblTel2.Hide();
            txtTel2.Hide();
            pictureBox6.Hide();
            pictureBox2.Hide();
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            txtTel1.Clear();
            txtTel1.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboUF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
