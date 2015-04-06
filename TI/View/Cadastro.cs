using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using TI.View;
using SuperTrunfo;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private Strategy<Pessoa> pessoaDataSource = new DataSourceStrategy<Pessoa>();
        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            List<Pessoa> lista = pessoaDataSource.getAll();
            p.Id = lista.Count == 0 ? 1 : lista.Last().Id + 1;
            p.Nome = txtNome.Text;
            p.Documento = rbFisica.Checked ? txtCPF.Text : txtCNPJ.Text;
            p.Tipo = rbFisica.Checked ? "FÍSICA" : "COMERCIAL";

            pessoaDataSource.add(p);
            button2_Click(null, null);
            
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
            txtCPF.Clear();
            txtCNPJ.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCity.Clear();
            txtCEP.Clear();

        }
        
        private void button4_Click(object sender, EventArgs e)
        {

            
     

            
            
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
            txtSexo.Hide();
            comboSexo.Hide();
            lblTipoDoc.Text = "CNPJ";
            

            
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {

            txtNome.Focus();
            txtCNPJ.Hide();
            txtCNPJ.Clear();
            txtCPF.Show();
            txtSexo.Show();
            comboSexo.Show();
            lblTipoDoc.Text = "CPF";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        

        


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboUF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MenuChooser menu = new MenuChooser();
            this.Close();
            menu.Show();
        }
    }
}
