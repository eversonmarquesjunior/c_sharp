namespace ProjetoCurso
{
    partial class FormDateTimePicker
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
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.bt_obterdata = new System.Windows.Forms.Button();
            this.tbox_data = new System.Windows.Forms.TextBox();
            this.tbox_mes = new System.Windows.Forms.TextBox();
            this.tbox_dia = new System.Windows.Forms.TextBox();
            this.tbox_ano = new System.Windows.Forms.TextBox();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(12, 31);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(275, 23);
            this.dtp_data.TabIndex = 0;
            // 
            // bt_obterdata
            // 
            this.bt_obterdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_obterdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_obterdata.Location = new System.Drawing.Point(310, 31);
            this.bt_obterdata.Name = "bt_obterdata";
            this.bt_obterdata.Size = new System.Drawing.Size(145, 23);
            this.bt_obterdata.TabIndex = 1;
            this.bt_obterdata.Text = "Obter Data";
            this.bt_obterdata.UseVisualStyleBackColor = false;
            this.bt_obterdata.Click += new System.EventHandler(this.bt_obterdata_Click);
            // 
            // tbox_data
            // 
            this.tbox_data.Location = new System.Drawing.Point(12, 60);
            this.tbox_data.Name = "tbox_data";
            this.tbox_data.Size = new System.Drawing.Size(275, 23);
            this.tbox_data.TabIndex = 2;
            // 
            // tbox_mes
            // 
            this.tbox_mes.Location = new System.Drawing.Point(106, 89);
            this.tbox_mes.Name = "tbox_mes";
            this.tbox_mes.Size = new System.Drawing.Size(88, 23);
            this.tbox_mes.TabIndex = 3;
            // 
            // tbox_dia
            // 
            this.tbox_dia.Location = new System.Drawing.Point(12, 89);
            this.tbox_dia.Name = "tbox_dia";
            this.tbox_dia.Size = new System.Drawing.Size(88, 23);
            this.tbox_dia.TabIndex = 4;
            // 
            // tbox_ano
            // 
            this.tbox_ano.Location = new System.Drawing.Point(199, 89);
            this.tbox_ano.Name = "tbox_ano";
            this.tbox_ano.Size = new System.Drawing.Size(88, 23);
            this.tbox_ano.TabIndex = 5;
            this.tbox_ano.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // bt_alterar
            // 
            this.bt_alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_alterar.Location = new System.Drawing.Point(310, 89);
            this.bt_alterar.Name = "bt_alterar";
            this.bt_alterar.Size = new System.Drawing.Size(145, 23);
            this.bt_alterar.TabIndex = 9;
            this.bt_alterar.Text = "Alterar Data";
            this.bt_alterar.UseVisualStyleBackColor = false;
            this.bt_alterar.Click += new System.EventHandler(this.bt_alterar_Click);
            // 
            // FormDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 453);
            this.Controls.Add(this.bt_alterar);
            this.Controls.Add(this.tbox_ano);
            this.Controls.Add(this.tbox_dia);
            this.Controls.Add(this.tbox_mes);
            this.Controls.Add(this.tbox_data);
            this.Controls.Add(this.bt_obterdata);
            this.Controls.Add(this.dtp_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormDateTimePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDateTimePicker";
            this.Load += new System.EventHandler(this.FormDateTimePicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtp_data;
        private Button bt_obterdata;
        private TextBox tbox_data;
        private TextBox tbox_mes;
        private TextBox tbox_dia;
        private TextBox tbox_ano;
        private Button bt_alterar;
    }
}