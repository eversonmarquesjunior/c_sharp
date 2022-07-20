namespace Aplicativo_Academia
{
    partial class FormTurmas
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
            this.datagrid_turmas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.bt_imprimir = new System.Windows.Forms.Button();
            this.bt_excluirprof = new System.Windows.Forms.Button();
            this.bt_salvarturma = new System.Windows.Forms.Button();
            this.bt_addturma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numeric_maxalunos = new System.Windows.Forms.NumericUpDown();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.cb_horarios = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_prof = new System.Windows.Forms.ComboBox();
            this.tbox_dscturma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_turmas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_maxalunos)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_turmas
            // 
            this.datagrid_turmas.AllowUserToAddRows = false;
            this.datagrid_turmas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_turmas.EnableHeadersVisualStyles = false;
            this.datagrid_turmas.Location = new System.Drawing.Point(7, 12);
            this.datagrid_turmas.MultiSelect = false;
            this.datagrid_turmas.Name = "datagrid_turmas";
            this.datagrid_turmas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_turmas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_turmas.RowHeadersVisible = false;
            this.datagrid_turmas.RowTemplate.Height = 25;
            this.datagrid_turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_turmas.Size = new System.Drawing.Size(359, 410);
            this.datagrid_turmas.TabIndex = 22;
            this.datagrid_turmas.SelectionChanged += new System.EventHandler(this.datagrid_turmas_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Professor";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_fechar);
            this.panel1.Controls.Add(this.bt_imprimir);
            this.panel1.Controls.Add(this.bt_excluirprof);
            this.panel1.Controls.Add(this.bt_salvarturma);
            this.panel1.Controls.Add(this.bt_addturma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 35);
            this.panel1.TabIndex = 17;
            // 
            // bt_fechar
            // 
            this.bt_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fechar.Location = new System.Drawing.Point(491, 4);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(113, 23);
            this.bt_fechar.TabIndex = 4;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = false;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // bt_imprimir
            // 
            this.bt_imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_imprimir.Location = new System.Drawing.Point(372, 4);
            this.bt_imprimir.Name = "bt_imprimir";
            this.bt_imprimir.Size = new System.Drawing.Size(113, 23);
            this.bt_imprimir.TabIndex = 3;
            this.bt_imprimir.Text = " Imprimir Turma";
            this.bt_imprimir.UseVisualStyleBackColor = false;
            // 
            // bt_excluirprof
            // 
            this.bt_excluirprof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_excluirprof.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_excluirprof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_excluirprof.Location = new System.Drawing.Point(253, 4);
            this.bt_excluirprof.Name = "bt_excluirprof";
            this.bt_excluirprof.Size = new System.Drawing.Size(113, 23);
            this.bt_excluirprof.TabIndex = 2;
            this.bt_excluirprof.Text = "Excluir Turma";
            this.bt_excluirprof.UseVisualStyleBackColor = false;
            // 
            // bt_salvarturma
            // 
            this.bt_salvarturma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_salvarturma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_salvarturma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_salvarturma.Location = new System.Drawing.Point(134, 4);
            this.bt_salvarturma.Name = "bt_salvarturma";
            this.bt_salvarturma.Size = new System.Drawing.Size(113, 23);
            this.bt_salvarturma.TabIndex = 1;
            this.bt_salvarturma.Text = "Salvar Edições";
            this.bt_salvarturma.UseVisualStyleBackColor = false;
            // 
            // bt_addturma
            // 
            this.bt_addturma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_addturma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_addturma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_addturma.Location = new System.Drawing.Point(7, 4);
            this.bt_addturma.Name = "bt_addturma";
            this.bt_addturma.Size = new System.Drawing.Size(121, 23);
            this.bt_addturma.TabIndex = 0;
            this.bt_addturma.Text = "Adicionar Turma";
            this.bt_addturma.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Máximo Alunos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Status";
            // 
            // numeric_maxalunos
            // 
            this.numeric_maxalunos.Location = new System.Drawing.Point(372, 139);
            this.numeric_maxalunos.Name = "numeric_maxalunos";
            this.numeric_maxalunos.Size = new System.Drawing.Size(120, 23);
            this.numeric_maxalunos.TabIndex = 3;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(498, 139);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(106, 23);
            this.cb_status.TabIndex = 4;
            // 
            // cb_horarios
            // 
            this.cb_horarios.FormattingEnabled = true;
            this.cb_horarios.Location = new System.Drawing.Point(372, 197);
            this.cb_horarios.Name = "cb_horarios";
            this.cb_horarios.Size = new System.Drawing.Size(232, 23);
            this.cb_horarios.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Horários";
            // 
            // cb_prof
            // 
            this.cb_prof.FormattingEnabled = true;
            this.cb_prof.Location = new System.Drawing.Point(372, 82);
            this.cb_prof.Name = "cb_prof";
            this.cb_prof.Size = new System.Drawing.Size(232, 23);
            this.cb_prof.TabIndex = 2;
            // 
            // tbox_dscturma
            // 
            this.tbox_dscturma.Location = new System.Drawing.Point(372, 28);
            this.tbox_dscturma.Name = "tbox_dscturma";
            this.tbox_dscturma.Size = new System.Drawing.Size(232, 23);
            this.tbox_dscturma.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nome Turma";
            // 
            // FormTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 463);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbox_dscturma);
            this.Controls.Add(this.cb_prof);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_horarios);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.numeric_maxalunos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagrid_turmas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Turmas";
            this.Load += new System.EventHandler(this.FormTurmas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_turmas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_maxalunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView datagrid_turmas;
        private Label label3;
        private Panel panel1;
        private Button bt_excluirprof;
        private Button bt_salvarturma;
        private Button bt_addturma;
        private Label label1;
        private Label label2;
        private NumericUpDown numeric_maxalunos;
        private ComboBox cb_status;
        private ComboBox cb_horarios;
        private Label label4;
        private Button bt_fechar;
        private Button bt_imprimir;
        private ComboBox cb_prof;
        private TextBox tbox_dscturma;
        private Label label5;
    }
}