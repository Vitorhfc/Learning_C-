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
    public partial class Tela_NumericUpDown : Form
    {
        public Tela_NumericUpDown()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = numericUpDown1.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int v = int.Parse(textBox2.Text);
            if(v > 100 || v < 0) { MessageBox.Show("VALOR INVÁLIDO\nO valor não pode ser superior a 100\n ou inferior a zero;"); }

            else { numericUpDown1.Value = v; }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int v = int.Parse(textBox2.Text);
            if (v > numericUpDown1.Maximum || v < numericUpDown1.Minimum) { MessageBox.Show("VALOR INVÁLIDO\nO valor não pode ser superior a 100\n ou inferior a zero;"); }

            else { numericUpDown1.Value = v; }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int vMax = int.Parse(textBox3.Text);
            if (vMax > 0 && textBox3.Text != "" && vMax > numericUpDown1.Minimum)
            {
                numericUpDown1.Maximum = vMax;
            }
            else if(vMax < numericUpDown1.Minimum)
            {
                textBox3.Text = "Valor inválido, valor maior que valor máximo";
            }
            else { MessageBox.Show("Valores errados"); }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int vMin = int.Parse(textBox4.Text);
            if (vMin > 0 && vMin != -1 && vMin < numericUpDown1.Maximum)
            {
                numericUpDown1.Minimum = vMin;
            }
            else if (vMin > numericUpDown1.Maximum)
            {
                textBox3.Text = "Valor inválido, valor minimo que valor máximo";
            }
            else { MessageBox.Show("Valores errados"); }

        }
    }
}
