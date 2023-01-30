using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            login();
            
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            login();
        }

        public void login()
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "0";
            label4.Text = "-";
            pictureBox1.Image = Properties.Resources.Red;

            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 3)
                {

                }

                else
                {
                    MessageBox.Show("Nivel de acesso não suficiente");
                }

            }
            else
            {
                MessageBox.Show("É necessário estar logado");
            }
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {

                }

                else
                {
                    MessageBox.Show("Nivel de acesso não suficiente");
                }

            }
            else
            {
                MessageBox.Show("É necessário estar logado");
            }
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {

                }

                else
                {
                    MessageBox.Show("Nivel de acesso não suficiente");
                }

            }
            else
            {
                MessageBox.Show("É necessário estar logado");
            }
        }
    }
}
