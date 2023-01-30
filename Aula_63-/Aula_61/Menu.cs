using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_61
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Console.WriteLine("Azul");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bt_textbox_Click(object sender, EventArgs e)
        {
            Conteudo_Text_Box conteudo = new Conteudo_Text_Box("azul");
            conteudo.Show();
            this.Hide();

            Console.WriteLine();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
