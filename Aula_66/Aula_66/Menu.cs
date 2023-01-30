using System;
using System.Windows.Forms;

namespace Aula_66
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tela_CheckBox tela_checkbox = new Tela_CheckBox();
            tela_checkbox.Show();
            this.Hide();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_CheckedListBox tela_CheckedListBox = new Tela_CheckedListBox();
            tela_CheckedListBox.Show();
            this.Hide();
        }

        private void comboBoxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tela_ComboBox tela_ComboBox = new Tela_ComboBox();
            tela_ComboBox.Show();
            this.Hide();
        }

        private void dateTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_DateTimer tela_dateTimer = new Tela_DateTimer();
            tela_dateTimer.Show();
            this.Hide();
        }

        private void linkLabelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tela_LinkLabel tela_LinkLabel = new Tela_LinkLabel();
            tela_LinkLabel.Show();
            this.Hide();

        }

        private void listBoxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tela_ListBox tela_listbox = new Tela_ListBox();
            tela_listbox.Show();
            this.Hide();
        }

        private void listViewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tela_ListView tela_ListView = new Tela_ListView();
            tela_ListView.Show();
            this.Hide();
        }

        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_MaskedTextBox tela_Masked = new Tela_MaskedTextBox();
            tela_Masked.Show();
            this.Hide();
        }

        private void mounthCalendarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tela_MounthCalendar tela_MounthCalendar = new Tela_MounthCalendar();
            tela_MounthCalendar.ShowDialog();
            this.Hide();
        }

        private void Menu_BarraDeNotificacao_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.ToString() == "Tsm_Fechar")
            {
                this.Close();
            }
            else if (e.ClickedItem.Name.ToString() == "Tsm_Restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (e.ClickedItem.Name.ToString() == "Tsm_Mensagem")
            {
                MessageBox.Show("Oi♥");
            }
        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_NumericUpDown tela_NumericUpDown = new Tela_NumericUpDown();
            tela_NumericUpDown.Show();
            this.Hide();
        }
        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_PictureBox tela_PictureBox = new Tela_PictureBox();
            tela_PictureBox.Show();
            this.Hide();
        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_ProgressBar tela_ProgressBar = new Tela_ProgressBar();
            tela_ProgressBar.Show();
            this.Hide();
        }

        private void radioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_RadioButton tela_RadioButton = new Tela_RadioButton();
            tela_RadioButton.Show();
            this.Hide();
        }

        private void contextoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trackBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_TrackBar tela_TrackBar1 = new Tela_TrackBar();
            tela_TrackBar1.Show();
            this.Hide();
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_WebBrowser tela_WebBrowser = new Tela_WebBrowser();
            tela_WebBrowser.Show();
            this.Hide();
        }

        private void tabControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_TabControl tela_TabControl = new Tela_TabControl();
            tela_TabControl.Show();
            this.Hide();
        }

        private void tableLayoutPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_TableLayoutPanel tela_TableLayoutPanel = new Tela_TableLayoutPanel();
            tela_TableLayoutPanel.Show();
            this.Hide();
        }

        private void toolStripContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_ToolStripContainer tela_ToolStripContainer = new Tela_ToolStripContainer();
            tela_ToolStripContainer.Show();
            this.Hide();
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Timer tela_Timer = new Tela_Timer();
            tela_Timer.Show();
            this.Hide();
        }
    }
}
