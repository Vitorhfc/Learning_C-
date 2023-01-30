using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_61
{
    public partial class Conteudo_Text_Box : Form
    {
        public int num, i = 0;
        Dictionary<int, string> lista_de_elementos = new Dictionary<int,string>();
        string texto;
        public Conteudo_Text_Box(string v)
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(num));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            button1.Visible = false;
            groupBox2.Visible = true;
        }

        private void Bt_adiciona_Click(object sender, EventArgs e)
        {
            if (Tb_Entrada.Text == "") { MessageBox.Show("Informe um elemento na entrada"); Tb_Entrada.Focus(); return; }
            else
            {
                lista_de_elementos.Add(i,Tb_Entrada.Text);
                foreach (KeyValuePair<int,string> v in lista_de_elementos)
                {
                    if (v.Key == i)
                    {
                        texto = texto + "Elemento " + (v.Key+1) + ": " + v.Value + ";";
                    }
                    Tb_Exibe.Text = texto;
                }
                i++;
            }   

        }
        private void Bt_limpa_Click(object sender, EventArgs e)
        {
            Tb_Entrada.Text = "";
            Tb_Entrada.Focus();

            Tb_Exibe.Text = "";
            lista_de_elementos.Clear();

            texto = "";
            i = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visualizador_Lista visualizador = new Visualizador_Lista(texto,this);
            visualizador.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Menu voltar = new Menu();
            voltar.Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Tb_Exibe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
