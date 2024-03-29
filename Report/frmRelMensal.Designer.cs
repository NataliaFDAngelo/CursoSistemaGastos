﻿namespace SistemaGastos.Report
{
    partial class frmRelMensal
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lancamentoanoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gastosLeoDataSet = new SistemaGastos.GastosLeoDataSet();
            this.entradaValorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gastosLeoDataSet1 = new SistemaGastos.GastosLeoDataSet();
            this.lancamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lancamentoTableAdapter = new SistemaGastos.GastosLeoDataSetTableAdapters.lancamentoTableAdapter();
            this.lancamento_anoTableAdapter = new SistemaGastos.GastosLeoDataSetTableAdapters.lancamento_anoTableAdapter();
            this.entradaValorTableAdapter = new SistemaGastos.GastosLeoDataSetTableAdapters.entradaValorTableAdapter();
            this.saidaValorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saidaValorTableAdapter = new SistemaGastos.GastosLeoDataSetTableAdapters.saidaValorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoanoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosLeoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaValorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosLeoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidaValorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.lancamentoanoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.entradaValorBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.saidaValorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaGastos.Report.RelMensal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 46);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(888, 445);
            this.reportViewer1.TabIndex = 0;
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbMes.Location = new System.Drawing.Point(739, 12);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(150, 24);
            this.cbMes.TabIndex = 22;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            this.cbMes.SelectionChangeCommitted += new System.EventHandler(this.cbMes_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(695, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mês:";
            // 
            // lancamentoanoBindingSource
            // 
            this.lancamentoanoBindingSource.DataMember = "lancamento_ano";
            this.lancamentoanoBindingSource.DataSource = this.gastosLeoDataSet;
            // 
            // gastosLeoDataSet
            // 
            this.gastosLeoDataSet.DataSetName = "GastosLeoDataSet";
            this.gastosLeoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entradaValorBindingSource
            // 
            this.entradaValorBindingSource.DataMember = "entradaValor";
            this.entradaValorBindingSource.DataSource = this.gastosLeoDataSet1;
            // 
            // gastosLeoDataSet1
            // 
            this.gastosLeoDataSet1.DataSetName = "GastosLeoDataSet";
            this.gastosLeoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lancamentoBindingSource
            // 
            this.lancamentoBindingSource.DataMember = "lancamento";
            this.lancamentoBindingSource.DataSource = this.gastosLeoDataSet;
            // 
            // lancamentoTableAdapter
            // 
            this.lancamentoTableAdapter.ClearBeforeFill = true;
            // 
            // lancamento_anoTableAdapter
            // 
            this.lancamento_anoTableAdapter.ClearBeforeFill = true;
            // 
            // entradaValorTableAdapter
            // 
            this.entradaValorTableAdapter.ClearBeforeFill = true;
            // 
            // saidaValorBindingSource
            // 
            this.saidaValorBindingSource.DataMember = "saidaValor";
            this.saidaValorBindingSource.DataSource = this.gastosLeoDataSet;
            // 
            // saidaValorTableAdapter
            // 
            this.saidaValorTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelMensal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 503);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelMensal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelMensal";
            this.Load += new System.EventHandler(this.frmRelMensal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoanoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosLeoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaValorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosLeoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidaValorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private GastosLeoDataSet gastosLeoDataSet;
        private System.Windows.Forms.BindingSource lancamentoBindingSource;
        private GastosLeoDataSetTableAdapters.lancamentoTableAdapter lancamentoTableAdapter;
        private System.Windows.Forms.BindingSource lancamentoanoBindingSource;
        private GastosLeoDataSetTableAdapters.lancamento_anoTableAdapter lancamento_anoTableAdapter;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label4;
        private GastosLeoDataSet gastosLeoDataSet1;
        private System.Windows.Forms.BindingSource entradaValorBindingSource;
        private GastosLeoDataSetTableAdapters.entradaValorTableAdapter entradaValorTableAdapter;
        private System.Windows.Forms.BindingSource saidaValorBindingSource;
        private GastosLeoDataSetTableAdapters.saidaValorTableAdapter saidaValorTableAdapter;
    }
}