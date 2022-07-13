using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCurso
{
    public partial class FormListView : Form
    {
        public FormListView()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            tbox_produto.Clear();
            tbox_qtde.Clear();
            tbox_preco.Clear();
        }

        private void obter()                    
        {
            tbox_produto.Text = listview_produtos.SelectedItems[0].SubItems[0].Text;
            tbox_qtde.Text = listview_produtos.SelectedItems[0].SubItems[1].Text;
            tbox_preco.Text = listview_produtos.SelectedItems[0].SubItems[2].Text;
        }

        private void FormListView_Load(object sender, EventArgs e)
        {

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if(tbox_produto.Text == "")
            {
                MessageBox.Show("Digite um produto!");
                tbox_produto.Focus();
                return;
            }

            string[] produtos = new string[3];

            produtos[0] = tbox_produto.Text;
            produtos[1] = tbox_qtde.Text;
            produtos[2] = tbox_preco.Text;

            ListViewItem listview = new ListViewItem(produtos);
            listview_produtos.Items.Add(listview);
            limpar();
            
        }

        private void bt_remover_Click(object sender, EventArgs e)
        {
            listview_produtos.Items.RemoveAt(listview_produtos.SelectedIndices[0]);
        }

        private void bt_obter_Click(object sender, EventArgs e)
        {
            obter();
        }

        private void listview_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listview_produtos.SelectedIndices.Count > 0)
            {
                obter();
            }
   
        }
    }
}
