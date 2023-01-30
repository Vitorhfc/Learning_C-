namespace Aula_61
{
    partial class Visualizador_Lista
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
            this.Bt_Voltar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_exibi = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_aumenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bt_Voltar
            // 
            this.Bt_Voltar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bt_Voltar.Location = new System.Drawing.Point(0, 468);
            this.Bt_Voltar.Name = "Bt_Voltar";
            this.Bt_Voltar.Size = new System.Drawing.Size(237, 23);
            this.Bt_Voltar.TabIndex = 0;
            this.Bt_Voltar.Text = "Voltar tela";
            this.Bt_Voltar.UseVisualStyleBackColor = true;
            this.Bt_Voltar.Click += new System.EventHandler(this.Bt_Voltar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(212, 363);
            this.textBox1.TabIndex = 1;
            // 
            // bt_exibi
            // 
            this.bt_exibi.Location = new System.Drawing.Point(12, 437);
            this.bt_exibi.Name = "bt_exibi";
            this.bt_exibi.Size = new System.Drawing.Size(107, 25);
            this.bt_exibi.TabIndex = 2;
            this.bt_exibi.Text = "Mostra var";
            this.bt_exibi.UseVisualStyleBackColor = true;
            this.bt_exibi.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 411);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(212, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Conteudo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_aumenta
            // 
            this.bt_aumenta.Location = new System.Drawing.Point(117, 437);
            this.bt_aumenta.Name = "bt_aumenta";
            this.bt_aumenta.Size = new System.Drawing.Size(107, 25);
            this.bt_aumenta.TabIndex = 5;
            this.bt_aumenta.Text = "Aumenta";
            this.bt_aumenta.UseVisualStyleBackColor = true;
            this.bt_aumenta.Click += new System.EventHandler(this.bt_aumenta_Click);
            // 
            // Visualizador_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(237, 491);
            this.Controls.Add(this.bt_aumenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.bt_exibi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Bt_Voltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Visualizador_Lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Voltar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_exibi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_aumenta;
    }
}