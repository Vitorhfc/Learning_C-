namespace Aula_61
{
    partial class Conteudo_Text_Box
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conteudo_Text_Box));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_tela_texto = new System.Windows.Forms.Button();
            this.Bt_limpa = new System.Windows.Forms.Button();
            this.Tb_Exibe = new System.Windows.Forms.TextBox();
            this.Bt_adiciona = new System.Windows.Forms.Button();
            this.Tb_Entrada = new System.Windows.Forms.TextBox();
            this.Lb_titulo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(240, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "TextBox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trabalhando com elementos do windows forms";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(262, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.bt_tela_texto);
            this.groupBox2.Controls.Add(this.Bt_limpa);
            this.groupBox2.Controls.Add(this.Tb_Exibe);
            this.groupBox2.Controls.Add(this.Bt_adiciona);
            this.groupBox2.Controls.Add(this.Tb_Entrada);
            this.groupBox2.Controls.Add(this.Lb_titulo);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(64, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 391);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trabalhando com text Box:";
            this.groupBox2.Visible = false;
            // 
            // bt_tela_texto
            // 
            this.bt_tela_texto.Location = new System.Drawing.Point(22, 358);
            this.bt_tela_texto.Name = "bt_tela_texto";
            this.bt_tela_texto.Size = new System.Drawing.Size(214, 23);
            this.bt_tela_texto.TabIndex = 5;
            this.bt_tela_texto.Text = "Visualizar apenas texto";
            this.bt_tela_texto.UseVisualStyleBackColor = true;
            this.bt_tela_texto.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bt_limpa
            // 
            this.Bt_limpa.Location = new System.Drawing.Point(22, 329);
            this.Bt_limpa.Name = "Bt_limpa";
            this.Bt_limpa.Size = new System.Drawing.Size(214, 23);
            this.Bt_limpa.TabIndex = 4;
            this.Bt_limpa.Text = "Clean";
            this.Bt_limpa.UseVisualStyleBackColor = true;
            this.Bt_limpa.Click += new System.EventHandler(this.Bt_limpa_Click);
            // 
            // Tb_Exibe
            // 
            this.Tb_Exibe.Location = new System.Drawing.Point(22, 86);
            this.Tb_Exibe.Multiline = true;
            this.Tb_Exibe.Name = "Tb_Exibe";
            this.Tb_Exibe.ReadOnly = true;
            this.Tb_Exibe.Size = new System.Drawing.Size(214, 237);
            this.Tb_Exibe.TabIndex = 3;
            this.Tb_Exibe.TextChanged += new System.EventHandler(this.Tb_Exibe_TextChanged);
            // 
            // Bt_adiciona
            // 
            this.Bt_adiciona.Location = new System.Drawing.Point(161, 57);
            this.Bt_adiciona.Name = "Bt_adiciona";
            this.Bt_adiciona.Size = new System.Drawing.Size(75, 23);
            this.Bt_adiciona.TabIndex = 2;
            this.Bt_adiciona.Text = "Adicionar";
            this.Bt_adiciona.UseVisualStyleBackColor = true;
            this.Bt_adiciona.Click += new System.EventHandler(this.Bt_adiciona_Click);
            // 
            // Tb_Entrada
            // 
            this.Tb_Entrada.Location = new System.Drawing.Point(22, 57);
            this.Tb_Entrada.Name = "Tb_Entrada";
            this.Tb_Entrada.Size = new System.Drawing.Size(133, 20);
            this.Tb_Entrada.TabIndex = 1;
            // 
            // Lb_titulo
            // 
            this.Lb_titulo.AutoSize = true;
            this.Lb_titulo.Location = new System.Drawing.Point(19, 41);
            this.Lb_titulo.Name = "Lb_titulo";
            this.Lb_titulo.Size = new System.Drawing.Size(86, 13);
            this.Lb_titulo.TabIndex = 0;
            this.Lb_titulo.Text = "Informe uma cor:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(713, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Valor variavel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Conteudo_Text_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Conteudo_Text_Box";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Bt_adiciona;
        private System.Windows.Forms.TextBox Tb_Entrada;
        private System.Windows.Forms.Label Lb_titulo;
        private System.Windows.Forms.Button Bt_limpa;
        private System.Windows.Forms.Button bt_tela_texto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox Tb_Exibe;
    }
}

