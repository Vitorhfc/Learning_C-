using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_99
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void projeto11AcademiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Projeto_Bradock projeto_bradock = new Projeto_Bradock();
            projeto_bradock.Show();
            this.Hide();
        }
    }
}
