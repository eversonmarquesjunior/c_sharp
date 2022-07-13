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
    public partial class FormLinkLabel : Form
    {
        public FormLinkLabel()
        {
            InitializeComponent();

            linklb_varios.Links.Add(0, 6, "www.google.com.br");             //múltiplos links
            linklb_varios.Links.Add(10, 7, "www.youtube.com");
        }

        private void linklb_yt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");  //inicia um processo, no caso direciona para um site ou programa//app
                                                          
        }

        private void linklb_calc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
            linklb_calc.LinkVisited = true;             //link visitado
        }

        private void linklb_varios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());   //erro (exceção sem tratamento no aplicativo)
        }
    }
}
