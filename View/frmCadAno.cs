using SistemaGastos.Entidades;
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
    public partial class frmCadAno : Form
    {
        Anos obj = new Anos();
        public frmCadAno()
        {
            InitializeComponent();
            Listar();
        }

        private void Listar()
        {
            try
            {
                List<Anos> lista = new List<Anos>();
                lista = new AnoModel().Listar();

                dg.DataSource = lista;
                dg.Columns[0].Visible = false;
                dg.Columns[1].HeaderText = "Ano";


            }
            catch(Exception ex)
            {
                MessageBox.Show("Não foi possível listar os dados" + ex);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            txtAno.Enabled = true;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtAno.Text == "")
            {
                MessageBox.Show("Insira um ano");
                return;
            }
            
            salvar();
            btnSalvar.Enabled = false;
            txtAno.Enabled = false;
            txtAno.Text = "";
            Listar();
        }

        private void salvar()
        {
            try
            {
                obj.Ano = Convert.ToInt32(txtAno.Text);
                int x = AnoModel.Inserir(obj);
                if (x > 0)
                {
                    MessageBox.Show("Inserido com sucesso");
                }
                else
                {
                    MessageBox.Show("Não inserido");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Não inserido" + ex);
            }

           
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscar.Text == "")
            {
                Listar();
                return;
            }
            obj.Ano = Convert.ToInt32(txtBuscar.Text);
            List<Anos> lista = new List<Anos>();
            lista = new AnoModel().Buscar(obj);
            dg.AutoGenerateColumns = false;
            dg.DataSource = lista;
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dg.CurrentRow.Cells[0].Value.ToString();
            txtAno.Text = dg.CurrentRow.Cells[1].Value.ToString();

            txtAno.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtAno.Text == "")
            {
                MessageBox.Show("Insira um ano");
                return;
            }

            Editar();
            btnSalvar.Enabled = false;
            txtAno.Enabled = false;
            txtAno.Text = "";
            Listar();
        }

        private void Editar()
        {
            try
            {
                obj.Ano = Convert.ToInt32(txtAno.Text);
                obj.Id_ano = Convert.ToInt32(txtId.Text);
                int x = AnoModel.Editar(obj);
                if (x > 0)
                {
                    MessageBox.Show("Editado com sucesso");
                }
                else
                {
                    MessageBox.Show("Não editado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não editado" + ex);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um registro para excluir");
                return;
            }

            Excluir();
            btnSalvar.Enabled = false;
            txtAno.Enabled = false;
            txtAno.Text = "";
            Listar();
        }

        private void Excluir()
        {
            try
            {
                obj.Id_ano = Convert.ToInt32(txtId.Text);
                int x = AnoModel.Deletar(obj);
                if (x > 0)
                {
                    MessageBox.Show("Excluido com sucesso");
                }
                else
                {
                    MessageBox.Show("Não excluido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não excluido" + ex);
            }
        }
    }
}
