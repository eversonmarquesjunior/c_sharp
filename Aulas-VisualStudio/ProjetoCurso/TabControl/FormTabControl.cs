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
    public partial class FormTabControl : Form
    {
        public FormTabControl()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if(tbox_novaaba.Text != "")
            {
                TabPage pagina = new TabPage();
                pagina.Text = tbox_novaaba.Text;
                pagina.Name = tbox_novaaba.Text;
                pagina.TabIndex = tabControl1.TabPages.Count;
                tabControl1.TabPages.Add(pagina);
                tbox_novaaba.Clear();
                definirmax();
            }
            else
            {
                MessageBox.Show("Digite o nome da nova aba");
                tbox_novaaba.Focus();
            }
        }

        private void bt_remover_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            definirmax();
        }

        private void bt_posicionar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = Int32.Parse(numericUpDown1.Value.ToString());
        }
        private void definirmax()
        {
            numericUpDown1.Maximum = tabControl1.TabPages.Count;
        }

        private void FormTabControl_Load(object sender, EventArgs e)
        {
            definirmax();
        }
    }
}
