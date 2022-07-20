namespace Aplicativo_Academia
{
    partial class FormProfessores
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
            this.label2 = new System.Windows.Forms.Label();
            this.mtbox_tel = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_excluirprof = new System.Windows.Forms.Button();
            this.bt_salvarprof = new System.Windows.Forms.Button();
            this.bt_addprof = new System.Windows.Forms.Button();
            this.tbox_idprof = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_nomeprof = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datagrid_professores = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_professores)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Telefone";
            // 
            // mtbox_tel
            // 
            this.mtbox_tel.Location = new System.Drawing.Point(261, 20);
            this.mtbox_tel.Mask = "(99) 00000-0000";
            this.mtbox_tel.Name = "mtbox_tel";
            this.mtbox_tel.Size = new System.Drawing.Size(105, 23);
            this.mtbox_tel.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_excluirprof);
            this.panel1.Controls.Add(this.bt_salvarprof);
            this.panel1.Controls.Add(this.bt_addprof);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 35);
            this.panel1.TabIndex = 9;
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
            this.bt_excluirprof.Text = "Excluir ";
            this.bt_excluirprof.UseVisualStyleBackColor = false;
            this.bt_excluirprof.Click += new System.EventHandler(this.bt_excluirprof_Click);
            // 
            // bt_salvarprof
            // 
            this.bt_salvarprof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_salvarprof.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_salvarprof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_salvarprof.Location = new System.Drawing.Point(134, 4);
            this.bt_salvarprof.Name = "bt_salvarprof";
            this.bt_salvarprof.Size = new System.Drawing.Size(113, 23);
            this.bt_salvarprof.TabIndex = 1;
            this.bt_salvarprof.Text = "Salvar";
            this.bt_salvarprof.UseVisualStyleBackColor = false;
            this.bt_salvarprof.Click += new System.EventHandler(this.bt_salvarprof_Click);
            // 
            // bt_addprof
            // 
            this.bt_addprof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_addprof.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_addprof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_addprof.Location = new System.Drawing.Point(7, 4);
            this.bt_addprof.Name = "bt_addprof";
            this.bt_addprof.Size = new System.Drawing.Size(121, 23);
            this.bt_addprof.TabIndex = 0;
            this.bt_addprof.Text = "Adicionar Professor";
            this.bt_addprof.UseVisualStyleBackColor = false;
            this.bt_addprof.Click += new System.EventHandler(this.bt_addprof_Click);
            // 
            // tbox_idprof
            // 
            this.tbox_idprof.BackColor = System.Drawing.SystemColors.Window;
            this.tbox_idprof.Location = new System.Drawing.Point(7, 20);
            this.tbox_idprof.Name = "tbox_idprof";
            this.tbox_idprof.ReadOnly = true;
            this.tbox_idprof.Size = new System.Drawing.Size(49, 23);
            this.tbox_idprof.TabIndex = 7;
            this.tbox_idprof.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // tbox_nomeprof
            // 
            this.tbox_nomeprof.Location = new System.Drawing.Point(62, 20);
            this.tbox_nomeprof.Name = "tbox_nomeprof";
            this.tbox_nomeprof.Size = new System.Drawing.Size(193, 23);
            this.tbox_nomeprof.TabIndex = 12;
            this.tbox_nomeprof.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Professor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // datagrid_professores
            // 
            this.datagrid_professores.AllowUserToAddRows = false;
            this.datagrid_professores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_professores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_professores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_professores.EnableHeadersVisualStyles = false;
            this.datagrid_professores.Location = new System.Drawing.Point(7, 49);
            this.datagrid_professores.MultiSelect = false;
            this.datagrid_professores.Name = "datagrid_professores";
            this.datagrid_professores.ReadOnly = true;
            this.datagrid_professores.RowHeadersVisible = false;
            this.datagrid_professores.RowTemplate.Height = 25;
            this.datagrid_professores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_professores.Size = new System.Drawing.Size(359, 408);
            this.datagrid_professores.TabIndex = 14;
            this.datagrid_professores.SelectionChanged += new System.EventHandler(this.datagrid_professores_SelectionChanged_1);
            // 
            // FormProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 494);
            this.Controls.Add(this.datagrid_professores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox_nomeprof);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbox_tel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbox_idprof);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Professores";
            this.Load += new System.EventHandler(this.FormProfessores_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_professores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private MaskedTextBox mtbox_tel;
        private Panel panel1;
        private Button bt_excluirprof;
        private Button bt_salvarprof;
        private Button bt_addprof;
        private TextBox tbox_idprof;
        private Label label1;
        private TextBox tbox_nomeprof;
        private Label label3;
        private DataGridView datagrid_professores;
    }
}