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
    public partial class FormCheckBox : Form
    {

        List<CheckBox> sabores = new List<CheckBox>();

        public FormCheckBox()
        {
            InitializeComponent();

            sabores.Add(cb_calabresa);
            sabores.Add(cb_4queijos);
            sabores.Add(cb_frango);
            sabores.Add(cb_portuguesa);
        }

        private void FormCheckBox_Load(object sender, EventArgs e)
        {

        }

        private void bt_sabores_sele_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach(CheckBox s in sabores)                               
            {
                if(s.Checked)                                       //.Checked - verifica se está marcado ou não
                {
                    txt += s.Text + "\n";
                }
            }               
           

            MessageBox.Show(txt);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_strog.Checked)
            {
                MessageBox.Show("Sabor Marcado");
            }
        }

        private void bt_aux_Click(object sender, EventArgs e)
        {
            FormCheckBoxFAux formaux = new FormCheckBoxFAux();
            formaux.ShowDialog();
        }
    }
}
