namespace ProjetoCurso
{
    partial class FormRadioButton
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
            this.radio_cala = new System.Windows.Forms.RadioButton();
            this.radio_port = new System.Windows.Forms.RadioButton();
            this.radio_4q = new System.Windows.Forms.RadioButton();
            this.radio_pep = new System.Windows.Forms.RadioButton();
            this.radio_coca = new System.Windows.Forms.RadioButton();
            this.radio_fanta = new System.Windows.Forms.RadioButton();
            this.radio_pepsi = new System.Windows.Forms.RadioButton();
            this.radio_guarana = new System.Windows.Forms.RadioButton();
            this.groupbox_sabores = new System.Windows.Forms.GroupBox();
            this.groupbox_bebidas = new System.Windows.Forms.GroupBox();
            this.bt_sele = new System.Windows.Forms.Button();
            this.tbox_sele = new System.Windows.Forms.TextBox();
            this.bt_sele2 = new System.Windows.Forms.Button();
            this.groupbox_sabores.SuspendLayout();
            this.groupbox_bebidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // radio_cala
            // 
            this.radio_cala.AutoSize = true;
            this.radio_cala.Location = new System.Drawing.Point(6, 28);
            this.radio_cala.Name = "radio_cala";
            this.radio_cala.Size = new System.Drawing.Size(76, 19);
            this.radio_cala.TabIndex = 0;
            this.radio_cala.TabStop = true;
            this.radio_cala.Text = "Calabresa";
            this.radio_cala.UseVisualStyleBackColor = true;
            // 
            // radio_port
            // 
            this.radio_port.AutoSize = true;
            this.radio_port.Location = new System.Drawing.Point(6, 53);
            this.radio_port.Name = "radio_port";
            this.radio_port.Size = new System.Drawing.Size(85, 19);
            this.radio_port.TabIndex = 1;
            this.radio_port.TabStop = true;
            this.radio_port.Text = "Portuguesa";
            this.radio_port.UseVisualStyleBackColor = true;
            // 
            // radio_4q
            // 
            this.radio_4q.AutoSize = true;
            this.radio_4q.Location = new System.Drawing.Point(6, 78);
            this.radio_4q.Name = "radio_4q";
            this.radio_4q.Size = new System.Drawing.Size(74, 19);
            this.radio_4q.TabIndex = 2;
            this.radio_4q.TabStop = true;
            this.radio_4q.Text = "4 Queijos";
            this.radio_4q.UseVisualStyleBackColor = true;
            // 
            // radio_pep
            // 
            this.radio_pep.AutoSize = true;
            this.radio_pep.Location = new System.Drawing.Point(6, 103);
            this.radio_pep.Name = "radio_pep";
            this.radio_pep.Size = new System.Drawing.Size(79, 19);
            this.radio_pep.TabIndex = 3;
            this.radio_pep.TabStop = true;
            this.radio_pep.Text = "Pepperoni";
            this.radio_pep.UseVisualStyleBackColor = true;
            // 
            // radio_coca
            // 
            this.radio_coca.AutoSize = true;
            this.radio_coca.Location = new System.Drawing.Point(6, 22);
            this.radio_coca.Name = "radio_coca";
            this.radio_coca.Size = new System.Drawing.Size(81, 19);
            this.radio_coca.TabIndex = 4;
            this.radio_coca.TabStop = true;
            this.radio_coca.Text = "Coca-Cola";
            this.radio_coca.UseVisualStyleBackColor = true;
            // 
            // radio_fanta
            // 
            this.radio_fanta.AutoSize = true;
            this.radio_fanta.Location = new System.Drawing.Point(6, 47);
            this.radio_fanta.Name = "radio_fanta";
            this.radio_fanta.Size = new System.Drawing.Size(54, 19);
            this.radio_fanta.TabIndex = 5;
            this.radio_fanta.TabStop = true;
            this.radio_fanta.Text = "Fanta";
            this.radio_fanta.UseVisualStyleBackColor = true;
            // 
            // radio_pepsi
            // 
            this.radio_pepsi.AutoSize = true;
            this.radio_pepsi.Location = new System.Drawing.Point(6, 72);
            this.radio_pepsi.Name = "radio_pepsi";
            this.radio_pepsi.Size = new System.Drawing.Size(53, 19);
            this.radio_pepsi.TabIndex = 6;
            this.radio_pepsi.TabStop = true;
            this.radio_pepsi.Text = "Pepsi";
            this.radio_pepsi.UseVisualStyleBackColor = true;
            // 
            // radio_guarana
            // 
            this.radio_guarana.AutoSize = true;
            this.radio_guarana.Location = new System.Drawing.Point(6, 97);
            this.radio_guarana.Name = "radio_guarana";
            this.radio_guarana.Size = new System.Drawing.Size(69, 19);
            this.radio_guarana.TabIndex = 7;
            this.radio_guarana.TabStop = true;
            this.radio_guarana.Text = "Guaraná";
            this.radio_guarana.UseVisualStyleBackColor = true;
            // 
            // groupbox_sabores
            // 
            this.groupbox_sabores.Controls.Add(this.radio_port);
            this.groupbox_sabores.Controls.Add(this.radio_cala);
            this.groupbox_sabores.Controls.Add(this.radio_4q);
            this.groupbox_sabores.Controls.Add(this.radio_pep);
            this.groupbox_sabores.Location = new System.Drawing.Point(129, 65);
            this.groupbox_sabores.Name = "groupbox_sabores";
            this.groupbox_sabores.Size = new System.Drawing.Size(100, 138);
            this.groupbox_sabores.TabIndex = 8;
            this.groupbox_sabores.TabStop = false;
            this.groupbox_sabores.Text = "Sabores";
            // 
            // groupbox_bebidas
            // 
            this.groupbox_bebidas.Controls.Add(this.radio_fanta);
            this.groupbox_bebidas.Controls.Add(this.radio_coca);
            this.groupbox_bebidas.Controls.Add(this.radio_guarana);
            this.groupbox_bebidas.Controls.Add(this.radio_pepsi);
            this.groupbox_bebidas.Location = new System.Drawing.Point(235, 65);
            this.groupbox_bebidas.Name = "groupbox_bebidas";
            this.groupbox_bebidas.Size = new System.Drawing.Size(97, 138);
            this.groupbox_bebidas.TabIndex = 9;
            this.groupbox_bebidas.TabStop = false;
            this.groupbox_bebidas.Text = "Bebidas";
            // 
            // bt_sele
            // 
            this.bt_sele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_sele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sele.Location = new System.Drawing.Point(129, 209);
            this.bt_sele.Name = "bt_sele";
            this.bt_sele.Size = new System.Drawing.Size(100, 23);
            this.bt_sele.TabIndex = 10;
            this.bt_sele.Text = "Selecionado";
            this.bt_sele.UseVisualStyleBackColor = false;
            this.bt_sele.Click += new System.EventHandler(this.bt_sele_Click);
            // 
            // tbox_sele
            // 
            this.tbox_sele.Location = new System.Drawing.Point(180, 238);
            this.tbox_sele.Name = "tbox_sele";
            this.tbox_sele.Size = new System.Drawing.Size(100, 23);
            this.tbox_sele.TabIndex = 11;
            // 
            // bt_sele2
            // 
            this.bt_sele2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_sele2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sele2.Location = new System.Drawing.Point(235, 209);
            this.bt_sele2.Name = "bt_sele2";
            this.bt_sele2.Size = new System.Drawing.Size(100, 23);
            this.bt_sele2.TabIndex = 12;
            this.bt_sele2.Text = "Selecionado 2";
            this.bt_sele2.UseVisualStyleBackColor = false;
            this.bt_sele2.Click += new System.EventHandler(this.bt_sele2_Click);
            // 
            // FormRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 448);
            this.Controls.Add(this.bt_sele2);
            this.Controls.Add(this.tbox_sele);
            this.Controls.Add(this.bt_sele);
            this.Controls.Add(this.groupbox_bebidas);
            this.Controls.Add(this.groupbox_sabores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormRadioButton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRadioButton";
            this.groupbox_sabores.ResumeLayout(false);
            this.groupbox_sabores.PerformLayout();
            this.groupbox_bebidas.ResumeLayout(false);
            this.groupbox_bebidas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radio_cala;
        private RadioButton radio_port;
        private RadioButton radio_4q;
        private RadioButton radio_pep;
        private RadioButton radio_coca;
        private RadioButton radio_fanta;
        private RadioButton radio_pepsi;
        private RadioButton radio_guarana;
        private GroupBox groupbox_sabores;
        private GroupBox groupbox_bebidas;
        private Button bt_sele;
        private TextBox tbox_sele;
        private Button bt_sele2;
    }
}