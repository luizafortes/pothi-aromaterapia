namespace Views.Pessoa
{
    partial class PessoaConsultaForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.labelPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.menuDeletar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.colPessoaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.menuDeletar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.AllowUserToAddRows = false;
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPessoaId,
            this.colCpf,
            this.colNome,
            this.colEmail});
            this.dataGridViewDados.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewDados.MultiSelect = false;
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.ReadOnly = true;
            this.dataGridViewDados.RowHeadersVisible = false;
            this.dataGridViewDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDados.Size = new System.Drawing.Size(622, 344);
            this.dataGridViewDados.TabIndex = 0;
            this.dataGridViewDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.AutoSize = true;
            this.labelPesquisa.Location = new System.Drawing.Point(14, 14);
            this.labelPesquisa.Name = "labelPesquisa";
            this.labelPesquisa.Size = new System.Drawing.Size(50, 13);
            this.labelPesquisa.TabIndex = 1;
            this.labelPesquisa.Text = "Pesquisa";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(70, 10);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(315, 20);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txbPesquisa_TextChanged);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(559, 386);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 3;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // menuDeletar
            // 
            this.menuDeletar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imDelete});
            this.menuDeletar.Name = "contextMenuStrip1";
            this.menuDeletar.Size = new System.Drawing.Size(108, 26);
            // 
            // imDelete
            // 
            this.imDelete.Name = "imDelete";
            this.imDelete.Size = new System.Drawing.Size(107, 22);
            this.imDelete.Text = "Delete";
            this.imDelete.Click += new System.EventHandler(this.imDelete_Click);
            // 
            // colPessoaId
            // 
            this.colPessoaId.HeaderText = "PessoaId";
            this.colPessoaId.Name = "colPessoaId";
            this.colPessoaId.ReadOnly = true;
            // 
            // colCpf
            // 
            this.colCpf.HeaderText = "CPF";
            this.colCpf.Name = "colCpf";
            this.colCpf.ReadOnly = true;
            this.colCpf.Width = 120;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 200;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "E-mail";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 200;
            // 
            // PessoaConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 414);
            this.ContextMenuStrip = this.menuDeletar;
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.labelPesquisa);
            this.Controls.Add(this.dataGridViewDados);
            this.Name = "PessoaConsultaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Pessoas";
            this.Load += new System.EventHandler(this.PessoaConsultaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            this.menuDeletar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button buttonSair;
        public System.Windows.Forms.DataGridView dataGridViewDados;
        private System.Windows.Forms.ContextMenuStrip menuDeletar;
        private System.Windows.Forms.ToolStripMenuItem imDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPessoaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    }
}