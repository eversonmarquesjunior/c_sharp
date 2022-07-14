using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCurso.MaskedTextBox
{
    public partial class FormMaskedTextBox : Form
    {
        public FormMaskedTextBox()
        {
            InitializeComponent();
        }

        private void FormMaskedTextBox_Load(object sender, EventArgs e)
        {

        }

        private void bt_mostrar_Click(object sender, EventArgs e)
        {
            if (cb_texto.Checked)
            {
                mtbox_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                mtbox_cpf.TextMaskFormat = MaskFormat.IncludeLiterals;
            }

            string msg = mtbox_cpf.Text;
            MessageBox.Show(msg);
        }

        private void mtbox_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void bt_senha_Click(object sender, EventArgs e)
        {
            string msg = mtbox_senha.Text;
            MessageBox.Show(msg);
        }
    }
}
