namespace ProjetoCurso
{
    partial class FormCheckBox
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
            this.cb_calabresa = new System.Windows.Forms.CheckBox();
            this.cb_4queijos = new System.Windows.Forms.CheckBox();
            this.cb_frango = new System.Windows.Forms.CheckBox();
            this.cb_portuguesa = new System.Windows.Forms.CheckBox();
            this.bt_sabores_sele = new System.Windows.Forms.Button();
            this.cb_strog = new System.Windows.Forms.CheckBox();
            this.bt_aux = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_calabresa
            // 
            this.cb_calabresa.AutoSize = true;
            this.cb_calabresa.Location = new System.Drawing.Point(22, 27);
            this.cb_calabresa.Name = "cb_calabresa";
            this.cb_calabresa.Size = new System.Drawing.Size(77, 19);
            this.cb_calabresa.TabIndex = 0;
            this.cb_calabresa.Text = "Calabresa";
            this.cb_calabresa.UseVisualStyleBackColor = true;
            // 
            // cb_4queijos
            // 
            this.cb_4queijos.AutoSize = true;
            this.cb_4queijos.Location = new System.Drawing.Point(22, 52);
            this.cb_4queijos.Name = "cb_4queijos";
            this.cb_4queijos.Size = new System.Drawing.Size(75, 19);
            this.cb_4queijos.TabIndex = 1;
            this.cb_4queijos.Text = "4 Queijos";
            this.cb_4queijos.UseVisualStyleBackColor = true;
            // 
            // cb_frango
            // 
            this.cb_frango.AutoSize = true;
            this.cb_frango.Location = new System.Drawing.Point(22, 77);
            this.cb_frango.Name = "cb_frango";
            this.cb_frango.Size = new System.Drawing.Size(111, 19);
            this.cb_frango.TabIndex = 2;
            this.cb_frango.Text = "Frango Catupiry";
            this.cb_frango.UseVisualStyleBackColor = true;
            // 
            // cb_portuguesa
            // 
            this.cb_portuguesa.AutoSize = true;
            this.cb_portuguesa.Location = new System.Drawing.Point(22, 102);
            this.cb_portuguesa.Name = "cb_portuguesa";
            this.cb_portuguesa.Size = new System.Drawing.Size(86, 19);
            this.cb_portuguesa.TabIndex = 3;
            this.cb_portuguesa.Text = "Portuguesa";
            this.cb_portuguesa.UseVisualStyleBackColor = true;
            // 
            // bt_sabores_sele
            // 
            this.bt_sabores_sele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_sabores_sele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sabores_sele.Location = new System.Drawing.Point(229, 20);
            this.bt_sabores_sele.Name = "bt_sabores_sele";
            this.bt_sabores_sele.Size = new System.Drawing.Size(145, 26);
            this.bt_sabores_sele.TabIndex = 4;
            this.bt_sabores_sele.Text = "Sabores Selecionados";
            this.bt_sabores_sele.UseVisualStyleBackColor = false;
            this.bt_sabores_sele.Click += new System.EventHandler(this.bt_sabores_sele_Click);
            // 
            // cb_strog
            // 
            this.cb_strog.AutoSize = true;
            this.cb_strog.Location = new System.Drawing.Point(22, 163);
            this.cb_strog.Name = "cb_strog";
            this.cb_strog.Size = new System.Drawing.Size(83, 19);
            this.cb_strog.TabIndex = 5;
            this.cb_strog.Text = "Strogonoff";
            this.cb_strog.UseVisualStyleBackColor = true;
            this.cb_strog.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bt_aux
            // 
            this.bt_aux.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_aux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_aux.Location = new System.Drawing.Point(229, 67);
            this.bt_aux.Name = "bt_aux";
            this.bt_aux.Size = new System.Drawing.Size(161, 29);
            this.bt_aux.TabIndex = 6;
            this.bt_aux.Text = "Abrir Formulário Auxiliar";
            this.bt_aux.UseVisualStyleBackColor = false;
            this.bt_aux.Click += new System.EventHandler(this.bt_aux_Click);
            // 
            // FormCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 453);
            this.Controls.Add(this.bt_aux);
            this.Controls.Add(this.cb_strog);
            this.Controls.Add(this.bt_sabores_sele);
            this.Controls.Add(this.cb_portuguesa);
            this.Controls.Add(this.cb_frango);
            this.Controls.Add(this.cb_4queijos);
            this.Controls.Add(this.cb_calabresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormCheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.Load += new System.EventHandler(this.FormCheckBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button bt_sabores_sele;
        private CheckBox cb_strog;
        public CheckBox cb_calabresa;
        public CheckBox cb_4queijos;
        public CheckBox cb_frango;
        public CheckBox cb_portuguesa;
        private Button bt_aux;
    }
}