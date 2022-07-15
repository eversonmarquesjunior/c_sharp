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
    public partial class FormTrackBar : Form
    {
        public FormTrackBar()
        {
            InitializeComponent();
        }

        private void FormTrackBar_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tbox_valor.Text = trackBar1.Value.ToString();
            label_max.Text = "Máximo: " +trackBar1.Maximum.ToString();
            label_min.Text = "Mínimo: " +trackBar1.Minimum.ToString();
        }

        private void bt_definir_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbox_valor.Text) > trackBar1.Maximum || int.Parse(tbox_valor.Text) < trackBar1.Minimum)
            {
                MessageBox.Show("Digite um valor dentro do limite");
            }
            else
            {
                trackBar1.Value = int.Parse(tbox_valor.Text);
            }
        }
    }
}
