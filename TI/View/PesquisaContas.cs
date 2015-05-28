using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using TI.DataSource;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TI.Service;
using TI.Entidade;
using System.IO;


namespace TI.View
{
    public partial class PesquisaContas : Form
    {
        private void load()
        {
            load(contaDataSource.getAll()); 
        }
        private void load(List<Conta> contas)
        {
            
            contas.OrderBy(conta => conta.Id).ToList().ForEach(conta =>
            {
                Pessoa pessoa = pessoaDataSource.getById(conta.Consumidor);
                dataGridView1.Rows.Add(new string[] { 
                    conta.Id.ToString(),
                    pessoa.Nome,
                    pessoa.Tipo,
                    conta.LeituraAnterior.ToString(),
                    conta.LeituraAtual.ToString(),
                    contaService.getTotalSemImposto(conta).ToString(),
                    contaService.getImposto(conta).ToString(),
                    contaService.getTotal(conta).ToString()                    


                });

            });
        }
        

        public PesquisaContas()
        {
            InitializeComponent();
            load();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MenuChooser menu = new MenuChooser();
            this.Hide();
            menu.Show();
        }

        private void PesquisaConsumidor_Load(object sender, EventArgs e)
        {

        }


        
        IContaService contaService = new ContaAguaService();
        private Strategy<Pessoa> pessoaDataSource = new DataSourceStrategy<Pessoa>();
        private Strategy<Conta> contaDataSource = new DataSourceStrategy<Conta>();
		private ContaCSVImporter importer = new ContaCSVImporter();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (searchBar.Text == "")
            {
                load();
            }
            else
            {
                List<Pessoa> lista = pessoaDataSource.find("Nome", searchBar.Text);
                List<Conta> contas = new List<Conta>();
                lista.ForEach(pessoa => contas.AddRange(contaDataSource.find("Consumidor", pessoa.Id)));
                load(contas);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            searchBar.Text = "";
            load();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PesquisaConsumidor listarClientes = new PesquisaConsumidor();
            this.Close();
            listarClientes.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LancarValores valores = new LancarValores();
            valores.Show();
            this.Close();
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
           // openFileDialog1.Filter = "TXT Files|*.txt";
            openFileDialog1.Title = "Select a Cursor File";
//            openFileDialog1.ShowDialog();

            
            //importer.Import(openFileDialog1.FileName, new string[] { "TipoConta", "Consumidor", "Data", "LeituraAnterior", "LeituraAtual" });
			List<Conta> c = importer.Import("/Users/ac-passis/Downloads/contasV2.txt", new string[] { "TipoConta", "Consumidor", "Data", "LeituraAnterior", "LeituraAtual" });
			contaDataSource.addAll (c);
        }
    }
}
;