namespace Aula_66
{
    partial class Tela_DateTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_DateTimer));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Tb_DataCompleta = new System.Windows.Forms.TextBox();
            this.Tb_Mes = new System.Windows.Forms.TextBox();
            this.Tb_Ano = new System.Windows.Forms.TextBox();
            this.Tb_Dia = new System.Windows.Forms.TextBox();
            this.Tb_Entrada_Dia = new System.Windows.Forms.TextBox();
            this.Tb_Entrada_Ano = new System.Windows.Forms.TextBox();
            this.Tb_Entrada_Mes = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(479, 26);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(692, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Data Timer Picker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Decompor data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tb_DataCompleta
            // 
            this.Tb_DataCompleta.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Tb_DataCompleta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_DataCompleta.Location = new System.Drawing.Point(26, 91);
            this.Tb_DataCompleta.Name = "Tb_DataCompleta";
            this.Tb_DataCompleta.ReadOnly = true;
            this.Tb_DataCompleta.Size = new System.Drawing.Size(479, 30);
            this.Tb_DataCompleta.TabIndex = 3;
            this.Tb_DataCompleta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tb_Mes
            // 
            this.Tb_Mes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Tb_Mes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Mes.Location = new System.Drawing.Point(189, 123);
            this.Tb_Mes.Name = "Tb_Mes";
            this.Tb_Mes.ReadOnly = true;
            this.Tb_Mes.Size = new System.Drawing.Size(157, 30);
            this.Tb_Mes.TabIndex = 4;
            this.Tb_Mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tb_Mes.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Tb_Ano
            // 
            this.Tb_Ano.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Tb_Ano.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Ano.Location = new System.Drawing.Point(352, 123);
            this.Tb_Ano.Name = "Tb_Ano";
            this.Tb_Ano.ReadOnly = true;
            this.Tb_Ano.Size = new System.Drawing.Size(153, 30);
            this.Tb_Ano.TabIndex = 5;
            this.Tb_Ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tb_Dia
            // 
            this.Tb_Dia.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Tb_Dia.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Dia.Location = new System.Drawing.Point(26, 123);
            this.Tb_Dia.Name = "Tb_Dia";
            this.Tb_Dia.ReadOnly = true;
            this.Tb_Dia.Size = new System.Drawing.Size(157, 30);
            this.Tb_Dia.TabIndex = 6;
            this.Tb_Dia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tb_Entrada_Dia
            // 
            this.Tb_Entrada_Dia.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Tb_Entrada_Dia.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Entrada_Dia.Location = new System.Drawing.Point(26, 255);
            this.Tb_Entrada_Dia.Name = "Tb_Entrada_Dia";
            this.Tb_Entrada_Dia.Size = new System.Drawing.Size(157, 30);
            this.Tb_Entrada_Dia.TabIndex = 9;
            this.Tb_Entrada_Dia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tb_Entrada_Ano
            // 
            this.Tb_Entrada_Ano.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Tb_Entrada_Ano.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Entrada_Ano.Location = new System.Drawing.Point(352, 255);
            this.Tb_Entrada_Ano.Name = "Tb_Entrada_Ano";
            this.Tb_Entrada_Ano.Size = new System.Drawing.Size(153, 30);
            this.Tb_Entrada_Ano.TabIndex = 8;
            this.Tb_Entrada_Ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tb_Entrada_Mes
            // 
            this.Tb_Entrada_Mes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Tb_Entrada_Mes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Entrada_Mes.Location = new System.Drawing.Point(189, 255);
            this.Tb_Entrada_Mes.Name = "Tb_Entrada_Mes";
            this.Tb_Entrada_Mes.Size = new System.Drawing.Size(157, 30);
            this.Tb_Entrada_Mes.TabIndex = 7;
            this.Tb_Entrada_Mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 26);
            this.button3.TabIndex = 11;
            this.button3.Text = "Setar nova data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 26);
            this.button2.TabIndex = 12;
            this.button2.Text = "Data atual";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tela_DateTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aula_66.Properties.Resources.white_marble_4_2018;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(716, 304);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Tb_Entrada_Dia);
            this.Controls.Add(this.Tb_Entrada_Ano);
            this.Controls.Add(this.Tb_Entrada_Mes);
            this.Controls.Add(this.Tb_Dia);
            this.Controls.Add(this.Tb_Ano);
            this.Controls.Add(this.Tb_Mes);
            this.Controls.Add(this.Tb_DataCompleta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tela_DateTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateTimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Tb_DataCompleta;
        private System.Windows.Forms.TextBox Tb_Mes;
        private System.Windows.Forms.TextBox Tb_Ano;
        private System.Windows.Forms.TextBox Tb_Dia;
        private System.Windows.Forms.TextBox Tb_Entrada_Dia;
        private System.Windows.Forms.TextBox Tb_Entrada_Ano;
        private System.Windows.Forms.TextBox Tb_Entrada_Mes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}