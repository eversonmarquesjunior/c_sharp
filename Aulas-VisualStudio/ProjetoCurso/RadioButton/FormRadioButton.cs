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
    public partial class FormRadioButton : Form
    {
        public FormRadioButton()
        {
            InitializeComponent();
        }

        private void bt_sele_Click(object sender, EventArgs e)
        {
            string txt = "";

            txt = groupbox_sabores.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;  //forma mais difícil

            tbox_sele.Text = txt;

            MessageBox.Show(txt);
        }

        private void bt_sele2_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach(RadioButton radio in groupbox_bebidas.Controls)     //forma mais fácil
            {
                if (radio.Checked)
                {
                    txt = radio.Text;
                }
            }
            tbox_sele.Text = txt;
            MessageBox.Show(txt);
        }
    }
}
