using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using TI.DataSource;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TI.Service;
using TI.Entidade;

namespace TI.View
{
    public partial class LancarValores : Form
    {
        public LancarValores()
        {
            InitializeComponent();
        }

        public IContaService getService(Conta conta)
        {
            return conta.TipoConta == "AGUA" ? aguaService : energiaService;
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

        IContaService energiaService = new ContaEnergiaService();
        IContaService aguaService = new ContaAguaService();
        private Strategy<Pessoa> pessoaDataSource = new DataSourceStrategy<Pessoa>();
        private Strategy<Conta> ContaDataSource = new DataSourceStrategy<Conta>();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button2_Click(null, null);
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
                conta.TipoConta = tipoConta.Text == "Agua" ? "AGUA" : "ENERGIA";
                txtNome.Text = pessoa.Nome;
                txtTipo.Text = pessoa.Tipo;
                List<Conta> contas = ContaDataSource.find("Consumidor", pessoa.Id)
                    .Where(cot => (tipoConta.Text == "Agua" ? "AGUA" : "ENERGIA") == cot.TipoConta).ToList();
                if (contas.Count != 0)
                {
                    Conta contaAnterior = contas.Last();
                    valorContaAnterior.Text = getService(conta).getTotal(contaAnterior).ToString();
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
            if ((int.Parse(consumoAtual.Text) >= int.Parse(consumoAnterior.Text)))
            {
                conta.LeituraAtual = int.Parse(consumoAtual.Text);
                conta.TipoConta = tipoConta.Text == "Agua" ? "AGUA" : "ENERGIA";
                valorContaAtual.Text = getService(conta).getTotal(conta).ToString();
            }
            else
            {
                MessageBox.Show(null, "A leitura atual não pode ser menor do que a leitura anterior.", "Operação inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tipoConta.SelectedItem == "")
            {
                MessageBox.Show("Tipo da conta é obrigatório.", "Ação inválida", MessageBoxButtons.OK);
                return;
            }




            List<Conta> lista = ContaDataSource.getAll();
            conta.Id = lista.Count == 0 ? 1 : lista.Last().Id + 1;
            conta.TipoConta = tipoConta.Text.ToUpper();
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
            id.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conta.TipoConta = tipoConta.Text == "Agua" ? "AGUA" : "ENERGIA";
            pictureBox1_Click(null, null);
        }

        private void consumoAtual_TextChanged(object sender, EventArgs e)
        {

        }

        private void numbersOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -2))
            {
                e.Handled = true;
            }
        }

        private void idOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
