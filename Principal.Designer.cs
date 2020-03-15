namespace SistemaGastos
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadAno = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadLanc = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelMensal = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelAnual = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgEntradas = new System.Windows.Forms.DataGridView();
            this.dgSaidas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalGeral = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalEntradas = new System.Windows.Forms.Label();
            this.lblTotalSaidas = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaidas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatorioToolStripMenuItem,
            this.btnSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadAno,
            this.btnCadLanc});
            this.cadastrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrosToolStripMenuItem.Image")));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.cadastrosToolStripMenuItem.Text = "Cadastro";
            // 
            // btnCadAno
            // 
            this.btnCadAno.Name = "btnCadAno";
            this.btnCadAno.Size = new System.Drawing.Size(173, 26);
            this.btnCadAno.Text = "Ano";
            this.btnCadAno.Click += new System.EventHandler(this.btnCadAno_Click);
            // 
            // btnCadLanc
            // 
            this.btnCadLanc.Name = "btnCadLanc";
            this.btnCadLanc.Size = new System.Drawing.Size(173, 26);
            this.btnCadLanc.Text = "Lancamento";
            this.btnCadLanc.Click += new System.EventHandler(this.btnCadLanc_Click);
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRelMensal,
            this.btnRelAnual});
            this.relatorioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relatorioToolStripMenuItem.Image")));
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.relatorioToolStripMenuItem.Text = "Relatorio";
            // 
            // btnRelMensal
            // 
            this.btnRelMensal.Name = "btnRelMensal";
            this.btnRelMensal.Size = new System.Drawing.Size(224, 26);
            this.btnRelMensal.Text = "Mensal";
            this.btnRelMensal.Click += new System.EventHandler(this.btnRelMensal_Click);
            // 
            // btnRelAnual
            // 
            this.btnRelAnual.Name = "btnRelAnual";
            this.btnRelAnual.Size = new System.Drawing.Size(224, 26);
            this.btnRelAnual.Text = "Anual";
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(68, 24);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lançamentos do Dia:";
            // 
            // dt
            // 
            this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt.Location = new System.Drawing.Point(15, 82);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(146, 22);
            this.dt.TabIndex = 2;
            this.dt.Value = new System.DateTime(2020, 3, 5, 0, 0, 0, 0);
            this.dt.ValueChanged += new System.EventHandler(this.dt_ValueChanged);
            this.dt.Enter += new System.EventHandler(this.dt_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entradas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saídas";
            // 
            // dgEntradas
            // 
            this.dgEntradas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntradas.Location = new System.Drawing.Point(15, 179);
            this.dgEntradas.Name = "dgEntradas";
            this.dgEntradas.RowHeadersWidth = 51;
            this.dgEntradas.RowTemplate.Height = 24;
            this.dgEntradas.Size = new System.Drawing.Size(365, 274);
            this.dgEntradas.TabIndex = 5;
            // 
            // dgSaidas
            // 
            this.dgSaidas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgSaidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaidas.Location = new System.Drawing.Point(398, 179);
            this.dgSaidas.Name = "dgSaidas";
            this.dgSaidas.RowHeadersWidth = 51;
            this.dgSaidas.RowTemplate.Height = 24;
            this.dgSaidas.Size = new System.Drawing.Size(365, 274);
            this.dgSaidas.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saldo Total:";
            // 
            // lblTotalGeral
            // 
            this.lblTotalGeral.AutoSize = true;
            this.lblTotalGeral.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGeral.Location = new System.Drawing.Point(695, 508);
            this.lblTotalGeral.Name = "lblTotalGeral";
            this.lblTotalGeral.Size = new System.Drawing.Size(21, 24);
            this.lblTotalGeral.TabIndex = 8;
            this.lblTotalGeral.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total das Entradas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(395, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total das Saídas:";
            // 
            // lblTotalEntradas
            // 
            this.lblTotalEntradas.AutoSize = true;
            this.lblTotalEntradas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEntradas.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotalEntradas.Location = new System.Drawing.Point(163, 465);
            this.lblTotalEntradas.Name = "lblTotalEntradas";
            this.lblTotalEntradas.Size = new System.Drawing.Size(17, 18);
            this.lblTotalEntradas.TabIndex = 11;
            this.lblTotalEntradas.Text = "0";
            // 
            // lblTotalSaidas
            // 
            this.lblTotalSaidas.AutoSize = true;
            this.lblTotalSaidas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalSaidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaidas.ForeColor = System.Drawing.Color.Red;
            this.lblTotalSaidas.Location = new System.Drawing.Point(535, 465);
            this.lblTotalSaidas.Name = "lblTotalSaidas";
            this.lblTotalSaidas.Size = new System.Drawing.Size(17, 18);
            this.lblTotalSaidas.TabIndex = 12;
            this.lblTotalSaidas.Text = "0";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.lblTotalSaidas);
            this.Controls.Add(this.lblTotalEntradas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotalGeral);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgSaidas);
            this.Controls.Add(this.dgEntradas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Gastos";
            this.Activated += new System.EventHandler(this.Principal_Activated);
            this.Click += new System.EventHandler(this.Principal_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCadAno;
        private System.Windows.Forms.ToolStripMenuItem btnCadLanc;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnRelMensal;
        private System.Windows.Forms.ToolStripMenuItem btnRelAnual;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgEntradas;
        private System.Windows.Forms.DataGridView dgSaidas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalGeral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalEntradas;
        private System.Windows.Forms.Label lblTotalSaidas;
    }
}

