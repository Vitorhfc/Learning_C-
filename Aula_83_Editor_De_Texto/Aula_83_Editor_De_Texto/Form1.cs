using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;

namespace Aula_83_Editor_De_Texto
{
    public partial class EditorTexto : Form
    {
        StringReader leitura = null;

        public EditorTexto()
        {
            InitializeComponent();
        }
        int x;
        int[] el = new int[] { 0, 0, 0 };

        //Verificar Negrito sublinhado ----------------------------------------------------------------------------------------------------------------------

        private void Mt_Verifica()
        {
            string nom_Font = null;
            float tamano_Font = 0f;
            nom_Font = richTextBox1.Font.Name;
            tamano_Font = richTextBox1.Font.Size;

            if (el[0] == 1 && el[1] == 1 && el[2] == 1)
            {
                if (x == 1) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Regular | FontStyle.Italic | FontStyle.Underline); el[0] = 0; }
                if (x == 2) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Bold | FontStyle.Underline); el[1] = 0; }
                if (x == 3) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Bold | FontStyle.Italic); el[2] = 0; }
            }
            else if (el[0] == 0 && el[1] == 1 && el[2] == 1)
            {
                if (x == 1) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); el[0] = 1; }
                if (x == 2) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Underline); el[1] =0; }
                if (x == 3) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Italic); el[2] = 0; }
            }
            else if (el[0] == 1 && el[1] == 0 && el[2] == 1)
            {
                if (x == 1) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Underline); el[0] = 0; }
                if (x == 2) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); el[1] = 1; }
                if (x == 3) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Bold); el[2] =0; }
            }
            else if (el[0] == 1 && el[1] == 1 && el[2] == 0)
            {
                if (x == 1) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Regular | FontStyle.Italic); el[0] = 0; }
                if (x == 2) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Bold | FontStyle.Underline); el[1] = 0; }
                if (x == 3) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Bold | FontStyle.Italic); el[2] = 1; }
            }

            else if (el[0] == 0 && el[1] == 0 && el[2] == 1)
            {
                if (x == 1) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Bold | FontStyle.Underline); el[0] = 1; }
                if (x == 2) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Italic | FontStyle.Underline); el[1] = 1; }
                if (x == 3) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font); el[2] = 0; }
            }
            else if (el[0] == 0 && el[1] == 1 && el[2] == 0)
            {
                if (x == 1) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Bold | FontStyle.Italic); el[0] = 1; }
                if (x == 2) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font); el[1] = 0; }
                if (x == 3) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Italic | FontStyle.Underline); el[2] = 1; }
            }
            else if (el[0] == 1 && el[1] == 0 && el[2] == 0)
            {
                if (x == 1) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Regular); el[0] = 0; }
                if (x == 2) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Bold | FontStyle.Italic); el[1] = 1; }
                if (x == 3) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Bold | FontStyle.Underline); el[2] = 1; }
            }
            else if (el[0] == 0 && el[1] == 0 && el[2] == 0)
            {
                if (x == 1) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Bold); el[0] = 1; }
                if (x == 2) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Italic); el[1] = 1; }
                if (x == 3) { richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Underline); el[2] = 1; }
            }
        }


        private void Mt_Negrito()
        {
            bool negrito = false;
            negrito = richTextBox1.Font.Bold;
            x = 1;
            Mt_Verifica();
        }

        private void Mt_Italic()
        {
            bool italic = false;
            italic = richTextBox1.Font.Italic;
            x = 2;
            Mt_Verifica();
        }

        private void Mt_Sublinhado()
        {
            bool sublinhado = false;
            sublinhado = richTextBox1.Font.Underline;
            x = 3;
            Mt_Verifica();
        }


        //Copiar Colar Recortar ----------------------------------------------------------------------------------------------------------------------
        private void Mt_Copiar()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }
        private void Mt_Colar()
        {
            richTextBox1.Paste();
        }

        private void Mt_Recortar()
        {
            richTextBox1.Cut();
        }

        //Novo ----------------------------------------------------------------------------------------------------------------------
        private void Mt_Novo()
        {
            DialogResult confirm = MessageBox.Show("Deseja salvar o arquivo?","Salvar Arquivo", MessageBoxButtons.YesNo);
            if(confirm == DialogResult.Yes) { Mt_Salvar(); }
            richTextBox1.Clear();
            richTextBox1.Focus();
        }
        //Salvar ----------------------------------------------------------------------------------------------------------------------
        private void Mt_Salvar()
        {
            try 
            { 
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter texto_streamWriter = new StreamWriter(arquivo);
                    texto_streamWriter.Flush();
                    texto_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin) ;
                    texto_streamWriter.Write(this.richTextBox1.Text);
                    texto_streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na gravação:\n"+ex.Message,"Erro GRAVAÇÂO",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }
        //Abrir ----------------------------------------------------------------------------------------------------------------------
        private void Mt_Abrir()
        {
            this.openFileDialog1.Multiselect=false;
            this.openFileDialog1.Title = "Abrir arquivo";
            openFileDialog1.InitialDirectory = "C:Documentos";
            openFileDialog1.Filter = "(*.txt)|*.txt";
            DialogResult dr = this.openFileDialog1 .ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK) 
            {
                try
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader texto_steamReader = new StreamReader(arquivo);
                    texto_steamReader.BaseStream.Seek(0,SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    string linha = texto_steamReader.ReadToEnd();
                    while (linha != null)
                    {
                        this.richTextBox1.Text += linha +"\n";
                        linha = texto_steamReader.ReadLine();
                    }
                    texto_steamReader.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro na leitura:\n" + ex.Message, "Erro Leitura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Left Right Center ----------------------------------------------------------------------------------------------------------------------
        
        private void align_Left()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void align_right()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void align_center()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        //imprimir ----------------------------------------------------------------------------------------------------------------------
        private void imprimir()
        {
            printDialog1.Document = printDocument1;
            string texto = this.richTextBox1.Text;
            leitura = new StringReader(texto);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }

        }

        //Chamadas ----------------------------------------------------------------------------------------------------------------------
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mt_Novo();
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            Mt_Novo();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mt_Salvar();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Mt_Salvar();        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Mt_Abrir();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mt_Abrir();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            Mt_Copiar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Mt_Recortar();
        }

        private void Txt_Colar_Click(object sender, EventArgs e)
        {
            Mt_Colar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mt_Copiar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mt_Colar();
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mt_Recortar();
        }

        private void Txt_Bold_Click(object sender, EventArgs e)
        {
            Mt_Negrito();
        }

        private void Txt_Sublinhado_Click(object sender, EventArgs e)
        {
            Mt_Sublinhado();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Mt_Sublinhado();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Mt_Negrito();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mt_Italic();
        }

        private void italico_Click(object sender, EventArgs e)
        {
            Mt_Italic();
        }

        private void Text_Normal_Click(object sender, EventArgs e)
        {
            string nom_Font = null;
            float tamano_Font = 0f;
            nom_Font = richTextBox1.Font.Name;
            tamano_Font = richTextBox1.Font.Size;
            richTextBox1.SelectionFont = new Font(nom_Font, tamano_Font, FontStyle.Regular);

        }

        private void Txt_Centralizar_Click(object sender, EventArgs e)
        {
            align_center();
        }

        private void Txt_Align_Left_Click(object sender, EventArgs e)
        {
            align_Left();
        }

        private void Txt_Align_Right_Click(object sender, EventArgs e)
        {
            align_right();
        }

        private void alinhadoADireitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            align_right();
        }

        private void alinhadoAEsquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            align_Left();
        }

        private void centralizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            align_center();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPag = 0;
            float PosY = 0;
            int count = 0;
            float margemEsquerda = e.MarginBounds.Left-50;
            float margemSuperior = e.MarginBounds.Top-50;

            if (margemEsquerda < 5)
            {
                margemEsquerda = 20;
            }
            if(margemSuperior < 5)
            {
                margemSuperior = 20;
            }

            string linha = null;

            Font font = this.richTextBox1.Font;

            SolidBrush pincel = new SolidBrush(Color.Black);

            linhasPag = e.MarginBounds.Height / font.GetHeight(e.Graphics);

            linha = leitura.ReadLine();

            while (count < linhasPag) 
            {
                PosY = (margemSuperior + (count - font.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, font, pincel,margemEsquerda, PosY, new StringFormat());
                count++;
                leitura.ReadLine();
            }

            if (linha != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }

            pincel.Dispose();
        }

        private void imprimirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            imprimir();
        }
    }
}
