namespace Aplicativo_Academia
{
    partial class FormHorarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_id = new System.Windows.Forms.TextBox();
            this.datagrid_horarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.mtbox_horario = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_horarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // tbox_id
            // 
            this.tbox_id.BackColor = System.Drawing.SystemColors.Window;
            this.tbox_id.Location = new System.Drawing.Point(12, 24);
            this.tbox_id.Name = "tbox_id";
            this.tbox_id.ReadOnly = true;
            this.tbox_id.Size = new System.Drawing.Size(49, 23);
            this.tbox_id.TabIndex = 1;
            this.tbox_id.TabStop = false;
            // 
            // datagrid_horarios
            // 
            this.datagrid_horarios.AllowUserToAddRows = false;
            this.datagrid_horarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_horarios.EnableHeadersVisualStyles = false;
            this.datagrid_horarios.Location = new System.Drawing.Point(7, 52);
            this.datagrid_horarios.MultiSelect = false;
            this.datagrid_horarios.Name = "datagrid_horarios";
            this.datagrid_horarios.ReadOnly = true;
            this.datagrid_horarios.RowHeadersVisible = false;
            this.datagrid_horarios.RowTemplate.Height = 25;
            this.datagrid_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_horarios.Size = new System.Drawing.Size(348, 338);
            this.datagrid_horarios.TabIndex = 2;
            this.datagrid_horarios.SelectionChanged += new System.EventHandler(this.datagrid_horarios_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_excluir);
            this.panel1.Controls.Add(this.bt_salvar);
            this.panel1.Controls.Add(this.bt_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 35);
            this.panel1.TabIndex = 3;
            // 
            // bt_excluir
            // 
            this.bt_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_excluir.Location = new System.Drawing.Point(239, 4);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(113, 23);
            this.bt_excluir.TabIndex = 2;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = false;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_salvar.Location = new System.Drawing.Point(123, 4);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(113, 23);
            this.bt_salvar.TabIndex = 1;
            this.bt_salvar.Text = "Salvar ";
            this.bt_salvar.UseVisualStyleBackColor = false;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add.Location = new System.Drawing.Point(7, 4);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(113, 23);
            this.bt_add.TabIndex = 0;
            this.bt_add.Text = "Adicionar Horário";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // mtbox_horario
            // 
            this.mtbox_horario.Location = new System.Drawing.Point(67, 24);
            this.mtbox_horario.Mask = "99:99 \\às 99:99";
            this.mtbox_horario.Name = "mtbox_horario";
            this.mtbox_horario.Size = new System.Drawing.Size(100, 23);
            this.mtbox_horario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Horário";
            // 
            // FormHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 426);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbox_horario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datagrid_horarios);
            this.Controls.Add(this.tbox_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horários";
            this.Load += new System.EventHandler(this.FormHorarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_horarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbox_id;
        private DataGridView datagrid_horarios;
        private Panel panel1;
        private Button bt_excluir;
        private Button bt_salvar;
        private Button bt_add;
        private MaskedTextBox mtbox_horario;
        private Label label2;
    }
}