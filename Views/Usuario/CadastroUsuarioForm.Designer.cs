
namespace Views.Usuario
{
    partial class UsuarioCadastroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dadosUsuario = new System.Windows.Forms.GroupBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dadosAcesso = new System.Windows.Forms.GroupBox();
            this.comboBoxTipoLogradouro = new System.Windows.Forms.ComboBox();
            this.labelPrivilegio = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.labelSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.labelUsuarioId = new System.Windows.Forms.Label();
            this.txtUsuarioId = new System.Windows.Forms.TextBox();
            this.dadosUsuario.SuspendLayout();
            this.dadosAcesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // dadosUsuario
            // 
            this.dadosUsuario.Controls.Add(this.labelEmail);
            this.dadosUsuario.Controls.Add(this.txtEmail);
            this.dadosUsuario.Controls.Add(this.labelNome);
            this.dadosUsuario.Controls.Add(this.txtNome);
            this.dadosUsuario.Location = new System.Drawing.Point(12, 50);
            this.dadosUsuario.Name = "dadosUsuario";
            this.dadosUsuario.Size = new System.Drawing.Size(290, 105);
            this.dadosUsuario.TabIndex = 0;
            this.dadosUsuario.TabStop = false;
            this.dadosUsuario.Text = "Dados do Usuário";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(6, 59);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmail.Location = new System.Drawing.Point(9, 75);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(272, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(6, 20);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Info;
            this.txtNome.Location = new System.Drawing.Point(9, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(272, 20);
            this.txtNome.TabIndex = 0;
            // 
            // dadosAcesso
            // 
            this.dadosAcesso.Controls.Add(this.labelSenha);
            this.dadosAcesso.Controls.Add(this.comboBoxTipoLogradouro);
            this.dadosAcesso.Controls.Add(this.labelPrivilegio);
            this.dadosAcesso.Controls.Add(this.txtSenha);
            this.dadosAcesso.Controls.Add(this.txtLogin);
            this.dadosAcesso.Controls.Add(this.labelLogin);
            this.dadosAcesso.Location = new System.Drawing.Point(12, 161);
            this.dadosAcesso.Name = "dadosAcesso";
            this.dadosAcesso.Size = new System.Drawing.Size(290, 110);
            this.dadosAcesso.TabIndex = 9;
            this.dadosAcesso.TabStop = false;
            this.dadosAcesso.Text = "Dados de Acesso";
            // 
            // comboBoxTipoLogradouro
            // 
            this.comboBoxTipoLogradouro.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxTipoLogradouro.FormattingEnabled = true;
            this.comboBoxTipoLogradouro.Items.AddRange(new object[] {
            "Avenida",
            "Estrada",
            "Rodovia",
            "Rua",
            "Travessa"});
            this.comboBoxTipoLogradouro.Location = new System.Drawing.Point(193, 33);
            this.comboBoxTipoLogradouro.Name = "comboBoxTipoLogradouro";
            this.comboBoxTipoLogradouro.Size = new System.Drawing.Size(88, 21);
            this.comboBoxTipoLogradouro.TabIndex = 11;
            // 
            // labelPrivilegio
            // 
            this.labelPrivilegio.AutoSize = true;
            this.labelPrivilegio.Location = new System.Drawing.Point(190, 17);
            this.labelPrivilegio.Name = "labelPrivilegio";
            this.labelPrivilegio.Size = new System.Drawing.Size(49, 13);
            this.labelPrivilegio.TabIndex = 1;
            this.labelPrivilegio.Text = "Privilégio";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(146, 286);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(227, 286);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(146, 286);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 12;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Visible = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(6, 56);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 12;
            this.labelSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Info;
            this.txtSenha.Location = new System.Drawing.Point(9, 72);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(178, 20);
            this.txtSenha.TabIndex = 11;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(6, 17);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 10;
            this.labelLogin.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.Info;
            this.txtLogin.Location = new System.Drawing.Point(9, 33);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(178, 20);
            this.txtLogin.TabIndex = 9;
            // 
            // labelUsuarioId
            // 
            this.labelUsuarioId.AutoSize = true;
            this.labelUsuarioId.Location = new System.Drawing.Point(9, 8);
            this.labelUsuarioId.Name = "labelUsuarioId";
            this.labelUsuarioId.Size = new System.Drawing.Size(52, 13);
            this.labelUsuarioId.TabIndex = 14;
            this.labelUsuarioId.Text = "UsuarioId";
            // 
            // txtUsuarioId
            // 
            this.txtUsuarioId.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsuarioId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioId.Location = new System.Drawing.Point(12, 24);
            this.txtUsuarioId.Name = "txtUsuarioId";
            this.txtUsuarioId.ReadOnly = true;
            this.txtUsuarioId.Size = new System.Drawing.Size(74, 13);
            this.txtUsuarioId.TabIndex = 13;
            // 
            // UsuarioCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 318);
            this.Controls.Add(this.labelUsuarioId);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.txtUsuarioId);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.dadosAcesso);
            this.Controls.Add(this.dadosUsuario);
            this.Name = "UsuarioCadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.CadastroUsuarioForm_Load);
            this.dadosUsuario.ResumeLayout(false);
            this.dadosUsuario.PerformLayout();
            this.dadosAcesso.ResumeLayout(false);
            this.dadosAcesso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox dadosUsuario;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox dadosAcesso;
        private System.Windows.Forms.Label labelPrivilegio;
        private System.Windows.Forms.ComboBox comboBoxTipoLogradouro;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label labelUsuarioId;
        private System.Windows.Forms.TextBox txtUsuarioId;
    }     
    
}