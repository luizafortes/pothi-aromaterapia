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

namespace Views.Usuario
{
    public partial class UsuarioCadastroForm : Form
    {
        public UsuarioCadastroForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioModel usuario = CapturarUsuario();
                PessoaController control = new PessoaController();

                if ((Boolean)control.BD('i', usuario))
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

        private UsuarioModel CapturarUsuario()
        {
            UsuarioModel usuario = new UsuarioModel();

            try
            {
                usuario.Login = txtLogin.Text;
                usuario.Senha = txtSenha.Text;
                usuario.Nome = txtNome.Text;
                usuario.Email = txtEmail.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao capturar dados do Usuário.", ex.Message);
            }
            return usuario;
        }

        private void CarregarUsuarioForm(UsuarioModel _usuario)
        {
            try
            {
                txtLogin.Text = _usuario.Login.ToString();
                txtSenha.Text = _usuario.Senha;
                txtNome.Text = _usuario.Nome;
                txtEmail.Text = _usuario.Email;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao carregar dados do Usuário.", ex.Message);
            }
        }

        private void CadastroUsuarioForm_Load(object sender, EventArgs e)
        {
            try
            {

                //CarregarComboEstados();

                if (this.Tag != null)
                {
                    buttonAlterar.Visible = true;

                    buttonSalvar.Visible = false;

                    txtUsuarioId.Enabled = false;

                    UsuarioModel u = (UsuarioModel)this.Tag;

                    CarregarUsuarioForm(u);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR FORM", ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioModel u = CapturarUsuario();

                UsuarioController control = new UsuarioController();

                if ((Boolean)control.BD('u', u))
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
    }
}
