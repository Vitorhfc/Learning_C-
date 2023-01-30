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
    public partial class Form1 : Form
    {
        public int num;
        public string text;
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_troca_Click(object sender, EventArgs e)
        {
            Form2 tela2 = new Form2(this);
            tela2.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = Convert.ToString(Convert.ToInt32(textBox1.Text));
            

        }
    }
}
