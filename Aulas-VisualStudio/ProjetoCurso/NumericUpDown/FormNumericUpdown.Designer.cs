namespace ProjetoCurso
{
    partial class FormNumericUpdown
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
            this.numericupdown1 = new System.Windows.Forms.NumericUpDown();
            this.tbox_valor = new System.Windows.Forms.TextBox();
            this.bt_definir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericupdown1
            // 
            this.numericupdown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericupdown1.Location = new System.Drawing.Point(12, 12);
            this.numericupdown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericupdown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericupdown1.Name = "numericupdown1";
            this.numericupdown1.Size = new System.Drawing.Size(120, 23);
            this.numericupdown1.TabIndex = 0;
            this.numericupdown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tbox_valor
            // 
            this.tbox_valor.Location = new System.Drawing.Point(150, 12);
            this.tbox_valor.Name = "tbox_valor";
            this.tbox_valor.Size = new System.Drawing.Size(100, 23);
            this.tbox_valor.TabIndex = 1;
            this.tbox_valor.Text = "0";
            // 
            // bt_definir
            // 
            this.bt_definir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_definir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_definir.Location = new System.Drawing.Point(256, 12);
            this.bt_definir.Name = "bt_definir";
            this.bt_definir.Size = new System.Drawing.Size(92, 23);
            this.bt_definir.TabIndex = 2;
            this.bt_definir.Text = "Definir Valor";
            this.bt_definir.UseVisualStyleBackColor = false;
            this.bt_definir.Click += new System.EventHandler(this.bt_definir_Click);
            // 
            // FormNumericUpdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 483);
            this.Controls.Add(this.bt_definir);
            this.Controls.Add(this.tbox_valor);
            this.Controls.Add(this.numericupdown1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormNumericUpdown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNumericUpdown";
            this.Load += new System.EventHandler(this.FormNumericUpdown_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericupdown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numericupdown1;
        private TextBox tbox_valor;
        private Button bt_definir;
    }
}