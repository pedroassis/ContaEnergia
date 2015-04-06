using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using SuperTrunfo;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI.View
{
    public partial class PesquisaContas : Form
    {
        private void load()
        {
            load(ContaDataSource.getAll()); 
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

        ContaService contaService = new ContaService();
        private Strategy<Pessoa> pessoaDataSource = new DataSourceStrategy<Pessoa>();
        private Strategy<Conta> ContaDataSource = new DataSourceStrategy<Conta>();
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
                lista.ForEach(pessoa => contas.AddRange(ContaDataSource.find("Consumidor", pessoa.Id)));
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
            PesquisaContas listarContas = new PesquisaContas();
            this.Show();
            listarContas.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lancarValores valores = new lancarValores();
            valores.Show();
            this.Close();
        }
    }
}
;