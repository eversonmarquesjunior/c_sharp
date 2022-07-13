namespace ProjetoCurso
{
    partial class FormLinkLabel
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
            this.linklb_yt = new System.Windows.Forms.LinkLabel();
            this.linklb_calc = new System.Windows.Forms.LinkLabel();
            this.linklb_varios = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linklb_yt
            // 
            this.linklb_yt.AutoSize = true;
            this.linklb_yt.Location = new System.Drawing.Point(181, 49);
            this.linklb_yt.Name = "linklb_yt";
            this.linklb_yt.Size = new System.Drawing.Size(51, 15);
            this.linklb_yt.TabIndex = 0;
            this.linklb_yt.TabStop = true;
            this.linklb_yt.Text = "Youtube";
            this.linklb_yt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklb_yt_LinkClicked);
            // 
            // linklb_calc
            // 
            this.linklb_calc.AutoSize = true;
            this.linklb_calc.Location = new System.Drawing.Point(181, 86);
            this.linklb_calc.Name = "linklb_calc";
            this.linklb_calc.Size = new System.Drawing.Size(70, 15);
            this.linklb_calc.TabIndex = 1;
            this.linklb_calc.TabStop = true;
            this.linklb_calc.Text = "Calculadora";
            this.linklb_calc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklb_calc_LinkClicked);
            // 
            // linklb_varios
            // 
            this.linklb_varios.AutoSize = true;
            this.linklb_varios.Location = new System.Drawing.Point(181, 121);
            this.linklb_varios.Name = "linklb_varios";
            this.linklb_varios.Size = new System.Drawing.Size(100, 15);
            this.linklb_varios.TabIndex = 2;
            this.linklb_varios.TabStop = true;
            this.linklb_varios.Text = "Google - Youtube";
            this.linklb_varios.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklb_varios_LinkClicked);
            // 
            // FormLinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 469);
            this.Controls.Add(this.linklb_varios);
            this.Controls.Add(this.linklb_calc);
            this.Controls.Add(this.linklb_yt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLinkLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linklb_yt;
        private LinkLabel linklb_calc;
        private LinkLabel linklb_varios;
    }
}