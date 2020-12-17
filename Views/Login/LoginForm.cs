using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Controllers;

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

            progressBar1.Value = 0;
            progressBar1.Visible = true;
            for (int i = 0; i <= progressBar1.Maximum; i++)
            {
                progressBar1.Value = i++;
                Thread.Sleep(50);
            }
            UsuarioModel user = new UsuarioModel();
            user.Login = txtUsuario.Text;
            user.Senha = txtSenha.Text;
            if (progressBar1.Value == progressBar1.Maximum)
            {
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
            
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private bool ValidarLogin(UsuarioModel _user)
        {
            try
            {
                UsuarioController control = new UsuarioController();

                if ((Boolean)control.BD('l', _user))
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
