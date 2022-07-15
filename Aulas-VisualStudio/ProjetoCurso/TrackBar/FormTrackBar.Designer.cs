namespace ProjetoCurso
{
    partial class FormTrackBar
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tbox_valor = new System.Windows.Forms.TextBox();
            this.bt_definir = new System.Windows.Forms.Button();
            this.label_max = new System.Windows.Forms.Label();
            this.label_min = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 12);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(382, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tbox_valor
            // 
            this.tbox_valor.Location = new System.Drawing.Point(12, 63);
            this.tbox_valor.Name = "tbox_valor";
            this.tbox_valor.Size = new System.Drawing.Size(100, 23);
            this.tbox_valor.TabIndex = 1;
            // 
            // bt_definir
            // 
            this.bt_definir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_definir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_definir.Location = new System.Drawing.Point(118, 63);
            this.bt_definir.Name = "bt_definir";
            this.bt_definir.Size = new System.Drawing.Size(75, 23);
            this.bt_definir.TabIndex = 3;
            this.bt_definir.Text = "Definir";
            this.bt_definir.UseVisualStyleBackColor = false;
            this.bt_definir.Click += new System.EventHandler(this.bt_definir_Click);
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Location = new System.Drawing.Point(12, 89);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(54, 15);
            this.label_max.TabIndex = 4;
            this.label_max.Text = "Máximo:";
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(12, 104);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(52, 15);
            this.label_min.TabIndex = 5;
            this.label_min.Text = "Mínimo:";
            // 
            // FormTrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 507);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.label_max);
            this.Controls.Add(this.bt_definir);
            this.Controls.Add(this.tbox_valor);
            this.Controls.Add(this.trackBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormTrackBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTrackBar";
            this.Load += new System.EventHandler(this.FormTrackBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar trackBar1;
        private TextBox tbox_valor;
        private Button bt_definir;
        private Label label_max;
        private Label label_min;
    }
}