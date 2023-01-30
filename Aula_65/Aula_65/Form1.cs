using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_65
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckBox tela_checkbox = new CheckBox();
            tela_checkbox.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chekedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckedListBox Tela_check_lis_box = new CheckedListBox();
            Tela_check_lis_box.Show();
            this.Hide();
        }
    }
}