namespace TI.View
{
    partial class PesquisaContas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaContas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAte = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rbAgua = new System.Windows.Forms.RadioButton();
            this.rbEnergia = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addNew = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPesssoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumoMesAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumoMesAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impostos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorContaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblAte);
            this.panel1.Controls.Add(this.lblDe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.rbAgua);
            this.panel1.Controls.Add(this.rbEnergia);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.addNew);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.searchBar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 554);
            this.panel1.TabIndex = 0;
            // 
            // lblAte
            // 
            this.lblAte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAte.Location = new System.Drawing.Point(794, 15);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(149, 20);
            this.lblAte.TabIndex = 30;
            this.lblAte.Text = "10000000000";
            // 
            // lblDe
            // 
            this.lblDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDe.Location = new System.Drawing.Point(619, 15);
            this.lblDe.Name = "lblDe";
            this.lblDe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDe.Size = new System.Drawing.Size(156, 20);
            this.lblDe.TabIndex = 29;
            this.lblDe.Text = "100000";
            this.lblDe.Click += new System.EventHandler(this.lblDe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(770, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "de";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 530);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1005, 16);
            this.progressBar1.TabIndex = 1;
            // 
            // rbAgua
            // 
            this.rbAgua.AutoSize = true;
            this.rbAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAgua.Location = new System.Drawing.Point(544, 12);
            this.rbAgua.Name = "rbAgua";
            this.rbAgua.Size = new System.Drawing.Size(58, 20);
            this.rbAgua.TabIndex = 26;
            this.rbAgua.Text = "Água";
            this.rbAgua.UseVisualStyleBackColor = true;
            // 
            // rbEnergia
            // 
            this.rbEnergia.AutoSize = true;
            this.rbEnergia.Checked = true;
            this.rbEnergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEnergia.Location = new System.Drawing.Point(465, 12);
            this.rbEnergia.Name = "rbEnergia";
            this.rbEnergia.Size = new System.Drawing.Size(73, 20);
            this.rbEnergia.TabIndex = 25;
            this.rbEnergia.TabStop = true;
            this.rbEnergia.Text = "Energia";
            this.rbEnergia.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(989, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(403, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(369, 496);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 29);
            this.button3.TabIndex = 22;
            this.button3.Text = "Pesquisar dados de consumidor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(610, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "Lançar novo valor de conta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // addNew
            // 
            this.addNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNew.Location = new System.Drawing.Point(815, 496);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(202, 29);
            this.addNew.TabIndex = 20;
            this.addNew.Text = "Cadastrar novo consumidor";
            this.addNew.UseVisualStyleBackColor = true;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 496);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 29);
            this.button7.TabIndex = 19;
            this.button7.Text = "Voltar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 436);
            this.panel2.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idConta,
            this.nomeCliente,
            this.tipoPesssoa,
            this.consumoMesAnterior,
            this.consumoMesAtual,
            this.valorConta,
            this.impostos,
            this.valorContaTotal});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 436);
            this.dataGridView1.TabIndex = 1;
            // 
            // idConta
            // 
            this.idConta.HeaderText = "Id";
            this.idConta.MaxInputLength = 3;
            this.idConta.Name = "idConta";
            this.idConta.ReadOnly = true;
            this.idConta.Width = 40;
            // 
            // nomeCliente
            // 
            this.nomeCliente.HeaderText = "Nome do Cliente";
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.ReadOnly = true;
            this.nomeCliente.Width = 220;
            // 
            // tipoPesssoa
            // 
            this.tipoPesssoa.HeaderText = "Tipo de Pessoa";
            this.tipoPesssoa.Name = "tipoPesssoa";
            this.tipoPesssoa.ReadOnly = true;
            this.tipoPesssoa.Width = 120;
            // 
            // consumoMesAnterior
            // 
            this.consumoMesAnterior.HeaderText = "Consumo do mês anterior";
            this.consumoMesAnterior.Name = "consumoMesAnterior";
            this.consumoMesAnterior.ReadOnly = true;
            this.consumoMesAnterior.Width = 130;
            // 
            // consumoMesAtual
            // 
            this.consumoMesAtual.HeaderText = "Consumo do mês atual";
            this.consumoMesAtual.Name = "consumoMesAtual";
            this.consumoMesAtual.ReadOnly = true;
            this.consumoMesAtual.Width = 130;
            // 
            // valorConta
            // 
            this.valorConta.HeaderText = "Valor da Conta";
            this.valorConta.Name = "valorConta";
            this.valorConta.ReadOnly = true;
            this.valorConta.Width = 130;
            // 
            // impostos
            // 
            this.impostos.HeaderText = "Impostos";
            this.impostos.Name = "impostos";
            this.impostos.ReadOnly = true;
            // 
            // valorContaTotal
            // 
            this.valorContaTotal.HeaderText = "Valor total da Conta";
            this.valorContaTotal.Name = "valorContaTotal";
            this.valorContaTotal.ReadOnly = true;
            this.valorContaTotal.Width = 130;
            // 
            // searchBar
            // 
            this.searchBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(12, 12);
            this.searchBar.MaxLength = 40;
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(353, 22);
            this.searchBar.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(369, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // PesquisaContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1032, 554);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisaContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de contas";
            this.Load += new System.EventHandler(this.PesquisaConsumidor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPesssoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumoMesAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumoMesAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn impostos;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorContaTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton rbAgua;
        private System.Windows.Forms.RadioButton rbEnergia;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label label1;
    }
}