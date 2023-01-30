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
    public partial class Visualizador_Lista : Form
    {
        Conteudo_Text_Box vt ;
        public int valor_total;
        public Visualizador_Lista(string texto, Conteudo_Text_Box v)
        {
            InitializeComponent();
            textBox1.Text = texto;
            vt = v;
            valor_total = v.num;
        }

        private void Bt_Voltar_Click(object sender, EventArgs e)
        {
            Conteudo_Text_Box cont = new Conteudo_Text_Box("");
            vt.Tb_Exibe.Text = Convert.ToString(valor_total);
            cont.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(valor_total);
        }

        private void bt_aumenta_Click(object sender, EventArgs e)
        {
            valor_total++;
            textBox2.Text = Convert.ToString(valor_total);
        }
    }
}
