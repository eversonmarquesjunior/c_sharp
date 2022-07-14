namespace ProjetoCurso
{
    partial class FormMonthCalendar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tbox1 = new System.Windows.Forms.TextBox();
            this.tbox2 = new System.Windows.Forms.TextBox();
            this.bt_obterdata = new System.Windows.Forms.Button();
            this.tbox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 27);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tbox1
            // 
            this.tbox1.Location = new System.Drawing.Point(257, 56);
            this.tbox1.Name = "tbox1";
            this.tbox1.Size = new System.Drawing.Size(100, 23);
            this.tbox1.TabIndex = 1;
            // 
            // tbox2
            // 
            this.tbox2.Location = new System.Drawing.Point(257, 85);
            this.tbox2.Name = "tbox2";
            this.tbox2.Size = new System.Drawing.Size(100, 23);
            this.tbox2.TabIndex = 2;
            // 
            // bt_obterdata
            // 
            this.bt_obterdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_obterdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_obterdata.Location = new System.Drawing.Point(257, 27);
            this.bt_obterdata.Name = "bt_obterdata";
            this.bt_obterdata.Size = new System.Drawing.Size(100, 23);
            this.bt_obterdata.TabIndex = 3;
            this.bt_obterdata.Text = "Obter Data";
            this.bt_obterdata.UseVisualStyleBackColor = false;
            this.bt_obterdata.Click += new System.EventHandler(this.bt_obterdata_Click);
            // 
            // tbox3
            // 
            this.tbox3.Location = new System.Drawing.Point(257, 114);
            this.tbox3.Name = "tbox3";
            this.tbox3.Size = new System.Drawing.Size(100, 23);
            this.tbox3.TabIndex = 4;
            // 
            // FormMonthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 465);
            this.Controls.Add(this.tbox3);
            this.Controls.Add(this.bt_obterdata);
            this.Controls.Add(this.tbox2);
            this.Controls.Add(this.tbox1);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMonthCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMonthCalendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar monthCalendar1;
        private TextBox tbox1;
        private TextBox tbox2;
        private Button bt_obterdata;
        private TextBox tbox3;
    }
}