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
            this.listBoxTipoLogradouro = new System.Windows.Forms.ListBox();
            this.labelTipoLogradouro = new System.Windows.Forms.Label();
            this.labelLogradouro = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
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
            this.dadosAdicionais.Location = new System.Drawing.Point(12, 356);
            this.dadosAdicionais.Name = "dadosAdicionais";
            this.dadosAdicionais.Size = new System.Drawing.Size(455, 155);
            this.dadosAdicionais.TabIndex = 1;
            this.dadosAdicionais.TabStop = false;
            this.dadosAdicionais.Text = "Dados Adicionais";
            // 
            // endereco
            // 
            this.endereco.Controls.Add(this.labelLogradouro);
            this.endereco.Controls.Add(this.txtLogradouro);
            this.endereco.Controls.Add(this.listBoxTipoLogradouro);
            this.endereco.Controls.Add(this.labelTipoLogradouro);
            this.endereco.Location = new System.Drawing.Point(12, 195);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(455, 155);
            this.endereco.TabIndex = 9;
            this.endereco.TabStop = false;
            this.endereco.Text = "Endereço";
            // 
            // listBoxTipoLogradouro
            // 
            this.listBoxTipoLogradouro.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxTipoLogradouro.FormattingEnabled = true;
            this.listBoxTipoLogradouro.Items.AddRange(new object[] {
            "Avenida",
            "Estrada",
            "Rodovia",
            "Rua",
            "Travessa"});
            this.listBoxTipoLogradouro.Location = new System.Drawing.Point(7, 36);
            this.listBoxTipoLogradouro.Name = "listBoxTipoLogradouro";
            this.listBoxTipoLogradouro.Size = new System.Drawing.Size(90, 69);
            this.listBoxTipoLogradouro.TabIndex = 5;
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
            // labelLogradouro
            // 
            this.labelLogradouro.AutoSize = true;
            this.labelLogradouro.Location = new System.Drawing.Point(100, 20);
            this.labelLogradouro.Name = "labelLogradouro";
            this.labelLogradouro.Size = new System.Drawing.Size(32, 13);
            this.labelLogradouro.TabIndex = 10;
            this.labelLogradouro.Text = "Email";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.BackColor = System.Drawing.SystemColors.Info;
            this.txtLogradouro.Location = new System.Drawing.Point(103, 36);
            this.txtLogradouro.Multiline = true;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(255, 34);
            this.txtLogradouro.TabIndex = 9;
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
        private System.Windows.Forms.ListBox listBoxTipoLogradouro;
        private System.Windows.Forms.Label labelTipoLogradouro;
        private System.Windows.Forms.Label labelLogradouro;
        private System.Windows.Forms.TextBox txtLogradouro;
    }
}