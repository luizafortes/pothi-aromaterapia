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
using Controllers;

namespace Views.Pessoa
{
    public partial class PessoaConsultaForm : Form
    {
        private Dictionary<int, PessoaModel> tabelaPessoas;

        public PessoaConsultaForm()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PessoaConsultaForm_Load(object sender, EventArgs e)
        {
            CarregarGrid("");
        }

        private void CarregarGrid(string _filtro)
        {
            try
            {
                dataGridViewDados.Rows.Clear();


                //Chamada para o controller (busca dos dados)
                PessoaController control = new PessoaController();

                //Alterado para atender a operação de Filtro por CPF e Nome
                if (_filtro.Equals(""))
                {
                    this.tabelaPessoas = (Dictionary<int, PessoaModel>)control.BD('t', null);
                }
                else
                {
                    this.tabelaPessoas = (Dictionary<int, PessoaModel>)control.BD('f', _filtro);
                }

                foreach (PessoaModel p in tabelaPessoas.Values)
                {
                    dataGridViewDados.Rows.Add(p.PessoaId, p.Cpf, p.Nome, p.Email);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR GRID: " + ex.Message);
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int pessoaId = Convert.ToInt32(dataGridViewDados.SelectedRows[0].Cells[0].Value);

            PessoaModel p = tabelaPessoas[pessoaId];

            PessoaCadastroForm formPessoa = new PessoaCadastroForm();

            formPessoa.Tag = p;

            formPessoa.ShowDialog();
        }

        private void imDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int pessoaId = Convert.ToInt32(dataGridViewDados.SelectedRows[0].Cells[0].Value);

                PessoaController control = new PessoaController();

                if ((Boolean)control.BD('d', pessoaId))
                {
                    MessageBox.Show("Pessoa deletada com sucesso!");

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
