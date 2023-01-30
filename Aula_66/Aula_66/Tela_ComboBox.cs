using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Aula_66
{
    public partial class Tela_ComboBox : Form
    {

        List<string> lista_de_comboBox = new List<string>();
        public Tela_ComboBox()
        {
            InitializeComponent();
            foreach (string v in comboBox1.Items)
            {
                lista_de_comboBox.Add(v);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.FindString(textBox1.Text)<0) { comboBox1.Items.Add(textBox1.Text); }
            else if (textBox1.Text != "" && comboBox1.FindString(textBox1.Text) >= 0) { MessageBox.Show("Elemento já existente"); }
            else { MessageBox.Show("ERRO \n Elemento 'CAIXA DE TEXTO' desmarcado"); }
            textBox1.Clear();
            textBox1.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (string a in lista_de_comboBox)
            {
                comboBox1.Items.Add(a);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
        }
    }
}
