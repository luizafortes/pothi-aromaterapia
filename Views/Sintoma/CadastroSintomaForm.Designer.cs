
namespace Views.Sintoma
{
    partial class SintomaCadastroForm
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
            this.dadosSintoma = new System.Windows.Forms.GroupBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.labelSintomaId = new System.Windows.Forms.Label();
            this.txtSintomaId = new System.Windows.Forms.TextBox();
            this.dadosSintoma.SuspendLayout();
            this.SuspendLayout();
            // 
            // dadosSintoma
            // 
            this.dadosSintoma.Controls.Add(this.labelDescricao);
            this.dadosSintoma.Controls.Add(this.txtDescricao);
            this.dadosSintoma.Controls.Add(this.labelNome);
            this.dadosSintoma.Controls.Add(this.txtNome);
            this.dadosSintoma.Location = new System.Drawing.Point(11, 43);
            this.dadosSintoma.Name = "dadosSintoma";
            this.dadosSintoma.Size = new System.Drawing.Size(290, 169);
            this.dadosSintoma.TabIndex = 0;
            this.dadosSintoma.TabStop = false;
            this.dadosSintoma.Text = "Dados do Sintoma";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(6, 59);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(55, 13);
            this.labelDescricao.TabIndex = 3;
            this.labelDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.Info;
            this.txtDescricao.Location = new System.Drawing.Point(9, 75);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(272, 79);
            this.txtDescricao.TabIndex = 2;
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
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(145, 218);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(226, 218);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(145, 218);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 12;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Visible = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // labelSintomaId
            // 
            this.labelSintomaId.AutoSize = true;
            this.labelSintomaId.Location = new System.Drawing.Point(9, 8);
            this.labelSintomaId.Name = "labelSintomaId";
            this.labelSintomaId.Size = new System.Drawing.Size(54, 13);
            this.labelSintomaId.TabIndex = 14;
            this.labelSintomaId.Text = "SintomaId";
            // 
            // txtSintomaId
            // 
            this.txtSintomaId.BackColor = System.Drawing.SystemColors.Control;
            this.txtSintomaId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSintomaId.Location = new System.Drawing.Point(12, 24);
            this.txtSintomaId.Name = "txtSintomaId";
            this.txtSintomaId.ReadOnly = true;
            this.txtSintomaId.Size = new System.Drawing.Size(74, 13);
            this.txtSintomaId.TabIndex = 13;
            // 
            // SintomaCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 250);
            this.Controls.Add(this.labelSintomaId);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.txtSintomaId);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.dadosSintoma);
            this.Name = "SintomaCadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Sintomas";
            this.Load += new System.EventHandler(this.CadastroSintomaForm_Load);
            this.dadosSintoma.ResumeLayout(false);
            this.dadosSintoma.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox dadosSintoma;
        private System.Windows.Forms.Label labelSintomaId;
        private System.Windows.Forms.TextBox txtSintomaId;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
    }

}