using System;
using System.Collections;
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
    public partial class Tela_CheckedListBox : Form
    {
        string texto;
        List<string> lista_de_checkBox = new List<string> ();
        public Tela_CheckedListBox()
        {
            InitializeComponent();

            foreach(string v in Clb_Cores.Items )
            {
                lista_de_checkBox.Add(v);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bt_Adiconar_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true  && textBox1.Text != "") { Clb_Cores.Items.Add(textBox1.Text,true); }
            else if (checkBox1.Checked == false && textBox1.Text != "") { Clb_Cores.Items.Add(textBox1.Text, false); }
            else { MessageBox.Show("ERRO \n Elemento 'CAIXA DE TEXTO' desmarcado"); }
            textBox1.Clear();
            textBox1.Focus();
        }

        private void Bt_Mostra_Click(object sender, EventArgs e)
        {
            foreach (string v in Clb_Cores.CheckedItems)
            {
                texto += "Elemento:  " + v + ";  ";
            }
            label3.Text = texto;
        }

        private void Bt_clear_Click(object sender, EventArgs e)
        {
            Clb_Cores.Items.Clear();
        }

        private void Bt_Reset_Click(object sender, EventArgs e)
        {
            foreach(string a in lista_de_checkBox)
            {
                Clb_Cores.Items.Add(a);
            }
        }
    }
}
