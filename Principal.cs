using SistemaGastos.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGastos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCadAno_Click(object sender, EventArgs e)
        {
            frmCadAno frm = new frmCadAno();
            frm.ShowDialog();
        }
    }
}
