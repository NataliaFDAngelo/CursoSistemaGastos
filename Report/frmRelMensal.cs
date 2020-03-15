using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGastos.Report
{
    public partial class frmRelMensal : Form
    {
        public frmRelMensal()
        {
            InitializeComponent();
        }

        private void frmRelMensal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gastosLeoDataSet.lancamento_ano'. Você pode movê-la ou removê-la conforme necessário.
           
        }

        private void cbMes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lancamento_anoTableAdapter.Fill(this.gastosLeoDataSet.lancamento_ano, cbMes.Text);


            this.reportViewer1.RefreshReport();
        }
    }
}
