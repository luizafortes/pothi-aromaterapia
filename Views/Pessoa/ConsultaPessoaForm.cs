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
        private Dictionary<Int64, PessoaModel> tabelaPessoas;

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
                    this.tabelaPessoas = (Dictionary<Int64, PessoaModel>)control.BD('t', null);
                }
                else
                {
                    this.tabelaPessoas = (Dictionary<Int64, PessoaModel>)control.BD('f', _filtro);
                }

                foreach (PessoaModel p in tabelaPessoas.Values)
                {
                    dataGridViewDados.Rows.Add(p.Cpf, p.Nome, p.Email);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR GRID: " + ex.Message);
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int64 cpf = Convert.ToInt64(dataGridViewDados.SelectedRows[0].Cells[0].Value);

            PessoaModel p = tabelaPessoas[cpf];

            PessoaCadastroForm fp = new PessoaCadastroForm();

            fp.Tag = p;

            fp.ShowDialog();
        }

        private void imDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 cpf = Convert.ToInt64(dataGridViewDados.SelectedRows[0].Cells[0].Value);

                PessoaController control = new PessoaController();

                if ((Boolean)control.BD('d', cpf))
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
