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
    public partial class FormAnimais : Form
    {
        FormPrincipal fp;
        public FormAnimais(String a, FormPrincipal f)
        {
            InitializeComponent();

            tbox_listaanimais.Text = a;

            fp = f;

            fp.num = 500;

        }

        private void FormAnimais_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tbox_listaanimais.Text = tbox_listaanimais.Text;
        }
    }
}
