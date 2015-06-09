using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using TI.DataSource;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TI.Entidade;
using TI.Service;

namespace TI.View
{
    public partial class PesquisaConsumidor : Form
    {

        //TODO messageBox exibindo o resultado.
        //TODO Em que mês houve a conta de maior valor, em reais e em consumo?

        private Strategy<Pessoa> pessoaDataSource = new DataSourceStrategy<Pessoa>();
        private Strategy<Conta> contaDataSource = new DataSourceStrategy<Conta>();

        public PesquisaConsumidor()
        {
            InitializeComponent();

            this.dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dataGridView.Columns[0].Resizable =DataGridViewTriState.False;
            dataGridView.Columns[1].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[2].Resizable = DataGridViewTriState.False;
            dataGridView.Columns[3].Resizable = DataGridViewTriState.False;




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
                List<Pessoa> lista = pessoaDataSource.findContains("Documento", searchBar.Text);
                lista.AddRange(pessoaDataSource.findContains("Nome", searchBar.Text));
                    
                if (radioButton1.Checked || radioButton2.Checked)
                {
                    string Tipo = radioButton1.Checked ? "FISICA" : "JURIDICA";
                    lista = lista.FindAll(pessoa => pessoa.Tipo==Tipo);
                    
                }
                
                lista.Take(100).ToList().ForEach(pessoa => dataGridView.Rows.Add(new string[] { 
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

        IContaService energiaService = new ContaEnergiaService();
        IContaService aguaService = new ContaAguaService();

        public IContaService getService(Conta conta)
        {
            return conta.TipoConta == "AGUA" ? aguaService : energiaService;
        }


        private double consumoMedio(List<Conta> contas){

            double somaConsumo = contas.Sum(conta => getService(conta).getConsumo(conta));
            return somaConsumo / contas.Count;            
        }

        private void mediaGeral_Click(object sender, EventArgs e)
        {
            String idString = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            int id = int.Parse(idString);
            List<Conta> contas = contaDataSource.find("Consumidor", id);
            List<Conta> contasAgua  = contas.Where( conta => conta.TipoConta == "AGUA").ToList();
            List<Conta> contasEnergia = contas.Where(conta => conta.TipoConta == "ENERGIA").ToList();

            double  consumoMedioAgua = consumoMedio(contasAgua);
            double consumoMedioEnergia = consumoMedio(contasEnergia);

            MessageBox.Show(null, "Conta de água: R$" +consumoMedioAgua + "\nConta de energia:" + consumoMedioAgua.ToString(), "Valor médio das contas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void getRowValue_Click(object sender, EventArgs e)
        {            
           
        }
    }
}
