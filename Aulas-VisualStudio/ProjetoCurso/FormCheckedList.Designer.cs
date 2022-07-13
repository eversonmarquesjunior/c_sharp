namespace ProjetoCurso
{
    partial class FormCheckedList
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
            this.bt_selecionados = new System.Windows.Forms.Button();
            this.clb_tenis = new System.Windows.Forms.CheckedListBox();
            this.bt_limparele = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.tbox_add = new System.Windows.Forms.TextBox();
            this.label_digite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_selecionados
            // 
            this.bt_selecionados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_selecionados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_selecionados.Location = new System.Drawing.Point(208, 28);
            this.bt_selecionados.Name = "bt_selecionados";
            this.bt_selecionados.Size = new System.Drawing.Size(156, 23);
            this.bt_selecionados.TabIndex = 0;
            this.bt_selecionados.Text = "Selecionados";
            this.bt_selecionados.UseVisualStyleBackColor = false;
            this.bt_selecionados.Click += new System.EventHandler(this.bt_selecionados_Click);
            // 
            // clb_tenis
            // 
            this.clb_tenis.FormattingEnabled = true;
            this.clb_tenis.Items.AddRange(new object[] {
            "Nike",
            "Adidas",
            "NewBalance",
            "Puma",
            "Vans"});
            this.clb_tenis.Location = new System.Drawing.Point(49, 28);
            this.clb_tenis.Name = "clb_tenis";
            this.clb_tenis.Size = new System.Drawing.Size(120, 202);
            this.clb_tenis.TabIndex = 1;
            // 
            // bt_limparele
            // 
            this.bt_limparele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_limparele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_limparele.Location = new System.Drawing.Point(208, 57);
            this.bt_limparele.Name = "bt_limparele";
            this.bt_limparele.Size = new System.Drawing.Size(156, 23);
            this.bt_limparele.TabIndex = 2;
            this.bt_limparele.Text = "Limpar";
            this.bt_limparele.UseVisualStyleBackColor = false;
            this.bt_limparele.Click += new System.EventHandler(this.bt_limparele_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_reset.Location = new System.Drawing.Point(208, 86);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(156, 23);
            this.bt_reset.TabIndex = 3;
            this.bt_reset.Text = "Resetar";
            this.bt_reset.UseVisualStyleBackColor = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add.Location = new System.Drawing.Point(208, 207);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(156, 23);
            this.bt_add.TabIndex = 4;
            this.bt_add.Text = "Adicionar";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tbox_add
            // 
            this.tbox_add.Location = new System.Drawing.Point(208, 178);
            this.tbox_add.Name = "tbox_add";
            this.tbox_add.Size = new System.Drawing.Size(156, 23);
            this.tbox_add.TabIndex = 5;
            // 
            // label_digite
            // 
            this.label_digite.AutoSize = true;
            this.label_digite.Location = new System.Drawing.Point(208, 155);
            this.label_digite.Name = "label_digite";
            this.label_digite.Size = new System.Drawing.Size(120, 15);
            this.label_digite.TabIndex = 6;
            this.label_digite.Text = "Digite um novo tênis:";
            this.label_digite.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormCheckedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 437);
            this.Controls.Add(this.label_digite);
            this.Controls.Add(this.tbox_add);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_limparele);
            this.Controls.Add(this.clb_tenis);
            this.Controls.Add(this.bt_selecionados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormCheckedList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedList";
            this.Load += new System.EventHandler(this.FormCheckedList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_selecionados;
        private CheckedListBox clb_tenis;
        private Button bt_limparele;
        private Button bt_reset;
        private Button bt_add;
        private TextBox tbox_add;
        private Label label_digite;
    }
}