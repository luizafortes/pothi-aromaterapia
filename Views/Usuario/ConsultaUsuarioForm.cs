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

namespace Views.Usuario
{
    public partial class ConsultaUsuarioForm : Form
    {
        private Dictionary<int, UsuarioModel> tabelaUsuarios;

        public ConsultaUsuarioForm()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsuarioConsultaForm_Load(object sender, EventArgs e)
        {
            CarregarGrid("");
        }

        private void CarregarGrid(string _filtro)
        {
            try
            {
                dataGridViewDados.Rows.Clear();


                //Chamada para o controller (busca dos dados)
                UsuarioController control = new UsuarioController();

                //Alterado para atender a operação de Filtro por CPF e Nome
                if (_filtro.Equals(""))
                {
                    this.tabelaUsuarios = (Dictionary<int, UsuarioModel>)control.BD('t', null);
                }
                else
                {
                    this.tabelaUsuarios = (Dictionary<int, UsuarioModel>)control.BD('f', _filtro);
                }

                foreach (UsuarioModel u in tabelaUsuarios.Values)
                {
                    dataGridViewDados.Rows.Add(u.UsuarioId, u.Login);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR GRID: " + ex.Message);
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int usuarioId = Convert.ToInt32(dataGridViewDados.SelectedRows[0].Cells[0].Value);

            UsuarioModel u = tabelaUsuarios[usuarioId];

            UsuarioCadastroForm fp = new UsuarioCadastroForm();

            fp.Tag = u;

            fp.ShowDialog();
        }
        private void imDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int usuarioId = Convert.ToInt32(dataGridViewDados.SelectedRows[0].Cells[0].Value);

                UsuarioController control = new UsuarioController();

                if ((Boolean)control.BD('d', usuarioId))
                {
                    MessageBox.Show("Usuario deletado com sucesso!");

                    CarregarGrid("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO SELECIONAR UM CADASTRO: " + ex.Message);
            }

        }

        //Adicionado para implementar as opções de filtro
        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid(txtPesquisa.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO FILTRAR O DATA GRID: " + ex.Message);
            }
        }
    }
}
