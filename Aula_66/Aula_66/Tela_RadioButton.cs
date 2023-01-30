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
    public partial class Tela_RadioButton : Form
    {
        string texto;
        public Tela_RadioButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            texto = "";
            texto = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(radioButton1=> radioButton1.Checked).Text;
            texto += "; " + groupBox2.Controls.OfType<RadioButton>().SingleOrDefault(radioButton1 => radioButton1.Checked).Text;
            textBox1.Text = texto;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            texto = "";
            if (radioButton1.Checked) { texto += radioButton1.Text + "; "; }
            if (radioButton2.Checked) { texto += radioButton2.Text + "; "; }
            if (radioButton3.Checked) { texto += radioButton3.Text + "; "; }
            if (radioButton4.Checked) { texto += radioButton4.Text + "; "; }
            if (radioButton5.Checked) { texto += radioButton5.Text + "; "; }
            if (radioButton6.Checked) { texto += radioButton6.Text + "; "; }
            if (radioButton7.Checked) { texto += radioButton7.Text + "; "; }
            if (radioButton8.Checked) { texto += radioButton8.Text + "; "; }

            textBox2.Text = texto;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            texto = "";
            foreach (RadioButton radioButton in groupBox1.Controls)
            {
                if (radioButton.Checked) { texto = radioButton.Text; }
            }
            foreach (RadioButton radioButton in groupBox2.Controls)
            {
                if (radioButton.Checked) { texto += "; "+ radioButton.Text; }
            }
            textBox3.Text = texto;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }


    }
}
