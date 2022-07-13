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

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

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
    }
}