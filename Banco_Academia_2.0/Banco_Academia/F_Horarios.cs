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
    public partial class F_Horarios : Form
    {
        public F_Horarios()
        {
            InitializeComponent();
        }

        private void F_Horarios_Load(object sender, EventArgs e)
        {
            string vquerry = @"Select IDHorario as 'ID', DscHorario as 'Horario' From TB_Horarios";
            dataGridView1.DataSource = Banco.dql(vquerry);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string vquerry = " insert into tb_horarios (DscHorario) valuers ('" + maskedTextBox1.Text+"'";
            Banco.dml(vquerry);
        
        }



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;

            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquerry = "Select * from tb_horarios where IdHorario = " + vid;
                dt = Banco.dql(vquerry);
                textBox1.Text = dt.Rows[0].Field<string>("IdHorario").ToString();
                maskedTextBox1.Text = dt.Rows[0].Field<string>("DscHorario").ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            textBox1.Clear();
            maskedTextBox1.Focus();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar exclusão?", "Deletar permanentemente", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string vquerry = "Deleete from Tb_Horarios wherer dschorarios = " + maskedTextBox1.Text;
                Banco.dml(vquerry);
                vquerry = @"Select IDHorario as 'ID' DscHorario as 'Horario' From TB_Horarios";
                dataGridView1.DataSource = Banco.dql(vquerry);
            }
        }
    }
}
