namespace Aplicativo_Academia
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_user = new System.Windows.Forms.TextBox();
            this.tbox_senha = new System.Windows.Forms.TextBox();
            this.bt_logar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // tbox_user
            // 
            this.tbox_user.Location = new System.Drawing.Point(12, 27);
            this.tbox_user.Name = "tbox_user";
            this.tbox_user.Size = new System.Drawing.Size(165, 23);
            this.tbox_user.TabIndex = 2;
            this.tbox_user.Text = "juninho";
            // 
            // tbox_senha
            // 
            this.tbox_senha.Location = new System.Drawing.Point(12, 71);
            this.tbox_senha.Name = "tbox_senha";
            this.tbox_senha.PasswordChar = '*';
            this.tbox_senha.Size = new System.Drawing.Size(165, 23);
            this.tbox_senha.TabIndex = 3;
            this.tbox_senha.Text = "123";
            // 
            // bt_logar
            // 
            this.bt_logar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_logar.Location = new System.Drawing.Point(12, 104);
            this.bt_logar.Name = "bt_logar";
            this.bt_logar.Size = new System.Drawing.Size(165, 33);
            this.bt_logar.TabIndex = 4;
            this.bt_logar.Text = "Logar";
            this.bt_logar.UseVisualStyleBackColor = false;
            this.bt_logar.Click += new System.EventHandler(this.bt_logar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Location = new System.Drawing.Point(12, 143);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(165, 33);
            this.bt_cancelar.TabIndex = 5;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 185);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_logar);
            this.Controls.Add(this.tbox_senha);
            this.Controls.Add(this.tbox_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbox_user;
        private TextBox tbox_senha;
        private Button bt_logar;
        private Button bt_cancelar;
    }
}