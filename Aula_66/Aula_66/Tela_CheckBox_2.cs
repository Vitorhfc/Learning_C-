using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Aula_66
{
    public partial class Tela_CheckBox_2 : Form
    {
        public Tela_CheckBox check2;
        public Tela_CheckBox_2()
        {
            InitializeComponent();
            check2 = Application.OpenForms["CheckBox"] as Tela_CheckBox;
            checkBox1.Checked = check2.checkBox1.Checked;
            checkBox2.Checked = check2.checkBox2.Checked;
            checkBox3.Checked = check2.checkBox3.Checked;
            checkBox4.Checked = check2.checkBox4.Checked;
            checkBox5.Checked = check2.checkBox5.Checked;
            checkBox6.Checked = check2.checkBox6.Checked;
            checkBox7.Checked = check2.checkBox7.Checked;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            check2.checkBox1.Checked = checkBox1.Checked;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

            check2.checkBox7.Checked = checkBox7.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            check2.checkBox6.Checked = checkBox6.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            check2.checkBox5.Checked = checkBox5.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            check2.checkBox4.Checked = checkBox4.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            check2.checkBox3.Checked = checkBox3.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            check2.checkBox2.Checked = checkBox2.Checked;
        }
    }
}
