namespace Aplicativo_Academia
{
    partial class FormNovoAluno
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_nomealuno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbox_telaluno = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.bt_salvaraluno = new System.Windows.Forms.Button();
            this.bt_novoaluno = new System.Windows.Forms.Button();
            this.bt_cancelaraluno = new System.Windows.Forms.Button();
            this.tbox_turma = new System.Windows.Forms.TextBox();
            this.tbox_plano = new System.Windows.Forms.TextBox();
            this.bt_selturma = new System.Windows.Forms.Button();
            this.bt_selplano = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "Nome";
            // 
            // tbox_nomealuno
            // 
            this.tbox_nomealuno.Enabled = false;
            this.tbox_nomealuno.Location = new System.Drawing.Point(12, 24);
            this.tbox_nomealuno.Name = "tbox_nomealuno";
            this.tbox_nomealuno.Size = new System.Drawing.Size(260, 23);
            this.tbox_nomealuno.TabIndex = 33;
            this.tbox_nomealuno.TextChanged += new System.EventHandler(this.tbox_nomealuno_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Plano";
            // 
            // cb_status
            // 
            this.cb_status.Enabled = false;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(12, 75);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(105, 23);
            this.cb_status.TabIndex = 36;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 46;
            this.label7.Text = "Telefone";
            // 
            // mtbox_telaluno
            // 
            this.mtbox_telaluno.Enabled = false;
            this.mtbox_telaluno.Location = new System.Drawing.Point(278, 24);
            this.mtbox_telaluno.Mask = "(99) 00000-0000";
            this.mtbox_telaluno.Name = "mtbox_telaluno";
            this.mtbox_telaluno.Size = new System.Drawing.Size(105, 23);
            this.mtbox_telaluno.TabIndex = 45;
            this.mtbox_telaluno.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbox_telaluno_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Turma";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_fechar);
            this.panel1.Controls.Add(this.bt_salvaraluno);
            this.panel1.Controls.Add(this.bt_novoaluno);
            this.panel1.Controls.Add(this.bt_cancelaraluno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 35);
            this.panel1.TabIndex = 47;
            // 
            // bt_fechar
            // 
            this.bt_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fechar.Location = new System.Drawing.Point(246, 6);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(137, 23);
            this.bt_fechar.TabIndex = 4;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = false;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // bt_salvaraluno
            // 
            this.bt_salvaraluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_salvaraluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_salvaraluno.Enabled = false;
            this.bt_salvaraluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_salvaraluno.Location = new System.Drawing.Point(84, 6);
            this.bt_salvaraluno.Name = "bt_salvaraluno";
            this.bt_salvaraluno.Size = new System.Drawing.Size(75, 23);
            this.bt_salvaraluno.TabIndex = 1;
            this.bt_salvaraluno.Text = "Salvar ";
            this.bt_salvaraluno.UseVisualStyleBackColor = false;
            this.bt_salvaraluno.Click += new System.EventHandler(this.bt_salvaraluno_Click);
            // 
            // bt_novoaluno
            // 
            this.bt_novoaluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_novoaluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_novoaluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_novoaluno.Location = new System.Drawing.Point(3, 6);
            this.bt_novoaluno.Name = "bt_novoaluno";
            this.bt_novoaluno.Size = new System.Drawing.Size(75, 23);
            this.bt_novoaluno.TabIndex = 0;
            this.bt_novoaluno.Text = "Novo";
            this.bt_novoaluno.UseVisualStyleBackColor = false;
            this.bt_novoaluno.Click += new System.EventHandler(this.bt_novoaluno_Click);
            // 
            // bt_cancelaraluno
            // 
            this.bt_cancelaraluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_cancelaraluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancelaraluno.Enabled = false;
            this.bt_cancelaraluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelaraluno.Location = new System.Drawing.Point(165, 6);
            this.bt_cancelaraluno.Name = "bt_cancelaraluno";
            this.bt_cancelaraluno.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelaraluno.TabIndex = 2;
            this.bt_cancelaraluno.Text = "Cancelar";
            this.bt_cancelaraluno.UseVisualStyleBackColor = false;
            this.bt_cancelaraluno.Click += new System.EventHandler(this.bt_cancelaraluno_Click);
            // 
            // tbox_turma
            // 
            this.tbox_turma.Location = new System.Drawing.Point(123, 75);
            this.tbox_turma.Name = "tbox_turma";
            this.tbox_turma.ReadOnly = true;
            this.tbox_turma.Size = new System.Drawing.Size(241, 23);
            this.tbox_turma.TabIndex = 48;
            this.tbox_turma.Tag = "11";
            // 
            // tbox_plano
            // 
            this.tbox_plano.Location = new System.Drawing.Point(12, 133);
            this.tbox_plano.Name = "tbox_plano";
            this.tbox_plano.ReadOnly = true;
            this.tbox_plano.Size = new System.Drawing.Size(186, 23);
            this.tbox_plano.TabIndex = 49;
            // 
            // bt_selturma
            // 
            this.bt_selturma.Location = new System.Drawing.Point(358, 75);
            this.bt_selturma.Name = "bt_selturma";
            this.bt_selturma.Size = new System.Drawing.Size(25, 23);
            this.bt_selturma.TabIndex = 50;
            this.bt_selturma.Text = "...";
            this.bt_selturma.UseVisualStyleBackColor = true;
            this.bt_selturma.Click += new System.EventHandler(this.bt_selturma_Click);
            // 
            // bt_selplano
            // 
            this.bt_selplano.Location = new System.Drawing.Point(195, 133);
            this.bt_selplano.Name = "bt_selplano";
            this.bt_selplano.Size = new System.Drawing.Size(25, 23);
            this.bt_selplano.TabIndex = 51;
            this.bt_selplano.Text = "...";
            this.bt_selplano.UseVisualStyleBackColor = true;
            // 
            // FormNovoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 209);
            this.Controls.Add(this.bt_selplano);
            this.Controls.Add(this.bt_selturma);
            this.Controls.Add(this.tbox_plano);
            this.Controls.Add(this.tbox_turma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtbox_telaluno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbox_nomealuno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNovoAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Aluno";
            this.Load += new System.EventHandler(this.FormNovoAluno_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label5;
        private TextBox tbox_nomealuno;
        private Label label4;
        private ComboBox cb_status;
        private Label label2;
        private Label label7;
        private MaskedTextBox mtbox_telaluno;
        private Label label3;
        private Panel panel1;
        private Button bt_fechar;
        private Button bt_salvaraluno;
        private Button bt_novoaluno;
        private Button bt_cancelaraluno;
        private TextBox tbox_plano;
        private Button bt_selturma;
        private Button bt_selplano;
        public TextBox tbox_turma;
    }
}