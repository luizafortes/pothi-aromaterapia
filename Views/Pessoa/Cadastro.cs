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
using Entities.Enums;

namespace Views.Pessoa
{
    public partial class PessoaCadastroForm : Form
    {
        public PessoaCadastroForm()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

        }

        private PessoaModel CapturarPessoa()
        {
            PessoaModel pessoa = new PessoaModel();

            try
            {
                pessoa.Cpf = txtCPF.Text.Replace(".", "").Replace("-", "");
                pessoa.Nome = txtNome.Text;
                pessoa.Tel = txtTel.Text;
                pessoa.Email = txtEmail.Text;

                pessoa.Endereco.TipoLogradouro = comboBoxTipoLogradouro.SelectedIndex;
                pessoa.Endereco.Logradouro = txtLogradouro.Text;
                pessoa.Endereco.Complemento = txtComplemento.Text;
                pessoa.Endereco.Cep = txtCEP.Text;
                pessoa.Endereco.Cidade = comboBoxCidade.SelectedIndex;
                pessoa.Endereco.Estado = comboBoxEstado.SelectedIndex;

                pessoa.Sexo = rdbFeminino.Checked ? Sexo.Feminino : Sexo.Masculino;
                pessoa.EstadoCivil = rdbSolteiro.Checked ? EstadoCivil.Solteiro : (rdbCasado.Checked ? EstadoCivil.Casado : (rdbDivorciado.Checked ? EstadoCivil.Divorciado : (EstadoCivil.Viuvo)));
                pessoa.Filhos = ckbFilhos.Checked;
                pessoa.Animais = ckbAnimais.Checked;
                pessoa.Fumante = ckbFumante.Checked;


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao capturar dados da Pessoa.", ex.Message);                
            }
            return pessoa;
        }

        private void CarregarPessoaForm(PessoaModel _pessoa)
        {
            try
            {
                txtCPF.Text = _pessoa.Cpf;
                txtNome.Text = _pessoa.Nome;
                txtTel.Text = _pessoa.Tel;
                txtEmail.Text = _pessoa.Email;

                comboBoxTipoLogradouro.SelectedIndex = _pessoa.Endereco.TipoLogradouro;
                txtLogradouro.Text = _pessoa.Endereco.Logradouro;
                txtComplemento.Text = _pessoa.Endereco.Complemento;
                txtCEP.Text = _pessoa.Endereco.Cep.ToString();
                comboBoxCidade.SelectedIndex = _pessoa.Endereco.Cidade;
                comboBoxEstado.SelectedIndex = _pessoa.Endereco.Estado;

                rdbFeminino.Checked = _pessoa.Sexo == Sexo.Feminino ? true : false;
                rdbSolteiro.Checked = _pessoa.EstadoCivil == EstadoCivil.Solteiro ? true : false;
                rdbCasado.Checked = _pessoa.EstadoCivil == EstadoCivil.Casado ? true : false;
                rdbDivorciado.Checked = _pessoa.EstadoCivil == EstadoCivil.Divorciado ? true : false;
                rdbViuvo.Checked = _pessoa.EstadoCivil == EstadoCivil.Viuvo ? true : false;

                ckbFilhos.Checked = _pessoa.Filhos;
                ckbAnimais.Checked = _pessoa.Animais;
                ckbFumante.Checked = _pessoa.Fumante;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao carregar dados da Pessoa.", ex.Message);
            }
        }
    }
}
