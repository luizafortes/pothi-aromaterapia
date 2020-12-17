using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Entities;

namespace Views.Oleo
{
    public partial class OleoCadastroForm : Form
    {
        public OleoCadastroForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                OleoModel oleo = CapturarOleo();
                OleoController control = new OleoController();

                if ((Boolean)control.BD('i', oleo))
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!!!");
                }
                else
                {
                    MessageBox.Show("Cadastro NÃO efetuado!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao inserir Oleo.", ex.Message);
            }
        }

        private OleoModel CapturarOleo()
        {
            OleoModel oleo = new OleoModel();
            try
            {
                if (txtOleoId.Text != null && txtOleoId.Text != "")
                {
                    oleo.OleoId = Convert.ToInt32(txtOleoId.Text);
                }
                oleo.Nome = txtNome.Text;
                oleo.Descricao = txtDescricao.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao capturar dados do Oleo.", ex.Message);
            }
            return oleo;
        }

        private void CarregarOleoForm(OleoModel _oleo)
        {
            try
            {
                txtOleoId.Text = _oleo.OleoId.ToString();
                txtNome.Text = _oleo.Nome;
                txtDescricao.Text = _oleo.Descricao;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao carregar dados do Oleo.", ex.Message);
            }
        }

        private void CadastroOleoForm_Load(object sender, EventArgs e)
        {
            try
            {

                //CarregarComboEstados();

                if (this.Tag != null)
                {
                    buttonAlterar.Visible = true;
                    this.Text = "Edição de Óleo";

                    buttonSalvar.Visible = false;

                    txtOleoId.Enabled = false;

                    OleoModel o = (OleoModel)this.Tag;

                    CarregarOleoForm(o);
                }
                else
                {
                    this.Text = "Cadastro de Óleo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR FORM", ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                OleoModel oleo = CapturarOleo();

                OleoController control = new OleoController();

                if ((Boolean)control.BD('u', oleo))
                {
                    MessageBox.Show("Cadastro alterado com sucesso!!!");
                }
                else
                {
                    MessageBox.Show("Cadastro NÃO alterado!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}