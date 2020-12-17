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
using Entities.Enums;

namespace Views.Usuario
{
    public partial class UsuarioCadastroForm : Form
    {
        public UsuarioCadastroForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioModel usuario = CapturarUsuario();
                UsuarioController control = new UsuarioController();

                if ((Boolean)control.BD('i', usuario))
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
                MessageBox.Show("ERRO ao inserir Usuario.", ex.Message);
            }
        }

        private UsuarioModel CapturarUsuario()
        {
            UsuarioModel usuario = new UsuarioModel();

            try
            {
                if (txtUsuarioId.Text != null && txtUsuarioId.Text != "")
                {
                    usuario.UsuarioId = Convert.ToInt32(txtUsuarioId.Text);
                }
                usuario.Login = txtLogin.Text;
                usuario.Senha = txtSenha.Text;
                if (txtPrivilegio.Text == "Master")
                {
                    usuario.PrivilegioId = Convert.ToInt32(Privilegio.Master);
                }
                else if (txtPrivilegio.Text == "Normal")
                {
                    usuario.PrivilegioId = Convert.ToInt32(Privilegio.Normal);
                }
                else if (txtPrivilegio.Text == "Administrador")
                {
                    usuario.PrivilegioId = Convert.ToInt32(Privilegio.Administrador);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao capturar dados do Usuário.", ex.Message);
            }
            return usuario;
        }

        private void CarregarUsuarioForm(UsuarioModel _usuario)
        {
            try
            {
                
                txtLogin.Text = _usuario.Login;
                txtSenha.Text = _usuario.Senha;
                switch (_usuario.PrivilegioId)
                {
                    case 1:
                        txtPrivilegio.Text = "Master";                        
                        break;
                    case 2:
                        txtPrivilegio.Text = "Normal";
                        break;
                    case 3:
                        txtPrivilegio.Text = "Administrador";
                        break;
                    default:
                        txtPrivilegio.Text = "Normal";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao carregar dados do Usuário.", ex.Message);
            }
        }

        private void CadastroUsuarioForm_Load(object sender, EventArgs e)
        {
            try
            {

                //CarregarComboEstados();

                if (this.Tag != null)
                {
                    buttonAlterar.Visible = true;
                    this.Text = "Edição de Usuário";

                    buttonSalvar.Visible = false;

                    txtUsuarioId.Enabled = false;

                    UsuarioModel u = (UsuarioModel)this.Tag;

                    CarregarUsuarioForm(u);
                }
                else
                {
                    this.Text = "Cadastro de Usuário";
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
                UsuarioModel u = CapturarUsuario();

                UsuarioController control = new UsuarioController();

                if ((Boolean)control.BD('u', u))
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
