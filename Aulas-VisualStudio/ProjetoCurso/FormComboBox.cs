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
    public partial class FormComboBox : Form
    {
        public FormComboBox()
        {
            InitializeComponent();
        }

        private void bt_sele_Click(object sender, EventArgs e)
        {
            MessageBox.Show(combo_frutas.Text);
        }

        private void bt_limparele_Click(object sender, EventArgs e)
        {
            combo_frutas.Items.Clear();
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            combo_frutas.Items.Clear();

            List<string> frutas = new List<string>();

            frutas.Add("Uva");
            frutas.Add("Maça");
            frutas.Add("Banana");
            frutas.Add("Melancia");
            frutas.Add("Morango");

            combo_frutas.Items.AddRange(frutas.ToArray());
        }

        private void combo_frutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbox_fruta.Text = combo_frutas.Text;
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (tbox_fruta.Text != "")
            {
                if(combo_frutas.FindString(tbox_fruta.Text) < 0)
                {
                    combo_frutas.Items.Add(tbox_fruta.Text);
                    tbox_fruta.Clear();
                    tbox_fruta.Focus();
                }
            }
        }

        private void FormComboBox_Load(object sender, EventArgs e)
        {

        }
    }
}
