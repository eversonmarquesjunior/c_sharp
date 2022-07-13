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
    public partial class FormListBox : Form
    {
        List<string> carros = new List<string>();

        public FormListBox()
        {
            InitializeComponent();

            carros.Add("Ferrari");
            carros.Add("Bugatti");
            carros.Add("Mercedes");

            listbox_carros.DataSource = carros;         //DataSource - associa um elemento a um banco ou lista de dados

        }

        private void atualizarlista(ListBox listbox, List<string> lista)
        {
            listbox.DataSource = null;           //função genérica que atualiza o ListBox de acordo com a lista de elementos
            listbox.DataSource = lista;
        }

        private void FormListBox_Load(object sender, EventArgs e)
        {

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if(tbox_carro.Text == "")
            {
                MessageBox.Show("Digite um carro!");
                tbox_carro.Focus();
            }
            else
            {
                carros.Add(tbox_carro.Text);
                tbox_carro.Clear();
                atualizarlista(listbox_carros, carros);         
                
            }
        }

        private void bt_remover_Click(object sender, EventArgs e)
        {
            carros.RemoveAt(listbox_carros.SelectedIndex);
            atualizarlista(listbox_carros, carros);
        }

        private void bt_obter_Click(object sender, EventArgs e)
        {
            tbox_carro.Text = carros[listbox_carros.SelectedIndex];
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            atualizarlista(listbox_carros, carros);
        }
    }
}
