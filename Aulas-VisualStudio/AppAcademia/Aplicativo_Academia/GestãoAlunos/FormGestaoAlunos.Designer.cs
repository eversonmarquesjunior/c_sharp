namespace Aplicativo_Academia
{
    partial class FormGestaoAlunos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagrid_alunos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbox_telaluno = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_nomealuno = new System.Windows.Forms.TextBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_turmas = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.bt_financeiro = new System.Windows.Forms.Button();
            this.bt_salvaraluno = new System.Windows.Forms.Button();
            this.bt_excluiraluno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_alunos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagrid_alunos
            // 
            this.datagrid_alunos.AllowUserToAddRows = false;
            this.datagrid_alunos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_alunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_alunos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datagrid_alunos.EnableHeadersVisualStyles = false;
            this.datagrid_alunos.Location = new System.Drawing.Point(12, 12);
            this.datagrid_alunos.Name = "datagrid_alunos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_alunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_alunos.RowHeadersVisible = false;
            this.datagrid_alunos.RowTemplate.Height = 25;
            this.datagrid_alunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_alunos.Size = new System.Drawing.Size(291, 429);
            this.datagrid_alunos.TabIndex = 1;
            this.datagrid_alunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_alunos_CellContentClick);
            this.datagrid_alunos.SelectionChanged += new System.EventHandler(this.datagrid_alunos_SelectionChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 56;
            this.label7.Text = "Telefone";
            // 
            // mtbox_telaluno
            // 
            this.mtbox_telaluno.Location = new System.Drawing.Point(472, 37);
            this.mtbox_telaluno.Mask = "(99) 00000-0000";
            this.mtbox_telaluno.Name = "mtbox_telaluno";
            this.mtbox_telaluno.Size = new System.Drawing.Size(139, 23);
            this.mtbox_telaluno.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 54;
            this.label5.Text = "Nome";
            // 
            // tbox_nomealuno
            // 
            this.tbox_nomealuno.Location = new System.Drawing.Point(309, 37);
            this.tbox_nomealuno.Name = "tbox_nomealuno";
            this.tbox_nomealuno.Size = new System.Drawing.Size(157, 23);
            this.tbox_nomealuno.TabIndex = 49;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(309, 88);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(105, 23);
            this.cb_status.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 51;
            this.label3.Text = "Turmas";
            // 
            // cb_turmas
            // 
            this.cb_turmas.FormattingEnabled = true;
            this.cb_turmas.Location = new System.Drawing.Point(420, 88);
            this.cb_turmas.Name = "cb_turmas";
            this.cb_turmas.Size = new System.Drawing.Size(191, 23);
            this.cb_turmas.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_fechar);
            this.panel1.Controls.Add(this.bt_financeiro);
            this.panel1.Controls.Add(this.bt_salvaraluno);
            this.panel1.Controls.Add(this.bt_excluiraluno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 35);
            this.panel1.TabIndex = 58;
            // 
            // bt_fechar
            // 
            this.bt_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fechar.Location = new System.Drawing.Point(432, 6);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(179, 23);
            this.bt_fechar.TabIndex = 4;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = false;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // bt_financeiro
            // 
            this.bt_financeiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_financeiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_financeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_financeiro.Location = new System.Drawing.Point(289, 6);
            this.bt_financeiro.Name = "bt_financeiro";
            this.bt_financeiro.Size = new System.Drawing.Size(137, 23);
            this.bt_financeiro.TabIndex = 2;
            this.bt_financeiro.Text = "Financeiro";
            this.bt_financeiro.UseVisualStyleBackColor = false;
            // 
            // bt_salvaraluno
            // 
            this.bt_salvaraluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_salvaraluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_salvaraluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_salvaraluno.Location = new System.Drawing.Point(3, 6);
            this.bt_salvaraluno.Name = "bt_salvaraluno";
            this.bt_salvaraluno.Size = new System.Drawing.Size(137, 23);
            this.bt_salvaraluno.TabIndex = 0;
            this.bt_salvaraluno.Text = "Salvar Edições";
            this.bt_salvaraluno.UseVisualStyleBackColor = false;
            this.bt_salvaraluno.Click += new System.EventHandler(this.bt_salvaraluno_Click);
            // 
            // bt_excluiraluno
            // 
            this.bt_excluiraluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_excluiraluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_excluiraluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_excluiraluno.Location = new System.Drawing.Point(146, 6);
            this.bt_excluiraluno.Name = "bt_excluiraluno";
            this.bt_excluiraluno.Size = new System.Drawing.Size(137, 23);
            this.bt_excluiraluno.TabIndex = 1;
            this.bt_excluiraluno.Text = "Excluir Aluno";
            this.bt_excluiraluno.UseVisualStyleBackColor = false;
            this.bt_excluiraluno.Click += new System.EventHandler(this.bt_excluiraluno_Click);
            // 
            // FormGestaoAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_turmas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtbox_telaluno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbox_nomealuno);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datagrid_alunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGestaoAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGestaoAlunos";
            this.Load += new System.EventHandler(this.FormGestaoAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_alunos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView datagrid_alunos;
        private Label label7;
        private MaskedTextBox mtbox_telaluno;
        private Label label5;
        private TextBox tbox_nomealuno;
        private ComboBox cb_status;
        private Label label2;
        private Label label3;
        private ComboBox cb_turmas;
        private Panel panel1;
        private Button bt_fechar;
        private Button bt_excluiraluno;
        private Button bt_salvaraluno;
        private Button bt_financeiro;
    }
}