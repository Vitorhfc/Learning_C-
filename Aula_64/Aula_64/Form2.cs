using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_64
{
    public partial class Form2 : Form
    {
        Form1 Conteudo;
        public Form2(Form1 v)
        {
            InitializeComponent();
            Conteudo = v;
            textBox1.Text = Conteudo.text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val_2 = Convert.ToInt32(textBox2.Text);
            Conteudo.textBox2.Text = Convert.ToString(val_2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
