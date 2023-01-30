using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_66
{
    public partial class Tela_TabControl : Form
    {
        int erro;

        public Tela_TabControl()
        {
            InitializeComponent();
            Set();

        }
        private void Set()
        {
            int v;
            numericUpDown1.Maximum = (tabControl1.TabCount);
            if(tabControl1.TabCount != 0 ) { v = 1; }
            else { v = 0; }
            numericUpDown1.Minimum = v;
        }
        private string Retorna()
        {
            string value = textBox1.Text;
            if (value != "")
            {
                erro = 0;
                return value;
            }
            else
            {
                erro = 1;
                MessageBox.Show("Erro caixa de texto está vazia");
                textBox1.Focus();
                value = "erro_Indice";
                return value;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string var = Retorna();
            if (erro != 1)
            {
                TabPage p = new TabPage();
                p.Text = var;
                p.Name = var;
                p.TabIndex = tabControl1.TabPages.Count;
                tabControl1.TabPages.Add(p);
                textBox1.Clear();
            }

            Set();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            Set();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Set();
            int v = ((int)numericUpDown1.Value);
            tabControl1.SelectedIndex = (v-1);
        }
    }
}
