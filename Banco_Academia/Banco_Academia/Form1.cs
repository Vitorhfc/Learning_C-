using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
            
        }
    }
}
