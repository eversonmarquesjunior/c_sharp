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
    public partial class FormTreeView : Form
    {
        public FormTreeView()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox2.Clear();
            textBox1.Text = treeView1.SelectedNode.Text;

            if(treeView1.SelectedNode.Tag != null)
            {
                textBox2.Text = treeView1.SelectedNode.Tag.ToString();
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            TreeNode raizestados = treeView1.Nodes.Add("Estados");
            raizestados.Name = "raizestados";

            TreeNode estado1 = raizestados.Nodes.Add("Paraná");
            estado1.Name = "Paraná";

            TreeNode estado2 = raizestados.Nodes.Add("Mato Grosso");
            estado2.Name = "Mato Grosso";

            TreeNode raizcores = treeView1.Nodes.Add("Cores");
            raizcores.Name = "raizcores";

            TreeNode cor1 = raizcores.Nodes.Add("Amarelo");
            cor1.Name = "Amarelo";

            TreeNode cor2 = raizcores.Nodes.Add("Roxo");
            cor1.Name = "Roxo";
        }

        private void bt_remover_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Remove(treeView1.Nodes["raizestados"]);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao remover");
            }
        }

        private void bt_removersele_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover");
            }
        }
    }
}
