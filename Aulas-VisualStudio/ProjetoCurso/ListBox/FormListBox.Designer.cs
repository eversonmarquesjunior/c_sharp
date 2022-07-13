namespace ProjetoCurso
{
    partial class FormListBox
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
            this.listbox_carros = new System.Windows.Forms.ListBox();
            this.tbox_carro = new System.Windows.Forms.TextBox();
            this.label_carro = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.bt_obter = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbox_carros
            // 
            this.listbox_carros.FormattingEnabled = true;
            this.listbox_carros.ItemHeight = 15;
            this.listbox_carros.Location = new System.Drawing.Point(12, 12);
            this.listbox_carros.Name = "listbox_carros";
            this.listbox_carros.Size = new System.Drawing.Size(120, 169);
            this.listbox_carros.TabIndex = 0;
            // 
            // tbox_carro
            // 
            this.tbox_carro.Location = new System.Drawing.Point(138, 30);
            this.tbox_carro.Name = "tbox_carro";
            this.tbox_carro.Size = new System.Drawing.Size(100, 23);
            this.tbox_carro.TabIndex = 1;
            // 
            // label_carro
            // 
            this.label_carro.AutoSize = true;
            this.label_carro.Location = new System.Drawing.Point(138, 9);
            this.label_carro.Name = "label_carro";
            this.label_carro.Size = new System.Drawing.Size(36, 15);
            this.label_carro.TabIndex = 2;
            this.label_carro.Text = "Carro";
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add.Location = new System.Drawing.Point(138, 59);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(100, 23);
            this.bt_add.TabIndex = 3;
            this.bt_add.Text = "Adicionar";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_remover.Location = new System.Drawing.Point(138, 88);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(100, 23);
            this.bt_remover.TabIndex = 6;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = false;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // bt_obter
            // 
            this.bt_obter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_obter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_obter.Location = new System.Drawing.Point(138, 117);
            this.bt_obter.Name = "bt_obter";
            this.bt_obter.Size = new System.Drawing.Size(100, 23);
            this.bt_obter.TabIndex = 7;
            this.bt_obter.Text = "Obter";
            this.bt_obter.UseVisualStyleBackColor = false;
            this.bt_obter.Click += new System.EventHandler(this.bt_obter_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_limpar.Location = new System.Drawing.Point(138, 146);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(100, 23);
            this.bt_limpar.TabIndex = 8;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = false;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // FormListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 452);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_obter);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.label_carro);
            this.Controls.Add(this.tbox_carro);
            this.Controls.Add(this.listbox_carros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListBox";
            this.Load += new System.EventHandler(this.FormListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listbox_carros;
        private TextBox tbox_carro;
        private Label label_carro;
        private Button bt_add;
        private Button bt_remover;
        private Button bt_obter;
        private Button bt_limpar;
    }
}