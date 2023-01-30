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
    public partial class Tela_ListBox : Form
    {
        List<string> lista_de_cores= new List<string>();
        public Tela_ListBox()
        {
            InitializeComponent();
            lista_de_cores.Add("Preto");
            lista_de_cores.Add("Roxo");
            lista_de_cores.Add("Branco");
            lista_de_cores.Add("Cinza");
            lista_de_cores.Add("Vermelho");
            lista_de_cores.Add("Azul");
            lista_de_cores.Add("Rosa");

            listBox1.DataSource = lista_de_cores;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                lista_de_cores.Add (Convert.ToString(textBox1.Text));
                atualiza();
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Texto do entrada VAZIO");
                textBox1.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string texto = textBox1.Text;
            if (textBox1.Text != "")
            {
                if (lista_de_cores.Contains(texto))
                {
                    lista_de_cores.Remove(texto);
                    atualiza();
                }
                else
                {
                    MessageBox.Show("Elemento não existe na tabela");
                }
            }
            else if (textBox1.Text == "" && listBox1.SelectedIndex != -1)
            {
                lista_de_cores.RemoveAt(listBox1.SelectedIndex);
                atualiza();
            }
            else
            {
                MessageBox.Show("Nenhum elemento selecionado");
                textBox1.Focus();
            }





        }

        public void atualiza()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = lista_de_cores;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O valor selecionado foi \n " + lista_de_cores[listBox1.SelectedIndex]);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            lista_de_cores.Clear();
        }
    }
}
