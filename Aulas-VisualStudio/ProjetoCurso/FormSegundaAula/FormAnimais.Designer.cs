namespace ProjetoCurso
{
    partial class FormAnimais
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
            this.tbox_listaanimais = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbox_listaanimais
            // 
            this.tbox_listaanimais.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbox_listaanimais.Location = new System.Drawing.Point(75, 53);
            this.tbox_listaanimais.Multiline = true;
            this.tbox_listaanimais.Name = "tbox_listaanimais";
            this.tbox_listaanimais.Size = new System.Drawing.Size(435, 330);
            this.tbox_listaanimais.TabIndex = 0;
            // 
            // FormAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 472);
            this.Controls.Add(this.tbox_listaanimais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAnimais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Veículos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAnimais_FormClosed);
            this.Load += new System.EventHandler(this.FormAnimais_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbox_listaanimais;
    }
}