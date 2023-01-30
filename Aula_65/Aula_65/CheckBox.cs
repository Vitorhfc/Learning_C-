using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_65
{
    public partial class CheckBox : Form
    {
        List<int> Checked_Elements = new List<int>();
        string texto;

        public CheckBox()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Checked_Elements.Add(1);
            
            }
            else
            {
                Checked_Elements.Add(0);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Checked_Elements.Add(2);

            }
            else
            {
                Checked_Elements.Add(0);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Checked_Elements.Add(3);

            }
            else
            {
                Checked_Elements.Add(0);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Checked_Elements.Add(4);

            }
            else
            {
                Checked_Elements.Add(0);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Checked_Elements.Add(5);

            }
            else
            {
                Checked_Elements.Add(0);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Checked_Elements.Add(6);

            }
            else
            {
                Checked_Elements.Add(0);
            }
        }

        private void Lb_Texto_Click(object sender, EventArgs e)
        {

        }

        private void Bt_incia_Click(object sender, EventArgs e)
        {
            foreach (int v in Checked_Elements)
            {
                if (v == 0) { }
                if (v == 1) { texto = texto + "Preto;  "; }
                if (v == 2) { texto = texto + "Roxo;  "; }
                if (v == 3) { texto = texto + "Branco;  "; }
                if (v == 4) { texto = texto + "Cinza;  "; }
                if (v == 5) { texto = texto + "Vermelho;  "; }
                if (v == 6) { texto = texto + "Cinza;  "; }
            }
            Lb_Texto.Text = texto;
        }
    }
}
