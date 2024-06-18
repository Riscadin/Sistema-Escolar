namespace JanelasMDI
{
    partial class frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastrarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.agendarAtendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarAtendimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarNaVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarJanelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarEmCascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.minimizarTodasJanelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizarTodasJanelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnCadCli = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBuscarCli = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBuscarAlu = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bemvindo = new System.Windows.Forms.Label();
            this.BemVindoTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sistemaToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.janelaToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.MdiWindowListItem = this.janelaToolStripMenuItem;
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            this.menuStrip2.MouseLeave += new System.EventHandler(this.menuStrip2_MouseLeave);
            this.menuStrip2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip2_MouseMove);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.toolStripSeparator1,
            this.fecharToolStripMenuItem});
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            this.arquivoToolStripMenuItem.MouseLeave += new System.EventHandler(this.arquivoToolStripMenuItem_MouseLeave);
            this.arquivoToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.arquivoToolStripMenuItem_MouseMove);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.salvarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.salvarToolStripMenuItem.Text = "Fechar Todas as Janelas";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.fecharToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.fecharToolStripMenuItem.Text = "Fechar Sistema";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem,
            this.cadastrarAnimalToolStripMenuItem});
            this.sistemaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.sistemaToolStripMenuItem.Text = "Adiministração";
            this.sistemaToolStripMenuItem.Click += new System.EventHandler(this.sistemaToolStripMenuItem_Click);
            this.sistemaToolStripMenuItem.MouseLeave += new System.EventHandler(this.sistemaToolStripMenuItem_MouseLeave);
            this.sistemaToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sistemaToolStripMenuItem_MouseMove);
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.cadastrarClienteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar Usuário";
            this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
            // 
            // cadastrarAnimalToolStripMenuItem
            // 
            this.cadastrarAnimalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.cadastrarAnimalToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastrarAnimalToolStripMenuItem.Name = "cadastrarAnimalToolStripMenuItem";
            this.cadastrarAnimalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.cadastrarAnimalToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.cadastrarAnimalToolStripMenuItem.Text = "Visualizar Usuários";
            this.cadastrarAnimalToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAnimalToolStripMenuItem_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadClientesToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.buscarClienteToolStripMenuItem,
            this.toolStripSeparator2,
            this.cadastrarAlunoToolStripMenuItem,
            this.listarAlunosToolStripMenuItem,
            this.buscarAlunoToolStripMenuItem,
            this.toolStripSeparator7,
            this.agendarAtendimentoToolStripMenuItem,
            this.visualizarAtendimentosToolStripMenuItem});
            this.ferramentasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ferramentasToolStripMenuItem.Text = "Sistemas";
            this.ferramentasToolStripMenuItem.MouseLeave += new System.EventHandler(this.ferramentasToolStripMenuItem_MouseLeave);
            this.ferramentasToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ferramentasToolStripMenuItem_MouseMove);
            this.ferramentasToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ferramentasToolStripMenuItem_MouseUp);
            // 
            // cadClientesToolStripMenuItem
            // 
            this.cadClientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.cadClientesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadClientesToolStripMenuItem.Name = "cadClientesToolStripMenuItem";
            this.cadClientesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.cadClientesToolStripMenuItem.Text = "Cadastrar Cliente";
            this.cadClientesToolStripMenuItem.Click += new System.EventHandler(this.cadClientesToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.calculadoraToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.calculadoraToolStripMenuItem.Text = "Listar Clientes";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.buscarClienteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(198, 6);
            // 
            // cadastrarAlunoToolStripMenuItem
            // 
            this.cadastrarAlunoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.cadastrarAlunoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastrarAlunoToolStripMenuItem.Name = "cadastrarAlunoToolStripMenuItem";
            this.cadastrarAlunoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.cadastrarAlunoToolStripMenuItem.Text = "Cadastrar Aluno";
            this.cadastrarAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAlunoToolStripMenuItem_Click);
            // 
            // listarAlunosToolStripMenuItem
            // 
            this.listarAlunosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.listarAlunosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.listarAlunosToolStripMenuItem.Name = "listarAlunosToolStripMenuItem";
            this.listarAlunosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.listarAlunosToolStripMenuItem.Text = "Listar Alunos";
            this.listarAlunosToolStripMenuItem.Click += new System.EventHandler(this.listarAlunosToolStripMenuItem_Click);
            // 
            // buscarAlunoToolStripMenuItem
            // 
            this.buscarAlunoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.buscarAlunoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.buscarAlunoToolStripMenuItem.Name = "buscarAlunoToolStripMenuItem";
            this.buscarAlunoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.buscarAlunoToolStripMenuItem.Text = "Buscar Aluno";
            this.buscarAlunoToolStripMenuItem.Click += new System.EventHandler(this.buscarAlunoToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.toolStripSeparator7.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(198, 6);
            // 
            // agendarAtendimentoToolStripMenuItem
            // 
            this.agendarAtendimentoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.agendarAtendimentoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.agendarAtendimentoToolStripMenuItem.Name = "agendarAtendimentoToolStripMenuItem";
            this.agendarAtendimentoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.agendarAtendimentoToolStripMenuItem.Text = "Agendar Atendimento";
            // 
            // visualizarAtendimentosToolStripMenuItem
            // 
            this.visualizarAtendimentosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.visualizarAtendimentosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.visualizarAtendimentosToolStripMenuItem.Name = "visualizarAtendimentosToolStripMenuItem";
            this.visualizarAtendimentosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.visualizarAtendimentosToolStripMenuItem.Text = "Visualizar Atendimentos";
            // 
            // janelaToolStripMenuItem
            // 
            this.janelaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.janelaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.organizarNaVerticalToolStripMenuItem,
            this.organizarJanelasToolStripMenuItem,
            this.organizarEmCascataToolStripMenuItem,
            this.toolStripSeparator3,
            this.minimizarTodasJanelasToolStripMenuItem,
            this.maximizarTodasJanelasToolStripMenuItem,
            this.toolStripSeparator4});
            this.janelaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            this.janelaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.janelaToolStripMenuItem.Text = "Janela";
            this.janelaToolStripMenuItem.MouseLeave += new System.EventHandler(this.janelaToolStripMenuItem_MouseLeave);
            this.janelaToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.janelaToolStripMenuItem_MouseMove);
            // 
            // organizarNaVerticalToolStripMenuItem
            // 
            this.organizarNaVerticalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.organizarNaVerticalToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.organizarNaVerticalToolStripMenuItem.Name = "organizarNaVerticalToolStripMenuItem";
            this.organizarNaVerticalToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.organizarNaVerticalToolStripMenuItem.Text = "Organizar na Vertical";
            this.organizarNaVerticalToolStripMenuItem.Click += new System.EventHandler(this.organizarNaVerticalToolStripMenuItem_Click);
            // 
            // organizarJanelasToolStripMenuItem
            // 
            this.organizarJanelasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.organizarJanelasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.organizarJanelasToolStripMenuItem.Name = "organizarJanelasToolStripMenuItem";
            this.organizarJanelasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.organizarJanelasToolStripMenuItem.Text = "Organizar na Horizontal";
            this.organizarJanelasToolStripMenuItem.Click += new System.EventHandler(this.organizarJanelasToolStripMenuItem_Click);
            // 
            // organizarEmCascataToolStripMenuItem
            // 
            this.organizarEmCascataToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.organizarEmCascataToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.organizarEmCascataToolStripMenuItem.Name = "organizarEmCascataToolStripMenuItem";
            this.organizarEmCascataToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.organizarEmCascataToolStripMenuItem.Text = "Organizar em Cascata";
            this.organizarEmCascataToolStripMenuItem.Click += new System.EventHandler(this.organizarEmCascataToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(196, 6);
            // 
            // minimizarTodasJanelasToolStripMenuItem
            // 
            this.minimizarTodasJanelasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.minimizarTodasJanelasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.minimizarTodasJanelasToolStripMenuItem.Name = "minimizarTodasJanelasToolStripMenuItem";
            this.minimizarTodasJanelasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.minimizarTodasJanelasToolStripMenuItem.Text = "Minimizar";
            this.minimizarTodasJanelasToolStripMenuItem.Click += new System.EventHandler(this.minimizarTodasJanelasToolStripMenuItem_Click);
            // 
            // maximizarTodasJanelasToolStripMenuItem
            // 
            this.maximizarTodasJanelasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.maximizarTodasJanelasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.maximizarTodasJanelasToolStripMenuItem.Name = "maximizarTodasJanelasToolStripMenuItem";
            this.maximizarTodasJanelasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.maximizarTodasJanelasToolStripMenuItem.Text = "Maximizar";
            this.maximizarTodasJanelasToolStripMenuItem.Click += new System.EventHandler(this.maximizarTodasJanelasToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(196, 6);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem1,
            this.sobreOSistemaToolStripMenuItem});
            this.ajudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.MouseLeave += new System.EventHandler(this.ajudaToolStripMenuItem_MouseLeave);
            this.ajudaToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ajudaToolStripMenuItem_MouseMove);
            // 
            // ajudaToolStripMenuItem1
            // 
            this.ajudaToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.ajudaToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.ajudaToolStripMenuItem1.Name = "ajudaToolStripMenuItem1";
            this.ajudaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.ajudaToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.ajudaToolStripMenuItem1.Text = "Ajuda";
            this.ajudaToolStripMenuItem1.Click += new System.EventHandler(this.ajudaToolStripMenuItem1_Click);
            // 
            // sobreOSistemaToolStripMenuItem
            // 
            this.sobreOSistemaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.sobreOSistemaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sobreOSistemaToolStripMenuItem.Name = "sobreOSistemaToolStripMenuItem";
            this.sobreOSistemaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F10)));
            this.sobreOSistemaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.sobreOSistemaToolStripMenuItem.Text = "Sobre";
            this.sobreOSistemaToolStripMenuItem.Click += new System.EventHandler(this.sobreOSistemaToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnCadCli,
            this.tsBtnBuscarCli,
            this.toolStripButton3,
            this.tsBtnBuscarAlu,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 35);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnCadCli
            // 
            this.tsBtnCadCli.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCadCli.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCadCli.Image")));
            this.tsBtnCadCli.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCadCli.Name = "tsBtnCadCli";
            this.tsBtnCadCli.Size = new System.Drawing.Size(23, 32);
            this.tsBtnCadCli.Text = "Cadastrar Cliente";
            this.tsBtnCadCli.ToolTipText = "Cadastrar Cliente - Atalho";
            this.tsBtnCadCli.Click += new System.EventHandler(this.tsBtnCadCli_Click);
            // 
            // tsBtnBuscarCli
            // 
            this.tsBtnBuscarCli.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnBuscarCli.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBuscarCli.Image")));
            this.tsBtnBuscarCli.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBuscarCli.Name = "tsBtnBuscarCli";
            this.tsBtnBuscarCli.Size = new System.Drawing.Size(23, 32);
            this.tsBtnBuscarCli.Text = "Buscar Cliente";
            this.tsBtnBuscarCli.ToolTipText = "Buscar Cliente - Atalho";
            this.tsBtnBuscarCli.Click += new System.EventHandler(this.tsBtnBuscarCli_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 32);
            this.toolStripButton3.Text = "Cadastrar Aluno";
            this.toolStripButton3.ToolTipText = "Cadastrar Aluno - Atalho";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tsBtnBuscarAlu
            // 
            this.tsBtnBuscarAlu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnBuscarAlu.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBuscarAlu.Image")));
            this.tsBtnBuscarAlu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBuscarAlu.Name = "tsBtnBuscarAlu";
            this.tsBtnBuscarAlu.Size = new System.Drawing.Size(23, 32);
            this.tsBtnBuscarAlu.Text = "Buscar Aluno";
            this.tsBtnBuscarAlu.ToolTipText = "Buscar Aluno - Atalho";
            this.tsBtnBuscarAlu.Click += new System.EventHandler(this.tsBtnBuscarAlu_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 32);
            this.toolStripButton2.Text = "Cadastrar Usuário";
            this.toolStripButton2.ToolTipText = "Cadastrar Usuário - Atalho";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(782, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(764, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // bemvindo
            // 
            this.bemvindo.AutoSize = true;
            this.bemvindo.BackColor = System.Drawing.Color.Transparent;
            this.bemvindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bemvindo.ForeColor = System.Drawing.Color.White;
            this.bemvindo.Location = new System.Drawing.Point(86, 232);
            this.bemvindo.Name = "bemvindo";
            this.bemvindo.Size = new System.Drawing.Size(0, 42);
            this.bemvindo.TabIndex = 9;
            this.bemvindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bemvindo.Click += new System.EventHandler(this.bemvindo_Click);
            // 
            // BemVindoTimer
            // 
            this.BemVindoTimer.Enabled = true;
            this.BemVindoTimer.Interval = 15;
            this.BemVindoTimer.Tick += new System.EventHandler(this.BemVindoTimer_Tick);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.bemvindo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Atendimento";
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarJanelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarNaVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarEmCascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreOSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnCadCli;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem minimizarTodasJanelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizarTodasJanelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem agendarAtendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarAtendimentosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripButton tsBtnBuscarCli;
        private System.Windows.Forms.ToolStripButton tsBtnBuscarAlu;
        private System.Windows.Forms.Label bemvindo;
        private System.Windows.Forms.Timer BemVindoTimer;
    }
}

