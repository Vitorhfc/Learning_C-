namespace Aula_83_Editor_De_Texto
{
    partial class EditorTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorTexto));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itálicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justificadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhadoADireitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhadoAEsquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralizadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewFile = new System.Windows.Forms.ToolStripButton();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.Open = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Txt_Sublinhado = new System.Windows.Forms.ToolStripButton();
            this.Txt_Bold = new System.Windows.Forms.ToolStripButton();
            this.italico = new System.Windows.Forms.ToolStripButton();
            this.Text_Normal = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Txt_Copiar = new System.Windows.Forms.ToolStripButton();
            this.Txt_Colar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Txt_Centralizar = new System.Windows.Forms.ToolStripButton();
            this.txt_Justicar = new System.Windows.Forms.ToolStripButton();
            this.Txt_Align_Right = new System.Windows.Forms.ToolStripButton();
            this.Txt_Align_Left = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bt_Aumenta_letra = new System.Windows.Forms.ToolStripButton();
            this.Txt_Diminuir_Letra = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(166, 84);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(506, 553);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem,
            this.alinhamentoToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextoToolStripMenuItem
            // 
            this.contextoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.imprimirToolStripMenuItem1});
            this.contextoToolStripMenuItem.Name = "contextoToolStripMenuItem";
            this.contextoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.contextoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.recortarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.desfazerToolStripMenuItem,
            this.refazerToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refazerToolStripMenuItem.Text = "Refazer";
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritoToolStripMenuItem,
            this.itálicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.formatarToolStripMenuItem.Text = "Formtação do texto";
            // 
            // negritoToolStripMenuItem
            // 
            this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            this.negritoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.negritoToolStripMenuItem.Text = "Negrito";
            this.negritoToolStripMenuItem.Click += new System.EventHandler(this.negritoToolStripMenuItem_Click);
            // 
            // itálicoToolStripMenuItem
            // 
            this.itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            this.itálicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itálicoToolStripMenuItem.Text = "Itálico";
            this.itálicoToolStripMenuItem.Click += new System.EventHandler(this.itálicoToolStripMenuItem_Click);
            // 
            // sublinhadoToolStripMenuItem
            // 
            this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sublinhadoToolStripMenuItem.Text = "Sublinhado";
            this.sublinhadoToolStripMenuItem.Click += new System.EventHandler(this.sublinhadoToolStripMenuItem_Click);
            // 
            // alinhamentoToolStripMenuItem
            // 
            this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.justificadoToolStripMenuItem,
            this.alinhadoADireitaToolStripMenuItem,
            this.alinhadoAEsquerdaToolStripMenuItem,
            this.centralizadoToolStripMenuItem});
            this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // justificadoToolStripMenuItem
            // 
            this.justificadoToolStripMenuItem.Name = "justificadoToolStripMenuItem";
            this.justificadoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.justificadoToolStripMenuItem.Text = "Justificado";
            // 
            // alinhadoADireitaToolStripMenuItem
            // 
            this.alinhadoADireitaToolStripMenuItem.Name = "alinhadoADireitaToolStripMenuItem";
            this.alinhadoADireitaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.alinhadoADireitaToolStripMenuItem.Text = "Alinhado a direita";
            this.alinhadoADireitaToolStripMenuItem.Click += new System.EventHandler(this.alinhadoADireitaToolStripMenuItem_Click);
            // 
            // alinhadoAEsquerdaToolStripMenuItem
            // 
            this.alinhadoAEsquerdaToolStripMenuItem.Name = "alinhadoAEsquerdaToolStripMenuItem";
            this.alinhadoAEsquerdaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.alinhadoAEsquerdaToolStripMenuItem.Text = "Alinhado a esquerda";
            this.alinhadoAEsquerdaToolStripMenuItem.Click += new System.EventHandler(this.alinhadoAEsquerdaToolStripMenuItem_Click);
            // 
            // centralizadoToolStripMenuItem
            // 
            this.centralizadoToolStripMenuItem.Name = "centralizadoToolStripMenuItem";
            this.centralizadoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.centralizadoToolStripMenuItem.Text = "Centralizado";
            this.centralizadoToolStripMenuItem.Click += new System.EventHandler(this.centralizadoToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFile,
            this.Save,
            this.Open,
            this.toolStripSeparator3,
            this.Txt_Sublinhado,
            this.Txt_Bold,
            this.italico,
            this.Text_Normal,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.Txt_Copiar,
            this.Txt_Colar,
            this.toolStripSeparator1,
            this.Txt_Centralizar,
            this.txt_Justicar,
            this.Txt_Align_Right,
            this.Txt_Align_Left,
            this.toolStripSeparator4,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripSeparator5,
            this.bt_Aumenta_letra,
            this.Txt_Diminuir_Letra,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(855, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewFile
            // 
            this.NewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewFile.Image = ((System.Drawing.Image)(resources.GetObject("NewFile.Image")));
            this.NewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewFile.Name = "NewFile";
            this.NewFile.Size = new System.Drawing.Size(23, 22);
            this.NewFile.Text = "NewFile";
            this.NewFile.Click += new System.EventHandler(this.toolStripButton15_Click);
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(23, 22);
            this.Save.Text = "Salvar";
            this.Save.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // Open
            // 
            this.Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Open.Image = ((System.Drawing.Image)(resources.GetObject("Open.Image")));
            this.Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(23, 22);
            this.Open.Text = "OpenFile";
            this.Open.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Txt_Sublinhado
            // 
            this.Txt_Sublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Txt_Sublinhado.Image = ((System.Drawing.Image)(resources.GetObject("Txt_Sublinhado.Image")));
            this.Txt_Sublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Txt_Sublinhado.Name = "Txt_Sublinhado";
            this.Txt_Sublinhado.Size = new System.Drawing.Size(23, 22);
            this.Txt_Sublinhado.Text = "Sublinhar";
            this.Txt_Sublinhado.Click += new System.EventHandler(this.Txt_Sublinhado_Click);
            // 
            // Txt_Bold
            // 
            this.Txt_Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Txt_Bold.Image = ((System.Drawing.Image)(resources.GetObject("Txt_Bold.Image")));
            this.Txt_Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Txt_Bold.Name = "Txt_Bold";
            this.Txt_Bold.Size = new System.Drawing.Size(23, 22);
            this.Txt_Bold.Text = "Negrito";
            this.Txt_Bold.Click += new System.EventHandler(this.Txt_Bold_Click);
            // 
            // italico
            // 
            this.italico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italico.Image = ((System.Drawing.Image)(resources.GetObject("italico.Image")));
            this.italico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italico.Name = "italico";
            this.italico.Size = new System.Drawing.Size(23, 22);
            this.italico.Text = "Itálico";
            this.italico.Click += new System.EventHandler(this.italico_Click);
            // 
            // Text_Normal
            // 
            this.Text_Normal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Text_Normal.Image = ((System.Drawing.Image)(resources.GetObject("Text_Normal.Image")));
            this.Text_Normal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Text_Normal.Name = "Text_Normal";
            this.Text_Normal.Size = new System.Drawing.Size(23, 22);
            this.Text_Normal.Text = "Normal";
            this.Text_Normal.Click += new System.EventHandler(this.Text_Normal_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Txt_Copiar
            // 
            this.Txt_Copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Txt_Copiar.Image = ((System.Drawing.Image)(resources.GetObject("Txt_Copiar.Image")));
            this.Txt_Copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Txt_Copiar.Name = "Txt_Copiar";
            this.Txt_Copiar.Size = new System.Drawing.Size(23, 22);
            this.Txt_Copiar.Text = "Copiar";
            this.Txt_Copiar.Click += new System.EventHandler(this.toolStripButton12_Click);
            // 
            // Txt_Colar
            // 
            this.Txt_Colar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Txt_Colar.Image = ((System.Drawing.Image)(resources.GetObject("Txt_Colar.Image")));
            this.Txt_Colar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Txt_Colar.Name = "Txt_Colar";
            this.Txt_Colar.Size = new System.Drawing.Size(23, 22);
            this.Txt_Colar.Text = "Colar";
            this.Txt_Colar.Click += new System.EventHandler(this.Txt_Colar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Txt_Centralizar
            // 
            this.Txt_Centralizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Txt_Centralizar.Image = ((System.Drawing.Image)(resources.GetObject("Txt_Centralizar.Image")));
            this.Txt_Centralizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Txt_Centralizar.Name = "Txt_Centralizar";
            this.Txt_Centralizar.Size = new System.Drawing.Size(23, 22);
            this.Txt_Centralizar.Text = "Centralizar";
            this.Txt_Centralizar.Click += new System.EventHandler(this.Txt_Centralizar_Click);
            // 
            // txt_Justicar
            // 
            this.txt_Justicar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.txt_Justicar.Image = ((System.Drawing.Image)(resources.GetObject("txt_Justicar.Image")));
            this.txt_Justicar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txt_Justicar.Name = "txt_Justicar";
            this.txt_Justicar.Size = new System.Drawing.Size(23, 22);
            this.txt_Justicar.Text = "Justificar";
            // 
            // Txt_Align_Right
            // 
            this.Txt_Align_Right.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Txt_Align_Right.Image = ((System.Drawing.Image)(resources.GetObject("Txt_Align_Right.Image")));
            this.Txt_Align_Right.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Txt_Align_Right.Name = "Txt_Align_Right";
            this.Txt_Align_Right.Size = new System.Drawing.Size(23, 22);
            this.Txt_Align_Right.Text = "Alinhar Direita";
            this.Txt_Align_Right.Click += new System.EventHandler(this.Txt_Align_Right_Click);
            // 
            // Txt_Align_Left
            // 
            this.Txt_Align_Left.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Txt_Align_Left.Image = ((System.Drawing.Image)(resources.GetObject("Txt_Align_Left.Image")));
            this.Txt_Align_Left.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Txt_Align_Left.Name = "Txt_Align_Left";
            this.Txt_Align_Left.Size = new System.Drawing.Size(23, 22);
            this.Txt_Align_Left.Text = "Alinhar esquerda";
            this.Txt_Align_Left.Click += new System.EventHandler(this.Txt_Align_Left_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel1.Text = "Fonte:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox1.ToolTipText = "Fonte do texto";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // bt_Aumenta_letra
            // 
            this.bt_Aumenta_letra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Aumenta_letra.Image = ((System.Drawing.Image)(resources.GetObject("bt_Aumenta_letra.Image")));
            this.bt_Aumenta_letra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_Aumenta_letra.Name = "bt_Aumenta_letra";
            this.bt_Aumenta_letra.Size = new System.Drawing.Size(23, 22);
            this.bt_Aumenta_letra.Tag = "Aumentar Letra";
            this.bt_Aumenta_letra.Text = "Aumentar Letra";
            // 
            // Txt_Diminuir_Letra
            // 
            this.Txt_Diminuir_Letra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Txt_Diminuir_Letra.Image = ((System.Drawing.Image)(resources.GetObject("Txt_Diminuir_Letra.Image")));
            this.Txt_Diminuir_Letra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Txt_Diminuir_Letra.Name = "Txt_Diminuir_Letra";
            this.Txt_Diminuir_Letra.Size = new System.Drawing.Size(23, 22);
            this.Txt_Diminuir_Letra.Text = "Diminuir Letra";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(90, 22);
            this.toolStripLabel2.Text = "Tamanho fonte:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(618, 27);
            this.maskedTextBox1.Mask = "00000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "Docx,txt";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Recortar texto";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recortarToolStripMenuItem.Text = "Recortar";
            this.recortarToolStripMenuItem.Click += new System.EventHandler(this.recortarToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem1
            // 
            this.imprimirToolStripMenuItem1.Name = "imprimirToolStripMenuItem1";
            this.imprimirToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.imprimirToolStripMenuItem1.Text = "Imprimir";
            this.imprimirToolStripMenuItem1.Click += new System.EventHandler(this.imprimirToolStripMenuItem1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // EditorTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(172)))), ((int)(((byte)(196)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(855, 644);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditorTexto";
            this.Text = "Text_Elemento";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itálicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sublinhadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem justificadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhadoADireitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhadoAEsquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centralizadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton Txt_Centralizar;
        private System.Windows.Forms.ToolStripButton Txt_Sublinhado;
        private System.Windows.Forms.ToolStripButton Txt_Bold;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.ToolStripButton Open;
        private System.Windows.Forms.ToolStripButton Txt_Copiar;
        private System.Windows.Forms.ToolStripButton italico;
        private System.Windows.Forms.ToolStripButton Text_Normal;
        private System.Windows.Forms.ToolStripButton Txt_Colar;
        private System.Windows.Forms.ToolStripButton txt_Justicar;
        private System.Windows.Forms.ToolStripButton Txt_Align_Right;
        private System.Windows.Forms.ToolStripButton Txt_Align_Left;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton bt_Aumenta_letra;
        private System.Windows.Forms.ToolStripButton Txt_Diminuir_Letra;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton NewFile;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

