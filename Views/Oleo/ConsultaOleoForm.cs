﻿using System;
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

        public ConsultaOleoForm()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
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

                foreach (OleoModel s in tabelaOleos.Values)
                {
                    dataGridViewDados.Rows.Add(s.OleoId, s.Nome, s.Descricao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR GRID: " + ex.Message);
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sintomaId = Convert.ToInt32(dataGridViewDados.SelectedRows[0].Cells[0].Value);

            OleoModel s = tabelaOleos[sintomaId];

            OleoCadastroForm fp = new OleoCadastroForm();

            fp.Tag = s;

            fp.ShowDialog();
        }

        private void imDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int sintomaId = Convert.ToInt32(dataGridViewDados.SelectedRows[0].Cells[0].Value);

                OleoController control = new OleoController();

                if ((Boolean)control.BD('d', sintomaId))
                {
                    MessageBox.Show("Oleo deletada com sucesso!");

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