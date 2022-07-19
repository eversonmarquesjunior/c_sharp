namespace Aplicativo_Academia
{
    partial class FormGestaoUsuarios
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numeric_nivel = new System.Windows.Forms.NumericUpDown();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.tbox_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.bt_excluiruser = new System.Windows.Forms.Button();
            this.bt_salvaralt = new System.Windows.Forms.Button();
            this.bt_novouser = new System.Windows.Forms.Button();
            this.datagrid_usuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_nivel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "D -> Desligado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "B -> Bloqueado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "A -> Ativo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nível";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Status";
            // 
            // numeric_nivel
            // 
            this.numeric_nivel.Location = new System.Drawing.Point(118, 166);
            this.numeric_nivel.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numeric_nivel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_nivel.Name = "numeric_nivel";
            this.numeric_nivel.Size = new System.Drawing.Size(100, 23);
            this.numeric_nivel.TabIndex = 20;
            this.numeric_nivel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.cb_status.Location = new System.Drawing.Point(12, 165);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(100, 23);
            this.cb_status.TabIndex = 19;
            // 
            // tbox_username
            // 
            this.tbox_username.Location = new System.Drawing.Point(12, 122);
            this.tbox_username.Name = "tbox_username";
            this.tbox_username.Size = new System.Drawing.Size(100, 23);
            this.tbox_username.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Senha";
            // 
            // tbox_senha
            // 
            this.tbox_senha.Location = new System.Drawing.Point(118, 122);
            this.tbox_senha.Name = "tbox_senha";
            this.tbox_senha.Size = new System.Drawing.Size(100, 23);
            this.tbox_senha.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Username";
            // 
            // tbox_nome
            // 
            this.tbox_nome.Location = new System.Drawing.Point(12, 76);
            this.tbox_nome.Name = "tbox_nome";
            this.tbox_nome.Size = new System.Drawing.Size(206, 23);
            this.tbox_nome.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            // 
            // tbox_id
            // 
            this.tbox_id.BackColor = System.Drawing.SystemColors.Window;
            this.tbox_id.Location = new System.Drawing.Point(12, 26);
            this.tbox_id.Name = "tbox_id";
            this.tbox_id.ReadOnly = true;
            this.tbox_id.Size = new System.Drawing.Size(100, 23);
            this.tbox_id.TabIndex = 27;
            this.tbox_id.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_fechar);
            this.panel1.Controls.Add(this.bt_excluiruser);
            this.panel1.Controls.Add(this.bt_salvaralt);
            this.panel1.Controls.Add(this.bt_novouser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 30);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_fechar
            // 
            this.bt_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fechar.Location = new System.Drawing.Point(458, 4);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(109, 23);
            this.bt_fechar.TabIndex = 4;
            this.bt_fechar.Text = "Fechar Janela";
            this.bt_fechar.UseVisualStyleBackColor = false;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // bt_excluiruser
            // 
            this.bt_excluiruser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_excluiruser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_excluiruser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_excluiruser.Location = new System.Drawing.Point(233, 3);
            this.bt_excluiruser.Name = "bt_excluiruser";
            this.bt_excluiruser.Size = new System.Drawing.Size(109, 23);
            this.bt_excluiruser.TabIndex = 3;
            this.bt_excluiruser.Text = "Excluir Usuário";
            this.bt_excluiruser.UseVisualStyleBackColor = false;
            // 
            // bt_salvaralt
            // 
            this.bt_salvaralt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_salvaralt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_salvaralt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_salvaralt.Location = new System.Drawing.Point(118, 3);
            this.bt_salvaralt.Name = "bt_salvaralt";
            this.bt_salvaralt.Size = new System.Drawing.Size(109, 23);
            this.bt_salvaralt.TabIndex = 2;
            this.bt_salvaralt.Text = "Salvar Alterações";
            this.bt_salvaralt.UseVisualStyleBackColor = false;
            this.bt_salvaralt.Click += new System.EventHandler(this.bt_salvaralt_Click);
            // 
            // bt_novouser
            // 
            this.bt_novouser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_novouser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_novouser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_novouser.Location = new System.Drawing.Point(3, 3);
            this.bt_novouser.Name = "bt_novouser";
            this.bt_novouser.Size = new System.Drawing.Size(109, 23);
            this.bt_novouser.TabIndex = 1;
            this.bt_novouser.Text = "Novo Usuário";
            this.bt_novouser.UseVisualStyleBackColor = false;
            this.bt_novouser.Click += new System.EventHandler(this.bt_novouser_Click);
            // 
            // datagrid_usuarios
            // 
            this.datagrid_usuarios.AllowUserToAddRows = false;
            this.datagrid_usuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_usuarios.EnableHeadersVisualStyles = false;
            this.datagrid_usuarios.Location = new System.Drawing.Point(250, 8);
            this.datagrid_usuarios.MultiSelect = false;
            this.datagrid_usuarios.Name = "datagrid_usuarios";
            this.datagrid_usuarios.ReadOnly = true;
            this.datagrid_usuarios.RowHeadersVisible = false;
            this.datagrid_usuarios.RowTemplate.Height = 25;
            this.datagrid_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_usuarios.Size = new System.Drawing.Size(317, 208);
            this.datagrid_usuarios.TabIndex = 29;
            this.datagrid_usuarios.SelectionChanged += new System.EventHandler(this.datagrid_usuarios_SelectionChanged);
            // 
            // FormGestaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 265);
            this.Controls.Add(this.datagrid_usuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbox_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numeric_nivel);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.tbox_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGestaoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Usuários";
            this.Load += new System.EventHandler(this.FormGestaoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_nivel)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private NumericUpDown numeric_nivel;
        private ComboBox cb_status;
        private TextBox tbox_username;
        private Label label3;
        private TextBox tbox_senha;
        private Label label2;
        private TextBox tbox_nome;
        private Label label1;
        private TextBox tbox_id;
        private Label label9;
        private Panel panel1;
        private DataGridView datagrid_usuarios;
        private Button bt_fechar;
        private Button bt_excluiruser;
        private Button bt_salvaralt;
        private Button bt_novouser;
    }
}