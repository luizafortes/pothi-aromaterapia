using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace Views.Login
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            labelLoginError.Visible = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Entities.Usuario user = new Entities.Usuario();
            user.Login = txtUsuario.Text;
            user.Senha = txtSenha.Text;
            if (ValidarLogin(user))
            {
                this.DialogResult = DialogResult.OK;

                this.Tag = user;
                this.Close();
            }
            else
            {
                labelLoginError.Visible = true;
            }
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private bool ValidarLogin(Entities.Usuario _user)
        {
            try
            {
                if (_user.Login.Equals("admin") && _user.Senha.Equals("admin"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO de Validação" + ex.Message);
                return false;
            }
        }
    }
}
