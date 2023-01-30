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
    public partial class Tela_PictureBox : Form
    {
        public Tela_PictureBox()
        {
            InitializeComponent();
            label1.Text = Properties.Resources.NomeVitor;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.teste;
        }
    }
}
