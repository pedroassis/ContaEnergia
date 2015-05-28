using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using SuperTrunfo;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI.View
{
    public partial class PesquisaConsumidor : Form
    {
        private Strategy<Pessoa> pessoaDataSource = new DataSourceStrategy<Pessoa>();
        public PesquisaConsumidor()
        {
            InitializeComponent();

            pessoaDataSource.getAll().OrderBy(pessoa => pessoa.Id).ToList().ForEach(pessoa => dataGridView.Rows.Add(new string[] { 
              pessoa.Id.ToString(), pessoa.Nome, pessoa.Tipo, pessoa.Documento }));



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            this.Close();
            cadastro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            LancarValores valores  = new LancarValores();
            this.Close();
            valores.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MenuChooser menu = new MenuChooser();
            this.Close();
            menu.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PesquisaConsumidor_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            dataGridView.Rows.Clear();
            if (searchBar.Text == "")
            {
                pessoaDataSource.getAll().OrderBy(pessoa => pessoa.Id).ToList().ForEach(pessoa => dataGridView.Rows.Add(new string[] { 
               pessoa.Id.ToString(), pessoa.Nome, pessoa.Tipo, pessoa.Documento }));
            }
            else
            {
                List<Pessoa> lista = pessoaDataSource.find("Nome", searchBar.Text);
                if (radioButton1.Checked || radioButton2.Checked)
                {
                    string Tipo = radioButton1.Checked ? "FISICA" : "COMERCIAL";
                    lista = lista.FindAll(pessoa => pessoa.Tipo==Tipo);

                }
                
                lista.ForEach(pessoa => dataGridView.Rows.Add(new string[] { 
                pessoa.Id.ToString(), pessoa.Nome, pessoa.Tipo, pessoa.Documento }));
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            searchBar.Text = "";
            dataGridView.Rows.Clear(); 
            pessoaDataSource.getAll().OrderBy(pessoa => pessoa.Id).ToList().ForEach(pessoa => dataGridView.Rows.Add(new string[] { 
               pessoa.Id.ToString(), pessoa.Nome, pessoa.Tipo, pessoa.Documento }));
        }
    }
}
