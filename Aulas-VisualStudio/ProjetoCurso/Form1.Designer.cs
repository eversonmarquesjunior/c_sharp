namespace ProjetoCurso
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.label_titulo = new System.Windows.Forms.Label();
            this.tbox_animal = new System.Windows.Forms.TextBox();
            this.tbox_listaanimais = new System.Windows.Forms.TextBox();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_mostrar = new System.Windows.Forms.Button();
            this.bt_var = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_adicionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_adicionar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_adicionar.Location = new System.Drawing.Point(236, 61);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(119, 23);
            this.bt_adicionar.TabIndex = 0;
            this.bt_adicionar.Text = "Adicionar";
            this.bt_adicionar.UseVisualStyleBackColor = false;
            this.bt_adicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.BackColor = System.Drawing.SystemColors.Control;
            this.label_titulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_titulo.Location = new System.Drawing.Point(60, 33);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(129, 21);
            this.label_titulo.TabIndex = 1;
            this.label_titulo.Text = "Digite um animal";
            // 
            // tbox_animal
            // 
            this.tbox_animal.Location = new System.Drawing.Point(60, 61);
            this.tbox_animal.Name = "tbox_animal";
            this.tbox_animal.Size = new System.Drawing.Size(170, 23);
            this.tbox_animal.TabIndex = 2;
            // 
            // tbox_listaanimais
            // 
            this.tbox_listaanimais.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbox_listaanimais.Location = new System.Drawing.Point(60, 90);
            this.tbox_listaanimais.Multiline = true;
            this.tbox_listaanimais.Name = "tbox_listaanimais";
            this.tbox_listaanimais.ReadOnly = true;
            this.tbox_listaanimais.Size = new System.Drawing.Size(295, 193);
            this.tbox_listaanimais.TabIndex = 3;
            this.tbox_listaanimais.TextChanged += new System.EventHandler(this.tbox_listaanimais_TextChanged);
            // 
            // bt_limpar
            // 
            this.bt_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_limpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_limpar.Location = new System.Drawing.Point(60, 289);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(295, 23);
            this.bt_limpar.TabIndex = 4;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = false;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_mostrar
            // 
            this.bt_mostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mostrar.Location = new System.Drawing.Point(60, 318);
            this.bt_mostrar.Name = "bt_mostrar";
            this.bt_mostrar.Size = new System.Drawing.Size(295, 23);
            this.bt_mostrar.TabIndex = 5;
            this.bt_mostrar.Text = "Mostrar lista";
            this.bt_mostrar.UseVisualStyleBackColor = false;
            this.bt_mostrar.Click += new System.EventHandler(this.bt_proximo_Click);
            // 
            // bt_var
            // 
            this.bt_var.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_var.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_var.Location = new System.Drawing.Point(60, 347);
            this.bt_var.Name = "bt_var";
            this.bt_var.Size = new System.Drawing.Size(295, 23);
            this.bt_var.TabIndex = 6;
            this.bt_var.Text = "Valor variável";
            this.bt_var.UseVisualStyleBackColor = false;
            this.bt_var.Click += new System.EventHandler(this.bt_var_Click);
            // 
            // FormPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(407, 442);
            this.Controls.Add(this.bt_var);
            this.Controls.Add(this.bt_mostrar);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.tbox_listaanimais);
            this.Controls.Add(this.tbox_animal);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.bt_adicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Button bt_adicionar;
        private Label label_titulo;
        private TextBox tbox_animal;
        private Button bt_limpar;
        private Button bt_mostrar;
        private Button bt_var;
        public TextBox tbox_listaanimais;
    }
}