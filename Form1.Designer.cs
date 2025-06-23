namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtResult = new TextBox();
            btn = new Button();
            btnAbrir = new Button();
            cboEstado = new ComboBox();
            label2 = new Label();
            dataGridView = new DataGridView();
            lblNomeGrid = new Label();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novoTextoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            licençaToolStripMenuItem = new ToolStripMenuItem();
            colaboraçãoToolStripMenuItem = new ToolStripMenuItem();
            lblHoraAtual = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 193);
            label1.Name = "label1";
            label1.Size = new Size(358, 25);
            label1.TabIndex = 0;
            label1.Text = "Precione OK para preencher a caixa de texto";
            label1.Click += label1_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(132, 221);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(358, 27);
            txtResult.TabIndex = 1;
            txtResult.TextChanged += textBox1_TextChanged;
            // 
            // btn
            // 
            btn.BackColor = SystemColors.ButtonShadow;
            btn.Location = new Point(132, 363);
            btn.Name = "btn";
            btn.Size = new Size(358, 60);
            btn.TabIndex = 2;
            btn.Text = "OK";
            btn.UseVisualStyleBackColor = false;
            btn.Click += btn_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(477, 493);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(156, 53);
            btnAbrir.TabIndex = 3;
            btnAbrir.Text = "Abrir nova janela";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "SP", "RJ", "MG", "GO", "BH" });
            cboEstado.Location = new Point(132, 293);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(358, 28);
            cboEstado.TabIndex = 4;
            cboEstado.Text = "(Selecione)";
            cboEstado.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(132, 265);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 5;
            label2.Text = "Estados:";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(650, 221);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(375, 202);
            dataGridView.TabIndex = 6;
            // 
            // lblNomeGrid
            // 
            lblNomeGrid.AutoSize = true;
            lblNomeGrid.Location = new Point(650, 198);
            lblNomeGrid.Name = "lblNomeGrid";
            lblNomeGrid.Size = new Size(207, 20);
            lblNomeGrid.TabIndex = 7;
            lblNomeGrid.Text = "Dados da Coleção de Estados";
            lblNomeGrid.Click += label3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1168, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoTextoToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(75, 24);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoTextoToolStripMenuItem
            // 
            novoTextoToolStripMenuItem.Name = "novoTextoToolStripMenuItem";
            novoTextoToolStripMenuItem.Size = new Size(168, 26);
            novoTextoToolStripMenuItem.Text = "Novo Texto";
            novoTextoToolStripMenuItem.Click += novoTextoToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(168, 26);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem, licençaToolStripMenuItem, colaboraçãoToolStripMenuItem });
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(49, 24);
            infoToolStripMenuItem.Text = "info";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(177, 26);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // licençaToolStripMenuItem
            // 
            licençaToolStripMenuItem.Name = "licençaToolStripMenuItem";
            licençaToolStripMenuItem.Size = new Size(177, 26);
            licençaToolStripMenuItem.Text = "Licença";
            licençaToolStripMenuItem.Click += licençaToolStripMenuItem_Click;
            // 
            // colaboraçãoToolStripMenuItem
            // 
            colaboraçãoToolStripMenuItem.Name = "colaboraçãoToolStripMenuItem";
            colaboraçãoToolStripMenuItem.Size = new Size(177, 26);
            colaboraçãoToolStripMenuItem.Text = "Colaboração";
            colaboraçãoToolStripMenuItem.Click += colaboraçãoToolStripMenuItem_Click;
            // 
            // lblHoraAtual
            // 
            lblHoraAtual.AutoSize = true;
            lblHoraAtual.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoraAtual.Location = new Point(348, 86);
            lblHoraAtual.Name = "lblHoraAtual";
            lblHoraAtual.Size = new Size(491, 38);
            lblHoraAtual.TabIndex = 9;
            lblHoraAtual.Text = "Dia e Hora atual: 01/01/ 0000 00:00:00";
            lblHoraAtual.Click += label3_Click_1;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 634);
            Controls.Add(lblHoraAtual);
            Controls.Add(lblNomeGrid);
            Controls.Add(dataGridView);
            Controls.Add(label2);
            Controls.Add(cboEstado);
            Controls.Add(btnAbrir);
            Controls.Add(btn);
            Controls.Add(txtResult);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Aplicação1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtResult;
        private Button btn;
        private Button btnAbrir;
        private ComboBox cboEstado;
        private Label label2;
        private DataGridView dataGridView;
        private Label lblNomeGrid;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem novoTextoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem licençaToolStripMenuItem;
        private ToolStripMenuItem colaboraçãoToolStripMenuItem;
        private Label lblHoraAtual;
        private System.Windows.Forms.Timer timer1;
    }
}
