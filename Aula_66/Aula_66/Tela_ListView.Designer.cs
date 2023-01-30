namespace Aula_66
{
    partial class Tela_ListView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Teclado",
            "10",
            "125,95"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Mouse",
            "8",
            "150,25"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor",
            "3",
            "2500,00"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_ListView));
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_1 = new System.Windows.Forms.TextBox();
            this.Tb_2 = new System.Windows.Forms.TextBox();
            this.Tb_3 = new System.Windows.Forms.TextBox();
            this.Tb_4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Coluna_Id_Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coluna_Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coluna_Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coluna_Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "&List_Box";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tb_1
            // 
            this.Tb_1.Location = new System.Drawing.Point(23, 517);
            this.Tb_1.Name = "Tb_1";
            this.Tb_1.Size = new System.Drawing.Size(88, 26);
            this.Tb_1.TabIndex = 5;
            // 
            // Tb_2
            // 
            this.Tb_2.Location = new System.Drawing.Point(117, 517);
            this.Tb_2.Name = "Tb_2";
            this.Tb_2.Size = new System.Drawing.Size(245, 26);
            this.Tb_2.TabIndex = 6;
            // 
            // Tb_3
            // 
            this.Tb_3.Location = new System.Drawing.Point(368, 517);
            this.Tb_3.Name = "Tb_3";
            this.Tb_3.Size = new System.Drawing.Size(95, 26);
            this.Tb_3.TabIndex = 7;
            // 
            // Tb_4
            // 
            this.Tb_4.Location = new System.Drawing.Point(469, 517);
            this.Tb_4.Name = "Tb_4";
            this.Tb_4.Size = new System.Drawing.Size(98, 26);
            this.Tb_4.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 8F);
            this.label2.Location = new System.Drawing.Point(26, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID_Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 8F);
            this.label3.Location = new System.Drawing.Point(120, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 8F);
            this.label4.Location = new System.Drawing.Point(371, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 8F);
            this.label5.Location = new System.Drawing.Point(472, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "Valor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(387, 565);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 33);
            this.button3.TabIndex = 15;
            this.button3.Text = "Remover";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Coluna_Id_Produto,
            this.Coluna_Produto,
            this.Coluna_Quantidade,
            this.Coluna_Valor});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(23, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(564, 395);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // Coluna_Id_Produto
            // 
            this.Coluna_Id_Produto.Text = "ID_Produto";
            this.Coluna_Id_Produto.Width = 120;
            // 
            // Coluna_Produto
            // 
            this.Coluna_Produto.Text = "Produto";
            this.Coluna_Produto.Width = 190;
            // 
            // Coluna_Quantidade
            // 
            this.Coluna_Quantidade.Text = "Quantidade";
            this.Coluna_Quantidade.Width = 120;
            // 
            // Coluna_Valor
            // 
            this.Coluna_Valor.Text = "Valor";
            this.Coluna_Valor.Width = 120;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 33);
            this.button2.TabIndex = 18;
            this.button2.Text = "Obter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Tela_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aula_66.Properties.Resources.white_marble_4_2018;
            this.ClientSize = new System.Drawing.Size(607, 623);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_4);
            this.Controls.Add(this.Tb_3);
            this.Controls.Add(this.Tb_2);
            this.Controls.Add(this.Tb_1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tela_ListView";
            this.Text = "ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_1;
        private System.Windows.Forms.TextBox Tb_2;
        private System.Windows.Forms.TextBox Tb_3;
        private System.Windows.Forms.TextBox Tb_4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Coluna_Id_Produto;
        private System.Windows.Forms.ColumnHeader Coluna_Produto;
        private System.Windows.Forms.ColumnHeader Coluna_Quantidade;
        private System.Windows.Forms.ColumnHeader Coluna_Valor;
        private System.Windows.Forms.Button button2;
    }
}