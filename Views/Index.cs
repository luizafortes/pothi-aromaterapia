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

namespace Views
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
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
                this.Show();
            }
            else
            {
                this.Close();
            }
        }
    }
}
