namespace ProjetoCurso.MaskedTextBox
{
    partial class FormMaskedTextBox
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
            this.mtbox_senha = new System.Windows.Forms.MaskedTextBox();
            this.label_senha = new System.Windows.Forms.Label();
            this.mtbox_cpf = new System.Windows.Forms.MaskedTextBox();
            this.bt_mostrar = new System.Windows.Forms.Button();
            this.cb_texto = new System.Windows.Forms.CheckBox();
            this.bt_senha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtbox_senha
            // 
            this.mtbox_senha.Location = new System.Drawing.Point(12, 52);
            this.mtbox_senha.Name = "mtbox_senha";
            this.mtbox_senha.PasswordChar = '*';
            this.mtbox_senha.Size = new System.Drawing.Size(147, 23);
            this.mtbox_senha.TabIndex = 0;
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Location = new System.Drawing.Point(12, 34);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(39, 15);
            this.label_senha.TabIndex = 1;
            this.label_senha.Text = "Senha";
            // 
            // mtbox_cpf
            // 
            this.mtbox_cpf.Location = new System.Drawing.Point(12, 105);
            this.mtbox_cpf.Mask = "000.000.000-00";
            this.mtbox_cpf.Name = "mtbox_cpf";
            this.mtbox_cpf.Size = new System.Drawing.Size(147, 23);
            this.mtbox_cpf.TabIndex = 2;
            this.mtbox_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbox_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbox_cpf_MaskInputRejected);
            // 
            // bt_mostrar
            // 
            this.bt_mostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mostrar.Location = new System.Drawing.Point(284, 105);
            this.bt_mostrar.Name = "bt_mostrar";
            this.bt_mostrar.Size = new System.Drawing.Size(90, 23);
            this.bt_mostrar.TabIndex = 3;
            this.bt_mostrar.Text = "Mostrar";
            this.bt_mostrar.UseVisualStyleBackColor = false;
            this.bt_mostrar.Click += new System.EventHandler(this.bt_mostrar_Click);
            // 
            // cb_texto
            // 
            this.cb_texto.AutoSize = true;
            this.cb_texto.Location = new System.Drawing.Point(174, 109);
            this.cb_texto.Name = "cb_texto";
            this.cb_texto.Size = new System.Drawing.Size(104, 19);
            this.cb_texto.TabIndex = 4;
            this.cb_texto.Text = "Somente Texto";
            this.cb_texto.UseVisualStyleBackColor = true;
            // 
            // bt_senha
            // 
            this.bt_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_senha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_senha.Location = new System.Drawing.Point(165, 52);
            this.bt_senha.Name = "bt_senha";
            this.bt_senha.Size = new System.Drawing.Size(104, 23);
            this.bt_senha.TabIndex = 5;
            this.bt_senha.Text = "Mostrar Senha";
            this.bt_senha.UseVisualStyleBackColor = false;
            this.bt_senha.Click += new System.EventHandler(this.bt_senha_Click);
            // 
            // FormMaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 462);
            this.Controls.Add(this.bt_senha);
            this.Controls.Add(this.cb_texto);
            this.Controls.Add(this.bt_mostrar);
            this.Controls.Add(this.mtbox_cpf);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.mtbox_senha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMaskedTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMaskedTextBox";
            this.Load += new System.EventHandler(this.FormMaskedTextBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbox_senha;
        private Label label_senha;
        private System.Windows.Forms.MaskedTextBox mtbox_cpf;
        private Button bt_mostrar;
        private CheckBox cb_texto;
        private Button bt_senha;
    }
}