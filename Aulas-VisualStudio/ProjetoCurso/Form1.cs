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
    }
}