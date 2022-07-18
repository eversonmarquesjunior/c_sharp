
using ProjetoCurso.MaskedTextBox;

namespace ProjetoCurso {
    public partial class FormPrincipal : Form {

        public int num;
        public FormPrincipal() {
            InitializeComponent();
            num = 0;
        }

        private void button1_Click(object sender, EventArgs e)          //botão adicionar
        {
            //label_titulo.Text = tbox_animal.Text;                 //atribui texto ao label

            if(tbox_animal.Text == "")
            {
                MessageBox.Show("Digite um animal!");               //emite uma mensagem na tela
                tbox_animal.Focus();                              //posiciona o cursor
                return;
            }

            tbox_listaanimais.Text += tbox_animal.Text + " - ";          //adiciona/atribui um texto na lista

            tbox_animal.Clear();            //limpa caixa de texto
            tbox_animal.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tbox_listaanimais.Clear();
            tbox_animal.Clear();            
            tbox_animal.Focus();
        }

        private void tbox_listaanimais_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            FormAnimais formveiculos = new FormAnimais(tbox_listaanimais.Text, this);
            formveiculos.ShowDialog();                      //impossível interagir com a janela anterior
        }

        private void bt_var_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCheckBox formcheckbox = new FormCheckBox();
            formcheckbox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCheckedList formcheckedlist = new FormCheckedList();
            formcheckedlist.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormComboBox formcombo = new FormComboBox();
            formcombo.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDateTimePicker formdate = new FormDateTimePicker();
            formdate.ShowDialog();
        }

        private void linkedLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLinkLabel formlinklabel = new FormLinkLabel();
            formlinklabel.ShowDialog();
        }


        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListBox formlistbox = new FormListBox();
            formlistbox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListView formlistview = new FormListView();
            formlistview.ShowDialog();
        }

        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMaskedTextBox formmasked = new FormMaskedTextBox();
            formmasked.ShowDialog();
        }

        private void monthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMonthCalendar formmonth = new FormMonthCalendar();
            formmonth.ShowDialog();
        }

        private void MenuNotificacoes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.ToString() == "menuitem_fechar")         //NotifyIcon - disponibiliza o ícone na área de notificações
            {                                                               //associando com o ContextMenuStrip para abrir um menu de opções
                this.Close();
            }
            else if (e.ClickedItem.Name.ToString() == "menuitem_restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (e.ClickedItem.Name.ToString() == "menuitem_msg")
            {
                MessageBox.Show("Tudo certo por aqui");
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void MenuNotificacoes_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNumericUpdown formnumericup = new FormNumericUpdown();
            formnumericup.ShowDialog();
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPictureBox formpicture = new FormPictureBox();
            formpicture.ShowDialog(); 
        }

        private void progressbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProgressbar formprogress = new FormProgressbar();
            formprogress.ShowDialog();
        }

        private void radioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRadioButton formradio = new FormRadioButton();
            formradio.ShowDialog();
        }

        private void editorTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditorTexto formeditor = new FormEditorTexto();
            formeditor.ShowDialog();
        }

        private void trackBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTrackBar formtrackbar = new FormTrackBar();
            formtrackbar.ShowDialog();
        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTreeView formtreeview = new FormTreeView();
            formtreeview.ShowDialog();
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWebBrowser formweb = new FormWebBrowser();
            formweb.ShowDialog();
        }

        private void splitContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSplitContainer formsplitc = new FormSplitContainer();
            formsplitc.ShowDialog();
        }

        private void tabControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTabControl formtab = new FormTabControl();
            formtab.ShowDialog();
        }

        private void tableLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTableLayout formtable = new FormTableLayout();
            formtable.ShowDialog();
        }

        private void toolStripContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormToolStripContainer formtstripcontainer = new FormToolStripContainer();
            formtstripcontainer.ShowDialog();
        }

        private void backgroundWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBackgroundWorker formbackworker = new FormBackgroundWorker();
            formbackworker.ShowDialog();
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTimer formtimer = new FormTimer();
            formtimer.ShowDialog();
        }

        private void aplicativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSQLite formapp = new FormSQLite();
            formapp.ShowDialog();
        }
    }
}