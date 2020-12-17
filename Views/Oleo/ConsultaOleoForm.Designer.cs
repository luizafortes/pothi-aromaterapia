
namespace Views.Oleo
{
    partial class ConsultaOleoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaOleoForm));
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.colOleoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.menuDeletar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListOleos = new System.Windows.Forms.ImageList(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.labelFoto = new System.Windows.Forms.Label();
            this.buttonNovoOleo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.menuDeletar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.AllowUserToAddRows = false;
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOleoId,
            this.colNome,
            this.colDescricao});
            this.dataGridViewDados.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewDados.MultiSelect = false;
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.ReadOnly = true;
            this.dataGridViewDados.RowHeadersVisible = false;
            this.dataGridViewDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDados.Size = new System.Drawing.Size(521, 344);
            this.dataGridViewDados.TabIndex = 0;
            this.dataGridViewDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // colOleoId
            // 
            this.colOleoId.HeaderText = "OleoId";
            this.colOleoId.Name = "colOleoId";
            this.colOleoId.ReadOnly = true;
            this.colOleoId.Width = 60;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 200;
            // 
            // colDescricao
            // 
            this.colDescricao.HeaderText = "Descricao";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Width = 260;
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
            this.txtPesquisa.Size = new System.Drawing.Size(463, 20);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txbPesquisa_TextChanged);
            // 
            // buttonSair
            // 
            this.buttonSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSair.Location = new System.Drawing.Point(458, 386);
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
            // imageListOleos
            // 
            this.imageListOleos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListOleos.ImageStream")));
            this.imageListOleos.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListOleos.Images.SetKeyName(0, "alecrim.jpg");
            this.imageListOleos.Images.SetKeyName(1, "amendoas_amargas.jpg");
            this.imageListOleos.Images.SetKeyName(2, "bergamota.jpg");
            this.imageListOleos.Images.SetKeyName(3, "breu_preto.jpg");
            this.imageListOleos.Images.SetKeyName(4, "cafe_torrado.jpg");
            this.imageListOleos.Images.SetKeyName(5, "camomila.jpg");
            this.imageListOleos.Images.SetKeyName(6, "capim_limao.jpg");
            this.imageListOleos.Images.SetKeyName(7, "cardamomo.jpg");
            this.imageListOleos.Images.SetKeyName(8, "cedro.jpg");
            this.imageListOleos.Images.SetKeyName(9, "geranio.jpg");
            this.imageListOleos.Images.SetKeyName(10, "jasmim.jpg");
            this.imageListOleos.Images.SetKeyName(11, "laranja_doce.jpg");
            this.imageListOleos.Images.SetKeyName(12, "lavanda_fina.jpg");
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(818, 295);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(23, 23);
            this.btn_right.TabIndex = 6;
            this.btn_right.Text = ">";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(588, 295);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(23, 23);
            this.btn_left.TabIndex = 5;
            this.btn_left.Text = "<";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // labelFoto
            // 
            this.labelFoto.ImageIndex = 0;
            this.labelFoto.ImageList = this.imageListOleos;
            this.labelFoto.Location = new System.Drawing.Point(585, 36);
            this.labelFoto.Name = "labelFoto";
            this.labelFoto.Size = new System.Drawing.Size(256, 256);
            this.labelFoto.TabIndex = 4;
            // 
            // buttonNovoOleo
            // 
            this.buttonNovoOleo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonNovoOleo.Location = new System.Drawing.Point(352, 386);
            this.buttonNovoOleo.Name = "buttonNovoOleo";
            this.buttonNovoOleo.Size = new System.Drawing.Size(100, 23);
            this.buttonNovoOleo.TabIndex = 3;
            this.buttonNovoOleo.Text = "Novo Óleo";
            this.buttonNovoOleo.UseVisualStyleBackColor = true;
            this.buttonNovoOleo.Click += new System.EventHandler(this.buttonNovoOleo_Click);
            // 
            // ConsultaOleoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonSair;
            this.ClientSize = new System.Drawing.Size(883, 414);
            this.ContextMenuStrip = this.menuDeletar;
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.labelFoto);
            this.Controls.Add(this.buttonNovoOleo);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.labelPesquisa);
            this.Controls.Add(this.dataGridViewDados);
            this.Name = "ConsultaOleoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Oleos";
            this.Load += new System.EventHandler(this.OleoConsultaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            this.menuDeletar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn colOleoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.Label labelPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button buttonSair;
        public System.Windows.Forms.DataGridView dataGridViewDados;
        private System.Windows.Forms.ContextMenuStrip menuDeletar;
        private System.Windows.Forms.ToolStripMenuItem imDelete;
        private System.Windows.Forms.ImageList imageListOleos;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Label labelFoto;
        private System.Windows.Forms.Button buttonNovoOleo;
    }
}