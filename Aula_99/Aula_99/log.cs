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
    public partial class log : Form
    {
        DataTable dt = new DataTable();
        Form p_bradock;

        public log(Form p)
        {
            InitializeComponent();
            p_bradock = p;
        }

        private void log_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usernom = textBox1.Text;
            string senha = maskedTextBox1.Text;

            if (usernom != "" && senha != "")
            {
                if (usernom == "" && senha == "") { MessageBox.Show("Preencha os campos de dados"); textBox1.Focus(); }
                else if (usernom != "" && senha == "") { MessageBox.Show("Preencha o campo de nome"); textBox1.Focus(); }
                else if (usernom == "" && senha != "") { MessageBox.Show("Preencha o campo de senha"); maskedTextBox1.Focus(); }
                return;
            }
            string sql = "select * from Tb_User where user_name='"+usernom+"' and user_senha='"+senha+"'";
            dt = Banco.Consulta(sql);

            if (dt.Rows.Count == 1)
            {
                 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
