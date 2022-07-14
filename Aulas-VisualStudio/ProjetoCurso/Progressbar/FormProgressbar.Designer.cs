namespace ProjetoCurso
{
    partial class FormProgressbar
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
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.bt_valor = new System.Windows.Forms.Button();
            this.tbox_valor = new System.Windows.Forms.TextBox();
            this.bt_preencher = new System.Windows.Forms.Button();
            this.tbox_cont = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressbar
            // 
            this.progressbar.Location = new System.Drawing.Point(12, 90);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(447, 23);
            this.progressbar.TabIndex = 0;
            // 
            // bt_valor
            // 
            this.bt_valor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_valor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_valor.Location = new System.Drawing.Point(12, 214);
            this.bt_valor.Name = "bt_valor";
            this.bt_valor.Size = new System.Drawing.Size(100, 23);
            this.bt_valor.TabIndex = 1;
            this.bt_valor.Text = "Definir Valor";
            this.bt_valor.UseVisualStyleBackColor = false;
            this.bt_valor.Click += new System.EventHandler(this.bt_valor_Click);
            // 
            // tbox_valor
            // 
            this.tbox_valor.Location = new System.Drawing.Point(12, 185);
            this.tbox_valor.Name = "tbox_valor";
            this.tbox_valor.Size = new System.Drawing.Size(100, 23);
            this.tbox_valor.TabIndex = 2;
            this.tbox_valor.Text = "0";
            // 
            // bt_preencher
            // 
            this.bt_preencher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_preencher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_preencher.Location = new System.Drawing.Point(12, 119);
            this.bt_preencher.Name = "bt_preencher";
            this.bt_preencher.Size = new System.Drawing.Size(75, 23);
            this.bt_preencher.TabIndex = 3;
            this.bt_preencher.Text = "Preencher";
            this.bt_preencher.UseVisualStyleBackColor = false;
            this.bt_preencher.Click += new System.EventHandler(this.bt_preencher_Click);
            // 
            // tbox_cont
            // 
            this.tbox_cont.Location = new System.Drawing.Point(234, 185);
            this.tbox_cont.Name = "tbox_cont";
            this.tbox_cont.Size = new System.Drawing.Size(100, 23);
            this.tbox_cont.TabIndex = 4;
            this.tbox_cont.Text = "5000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Limite Máximo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormProgressbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_cont);
            this.Controls.Add(this.bt_preencher);
            this.Controls.Add(this.tbox_valor);
            this.Controls.Add(this.bt_valor);
            this.Controls.Add(this.progressbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormProgressbar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProgressbar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar progressbar;
        private Button bt_valor;
        private TextBox tbox_valor;
        private Button bt_preencher;
        private TextBox tbox_cont;
        private Label label1;
    }
}