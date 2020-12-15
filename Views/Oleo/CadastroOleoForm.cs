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
                OleoModel sintoma = CapturarOleo();
                PessoaController control = new PessoaController();

                if ((Boolean)control.BD('i', sintoma))
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
            OleoModel sintoma = new OleoModel();

            try
            {
                sintoma.OleoId = Convert.ToInt32(txtOleoId.Text);
                sintoma.Nome = txtNome.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao capturar dados do Oleo.", ex.Message);
            }
            return sintoma;
        }

        private void CarregarOleoForm(OleoModel _oleo)
        {
            try
            {
                txtOleoId.Text = _oleo.OleoId.ToString();
                txtNome.Text = _oleo.Nome;
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

                    buttonSalvar.Visible = false;

                    txtOleoId.Enabled = false;

                    OleoModel o = (OleoModel)this.Tag;

                    CarregarOleoForm(o);
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
                OleoModel o = CapturarOleo();

                OleoController control = new OleoController();

                if ((Boolean)control.BD('o', o))
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