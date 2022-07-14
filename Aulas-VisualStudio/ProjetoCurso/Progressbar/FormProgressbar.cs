using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjetoCurso
{
    public partial class FormProgressbar : Form
    {
        public FormProgressbar()
        {
            InitializeComponent();
        }

        private void bt_valor_Click(object sender, EventArgs e)
        {
            if ((int.Parse(tbox_valor.Text) < progressbar.Minimum) |
                    (int.Parse(tbox_valor.Text) > progressbar.Maximum))
            {
                MessageBox.Show("Digite um valor entre 0 e 100");
            }
            else
            {
                progressbar.Value = int.Parse(tbox_valor.Text);
            }
        }

        private void bt_preencher_Click(object sender, EventArgs e)     
        {
            progressbar.Value = 0;
            progressbar.Maximum = int.Parse(tbox_cont.Text);

            for(int i = 0; i < int.Parse(tbox_cont.Text); i++)
            {
                progressbar.Value = i;
                //Thread.Sleep(100);        //Sleep - faz uma pausa no processamento do programa de acordo com um tempo especificado
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
