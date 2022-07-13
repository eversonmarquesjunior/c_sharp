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
    public partial class FormCheckedList : Form
    {
        public FormCheckedList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_selecionados_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach(string t in clb_tenis.CheckedItems)         //CheckedItems - retorna os itens selecionados de uma lista
            {
                txt += t + "\n";
            }
                     

            MessageBox.Show(txt);
        }

        private void bt_limparele_Click(object sender, EventArgs e)
        {
            clb_tenis.Items.Clear();
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            clb_tenis.Items.Clear();
          
            List<string> tenis = new List<string>();

            tenis.Add("Nike");
            tenis.Add("Adidas");
            tenis.Add("NewBalance");
            tenis.Add("Puma");
            tenis.Add("Vans");

            clb_tenis.Items.AddRange(tenis.ToArray()); 
        }

        private void bt_add_Click(object sender, EventArgs e)
        {

            if (tbox_add.Text != "")
            {
                clb_tenis.Items.Add(tbox_add.Text);
                tbox_add.Clear();
                tbox_add.Focus();
            }
        }

        private void FormCheckedList_Load(object sender, EventArgs e)
        {

        }
    }
}
