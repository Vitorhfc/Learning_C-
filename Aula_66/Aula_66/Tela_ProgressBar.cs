using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_66
{
    public partial class Tela_ProgressBar : Form
    {
        public Tela_ProgressBar()
        {
            InitializeComponent();
            progressBar1.BackColor= Color.Black;
            progressBar1.ForeColor= Color.White;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" )
            {
                int val_textbox = int.Parse(textBox1.Text);
                if (val_textbox > progressBar1.Maximum) { progressBar1.Value = progressBar1.Maximum; }
                else if (val_textbox < progressBar1.Minimum) { progressBar1.Value = progressBar1.Minimum; }
                else
                {
                    progressBar1.Value = val_textbox;
                }
            }
            else
            {

                MessageBox.Show("O valor da caixa de texto não foi preenchido.\n o preencha para poder realizar a operação.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;
            for (int v = progressBar1.Minimum; v < progressBar1.Maximum; v++)
            {
                label1.Text = Convert.ToString(progressBar1.Value);
                progressBar1.Value++;
                Thread.Sleep(35);
            }
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
