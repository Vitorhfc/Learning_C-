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
            config_menu();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "0";
            label4.Text = "-";
            pictureBox1.Image = Properties.Resources.Red;

            Globais.nivel = 1;
            //Globais.logado = false;
            config_menu();
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
                    F_GestaoUsuarios f_gestao = new F_GestaoUsuarios();
                    f_gestao.Show();
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
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();
                    this.Close();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void config_menu()
        {
            if (Globais.nivel == 0)
            {
                manutençãoToolStripMenuItem.Visible = false;
                usuáriosToolStripMenuItem.Visible = false;
                alunoToolStripMenuItem.Visible = false;
            }
            if (Globais.nivel == 1)
            {
                manutençãoToolStripMenuItem.Visible = false;
                usuáriosToolStripMenuItem.Visible = false;
                alunoToolStripMenuItem.Visible = true;
            }
            if (Globais.nivel == 2)
            {
                manutençãoToolStripMenuItem.Visible = false;
                usuáriosToolStripMenuItem.Visible = true;
            }
            if (Globais.nivel == 3)
            {
                manutençãoToolStripMenuItem.Visible = true;
            }
        }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Horarios f_Horarios = new F_Horarios();
            f_Horarios.Show();

        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Turmas f_Turmas = new F_Turmas();
            f_Turmas.Show();
        }
    }
}
