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
    public partial class F_GestaoUsuarios : Form
    {
        public F_GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void F_GestaoUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Banco.IdNome_User();
            dataGridView1.Columns[0].Width = (80);
            dataGridView1.Columns[1].Width = (10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DadosDoUsuario u = new DadosDoUsuario();
            u.Id = Convert.ToInt32(tb1.Text);
            u.nome = tb2.Text;
            u.nome_De_usuário = tb3.Text;
            u.senha = tb4.Text;
            u.status = tb5.Text;
            u.nivel = Convert.ToInt32(Math.Round(tb6.Value,0));
            Banco.AtualizarUsuario(u);

            dataGridView1.DataSource = Banco.IdNome_User();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Banco.IdNome_User();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dt = (DataGridView)sender;
            int vlinhas = dt.SelectedRows.Count;
            string id = "";

            if (vlinhas > 0)
            {
                id = dt.SelectedRows[0].Cells[0].Value.ToString();
                DataTable dt2 = new DataTable();
                dt2 = Banco.DadosPeloId(id);
                tb1.Text = dt2.Rows[0].Field<Int64>("IdUser").ToString();
                tb2.Text = dt2.Rows[0].Field<string>("UserName").ToString();
                tb3.Text = dt2.Rows[0].Field<string>("UserNick").ToString();
                tb4.Text = dt2.Rows[0].Field<string>("UserSenha").ToString();
                tb5.Text = dt2.Rows[0].Field<string>("UserStatus").ToString();
                tb6.Value = dt2.Rows[0].Field<Int64>("UserNivel");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            f_NovoUsuario.Show();
            dataGridView1.DataSource = Banco.IdNome_User();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
