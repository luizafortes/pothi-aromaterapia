using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.Pessoa;
using Views.Login;
using Entities;
using Views.Usuario;
using Views.Oleo;
using Views.Sintoma;

namespace Views
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void relogio_Tick(object sender, EventArgs e)
        {
            timeStamp.Text = DateTime.Now.ToString();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            relogio.Enabled = true;

            this.Hide();

            loginForm loginForm = new loginForm();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                UsuarioModel user = (UsuarioModel)loginForm.Tag;

                labelDadosUsuario.Text = "Usuário logado: " + user.Login;
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void CadastrarPessoa(object sender, EventArgs e)
        {
            PessoaCadastroForm form = new PessoaCadastroForm();
            form.ShowDialog();
        }

        private void ConsultarPessoa(object sender, EventArgs e)
        {
            PessoaConsultaForm form = new PessoaConsultaForm();
            form.ShowDialog();
        }

        private void CadastrarUsuario(object sender, EventArgs e)
        {
            UsuarioCadastroForm form = new UsuarioCadastroForm();
            form.ShowDialog();
        }

        private void ConsultarUsuario(object sender, EventArgs e)
        {
            ConsultaUsuarioForm form = new ConsultaUsuarioForm();
            form.ShowDialog();
        }

        private void CadastrarOleo(object sender, EventArgs e)
        {
            OleoCadastroForm form = new OleoCadastroForm();
            form.ShowDialog();
        }

        private void ConsultarOleo(object sender, EventArgs e)
        {
            ConsultaOleoForm form = new ConsultaOleoForm();
            form.ShowDialog();
        }

        private void CadastrarSintoma(object sender, EventArgs e)
        {
            SintomaCadastroForm form = new SintomaCadastroForm();
            form.ShowDialog();
        }

        private void ConsultarSintoma(object sender, EventArgs e)
        {
            ConsultaSintomaForm form = new ConsultaSintomaForm();
            form.ShowDialog();
        }

    }
}
