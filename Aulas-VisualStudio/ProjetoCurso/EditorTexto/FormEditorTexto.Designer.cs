namespace ProjetoCurso
{
    partial class FormEditorTexto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditorTexto));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copirarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itálicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuitem_novo = new System.Windows.Forms.ToolStripButton();
            this.menuitem_abrir = new System.Windows.Forms.ToolStripButton();
            this.menuitem_salvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitem_copiar = new System.Windows.Forms.ToolStripButton();
            this.menuitem_colar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitem_negrito = new System.Windows.Forms.ToolStripButton();
            this.menuitem_italico = new System.Windows.Forms.ToolStripButton();
            this.menuitem_sublinhado = new System.Windows.Forms.ToolStripButton();
            this.menuitem_fonte = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitem_esquerda = new System.Windows.Forms.ToolStripButton();
            this.menuitem_centro = new System.Windows.Forms.ToolStripButton();
            this.menuitem_direita = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 65);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(782, 393);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copirarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.desfazerToolStripMenuItem,
            this.refazerToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // copirarToolStripMenuItem
            // 
            this.copirarToolStripMenuItem.Name = "copirarToolStripMenuItem";
            this.copirarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.copirarToolStripMenuItem.Text = "Copiar";
            this.copirarToolStripMenuItem.Click += new System.EventHandler(this.copirarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.refazerToolStripMenuItem.Text = "Refazer";
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritoToolStripMenuItem,
            this.itálicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem,
            this.alinhamentoToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // negritoToolStripMenuItem
            // 
            this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            this.negritoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.negritoToolStripMenuItem.Text = "Negrito";
            this.negritoToolStripMenuItem.Click += new System.EventHandler(this.negritoToolStripMenuItem_Click);
            // 
            // itálicoToolStripMenuItem
            // 
            this.itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            this.itálicoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.itálicoToolStripMenuItem.Text = "Itálico";
            this.itálicoToolStripMenuItem.Click += new System.EventHandler(this.itálicoToolStripMenuItem_Click);
            // 
            // sublinhadoToolStripMenuItem
            // 
            this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sublinhadoToolStripMenuItem.Text = "Sublinhado";
            this.sublinhadoToolStripMenuItem.Click += new System.EventHandler(this.sublinhadoToolStripMenuItem_Click);
            // 
            // alinhamentoToolStripMenuItem
            // 
            this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centralizarToolStripMenuItem,
            this.esquerdaToolStripMenuItem,
            this.direitaToolStripMenuItem});
            this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // centralizarToolStripMenuItem
            // 
            this.centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            this.centralizarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.centralizarToolStripMenuItem.Text = "Centralizar";
            this.centralizarToolStripMenuItem.Click += new System.EventHandler(this.centralizarToolStripMenuItem_Click);
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.esquerdaToolStripMenuItem.Text = "Esquerda";
            this.esquerdaToolStripMenuItem.Click += new System.EventHandler(this.esquerdaToolStripMenuItem_Click);
            // 
            // direitaToolStripMenuItem
            // 
            this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            this.direitaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.direitaToolStripMenuItem.Text = "Direita";
            this.direitaToolStripMenuItem.Click += new System.EventHandler(this.direitaToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitem_novo,
            this.menuitem_abrir,
            this.menuitem_salvar,
            this.toolStripSeparator1,
            this.menuitem_copiar,
            this.menuitem_colar,
            this.toolStripSeparator2,
            this.menuitem_negrito,
            this.menuitem_italico,
            this.menuitem_sublinhado,
            this.menuitem_fonte,
            this.toolStripSeparator3,
            this.menuitem_esquerda,
            this.menuitem_centro,
            this.menuitem_direita});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(806, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuitem_novo
            // 
            this.menuitem_novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuitem_novo.Image = ((System.Drawing.Image)(resources.GetObject("menuitem_novo.Image")));
            this.menuitem_novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuitem_novo.Name = "menuitem_novo";
            this.menuitem_novo.Size = new System.Drawing.Size(23, 22);
            this.menuitem_novo.Text = "Novo";
            this.menuitem_novo.Click += new System.EventHandler(this.menuitem_novo_Click);
            // 
            // menuitem_abrir
            // 
            this.menuitem_abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuitem_abrir.Image = ((System.Drawing.Image)(resources.GetObject("menuitem_abrir.Image")));
            this.menuitem_abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuitem_abrir.Name = "menuitem_abrir";
            this.menuitem_abrir.Size = new System.Drawing.Size(23, 22);
            this.menuitem_abrir.Text = "Abrir";
            this.menuitem_abrir.Click += new System.EventHandler(this.menuitem_abrir_Click);
            // 
            // menuitem_salvar
            // 
            this.menuitem_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuitem_salvar.Image = ((System.Drawing.Image)(resources.GetObject("menuitem_salvar.Image")));
            this.menuitem_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuitem_salvar.Name = "menuitem_salvar";
            this.menuitem_salvar.Size = new System.Drawing.Size(23, 22);
            this.menuitem_salvar.Text = "Salvar";
            this.menuitem_salvar.Click += new System.EventHandler(this.menuitem_salvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // menuitem_copiar
            // 
            this.menuitem_copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuitem_copiar.Image = ((System.Drawing.Image)(resources.GetObject("menuitem_copiar.Image")));
            this.menuitem_copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuitem_copiar.Name = "menuitem_copiar";
            this.menuitem_copiar.Size = new System.Drawing.Size(23, 22);
            this.menuitem_copiar.Text = "Copiar";
            this.menuitem_copiar.Click += new System.EventHandler(this.menuitem_copiar_Click);
            // 
            // menuitem_colar
            // 
            this.menuitem_colar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuitem_colar.Image = ((System.Drawing.Image)(resources.GetObject("menuitem_colar.Image")));
            this.menuitem_colar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuitem_colar.Name = "menuitem_colar";
            this.menuitem_colar.Size = new System.Drawing.Size(23, 22);
            this.menuitem_colar.Text = "Colar";
            this.menuitem_colar.Click += new System.EventHandler(this.menuitem_colar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // menuitem_negrito
            // 
            this.menuitem_negrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuitem_negrito.Image = ((System.Drawing.Image)(resources.GetObject("menuitem_negrito.Image")));
            this.menuitem_negrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuitem_negrito.Name = "menuitem_negrito";
            this.menuitem_negrito.Size = new System.Drawing.Size(23, 22);
            this.menuitem_negrito.Text = "Negrito";
            this.menuitem_negrito.Click += new System.EventHandler(this.menuitem_negrito_Click);
            // 
            // menuitem_italico
            // 
            this.menuitem_italico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuitem_italico.Image = ((System.Drawing.Image)(resources.GetObject("menuitem_italico.Image")));
            this.menuitem_italico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuitem_italico.Name = "menuitem_italico";
            this.menuitem_italico.Size = new System.Drawing.Size(23, 22);
            this.menuitem_italico.Text = "Itálico";
            this.menuitem_italico.Click += new System.EventHandler(this.menuitem_italico_Click);
            // 
            // menuitem_sublinhado
            // 
            this.menuitem_sublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuitem_sublinhado.Image = ((System.Drawing.Image)(resources.GetObject("menuitem_sublinhado.Image")));
            this.menuitem_sublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuitem_sublinhado.Name = "menuitem_sublinhado";
            this.menuitem_sublinhado.Size = new System.Drawing.Size(23, 22);
            this.menuitem_sublinhado.Text = "Sublinhado";
            this.menuitem_sublinhado.Click += new System.EventHandler(this.menuitem_sublinhado_Click);
            // 
            // menuitem_fonte
            // 
            this.menuitem_fonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuitem_fonte.Image = ((System.Drawing.Image)(resources.GetObject("menuitem_fonte.Image")));
            this.menuitem_fonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuitem_fonte.Name = "menuitem_fonte";
            this.menuitem_fonte.Size = new System.Drawing.Size(23, 22);
            this.menuitem_fonte.Text = "Fonte";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // menuitem_esquerda
            // 
            this.menuitem_esquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuitem_esquerda.Image = ((System.Drawing.Image)(resources.GetObject("menuitem_esquerda.Image")));
            this.menuitem_esquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuitem_esquerda.Name = "menuitem_esquerda";
            this.menuitem_esquerda.Size = new System.Drawing.Size(23, 22);
            this.menuitem_esquerda.Text = "Esquerda";
            this.menuitem_esquerda.Click += new System.EventHandler(this.menuitem_esquerda_Click);
            // 
            // menuitem_centro
            // 
            this.menuitem_centro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuitem_centro.Image = ((System.Drawing.Image)(resources.GetObject("menuitem_centro.Image")));
            this.menuitem_centro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuitem_centro.Name = "menuitem_centro";
            this.menuitem_centro.Size = new System.Drawing.Size(23, 22);
            this.menuitem_centro.Text = "Centro";
            this.menuitem_centro.Click += new System.EventHandler(this.menuitem_centro_Click);
            // 
            // menuitem_direita
            // 
            this.menuitem_direita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuitem_direita.Image = ((System.Drawing.Image)(resources.GetObject("menuitem_direita.Image")));
            this.menuitem_direita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuitem_direita.Name = "menuitem_direita";
            this.menuitem_direita.Size = new System.Drawing.Size(23, 22);
            this.menuitem_direita.Text = "Direita";
            this.menuitem_direita.Click += new System.EventHandler(this.menuitem_direita_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "teste";
            this.saveFileDialog1.Filter = "(*.TESTE)|*.TESTE";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormEditorTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 470);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormEditorTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Texto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem copirarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripMenuItem desfazerToolStripMenuItem;
        private ToolStripMenuItem refazerToolStripMenuItem;
        private ToolStripMenuItem formatarToolStripMenuItem;
        private ToolStripMenuItem negritoToolStripMenuItem;
        private ToolStripMenuItem itálicoToolStripMenuItem;
        private ToolStripMenuItem sublinhadoToolStripMenuItem;
        private ToolStripMenuItem alinhamentoToolStripMenuItem;
        private ToolStripMenuItem centralizarToolStripMenuItem;
        private ToolStripMenuItem esquerdaToolStripMenuItem;
        private ToolStripMenuItem direitaToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton menuitem_novo;
        private ToolStripButton menuitem_abrir;
        private ToolStripButton menuitem_salvar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton menuitem_copiar;
        private ToolStripButton menuitem_colar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton menuitem_negrito;
        private ToolStripButton menuitem_italico;
        private ToolStripButton menuitem_sublinhado;
        private ToolStripButton menuitem_fonte;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton menuitem_esquerda;
        private ToolStripButton menuitem_centro;
        private ToolStripButton menuitem_direita;
        private FontDialog fontDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}