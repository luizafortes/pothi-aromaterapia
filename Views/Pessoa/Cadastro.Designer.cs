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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dadosPrincipais.SuspendLayout();
            this.dadosAdicionais.SuspendLayout();
            this.endereco.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.dadosPrincipais.Size = new System.Drawing.Size(455, 105);
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
            this.dadosAdicionais.Controls.Add(this.groupBox3);
            this.dadosAdicionais.Controls.Add(this.groupBox2);
            this.dadosAdicionais.Controls.Add(this.groupBox1);
            this.dadosAdicionais.Location = new System.Drawing.Point(12, 261);
            this.dadosAdicionais.Name = "dadosAdicionais";
            this.dadosAdicionais.Size = new System.Drawing.Size(455, 165);
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
            this.endereco.Location = new System.Drawing.Point(12, 145);
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Feminino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Masculino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Solteiro";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 45);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(61, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Casado";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 68);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(76, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Divorciado";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 91);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(52, 17);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Viúvo";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Filhos";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 44);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(62, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Animais";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 67);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(67, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Fumante";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(9, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 133);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Location = new System.Drawing.Point(164, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 133);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado Civil";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Location = new System.Drawing.Point(324, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 132);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Outros";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PessoaCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 463);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.dadosAdicionais);
            this.Controls.Add(this.dadosPrincipais);
            this.Name = "PessoaCadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro";
            this.dadosPrincipais.ResumeLayout(false);
            this.dadosPrincipais.PerformLayout();
            this.dadosAdicionais.ResumeLayout(false);
            this.endereco.ResumeLayout(false);
            this.endereco.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}