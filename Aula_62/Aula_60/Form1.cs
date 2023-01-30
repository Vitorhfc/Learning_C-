using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_60
{
    public partial class Formulário_Principal : Form
    {
        public Formulário_Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_modifica_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(textBox1.Text);
        }
    }
}
