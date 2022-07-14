namespace ProjetoCurso
{
    partial class FormPictureBox
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
            this.picture_img = new System.Windows.Forms.PictureBox();
            this.bt_img1 = new System.Windows.Forms.Button();
            this.bt_img2 = new System.Windows.Forms.Button();
            this.bt_img3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_img)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // picture_img
            // 
            this.picture_img.Image = global::ProjetoCurso.Properties.Resources.Caricatura;
            this.picture_img.Location = new System.Drawing.Point(157, 74);
            this.picture_img.Name = "picture_img";
            this.picture_img.Size = new System.Drawing.Size(324, 310);
            this.picture_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_img.TabIndex = 2;
            this.picture_img.TabStop = false;
            // 
            // bt_img1
            // 
            this.bt_img1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_img1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_img1.Location = new System.Drawing.Point(202, 390);
            this.bt_img1.Name = "bt_img1";
            this.bt_img1.Size = new System.Drawing.Size(75, 41);
            this.bt_img1.TabIndex = 3;
            this.bt_img1.Text = "Imagem 1";
            this.bt_img1.UseVisualStyleBackColor = false;
            this.bt_img1.Click += new System.EventHandler(this.bt_img1_Click);
            // 
            // bt_img2
            // 
            this.bt_img2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_img2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_img2.Location = new System.Drawing.Point(283, 390);
            this.bt_img2.Name = "bt_img2";
            this.bt_img2.Size = new System.Drawing.Size(75, 41);
            this.bt_img2.TabIndex = 5;
            this.bt_img2.Text = "Imagem 2";
            this.bt_img2.UseVisualStyleBackColor = false;
            this.bt_img2.Click += new System.EventHandler(this.bt_img2_Click);
            // 
            // bt_img3
            // 
            this.bt_img3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_img3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_img3.Location = new System.Drawing.Point(364, 390);
            this.bt_img3.Name = "bt_img3";
            this.bt_img3.Size = new System.Drawing.Size(75, 41);
            this.bt_img3.TabIndex = 6;
            this.bt_img3.Text = "Imagem 3";
            this.bt_img3.UseVisualStyleBackColor = false;
            this.bt_img3.Click += new System.EventHandler(this.bt_img3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // FormPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 487);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_img3);
            this.Controls.Add(this.bt_img2);
            this.Controls.Add(this.bt_img1);
            this.Controls.Add(this.picture_img);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPictureBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPictureBox";
            this.Load += new System.EventHandler(this.FormPictureBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox picture_img;
        private Button bt_img1;
        private Button bt_img2;
        private Button bt_img3;
        private Label label3;
    }
}