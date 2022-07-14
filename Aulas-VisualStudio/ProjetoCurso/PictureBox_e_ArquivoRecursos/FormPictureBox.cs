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
    public partial class FormPictureBox : Form
    {
        public FormPictureBox()
        {
            InitializeComponent();
        }

        private void FormPictureBox_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.NomeCarro;       //Arquivo de Recursos - repositório que aponta para arquivos externos
            label2.Text = Properties.Resources.Foto;
            label3.Text = Properties.Resources.PapeldeParede;
        }

        private void bt_img1_Click(object sender, EventArgs e)
        {
            picture_img.Image = Properties.Resources.desenho;
        }

        private void bt_img2_Click(object sender, EventArgs e)
        {
            picture_img.Image = Properties.Resources.Caricatura;
        }

        private void bt_img3_Click(object sender, EventArgs e)
        {
            picture_img.Image = Properties.Resources.Papel;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
