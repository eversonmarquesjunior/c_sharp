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
    public partial class FormTimer : Form
    {
        int num;
        int px, py;
        public FormTimer()
        {
            InitializeComponent();
        }

        private void FormTimer_Load(object sender, EventArgs e)
        {
            px = img_carro.Location.X;
            py = img_carro.Location.Y;
        }

        private void bt_iniciar_t1_Click(object sender, EventArgs e)
        {
            //timer1.Interval = 500;
            timer1.Start();
        }

        private void bt_parar_t1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = num.ToString();
            num++;
        }

        private void bt_reiniciar_t1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            num = 0;
            label1.Text = num.ToString();
            timer1.Start();
        }

        private void bt_iniciarcarro_tcarro_Click(object sender, EventArgs e)
        {
            timer_carro.Start();
        }

        private void bt_pararcarro_tcarro_Click(object sender, EventArgs e)
        {
            timer_carro.Stop();
        }

        private void timer_carro_Tick(object sender, EventArgs e)
        {
            px += 2;

            if (px >= 620)
            {
                px = 12;
            }

            img_carro.Location = new Point(px, py);
            px = img_carro.Location.X;
        }
    }
}
