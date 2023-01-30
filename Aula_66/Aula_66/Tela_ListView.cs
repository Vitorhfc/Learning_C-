using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aula_66
{
    public partial class Tela_ListView : Form
    {
        string[] vals = new string[4];
        int x = 0;

        public Tela_ListView()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setArray();

            ListViewItem v = new ListViewItem(vals);
            listView1.Items.Add(v);
            limpar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(listView1.SelectedIndices));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
        }
        public void limpar()
        {
            Tb_1.Clear();
            Tb_2.Clear();
            Tb_3.Clear();
            Tb_4.Clear();
            Tb_1.Focus();
        }
        public void setArray()
        {
            if (Tb_1.Text != "" && Tb_2.Text != "" && Tb_3.Text != "" && Tb_4.Text != "")
            {
                for (x = 0; x != 4; x++)
                {
                    if (x == 0) { vals[x] = Tb_1.Text; }
                    if (x == 1) { vals[x] = Tb_2.Text; }
                    if (x == 2) { vals[x] = Tb_3.Text; }
                    if (x == 3) { vals[x] = Tb_4.Text; }
                }
            }
            else
            {
                MessageBox.Show("Caixas de texto incompletas geram linhas incompletas.\n Preencha \bTODAS\b por favor;");
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {/*
            int v = listView1.SelectedIndices[0];
            for(int c = 0; c != 0; c++)
            {
                string val = listView1.SelectedIndices[0].ToString();
                vals[c] = Convert.ToString(val);
                c++;
            }
            MessageBox.Show(vals[1]);

            Tb_1.Text = vals[0];
            Tb_2.Text = vals[1];
            Tb_3.Text = vals[2];
            Tb_4.Text = vals[3];*/
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Tb_1.Text = listView1.SelectedIndices[0].ToString();
            Tb_2.Text = listView1.SelectedItems[0].Text;
            Tb_4.Text = listView1.SelectedIndices[0].ToString();
            Tb_4.Text = listView1.SelectedIndices[0].ToString();

        }
    }
}
