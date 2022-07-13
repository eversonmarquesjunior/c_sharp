namespace ProjetoCurso
{
    partial class FormCheckBoxFAux
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
            this.cb_portuguesa = new System.Windows.Forms.CheckBox();
            this.cb_frango = new System.Windows.Forms.CheckBox();
            this.cb_4queijos = new System.Windows.Forms.CheckBox();
            this.cb_calabresa = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_portuguesa
            // 
            this.cb_portuguesa.AutoSize = true;
            this.cb_portuguesa.Location = new System.Drawing.Point(12, 99);
            this.cb_portuguesa.Name = "cb_portuguesa";
            this.cb_portuguesa.Size = new System.Drawing.Size(86, 19);
            this.cb_portuguesa.TabIndex = 7;
            this.cb_portuguesa.Text = "Portuguesa";
            this.cb_portuguesa.UseVisualStyleBackColor = true;
            this.cb_portuguesa.CheckedChanged += new System.EventHandler(this.cb_portuguesa_CheckedChanged);
            // 
            // cb_frango
            // 
            this.cb_frango.AutoSize = true;
            this.cb_frango.Location = new System.Drawing.Point(12, 74);
            this.cb_frango.Name = "cb_frango";
            this.cb_frango.Size = new System.Drawing.Size(111, 19);
            this.cb_frango.TabIndex = 6;
            this.cb_frango.Text = "Frango Catupiry";
            this.cb_frango.UseVisualStyleBackColor = true;
            this.cb_frango.CheckedChanged += new System.EventHandler(this.cb_frango_CheckedChanged);
            // 
            // cb_4queijos
            // 
            this.cb_4queijos.AutoSize = true;
            this.cb_4queijos.Location = new System.Drawing.Point(12, 49);
            this.cb_4queijos.Name = "cb_4queijos";
            this.cb_4queijos.Size = new System.Drawing.Size(75, 19);
            this.cb_4queijos.TabIndex = 5;
            this.cb_4queijos.Text = "4 Queijos";
            this.cb_4queijos.UseVisualStyleBackColor = true;
            this.cb_4queijos.CheckedChanged += new System.EventHandler(this.cb_4queijos_CheckedChanged);
            // 
            // cb_calabresa
            // 
            this.cb_calabresa.AutoSize = true;
            this.cb_calabresa.Location = new System.Drawing.Point(12, 24);
            this.cb_calabresa.Name = "cb_calabresa";
            this.cb_calabresa.Size = new System.Drawing.Size(77, 19);
            this.cb_calabresa.TabIndex = 4;
            this.cb_calabresa.Text = "Calabresa";
            this.cb_calabresa.UseVisualStyleBackColor = true;
            this.cb_calabresa.CheckedChanged += new System.EventHandler(this.cb_calabresa_CheckedChanged);
            // 
            // FormCheckBoxFAux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 218);
            this.Controls.Add(this.cb_portuguesa);
            this.Controls.Add(this.cb_frango);
            this.Controls.Add(this.cb_4queijos);
            this.Controls.Add(this.cb_calabresa);
            this.Name = "FormCheckBoxFAux";
            this.Text = "FormCheckBoxFAux";
            this.Load += new System.EventHandler(this.FormCheckBoxFAux_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox cb_portuguesa;
        private CheckBox cb_frango;
        private CheckBox cb_4queijos;
        private CheckBox cb_calabresa;
    }
}