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
    public partial class Tela_TrackBar : Form
    {
        int v = 0;

        public Tela_TrackBar()
        {
            InitializeComponent();
            textBox1.Text = trackBar1.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                v = int.Parse(textBox1.Text);

            }catch(Exception ex)
            {
                MessageBox.Show("Valores em string não aceitos\n Apenas valores inteiros."+ex.Message.ToString());
            }

            if (v > trackBar1.Maximum) { trackBar1.Value = trackBar1.Maximum; }
            else if (v < trackBar1.Minimum) { trackBar1.Value = trackBar1.Minimum; }
            else { trackBar1.Value = v; }

        }
    }
}
