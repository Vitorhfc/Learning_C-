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
    public partial class Tela_DateTimer : Form
    {
        public Tela_DateTimer()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tb_DataCompleta.Text = dateTimePicker1.Text;

            Tb_Dia.Text = Convert.ToString(dateTimePicker1.Value.Day);
            Tb_Mes.Text = Convert.ToString(dateTimePicker1.Value.Month);
            Tb_Ano.Text = Convert.ToString(dateTimePicker1.Value.Year);



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(Convert.ToInt32(Tb_Entrada_Ano.Text), Convert.ToInt32(Tb_Entrada_Mes.Text), Convert.ToInt32(Tb_Entrada_Dia.Text));
            dateTimePicker1.Value = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
        }
    }
}
