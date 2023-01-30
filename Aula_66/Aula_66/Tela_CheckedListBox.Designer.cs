namespace Aula_66
{
    partial class Tela_CheckedListBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_CheckedListBox));
            this.label1 = new System.Windows.Forms.Label();
            this.Clb_Cores = new System.Windows.Forms.CheckedListBox();
            this.Bt_Mostra = new System.Windows.Forms.Button();
            this.Bt_clear = new System.Windows.Forms.Button();
            this.Bt_Reset = new System.Windows.Forms.Button();
            this.Bt_Adiconar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Checked List Box";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clb_Cores
            // 
            this.Clb_Cores.FormattingEnabled = true;
            this.Clb_Cores.Items.AddRange(new object[] {
            "Preto",
            "Roxo",
            "Branco",
            "Cinza",
            "Vermelho",
            "Azul",
            "Rosa"});
            this.Clb_Cores.Location = new System.Drawing.Point(12, 91);
            this.Clb_Cores.Name = "Clb_Cores";
            this.Clb_Cores.Size = new System.Drawing.Size(206, 298);
            this.Clb_Cores.TabIndex = 1;
            // 
            // Bt_Mostra
            // 
            this.Bt_Mostra.AutoEllipsis = true;
            this.Bt_Mostra.Location = new System.Drawing.Point(242, 349);
            this.Bt_Mostra.Name = "Bt_Mostra";
            this.Bt_Mostra.Size = new System.Drawing.Size(223, 40);
            this.Bt_Mostra.TabIndex = 2;
            this.Bt_Mostra.Text = "Mostrar Selecionados";
            this.Bt_Mostra.UseVisualStyleBackColor = true;
            this.Bt_Mostra.Click += new System.EventHandler(this.Bt_Mostra_Click);
            // 
            // Bt_clear
            // 
            this.Bt_clear.AutoEllipsis = true;
            this.Bt_clear.Location = new System.Drawing.Point(242, 309);
            this.Bt_clear.Name = "Bt_clear";
            this.Bt_clear.Size = new System.Drawing.Size(223, 40);
            this.Bt_clear.TabIndex = 3;
            this.Bt_clear.Text = "Limpar Lista";
            this.Bt_clear.UseVisualStyleBackColor = true;
            this.Bt_clear.Click += new System.EventHandler(this.Bt_clear_Click);
            // 
            // Bt_Reset
            // 
            this.Bt_Reset.AutoEllipsis = true;
            this.Bt_Reset.Location = new System.Drawing.Point(242, 269);
            this.Bt_Reset.Name = "Bt_Reset";
            this.Bt_Reset.Size = new System.Drawing.Size(223, 40);
            this.Bt_Reset.TabIndex = 4;
            this.Bt_Reset.Text = "Resetar Lista";
            this.Bt_Reset.UseVisualStyleBackColor = true;
            this.Bt_Reset.Click += new System.EventHandler(this.Bt_Reset_Click);
            // 
            // Bt_Adiconar
            // 
            this.Bt_Adiconar.AutoEllipsis = true;
            this.Bt_Adiconar.Location = new System.Drawing.Point(242, 229);
            this.Bt_Adiconar.Name = "Bt_Adiconar";
            this.Bt_Adiconar.Size = new System.Drawing.Size(223, 40);
            this.Bt_Adiconar.TabIndex = 5;
            this.Bt_Adiconar.Text = "Adicionar Elemento";
            this.Bt_Adiconar.UseVisualStyleBackColor = true;
            this.Bt_Adiconar.Click += new System.EventHandler(this.Bt_Adiconar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Insert elements";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 73);
            this.label3.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(258, 142);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(207, 22);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Add item Checkado?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aula_66.Properties.Resources.white_marble_4_2018;
            this.ClientSize = new System.Drawing.Size(477, 502);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Bt_Adiconar);
            this.Controls.Add(this.Bt_Reset);
            this.Controls.Add(this.Bt_clear);
            this.Controls.Add(this.Bt_Mostra);
            this.Controls.Add(this.Clb_Cores);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckedListBox";
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox Clb_Cores;
        private System.Windows.Forms.Button Bt_Mostra;
        private System.Windows.Forms.Button Bt_clear;
        private System.Windows.Forms.Button Bt_Reset;
        private System.Windows.Forms.Button Bt_Adiconar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}