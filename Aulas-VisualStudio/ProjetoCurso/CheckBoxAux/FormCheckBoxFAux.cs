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
    public partial class FormCheckBoxFAux : Form
    {

        public FormCheckBox fcb;

        public FormCheckBoxFAux()
        {
            InitializeComponent();

            fcb = Application.OpenForms["FormCheckBox"] as FormCheckBox;    //OpenForms - retorna todos os formulários que estão abertos

            cb_calabresa.Checked = fcb.cb_calabresa.Checked;               //checked desse formulário recebe o checked do formulário principal
            cb_4queijos.Checked = fcb.cb_4queijos.Checked;
            cb_frango.Checked = fcb.cb_frango.Checked;
            cb_portuguesa.Checked = fcb.cb_portuguesa.Checked;
        }

        private void FormCheckBoxFAux_Load(object sender, EventArgs e)
        {

        }

        private void cb_calabresa_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_calabresa.Checked = cb_calabresa.Checked;
        }

        private void cb_4queijos_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_4queijos.Checked = cb_4queijos.Checked;
        }

        private void cb_frango_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_frango.Checked = cb_frango.Checked;
        }

        private void cb_portuguesa_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_portuguesa.Checked = cb_portuguesa.Checked;
        }
    }
}
