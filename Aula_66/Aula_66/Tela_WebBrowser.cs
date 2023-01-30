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
    public partial class Tela_WebBrowser : Form
    {
        public Tela_WebBrowser()
        {
            InitializeComponent();
            toolStripButton2.Visible = false;toolStripButton1.Visible = false; 
        }

        private void M_Navegar()
        {
            if (textBox1.Text != "")
            {
                webBrowser1.Navigate(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Barra de pesquisa vazia \n Preencha a barra para continuar");
                textBox1.Focus();
            }
            BackAndNext();

        }
        private void BackAndNext()
        {
            if (webBrowser1.GoForward() != true && webBrowser1.GoBack() != true)
            {
                if (webBrowser1.GoBack() != true) { toolStripButton2.Visible = false; }
                if (webBrowser1.GoForward() != true) { toolStripButton1.Visible = false; }
            }
            else
            {
                if (webBrowser1.GoBack() != false) { toolStripButton2.Visible = true; }
                if (webBrowser1.GoForward() != false) { toolStripButton1.Visible = true; }
            }
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { M_Navegar(); }
        }

        private void bt_Home_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void Bt_Parar_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
