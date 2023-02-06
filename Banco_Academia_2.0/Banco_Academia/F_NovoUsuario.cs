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
    public partial class F_NovoUsuario : Form
    {
        int tela = 1;
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tb3.PasswordChar = '\0';
            }
            else
            {
                tb4.PasswordChar = '♦';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] res = new int[4];
            if (tb1.Text == "" || tb2.Text == "") { MessageBox.Show("Campo não preenchido"); tb1.Focus(); return; } else { res[0] = 1; }
            if (tb3.Text == "" || tb4.Text == "") { if (tb3.Text == "") { MessageBox.Show("Campo não preenchido"); tb3.Focus(); return; } if (tb4.Text == "") { MessageBox.Show("Campo não preenchido"); tb4.Focus(); return; } }
            else { if (tb3.Text != tb4.Text) { MessageBox.Show("Senhas não coincidem"); tb3.Clear(); tb4.Clear(); tb3.Focus(); return; } else { res[1] = 1; } }
            if (tb5.Text != "a" && tb5.Text != "A" && tb5.Text != "b" && tb5.Text != "B" && tb5.Text != "c" && tb5.Text != "C") { MessageBox.Show("Campo ou não preenchido ou diferente de 'a', 'b' ou 'c'"); tb5.Focus(); return; }
            else { res[2] = 1; }
            if (tb6.Value > 3 && tb6.Value < 1) { MessageBox.Show("Valor inválido, se mantenha entre 1 e 3"); tb6.Focus(); return; }
            else { res[3] = 1; }

            if (res[0] == 1 && res[1] == 1 && res[2] == 1 && res[3] == 1)
            {
                DadosDoUsuario usuario = new DadosDoUsuario();
                usuario.nome = tb1.Text;
                usuario.nome_De_usuário = tb2.Text;
                usuario.senha = tb4.Text;
                usuario.status = tb5.Text;
                usuario.nivel = ((int)tb6.Value);

                Banco.novoUsuario(usuario);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
