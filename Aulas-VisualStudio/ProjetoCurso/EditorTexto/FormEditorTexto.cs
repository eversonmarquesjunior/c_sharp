using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetoCurso
{
    public partial class FormEditorTexto : Form
    {
        StringReader leitura = null;
        public FormEditorTexto()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void menuitem_novo_Click(object sender, EventArgs e)
        {
            novo();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novo();
        }
        private void salvar()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)       //SaveFileDialog - abre janela salvar como
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter escritor = new StreamWriter(arquivo);
                    escritor.Flush();
                    escritor.BaseStream.Seek(0, SeekOrigin.Begin);
                    escritor.Write(this.richTextBox1.Text);
                    escritor.Flush();
                    escritor.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro na criação do arquivo " +ex.Message, "Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuitem_salvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvar();
        }
        private void abrir()
        {
            this.openFileDialog1.Title = "Abrir Arquivo";           //OpenFileDialog - abre janela abrir arquivo
            openFileDialog1.InitialDirectory = @"D:\CursoC#\Aulas-VisualStudio\ProjetoCurso\";
            openFileDialog1.Filter = "(*.TESTE)|*.TESTE";

            DialogResult dr = this.openFileDialog1.ShowDialog();

            if(dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader leitor = new StreamReader(arquivo);
                    leitor.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    string linha = leitor.ReadLine();
                    
                    while (linha != null)
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = leitor.ReadLine();
                    }
                    leitor.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro de leitura: " + ex.Message, "Erro ao ler arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void menuitem_abrir_Click(object sender, EventArgs e)
        {
            abrir();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir();
        }
        public void copiar()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }
        public void colar()
        {
            richTextBox1.Paste();
        }

        private void menuitem_copiar_Click(object sender, EventArgs e)
        {
            copiar();
        }

        private void copirarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copiar();
        }

        private void menuitem_colar_Click(object sender, EventArgs e)
        {
            colar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colar();
        }
        private void negrito()
        {
            string nomefonte = null;
            float tamanhofonte = 0;
            bool negri = false;

            nomefonte = richTextBox1.Font.Name;
            tamanhofonte = richTextBox1.Font.Size;
            negri = richTextBox1.Font.Bold;

            if (negri == false)
            {
                richTextBox1.SelectionFont = new Font(nomefonte, tamanhofonte, FontStyle.Bold);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(nomefonte, tamanhofonte, FontStyle.Regular);
            }
        }
        private void italico()
        {
            string nomefonte = null;
            float tamanhofonte = 0;
            bool ita = false;

            nomefonte = richTextBox1.Font.Name;
            tamanhofonte = richTextBox1.Font.Size;
            ita = richTextBox1.Font.Italic;

            if (ita == false)
            {
                richTextBox1.SelectionFont = new Font(nomefonte, tamanhofonte, FontStyle.Italic);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(nomefonte, tamanhofonte, FontStyle.Italic);
            }
        }
        private void sublinhado()
        {
            string nomefonte = null;
            float tamanhofonte = 0;
            bool sub = false;

            nomefonte = richTextBox1.Font.Name;
            tamanhofonte = richTextBox1.Font.Size;
            sub = richTextBox1.Font.Underline;

            if (sub == false)
            {
                richTextBox1.SelectionFont = new Font(nomefonte, tamanhofonte, FontStyle.Underline);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(nomefonte, tamanhofonte, FontStyle.Underline);
            }
        }

        private void menuitem_negrito_Click(object sender, EventArgs e)
        {
            negrito();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            negrito();
        }

        private void menuitem_italico_Click(object sender, EventArgs e)
        {
            italico();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italico();
        }

        private void menuitem_sublinhado_Click(object sender, EventArgs e)
        {
            sublinhado();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sublinhado();
        }
        private void alinhar_esquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void alinhar_direita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void alinhar_centro()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void menuitem_esquerda_Click(object sender, EventArgs e)
        {
            alinhar_esquerda();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alinhar_esquerda();
        }

        private void menuitem_centro_Click(object sender, EventArgs e)
        {
            alinhar_centro();
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alinhar_centro();
        }

        private void menuitem_direita_Click(object sender, EventArgs e)
        {
            alinhar_direita();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alinhar_direita();
        }

        private void imprimir()
        {
            printDialog1.Document = printDocument1;
            string texto = this.richTextBox1.Text;
            leitura = new StringReader(texto);

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhaspag = 0;
            float posy = 0;
            int cont = 0;
            float margemesq = e.MarginBounds.Left - 50;
            float margemsup = e.MarginBounds.Top - 50;

            if(margemesq < 5)
            {
                margemesq = 20;
            }

            if (margemsup < 5)
            {
                margemsup = 20;
            }

            string linha = null;
            Font fonte = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);
            linhaspag = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);
            linha = leitura.ReadLine();

            while (cont < linhaspag)
            {
                posy = (margemsup + (cont * fonte.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, fonte, pincel, margemesq, posy, new StringFormat());
                cont += 1;
                linha = leitura.ReadLine();
            }

            if(linha != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }

            pincel.Dispose();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprimir();
        }
    }
}
