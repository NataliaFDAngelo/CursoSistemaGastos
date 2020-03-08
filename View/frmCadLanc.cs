using SistemaGastos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGastos.View
{
    public partial class frmCadLanc : Form
    {
        AnoModel modelA = new AnoModel();
        public frmCadLanc()
        {
            InitializeComponent();
            PreencherCB();

            dt.Value = DateTime.Now;
            dtBuscar.Value = DateTime.Now;
        }

        private void PreencherCB()
        {
            cbAno.DataSource = modelA.Listar();
            cbAno.ValueMember = "id_ano";
            cbAno.DisplayMember = "ano";
        }

        private void rbBuscarTipo_CheckedChanged(object sender, EventArgs e)
        {
            dtBuscar.Visible = false;
            cbBuscarTipo.Visible = true;
        }

        private void rbBuscarData_CheckedChanged(object sender, EventArgs e)
        {
            dtBuscar.Visible = true;
            cbBuscarTipo.Visible = false;
        }
    }
}
