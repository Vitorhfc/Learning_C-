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
    public partial class Tela_Timer : Form
    {
        int x = 0;
        int y = 0;
        int py = 0;
        int px = 0;
        public Tela_Timer()
        {
            InitializeComponent();
            pictureBox1.BackColor= TransparencyKey; pictureBox2.BackColor= TransparencyKey;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;
            label1.Text = x.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop(); x = 0; timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            y++;    
            py = pictureBox1.Location.Y;
            px = pictureBox1.Location.X;

            if (y < 50)
            {
                py--;
            }
            else if (y < 100 && y > 50)
            {
                py++;
            }
            else if (y == 100)
            {
                 y= 0;
            }
            pictureBox1.Location = new Point(px,py);
        }
    }
}
