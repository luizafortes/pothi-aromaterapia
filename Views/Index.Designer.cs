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
            this.menuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.barraTarefas = new System.Windows.Forms.ToolStrip();
            this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imprimirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.recortarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copiarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rodape = new System.Windows.Forms.StatusStrip();
            this.timeStamp = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.relogio = new System.Windows.Forms.Timer(this.components);
            this.menuPrincipal.SuspendLayout();
            this.barraTarefas.SuspendLayout();
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
            this.menuConsultaOleo});
            this.menuOleo.Name = "menuOleo";
            this.menuOleo.Size = new System.Drawing.Size(49, 20);
            this.menuOleo.Text = "Óleos";
            // 
            // menuCadastroOleo
            // 
            this.menuCadastroOleo.Name = "menuCadastroOleo";
            this.menuCadastroOleo.Size = new System.Drawing.Size(125, 22);
            this.menuCadastroOleo.Text = "Cadastrar";
            this.menuCadastroOleo.ToolTipText = "Cadastrar Óleo";
            // 
            // menuConsultaOleo
            // 
            this.menuConsultaOleo.Name = "menuConsultaOleo";
            this.menuConsultaOleo.Size = new System.Drawing.Size(125, 22);
            this.menuConsultaOleo.Text = "Consultar";
            this.menuConsultaOleo.ToolTipText = "Consultar óleo";
            // 
            // menuSintoma
            // 
            this.menuSintoma.Name = "menuSintoma";
            this.menuSintoma.Size = new System.Drawing.Size(68, 20);
            this.menuSintoma.Text = "Sintomas";
            // 
            // menuUsuario
            // 
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(64, 20);
            this.menuUsuario.Text = "Usuários";
            // 
            // barraTarefas
            // 
            this.barraTarefas.Dock = System.Windows.Forms.DockStyle.Left;
            this.barraTarefas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.barraTarefas.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.barraTarefas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripButton,
            this.abrirToolStripButton,
            this.salvarToolStripButton,
            this.imprimirToolStripButton,
            this.toolStripSeparator,
            this.recortarToolStripButton,
            this.copiarToolStripButton,
            this.colarToolStripButton,
            this.toolStripSeparator1,
            this.ajudaToolStripButton});
            this.barraTarefas.Location = new System.Drawing.Point(0, 24);
            this.barraTarefas.Name = "barraTarefas";
            this.barraTarefas.Size = new System.Drawing.Size(30, 644);
            this.barraTarefas.TabIndex = 1;
            this.barraTarefas.Text = "toolStrip1";
            // 
            // novoToolStripButton
            // 
            this.novoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripButton.Image")));
            this.novoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripButton.Name = "novoToolStripButton";
            this.novoToolStripButton.Size = new System.Drawing.Size(27, 29);
            this.novoToolStripButton.Text = "&Novo";
            // 
            // abrirToolStripButton
            // 
            this.abrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripButton.Image")));
            this.abrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton.Name = "abrirToolStripButton";
            this.abrirToolStripButton.Size = new System.Drawing.Size(27, 29);
            this.abrirToolStripButton.Text = "&Abrir";
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(27, 29);
            this.salvarToolStripButton.Text = "&Salvar";
            // 
            // imprimirToolStripButton
            // 
            this.imprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripButton.Image")));
            this.imprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripButton.Name = "imprimirToolStripButton";
            this.imprimirToolStripButton.Size = new System.Drawing.Size(27, 29);
            this.imprimirToolStripButton.Text = "&Imprimir";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(27, 6);
            // 
            // recortarToolStripButton
            // 
            this.recortarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.recortarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("recortarToolStripButton.Image")));
            this.recortarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.recortarToolStripButton.Name = "recortarToolStripButton";
            this.recortarToolStripButton.Size = new System.Drawing.Size(27, 29);
            this.recortarToolStripButton.Text = "Recor&tar";
            // 
            // copiarToolStripButton
            // 
            this.copiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripButton.Image")));
            this.copiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripButton.Name = "copiarToolStripButton";
            this.copiarToolStripButton.Size = new System.Drawing.Size(27, 29);
            this.copiarToolStripButton.Text = "&Copiar";
            // 
            // colarToolStripButton
            // 
            this.colarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("colarToolStripButton.Image")));
            this.colarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colarToolStripButton.Name = "colarToolStripButton";
            this.colarToolStripButton.Size = new System.Drawing.Size(27, 29);
            this.colarToolStripButton.Text = "C&olar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(27, 6);
            // 
            // ajudaToolStripButton
            // 
            this.ajudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ajudaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripButton.Image")));
            this.ajudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ajudaToolStripButton.Name = "ajudaToolStripButton";
            this.ajudaToolStripButton.Size = new System.Drawing.Size(27, 29);
            this.ajudaToolStripButton.Text = "&Ajuda";
            // 
            // rodape
            // 
            this.rodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeStamp});
            this.rodape.Location = new System.Drawing.Point(30, 646);
            this.rodape.Name = "rodape";
            this.rodape.Size = new System.Drawing.Size(978, 22);
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
            this.pictureBox1.Location = new System.Drawing.Point(30, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(978, 622);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // relogio
            // 
            this.relogio.Interval = 1000;
            this.relogio.Tick += new System.EventHandler(this.relogio_Tick);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1008, 668);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rodape);
            this.Controls.Add(this.barraTarefas);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Index_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.barraTarefas.ResumeLayout(false);
            this.barraTarefas.PerformLayout();
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
        private ToolStrip barraTarefas;
        private ToolStripButton novoToolStripButton;
        private ToolStripButton abrirToolStripButton;
        private ToolStripButton salvarToolStripButton;
        private ToolStripButton imprimirToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton recortarToolStripButton;
        private ToolStripButton copiarToolStripButton;
        private ToolStripButton colarToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ajudaToolStripButton;
        private StatusStrip rodape;
        private ToolStripStatusLabel timeStamp;
        private PictureBox pictureBox1;
        private Timer relogio;
    }
}

