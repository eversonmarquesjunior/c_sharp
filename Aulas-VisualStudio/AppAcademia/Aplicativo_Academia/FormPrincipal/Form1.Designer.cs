namespace Aplicativo_Academia
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_nomeuser = new System.Windows.Forms.Label();
            this.label_acesso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_statuslog = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panel1.Controls.Add(this.label_acesso);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pb_statuslog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 31);
            this.panel1.TabIndex = 0;
            // 
            // label_nomeuser
            // 
            this.label_nomeuser.AutoSize = true;
            this.label_nomeuser.Location = new System.Drawing.Point(204, 9);
            this.label_nomeuser.Name = "label_nomeuser";
            this.label_nomeuser.Size = new System.Drawing.Size(22, 15);
            this.label_nomeuser.TabIndex = 4;
            this.label_nomeuser.Text = "---";
            // 
            // label_acesso
            // 
            this.label_acesso.AutoSize = true;
            this.label_acesso.Location = new System.Drawing.Point(127, 9);
            this.label_acesso.Name = "label_acesso";
            this.label_acesso.Size = new System.Drawing.Size(13, 15);
            this.label_acesso.TabIndex = 3;
            this.label_acesso.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nível de Acesso:";
            // 
            // pb_statuslog
            // 
            this.pb_statuslog.Image = global::Aplicativo_Academia.Properties.Resources.botaovermelho;
            this.pb_statuslog.Location = new System.Drawing.Point(4, 4);
            this.pb_statuslog.Name = "pb_statuslog";
            this.pb_statuslog.Size = new System.Drawing.Size(24, 23);
            this.pb_statuslog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_statuslog.TabIndex = 0;
            this.pb_statuslog.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.usuárioToolStripMenuItem,
            this.manutençãoToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(531, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoAlunoToolStripMenuItem,
            this.gestãoAlunoToolStripMenuItem});
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.alunosToolStripMenuItem.Text = "Alunos";
            // 
            // novoAlunoToolStripMenuItem
            // 
            this.novoAlunoToolStripMenuItem.Name = "novoAlunoToolStripMenuItem";
            this.novoAlunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoAlunoToolStripMenuItem.Text = "Novo Aluno";
            this.novoAlunoToolStripMenuItem.Click += new System.EventHandler(this.novoAlunoToolStripMenuItem_Click_1);
            // 
            // gestãoAlunoToolStripMenuItem
            // 
            this.gestãoAlunoToolStripMenuItem.Name = "gestãoAlunoToolStripMenuItem";
            this.gestãoAlunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestãoAlunoToolStripMenuItem.Text = "Gestão Alunos";
            this.gestãoAlunoToolStripMenuItem.Click += new System.EventHandler(this.gestãoAlunoToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUsuárioToolStripMenuItem,
            this.gestãoDeUsuáriosToolStripMenuItem});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // novoUsuárioToolStripMenuItem
            // 
            this.novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            this.novoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoUsuárioToolStripMenuItem.Text = "Novo Usuário";
            this.novoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.novoUsuárioToolStripMenuItem_Click_1);
            // 
            // gestãoDeUsuáriosToolStripMenuItem
            // 
            this.gestãoDeUsuáriosToolStripMenuItem.Name = "gestãoDeUsuáriosToolStripMenuItem";
            this.gestãoDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestãoDeUsuáriosToolStripMenuItem.Text = "Gestão de Usuários";
            this.gestãoDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeUsuáriosToolStripMenuItem_Click_1);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoDeDadosToolStripMenuItem,
            this.horáriosToolStripMenuItem,
            this.professoresToolStripMenuItem,
            this.turmasToolStripMenuItem});
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de Dados";
            this.bancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.bancoDeDadosToolStripMenuItem_Click_1);
            // 
            // horáriosToolStripMenuItem
            // 
            this.horáriosToolStripMenuItem.Name = "horáriosToolStripMenuItem";
            this.horáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horáriosToolStripMenuItem.Text = "Horários";
            this.horáriosToolStripMenuItem.Click += new System.EventHandler(this.horáriosToolStripMenuItem_Click_1);
            // 
            // professoresToolStripMenuItem
            // 
            this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            this.professoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.professoresToolStripMenuItem.Text = "Professores";
            this.professoresToolStripMenuItem.Click += new System.EventHandler(this.professoresToolStripMenuItem_Click_1);
            // 
            // turmasToolStripMenuItem
            // 
            this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            this.turmasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.turmasToolStripMenuItem.Text = "Turmas";
            this.turmasToolStripMenuItem.Click += new System.EventHandler(this.turmasToolStripMenuItem_Click_1);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // entrarToolStripMenuItem
            // 
            this.entrarToolStripMenuItem.Name = "entrarToolStripMenuItem";
            this.entrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entrarToolStripMenuItem.Text = "Entrar";
            this.entrarToolStripMenuItem.Click += new System.EventHandler(this.entrarToolStripMenuItem_Click_1);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 405);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppAcademia";
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
        public Label label_nomeuser;
        public Label label_acesso;
        public PictureBox pb_statuslog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem alunosToolStripMenuItem;
        private ToolStripMenuItem novoAlunoToolStripMenuItem;
        private ToolStripMenuItem gestãoAlunoToolStripMenuItem;
        private ToolStripMenuItem usuárioToolStripMenuItem;
        private ToolStripMenuItem novoUsuárioToolStripMenuItem;
        private ToolStripMenuItem gestãoDeUsuáriosToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem entrarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem manutençãoToolStripMenuItem;
        private ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private ToolStripMenuItem horáriosToolStripMenuItem;
        private ToolStripMenuItem professoresToolStripMenuItem;
        private ToolStripMenuItem turmasToolStripMenuItem;
    }
}