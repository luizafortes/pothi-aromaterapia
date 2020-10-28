namespace Views.Pessoa
{
    partial class PessoaCadastroForm
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
            this.dadosPrincipais = new System.Windows.Forms.GroupBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dadosAdicionais = new System.Windows.Forms.GroupBox();
            this.endereco = new System.Windows.Forms.GroupBox();
            this.labelLogradouro = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.labelTipoLogradouro = new System.Windows.Forms.Label();
            this.comboBoxTipoLogradouro = new System.Windows.Forms.ComboBox();
            this.comboBoxCidade = new System.Windows.Forms.ComboBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelCEP = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.dadosPrincipais.SuspendLayout();
            this.endereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // dadosPrincipais
            // 
            this.dadosPrincipais.Controls.Add(this.labelEmail);
            this.dadosPrincipais.Controls.Add(this.txtEmail);
            this.dadosPrincipais.Controls.Add(this.maskedTextBox2);
            this.dadosPrincipais.Controls.Add(this.labelTelefone);
            this.dadosPrincipais.Controls.Add(this.txtCPF);
            this.dadosPrincipais.Controls.Add(this.labelCPF);
            this.dadosPrincipais.Controls.Add(this.labelNome);
            this.dadosPrincipais.Controls.Add(this.txtNome);
            this.dadosPrincipais.Location = new System.Drawing.Point(12, 34);
            this.dadosPrincipais.Name = "dadosPrincipais";
            this.dadosPrincipais.Size = new System.Drawing.Size(455, 155);
            this.dadosPrincipais.TabIndex = 0;
            this.dadosPrincipais.TabStop = false;
            this.dadosPrincipais.Text = "Dados Principais";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(100, 59);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmail.Location = new System.Drawing.Point(103, 75);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(346, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.SystemColors.Info;
            this.maskedTextBox2.Location = new System.Drawing.Point(9, 75);
            this.maskedTextBox2.Mask = "(99) 90000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(88, 20);
            this.maskedTextBox2.TabIndex = 6;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(6, 59);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(25, 13);
            this.labelTelefone.TabIndex = 5;
            this.labelTelefone.Text = "Tel.";
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.SystemColors.Info;
            this.txtCPF.Location = new System.Drawing.Point(364, 36);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(85, 20);
            this.txtCPF.TabIndex = 4;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(361, 20);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(27, 13);
            this.labelCPF.TabIndex = 3;
            this.labelCPF.Text = "CPF";
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
            this.txtNome.Size = new System.Drawing.Size(349, 20);
            this.txtNome.TabIndex = 0;
            // 
            // dadosAdicionais
            // 
            this.dadosAdicionais.Location = new System.Drawing.Point(12, 311);
            this.dadosAdicionais.Name = "dadosAdicionais";
            this.dadosAdicionais.Size = new System.Drawing.Size(455, 200);
            this.dadosAdicionais.TabIndex = 1;
            this.dadosAdicionais.TabStop = false;
            this.dadosAdicionais.Text = "Dados Adicionais";
            // 
            // endereco
            // 
            this.endereco.Controls.Add(this.labelComplemento);
            this.endereco.Controls.Add(this.txtComplemento);
            this.endereco.Controls.Add(this.txtCEP);
            this.endereco.Controls.Add(this.labelCEP);
            this.endereco.Controls.Add(this.comboBoxEstado);
            this.endereco.Controls.Add(this.labelEstado);
            this.endereco.Controls.Add(this.comboBoxCidade);
            this.endereco.Controls.Add(this.labelCidade);
            this.endereco.Controls.Add(this.comboBoxTipoLogradouro);
            this.endereco.Controls.Add(this.labelLogradouro);
            this.endereco.Controls.Add(this.txtLogradouro);
            this.endereco.Controls.Add(this.labelTipoLogradouro);
            this.endereco.Location = new System.Drawing.Point(12, 195);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(455, 110);
            this.endereco.TabIndex = 9;
            this.endereco.TabStop = false;
            this.endereco.Text = "Endereço";
            // 
            // labelLogradouro
            // 
            this.labelLogradouro.AutoSize = true;
            this.labelLogradouro.Location = new System.Drawing.Point(100, 20);
            this.labelLogradouro.Name = "labelLogradouro";
            this.labelLogradouro.Size = new System.Drawing.Size(61, 13);
            this.labelLogradouro.TabIndex = 10;
            this.labelLogradouro.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.BackColor = System.Drawing.SystemColors.Info;
            this.txtLogradouro.Location = new System.Drawing.Point(103, 36);
            this.txtLogradouro.Multiline = true;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(346, 21);
            this.txtLogradouro.TabIndex = 9;
            // 
            // labelTipoLogradouro
            // 
            this.labelTipoLogradouro.AutoSize = true;
            this.labelTipoLogradouro.Location = new System.Drawing.Point(6, 20);
            this.labelTipoLogradouro.Name = "labelTipoLogradouro";
            this.labelTipoLogradouro.Size = new System.Drawing.Size(31, 13);
            this.labelTipoLogradouro.TabIndex = 1;
            this.labelTipoLogradouro.Text = "Tipo ";
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
            this.comboBoxTipoLogradouro.Location = new System.Drawing.Point(9, 36);
            this.comboBoxTipoLogradouro.Name = "comboBoxTipoLogradouro";
            this.comboBoxTipoLogradouro.Size = new System.Drawing.Size(88, 21);
            this.comboBoxTipoLogradouro.TabIndex = 11;
            // 
            // comboBoxCidade
            // 
            this.comboBoxCidade.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxCidade.FormattingEnabled = true;
            this.comboBoxCidade.Items.AddRange(new object[] {
            "Avenida",
            "Estrada",
            "Rodovia",
            "Rua",
            "Travessa"});
            this.comboBoxCidade.Location = new System.Drawing.Point(173, 77);
            this.comboBoxCidade.Name = "comboBoxCidade";
            this.comboBoxCidade.Size = new System.Drawing.Size(88, 21);
            this.comboBoxCidade.TabIndex = 13;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(170, 61);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(40, 13);
            this.labelCidade.TabIndex = 12;
            this.labelCidade.Text = "Cidade";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Avenida",
            "Estrada",
            "Rodovia",
            "Rua",
            "Travessa"});
            this.comboBoxEstado.Location = new System.Drawing.Point(267, 77);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(88, 21);
            this.comboBoxEstado.TabIndex = 15;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(264, 61);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 14;
            this.labelEstado.Text = "Estado";
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Location = new System.Drawing.Point(358, 61);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(28, 13);
            this.labelCEP.TabIndex = 16;
            this.labelCEP.Text = "CEP";
            // 
            // txtCEP
            // 
            this.txtCEP.BackColor = System.Drawing.SystemColors.Info;
            this.txtCEP.Location = new System.Drawing.Point(361, 77);
            this.txtCEP.Mask = "00000-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(88, 20);
            this.txtCEP.TabIndex = 9;
            // 
            // txtComplemento
            // 
            this.txtComplemento.BackColor = System.Drawing.SystemColors.Info;
            this.txtComplemento.Location = new System.Drawing.Point(9, 77);
            this.txtComplemento.Multiline = true;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(158, 21);
            this.txtComplemento.TabIndex = 17;
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Location = new System.Drawing.Point(6, 61);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(71, 13);
            this.labelComplemento.TabIndex = 18;
            this.labelComplemento.Text = "Complemento";
            // 
            // PessoaCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 565);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.dadosAdicionais);
            this.Controls.Add(this.dadosPrincipais);
            this.Name = "PessoaCadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro";
            this.dadosPrincipais.ResumeLayout(false);
            this.dadosPrincipais.PerformLayout();
            this.endereco.ResumeLayout(false);
            this.endereco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dadosPrincipais;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox dadosAdicionais;
        private System.Windows.Forms.GroupBox endereco;
        private System.Windows.Forms.Label labelTipoLogradouro;
        private System.Windows.Forms.Label labelLogradouro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label labelComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox comboBoxCidade;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.ComboBox comboBoxTipoLogradouro;
    }
}