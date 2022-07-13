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
    public partial class FormDateTimePicker : Form
    {
        public FormDateTimePicker()
        {
            InitializeComponent();
        }

        private void FormDateTimePicker_Load(object sender, EventArgs e)        //DateTimePicker - obter/visualizar/alterar a data
        {
             
        }

        private void bt_obterdata_Click(object sender, EventArgs e)
        {
            tbox_data.Text = dtp_data.Text;

            tbox_dia.Text = dtp_data.Value.Day.ToString();
            tbox_mes.Text = dtp_data.Value.Month.ToString();
            tbox_ano.Text = dtp_data.Value.Year.ToString();
        }

        private void bt_alterar_Click(object sender, EventArgs e)
        {
            int d, m, a;

            d = int.Parse(tbox_dia.Text);
            m = int.Parse(tbox_mes.Text);
            a = int.Parse(tbox_ano.Text);

            DateTime dt = new DateTime(a, m, d);

            dtp_data.Value = dt;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
