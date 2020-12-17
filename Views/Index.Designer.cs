using System.Windows.Forms;

namespace Views
{
    partial class Index
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuPessoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroPessoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaPessoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOleo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroOleo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaOleo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSintoma = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rodape = new System.Windows.Forms.StatusStrip();
            this.timeStamp = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.relogio = new System.Windows.Forms.Timer(this.components);
            this.labelDadosUsuario = new System.Windows.Forms.Label();
            this.menuConsultaByImagenmOleo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.rodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPessoa,
            this.menuOleo,
            this.menuSintoma,
            this.menuUsuario});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1008, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "Menu";
            // 
            // menuPessoa
            // 
            this.menuPessoa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroPessoa,
            this.menuConsultaPessoa});
            this.menuPessoa.Name = "menuPessoa";
            this.menuPessoa.Size = new System.Drawing.Size(60, 20);
            this.menuPessoa.Text = "Pessoas";
            // 
            // menuCadastroPessoa
            // 
            this.menuCadastroPessoa.Name = "menuCadastroPessoa";
            this.menuCadastroPessoa.Size = new System.Drawing.Size(125, 22);
            this.menuCadastroPessoa.Text = "Cadastrar";
            this.menuCadastroPessoa.Click += new System.EventHandler(this.CadastrarPessoa);
            // 
            // menuConsultaPessoa
            // 
            this.menuConsultaPessoa.Name = "menuConsultaPessoa";
            this.menuConsultaPessoa.Size = new System.Drawing.Size(125, 22);
            this.menuConsultaPessoa.Text = "Consultar";
            this.menuConsultaPessoa.Click += new System.EventHandler(this.ConsultarPessoa);
            // 
            // menuOleo
            // 
            this.menuOleo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroOleo,
            this.menuConsultaOleo,
            this.menuConsultaByImagenmOleo});
            this.menuOleo.Name = "menuOleo";
            this.menuOleo.Size = new System.Drawing.Size(49, 20);
            this.menuOleo.Text = "Óleos";
            // 
            // menuCadastroOleo
            // 
            this.menuCadastroOleo.Name = "menuCadastroOleo";
            this.menuCadastroOleo.Size = new System.Drawing.Size(194, 22);
            this.menuCadastroOleo.Text = "Cadastrar";
            this.menuCadastroOleo.ToolTipText = "Cadastrar Óleo";
            this.menuCadastroOleo.Click += new System.EventHandler(this.CadastrarOleo);
            // 
            // menuConsultaOleo
            // 
            this.menuConsultaOleo.Name = "menuConsultaOleo";
            this.menuConsultaOleo.Size = new System.Drawing.Size(194, 22);
            this.menuConsultaOleo.Text = "Consultar";
            this.menuConsultaOleo.ToolTipText = "Consultar óleo";
            this.menuConsultaOleo.Click += new System.EventHandler(this.ConsultarOleo);
            // 
            // menuSintoma
            // 
            this.menuSintoma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1,
            this.consultarToolStripMenuItem1});
            this.menuSintoma.Name = "menuSintoma";
            this.menuSintoma.Size = new System.Drawing.Size(68, 20);
            this.menuSintoma.Text = "Sintomas";
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem1.Click += new System.EventHandler(this.CadastrarSintoma);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            this.consultarToolStripMenuItem1.Click += new System.EventHandler(this.ConsultarSintoma);
            // 
            // menuUsuario
            // 
            this.menuUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(64, 20);
            this.menuUsuario.Text = "Usuários";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.CadastrarUsuario);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.ConsultarUsuario);
            // 
            // rodape
            // 
            this.rodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeStamp});
            this.rodape.Location = new System.Drawing.Point(0, 646);
            this.rodape.Name = "rodape";
            this.rodape.Size = new System.Drawing.Size(1008, 22);
            this.rodape.TabIndex = 2;
            this.rodape.Text = "statusStrip1";
            // 
            // timeStamp
            // 
            this.timeStamp.Name = "timeStamp";
            this.timeStamp.Size = new System.Drawing.Size(110, 17);
            this.timeStamp.Text = "28/10/2020 10:45:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1008, 622);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // relogio
            // 
            this.relogio.Interval = 1000;
            this.relogio.Tick += new System.EventHandler(this.relogio_Tick);
            // 
            // labelDadosUsuario
            // 
            this.labelDadosUsuario.AutoSize = true;
            this.labelDadosUsuario.Location = new System.Drawing.Point(853, 649);
            this.labelDadosUsuario.Name = "labelDadosUsuario";
            this.labelDadosUsuario.Size = new System.Drawing.Size(16, 13);
            this.labelDadosUsuario.TabIndex = 4;
            this.labelDadosUsuario.Text = "...";
            this.labelDadosUsuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // menuConsultaByImagenmOleo
            // 
            this.menuConsultaByImagenmOleo.Name = "menuConsultaByImagenmOleo";
            this.menuConsultaByImagenmOleo.Size = new System.Drawing.Size(194, 22);
            this.menuConsultaByImagenmOleo.Text = "Consultar por Imagens";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1008, 668);
            this.Controls.Add(this.labelDadosUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rodape);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Index_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.rodape.ResumeLayout(false);
            this.rodape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStripMenuItem menuPessoa;
        private ToolStripMenuItem menuCadastroPessoa;
        private ToolStripMenuItem menuConsultaPessoa;
        private ToolStripMenuItem menuOleo;
        private ToolStripMenuItem menuCadastroOleo;
        private ToolStripMenuItem menuConsultaOleo;
        private ToolStripMenuItem menuSintoma;
        private ToolStripMenuItem menuUsuario;
        private StatusStrip rodape;
        private ToolStripStatusLabel timeStamp;
        private PictureBox pictureBox1;
        private Timer relogio;
        private Label labelDadosUsuario;
        private ToolStripMenuItem cadastrarToolStripMenuItem1;
        private ToolStripMenuItem consultarToolStripMenuItem1;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem menuConsultaByImagenmOleo;
    }
}

