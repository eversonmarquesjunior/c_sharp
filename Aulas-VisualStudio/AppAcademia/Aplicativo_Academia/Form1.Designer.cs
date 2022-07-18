namespace Aplicativo_Academia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_nomeuser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_acesso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_statuslog = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aLUNOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUÁRIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANUTENÇÃOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_statuslog)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label_nomeuser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label_acesso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pb_statuslog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 28);
            this.panel1.TabIndex = 0;
            // 
            // label_nomeuser
            // 
            this.label_nomeuser.AutoSize = true;
            this.label_nomeuser.Location = new System.Drawing.Point(245, 6);
            this.label_nomeuser.Name = "label_nomeuser";
            this.label_nomeuser.Size = new System.Drawing.Size(22, 15);
            this.label_nomeuser.TabIndex = 4;
            this.label_nomeuser.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuário Logado:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_acesso
            // 
            this.label_acesso.AutoSize = true;
            this.label_acesso.Location = new System.Drawing.Point(127, 6);
            this.label_acesso.Name = "label_acesso";
            this.label_acesso.Size = new System.Drawing.Size(13, 15);
            this.label_acesso.TabIndex = 2;
            this.label_acesso.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nível de Acesso:";
            // 
            // pb_statuslog
            // 
            this.pb_statuslog.Image = global::Aplicativo_Academia.Properties.Resources.botaovermelho;
            this.pb_statuslog.Location = new System.Drawing.Point(3, 3);
            this.pb_statuslog.Name = "pb_statuslog";
            this.pb_statuslog.Size = new System.Drawing.Size(20, 20);
            this.pb_statuslog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_statuslog.TabIndex = 0;
            this.pb_statuslog.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLUNOSToolStripMenuItem,
            this.uSUÁRIOSToolStripMenuItem,
            this.mANUTENÇÃOToolStripMenuItem,
            this.lOGINToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aLUNOSToolStripMenuItem
            // 
            this.aLUNOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoAlunoToolStripMenuItem});
            this.aLUNOSToolStripMenuItem.Name = "aLUNOSToolStripMenuItem";
            this.aLUNOSToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.aLUNOSToolStripMenuItem.Text = "ALUNOS";
            // 
            // novoAlunoToolStripMenuItem
            // 
            this.novoAlunoToolStripMenuItem.Name = "novoAlunoToolStripMenuItem";
            this.novoAlunoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.novoAlunoToolStripMenuItem.Text = "Novo Aluno";
            this.novoAlunoToolStripMenuItem.Click += new System.EventHandler(this.novoAlunoToolStripMenuItem_Click);
            // 
            // uSUÁRIOSToolStripMenuItem
            // 
            this.uSUÁRIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUsuárioToolStripMenuItem,
            this.gestãoDeUsuáriosToolStripMenuItem});
            this.uSUÁRIOSToolStripMenuItem.Name = "uSUÁRIOSToolStripMenuItem";
            this.uSUÁRIOSToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.uSUÁRIOSToolStripMenuItem.Text = "USUÁRIOS";
            // 
            // novoUsuárioToolStripMenuItem
            // 
            this.novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            this.novoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.novoUsuárioToolStripMenuItem.Text = "Novo Usuário";
            this.novoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.novoUsuárioToolStripMenuItem_Click);
            // 
            // gestãoDeUsuáriosToolStripMenuItem
            // 
            this.gestãoDeUsuáriosToolStripMenuItem.Name = "gestãoDeUsuáriosToolStripMenuItem";
            this.gestãoDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gestãoDeUsuáriosToolStripMenuItem.Text = "Gestão de Usuários";
            this.gestãoDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeUsuáriosToolStripMenuItem_Click);
            // 
            // mANUTENÇÃOToolStripMenuItem
            // 
            this.mANUTENÇÃOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoDeDadosToolStripMenuItem});
            this.mANUTENÇÃOToolStripMenuItem.Name = "mANUTENÇÃOToolStripMenuItem";
            this.mANUTENÇÃOToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mANUTENÇÃOToolStripMenuItem.Text = "MANUTENÇÃO";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de Dados";
            this.bancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.bancoDeDadosToolStripMenuItem_Click);
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            // 
            // entrarToolStripMenuItem
            // 
            this.entrarToolStripMenuItem.Name = "entrarToolStripMenuItem";
            this.entrarToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.entrarToolStripMenuItem.Text = "Entrar";
            this.entrarToolStripMenuItem.Click += new System.EventHandler(this.entrarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppAcademia - v1.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_statuslog)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        public PictureBox pb_statuslog;
        public Label label_acesso;
        public Label label_nomeuser;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem lOGINToolStripMenuItem;
        private ToolStripMenuItem entrarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem aLUNOSToolStripMenuItem;
        private ToolStripMenuItem novoAlunoToolStripMenuItem;
        private ToolStripMenuItem uSUÁRIOSToolStripMenuItem;
        private ToolStripMenuItem novoUsuárioToolStripMenuItem;
        private ToolStripMenuItem gestãoDeUsuáriosToolStripMenuItem;
        private ToolStripMenuItem mANUTENÇÃOToolStripMenuItem;
        private ToolStripMenuItem bancoDeDadosToolStripMenuItem;
    }
}