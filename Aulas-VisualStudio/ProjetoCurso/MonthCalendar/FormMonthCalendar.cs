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
    public partial class FormMonthCalendar : Form
    {
        public FormMonthCalendar()
        {
            InitializeComponent();
        }

        private void bt_obterdata_Click(object sender, EventArgs e)
        {
            tbox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            tbox2.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            tbox3.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            tbox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            tbox2.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            tbox3.Text = monthCalendar1.TodayDate.ToShortDateString();
        }
    }
}
