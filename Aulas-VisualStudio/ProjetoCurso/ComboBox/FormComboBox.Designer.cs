namespace ProjetoCurso
{
    partial class FormComboBox
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
            this.combo_frutas = new System.Windows.Forms.ComboBox();
            this.bt_sele = new System.Windows.Forms.Button();
            this.bt_limparele = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.tbox_fruta = new System.Windows.Forms.TextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combo_frutas
            // 
            this.combo_frutas.FormattingEnabled = true;
            this.combo_frutas.Items.AddRange(new object[] {
            "Uva",
            "Maça",
            "Banana",
            "Melancia",
            "Morango"});
            this.combo_frutas.Location = new System.Drawing.Point(67, 28);
            this.combo_frutas.Name = "combo_frutas";
            this.combo_frutas.Size = new System.Drawing.Size(162, 23);
            this.combo_frutas.TabIndex = 0;
            this.combo_frutas.SelectedIndexChanged += new System.EventHandler(this.combo_frutas_SelectedIndexChanged);
            // 
            // bt_sele
            // 
            this.bt_sele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_sele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sele.Location = new System.Drawing.Point(250, 28);
            this.bt_sele.Name = "bt_sele";
            this.bt_sele.Size = new System.Drawing.Size(183, 23);
            this.bt_sele.TabIndex = 1;
            this.bt_sele.Text = "Selecionado";
            this.bt_sele.UseVisualStyleBackColor = false;
            this.bt_sele.Click += new System.EventHandler(this.bt_sele_Click);
            // 
            // bt_limparele
            // 
            this.bt_limparele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_limparele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_limparele.Location = new System.Drawing.Point(250, 57);
            this.bt_limparele.Name = "bt_limparele";
            this.bt_limparele.Size = new System.Drawing.Size(183, 23);
            this.bt_limparele.TabIndex = 2;
            this.bt_limparele.Text = "Limpar";
            this.bt_limparele.UseVisualStyleBackColor = false;
            this.bt_limparele.Click += new System.EventHandler(this.bt_limparele_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_reset.Location = new System.Drawing.Point(250, 86);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(183, 23);
            this.bt_reset.TabIndex = 3;
            this.bt_reset.Text = "Resetar";
            this.bt_reset.UseVisualStyleBackColor = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // tbox_fruta
            // 
            this.tbox_fruta.Location = new System.Drawing.Point(250, 127);
            this.tbox_fruta.Name = "tbox_fruta";
            this.tbox_fruta.Size = new System.Drawing.Size(183, 23);
            this.tbox_fruta.TabIndex = 4;
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add.Location = new System.Drawing.Point(250, 156);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(183, 23);
            this.bt_add.TabIndex = 5;
            this.bt_add.Text = "Adicionar";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // FormComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 486);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.tbox_fruta);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_limparele);
            this.Controls.Add(this.bt_sele);
            this.Controls.Add(this.combo_frutas);
            this.Name = "FormComboBox";
            this.Text = "FormComboBox";
            this.Load += new System.EventHandler(this.FormComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox combo_frutas;
        private Button bt_sele;
        private Button bt_limparele;
        private Button bt_reset;
        private TextBox tbox_fruta;
        private Button bt_add;
    }
}