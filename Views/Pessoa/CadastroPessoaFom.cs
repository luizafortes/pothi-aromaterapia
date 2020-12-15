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
using Entities.Enums;

namespace Views.Pessoa
{
    public partial class PessoaCadastroForm : Form
    {
        public PessoaCadastroForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                PessoaModel pessoa = CapturarPessoa();
                PessoaController control = new PessoaController();

                if ((Boolean)control.BD('i', pessoa))
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!!!");
                }
                else
                {
                    MessageBox.Show("Cadastro NÃO efetuado!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao inserir Pessoa.", ex.Message);
            }
        }

        private PessoaModel CapturarPessoa()
        {
            PessoaModel pessoa = new PessoaModel();

            try
            {
                pessoa.Cpf = Convert.ToInt64(txtCPF.Text.Replace(".", "").Replace("-", ""));
                pessoa.Nome = txtNome.Text;
                pessoa.Tel = txtTel.Text;
                pessoa.Email = txtEmail.Text;

                //pessoa.Endereco.TipoLogradouro = comboBoxTipoLogradouro.SelectedIndex;
                //pessoa.Endereco.Logradouro = txtLogradouro.Text;
                //pessoa.Endereco.Complemento = txtComplemento.Text;
                //pessoa.Endereco.Cep = txtCEP.Text;
                //pessoa.Endereco.Cidade = comboBoxCidade.SelectedIndex;
                //pessoa.Endereco.Estado = comboBoxEstado.SelectedIndex;

                //pessoa.Sexo = rdbFeminino.Checked ? Sexo.Feminino : Sexo.Masculino;
                //pessoa.EstadoCivil = rdbSolteiro.Checked ? EstadoCivil.Solteiro : (rdbCasado.Checked ? EstadoCivil.Casado : (rdbDivorciado.Checked ? EstadoCivil.Divorciado : (EstadoCivil.Viuvo)));
                pessoa.Filhos = ckbFilhos.Checked == true ? 1 : 0;
                pessoa.Animais = ckbAnimais.Checked == true ? 1 : 0;
                pessoa.Fumante = ckbFumante.Checked == true ? 1 : 0;

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
                txtCPF.Text = _pessoa.Cpf.ToString();
                txtNome.Text = _pessoa.Nome;
                txtTel.Text = _pessoa.Tel;
                txtEmail.Text = _pessoa.Email;

                //comboBoxTipoLogradouro.SelectedIndex = _pessoa.Endereco.TipoLogradouro;
                //txtLogradouro.Text = _pessoa.Endereco.Logradouro;
                //txtComplemento.Text = _pessoa.Endereco.Complemento;
                //txtCEP.Text = _pessoa.Endereco.Cep.ToString();
                //comboBoxCidade.SelectedIndex = _pessoa.Endereco.Cidade;
                //comboBoxEstado.SelectedIndex = _pessoa.Endereco.Estado;

                //rdbFeminino.Checked = _pessoa.Sexo == Sexo.Feminino ? true : false;
                //rdbSolteiro.Checked = _pessoa.EstadoCivil == EstadoCivil.Solteiro ? true : false;
                //rdbCasado.Checked = _pessoa.EstadoCivil == EstadoCivil.Casado ? true : false;
                //rdbDivorciado.Checked = _pessoa.EstadoCivil == EstadoCivil.Divorciado ? true : false;
                //rdbViuvo.Checked = _pessoa.EstadoCivil == EstadoCivil.Viuvo ? true : false;

                ckbFilhos.Checked = _pessoa.Filhos == 1 ? true : false;
                ckbAnimais.Checked = _pessoa.Animais == 1 ? true : false;
                ckbFumante.Checked = _pessoa.Fumante == 1 ? true : false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao carregar dados da Pessoa.", ex.Message);
            }
        }

        private void CadastroPessoaForm_Load(object sender, EventArgs e)
        {
            try
            {

                //CarregarComboEstados();

                if (this.Tag != null)
                {
                    buttonAlterar.Visible = true;

                    buttonSalvar.Visible = false;

                    txtCPF.Enabled = false;

                    PessoaModel p = (PessoaModel)this.Tag;

                    CarregarPessoaForm(p);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR FORM", ex.Message);
            }
        }

        private void CarregarComboEstados()
        {
            try
            {
                EstadoController controlEstado = new EstadoController();

                Dictionary<Int64, Estado> mapaEstados = (Dictionary<Int64, Estado>)controlEstado.BD('t', null);

                comboBoxEstado.DisplayMember = "descricao";
                comboBoxEstado.ValueMember = "id";

                comboBoxEstado.DataSource = mapaEstados.Values.ToList<Estado>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR COMBO DE ESTADOS: " + ex.Message);
            }
        }

        /*
        private void CarregarComboCidade()
        {
            try
            {
                CidadeCtrl controlCidade = new CidadeCtrl();

                Dictionary<Int64, Cidade> mapaCidades = (Dictionary<Int64, Cidade>)controlCidade.BD('t', null);

                comboBox.DisplayMember = "descricao";
                comboBox.ValueMember = "id";

                comboBox.DataSource = mapaCidades.Values.ToList<Cidade>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR COMBO DE CIDADES: " + ex.Message);
            }
        }
        */

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                PessoaModel p = CapturarPessoa();

                PessoaController control = new PessoaController();

                if ((Boolean)control.BD('u', p))
                {
                    MessageBox.Show("Cadastro alterado com sucesso!!!");
                }
                else
                {
                    MessageBox.Show("Cadastro NÃO alterado!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Int64 idEstado = (Int64)comboBoxEstado.SelectedValue;

                CidadeController controlCidade = new CidadeController();

                Dictionary<Int64, Cidade> mapaCidades = (Dictionary<Int64, Cidade>)controlCidade.BD('f', idEstado);

                comboBoxCidade.DisplayMember = "descricao";
                comboBoxCidade.ValueMember = "id";

                comboBoxCidade.DataSource = mapaCidades.Values.ToList<Cidade>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR COMBO DE CIDADES: " + ex.Message);
            }
        }

    }
}
