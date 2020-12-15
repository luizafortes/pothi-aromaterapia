
namespace Views.Oleo
{
    partial class OleoCadastroForm
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
            this.dadosOleo = new System.Windows.Forms.GroupBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.labelOleoId = new System.Windows.Forms.Label();
            this.txtOleoId = new System.Windows.Forms.TextBox();
            this.dadosOleo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dadosOleo
            // 
            this.dadosOleo.Controls.Add(this.labelDescricao);
            this.dadosOleo.Controls.Add(this.txtDescricao);
            this.dadosOleo.Controls.Add(this.labelNome);
            this.dadosOleo.Controls.Add(this.txtNome);
            this.dadosOleo.Location = new System.Drawing.Point(11, 43);
            this.dadosOleo.Name = "dadosOleo";
            this.dadosOleo.Size = new System.Drawing.Size(290, 169);
            this.dadosOleo.TabIndex = 0;
            this.dadosOleo.TabStop = false;
            this.dadosOleo.Text = "Dados do Óleo";
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
            // labelOleoId
            // 
            this.labelOleoId.AutoSize = true;
            this.labelOleoId.Location = new System.Drawing.Point(9, 8);
            this.labelOleoId.Name = "labelOleoId";
            this.labelOleoId.Size = new System.Drawing.Size(54, 13);
            this.labelOleoId.TabIndex = 14;
            this.labelOleoId.Text = "OleoId";
            // 
            // txtOleoId
            // 
            this.txtOleoId.BackColor = System.Drawing.SystemColors.Control;
            this.txtOleoId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOleoId.Location = new System.Drawing.Point(12, 24);
            this.txtOleoId.Name = "txtOleoId";
            this.txtOleoId.ReadOnly = true;
            this.txtOleoId.Size = new System.Drawing.Size(74, 13);
            this.txtOleoId.TabIndex = 13;
            // 
            // OleoCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 250);
            this.Controls.Add(this.labelOleoId);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.txtOleoId);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.dadosOleo);
            this.Name = "OleoCadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Óleos";
            this.Load += new System.EventHandler(this.CadastroOleoForm_Load);
            this.dadosOleo.ResumeLayout(false);
            this.dadosOleo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox dadosOleo;
        private System.Windows.Forms.Label labelOleoId;
        private System.Windows.Forms.TextBox txtOleoId;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
    }

}