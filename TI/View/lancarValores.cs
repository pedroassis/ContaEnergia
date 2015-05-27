using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using SuperTrunfo;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TI.Service;

namespace TI.View
{
    public partial class lancarValores : Form
    {
        public lancarValores()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Focus();
            
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuChooser menu = new MenuChooser();
            this.Close();
            menu.Show();
        }

        private void lancarValores_Load(object sender, EventArgs e)
        {

        }

        ContaEnergiaService contaService = new ContaEnergiaService();
        private Strategy<Pessoa> pessoaDataSource = new DataSourceStrategy<Pessoa>();
        private Strategy<Conta> ContaDataSource = new DataSourceStrategy<Conta>();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pessoa pessoa;

            try
            {
                pessoa = pessoaDataSource.getById(int.Parse(id.Text));
            }
            catch (Exception)
            {
                return;
            }

            if (pessoa != null && pessoa.Id != null)
            {
                conta.Consumidor = pessoa.Id;
                txtNome.Text = pessoa.Nome;
                txtTipo.Text = pessoa.Tipo;
                List<Conta> contas = ContaDataSource.find("Consumidor", pessoa.Id);
                if (contas.Count != 0)
                {
                    Conta contaAnterior = contas.Last();
                    valorContaAnterior.Text = contaService.getTotal(contaAnterior).ToString();
                    consumoAnterior.Text = (contaAnterior.LeituraAnterior + contaAnterior.LeituraAtual).ToString();
                    conta.LeituraAnterior = (contaAnterior.LeituraAnterior + contaAnterior.LeituraAtual);
                }
                else
                {
                    conta.LeituraAnterior = 0;
                }

            }
        }

        private Conta conta = new Conta();
        private void button5_Click(object sender, EventArgs e)
        {
            conta.LeituraAtual = int.Parse(consumoAtual.Text);

            valorContaAtual.Text = contaService.getTotal(conta).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Conta> lista = ContaDataSource.getAll();
            conta.Id = lista.Count==0 ? 1 : lista.Last().Id + 1;
            ContaDataSource.add(conta);
            conta = new Conta();
            txtNome.Text = "";
            txtTipo.Text = "";
            valorContaAnterior.Text = "";
            valorContaAtual.Text = "";
            consumoAnterior.Text = "";
            consumoAtual.Text = "";
            id.Text = "";
            MessageBox.Show("Sucesso", "Conta cadastrada com sucesso.", MessageBoxButtons.OK);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtTipo.Text = "";
            valorContaAnterior.Text = "";
            valorContaAtual.Text = "";
            consumoAnterior.Text = "";
            consumoAtual.Text = "";
            id.Text = "";
            id.Focus();
        }
    }
}
