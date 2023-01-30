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
    public partial class Tela_MaskedTextBox : Form
    {
        public Tela_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                maskedTextBox2.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            else
            {
                maskedTextBox2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }

            label3.Text = maskedTextBox2.Text;
        }
    }
}
