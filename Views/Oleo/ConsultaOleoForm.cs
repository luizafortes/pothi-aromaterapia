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
    public partial class ConsultaOleoForm : Form
    {
        private Dictionary<int, OleoModel> tabelaOleos;
        private int indice;
        public ConsultaOleoForm()
        {
            InitializeComponent();
            indice = 0;
        }


        private void OleoConsultaForm_Load(object sender, EventArgs e)
        {
            CarregarGrid("");
        }

        private void CarregarGrid(string _filtro)
        {
            try
            {
                dataGridViewDados.Rows.Clear();


                //Chamada para o controller (busca dos dados)
                OleoController control = new OleoController();

                //Alterado para atender a operação de Filtro por CPF e Nome
                if (_filtro.Equals(""))
                {
                    this.tabelaOleos = (Dictionary<int, OleoModel>)control.BD('t', null);
                }
                else
                {
                    this.tabelaOleos = (Dictionary<int, OleoModel>)control.BD('f', _filtro);
                }

                foreach (OleoModel o in tabelaOleos.Values)
                {
                    dataGridViewDados.Rows.Add(o.OleoId, o.Nome, o.Descricao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR GRID: " + ex.Message);
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int oleoId = Convert.ToInt32(dataGridViewDados.SelectedRows[0].Cells[0].Value);

            OleoModel o = tabelaOleos[oleoId];

            OleoCadastroForm formOleo = new OleoCadastroForm();

            formOleo.Tag = o;

            formOleo.ShowDialog();
            CarregarGrid("");
        }

        private void imDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int oleoId = Convert.ToInt32(dataGridViewDados.SelectedRows[0].Cells[0].Value);

                OleoController control = new OleoController();

                if ((Boolean)control.BD('d', oleoId))
                {
                    MessageBox.Show("Oleo deletado com sucesso!");

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

        private void btn_left_Click(object sender, EventArgs e)
        {
            if (indice > 0)
                indice--;
            else
                indice = this.imageListOleos.Images.Count - 1;

            labelFoto.ImageIndex = indice;
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            if (indice < this.imageListOleos.Images.Count)
                indice++;
            else
                indice = 0;


            labelFoto.ImageIndex = indice;
        }

        private void buttonNovoOleo_Click(object sender, EventArgs e)
        {
            OleoCadastroForm formOleo = new OleoCadastroForm();

            formOleo.ShowDialog();
            CarregarGrid("");
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}