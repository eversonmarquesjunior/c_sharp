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
    public partial class FormNumericUpdown : Form
    {
        public FormNumericUpdown()
        {
            InitializeComponent();
        }

        private void bt_definir_Click(object sender, EventArgs e)
        {
            if ((Decimal.Parse(tbox_valor.Text) <= numericupdown1.Minimum) || 
                    (Decimal.Parse(tbox_valor.Text) >= numericupdown1.Maximum))
            {
                MessageBox.Show("Valor fora do limite");
            }
            else
            {
                numericupdown1.Value = Decimal.Parse(tbox_valor.Text);
            }
        }
    }
}
