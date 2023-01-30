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
    public partial class F_Login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();

        public F_Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string senha = textBox2.Text;


            if (username == "" || senha == "")
            {
                if (username == "" && senha == "") { MessageBox.Show("Preencha os campos de dados"); textBox1.Focus(); }
                else if (username != "" && senha == "") { MessageBox.Show("Preencha o campo de nome"); textBox1.Focus(); }
                else if (username == "" && senha != "") { MessageBox.Show("Preencha o campo de senha"); textBox2.Focus(); }
                return;
            }
            string sql = "select * from Tb_User where user_name='" + username + "' and user_senha='" + senha + "'";
            dt = Banco.Consulta(sql);

            if (dt.Rows.Count == 1)
            {
                form1.label3.Text = dt.Rows[0].ItemArray[2].ToString();
                form1.label4.Text = dt.Rows[0].Field<string>("User_Name");
                form1.pictureBox1.Image = Properties.Resources.Green;

                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("User_nivel").ToString());
                Globais.logado = true;

                this.Close();
            }
            else
            {
                MessageBox.Show("User não encontrado");
            }
        }
    }
}
