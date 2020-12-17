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

namespace Views.Sintoma
{
    public partial class SintomaCadastroForm : Form
    {
        public SintomaCadastroForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                SintomaModel sintoma = CapturarSintoma();
                SintomaController control = new SintomaController();

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
                MessageBox.Show("ERRO ao inserir Sintoma.", ex.Message);
            }
        }

        private SintomaModel CapturarSintoma()
        {
            SintomaModel sintoma = new SintomaModel();

            try
            {
                sintoma.SintomaId = Convert.ToInt32(txtSintomaId.Text);
                sintoma.Nome = txtNome.Text;
                sintoma.Descricao = txtDescricao.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao capturar dados do Sintoma.", ex.Message);
            }
            return sintoma;
        }

        private void CarregarSintomaForm(SintomaModel _sintoma)
        {
            try
            {
                txtSintomaId.Text = _sintoma.SintomaId.ToString();
                txtNome.Text = _sintoma.Nome;
                txtDescricao.Text = _sintoma.Descricao;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao carregar dados do Sintoma.", ex.Message);
            }
        }

        private void CadastroSintomaForm_Load(object sender, EventArgs e)
        {
            try
            {

                //CarregarComboEstados();

                if (this.Tag != null)
                {
                    buttonAlterar.Visible = true;

                    buttonSalvar.Visible = false;

                    txtSintomaId.Enabled = false;

                    SintomaModel s = (SintomaModel)this.Tag;

                    CarregarSintomaForm(s);
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
            ConsultaSintomaForm consulta = new ConsultaSintomaForm();
            try
            {
                SintomaModel s = CapturarSintoma();

                SintomaController control = new SintomaController();

                if ((Boolean)control.BD('u', s))
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
            finally
            {
                consulta.CarregarGrid("");
            }
        }
    }
}