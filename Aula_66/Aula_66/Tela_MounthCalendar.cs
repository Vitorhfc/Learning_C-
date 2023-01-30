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
    public partial class Tela_MounthCalendar : Form
    {
        public Tela_MounthCalendar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBox2.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBox2.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int d, m, a;
            Random randNum = new Random();
            d = randNum.Next(1, 28);
            m = randNum.Next(1, 12);
            a = randNum.Next(1900, 2999);
            DateTime data = new DateTime(a, m, d);
            monthCalendar1.SetDate(data);
        }
    }
}
