namespace ProjetoCurso
{
    partial class FormTimer
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bt_iniciar_t1 = new System.Windows.Forms.Button();
            this.bt_parar_t1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_reiniciar_t1 = new System.Windows.Forms.Button();
            this.img_carro = new System.Windows.Forms.PictureBox();
            this.bt_iniciarcarro_tcarro = new System.Windows.Forms.Button();
            this.timer_carro = new System.Windows.Forms.Timer(this.components);
            this.bt_pararcarro_tcarro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_carro)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bt_iniciar_t1
            // 
            this.bt_iniciar_t1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_iniciar_t1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_iniciar_t1.Location = new System.Drawing.Point(12, 12);
            this.bt_iniciar_t1.Name = "bt_iniciar_t1";
            this.bt_iniciar_t1.Size = new System.Drawing.Size(75, 23);
            this.bt_iniciar_t1.TabIndex = 0;
            this.bt_iniciar_t1.Text = "Iniciar";
            this.bt_iniciar_t1.UseVisualStyleBackColor = false;
            this.bt_iniciar_t1.Click += new System.EventHandler(this.bt_iniciar_t1_Click);
            // 
            // bt_parar_t1
            // 
            this.bt_parar_t1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_parar_t1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_parar_t1.Location = new System.Drawing.Point(93, 12);
            this.bt_parar_t1.Name = "bt_parar_t1";
            this.bt_parar_t1.Size = new System.Drawing.Size(75, 23);
            this.bt_parar_t1.TabIndex = 1;
            this.bt_parar_t1.Text = "Parar";
            this.bt_parar_t1.UseVisualStyleBackColor = false;
            this.bt_parar_t1.Click += new System.EventHandler(this.bt_parar_t1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // bt_reiniciar_t1
            // 
            this.bt_reiniciar_t1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_reiniciar_t1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_reiniciar_t1.Location = new System.Drawing.Point(174, 12);
            this.bt_reiniciar_t1.Name = "bt_reiniciar_t1";
            this.bt_reiniciar_t1.Size = new System.Drawing.Size(75, 23);
            this.bt_reiniciar_t1.TabIndex = 3;
            this.bt_reiniciar_t1.Text = "Reiniciar";
            this.bt_reiniciar_t1.UseVisualStyleBackColor = false;
            this.bt_reiniciar_t1.Click += new System.EventHandler(this.bt_reiniciar_t1_Click);
            // 
            // img_carro
            // 
            this.img_carro.Image = global::ProjetoCurso.Properties.Resources.desenho;
            this.img_carro.Location = new System.Drawing.Point(12, 118);
            this.img_carro.Name = "img_carro";
            this.img_carro.Size = new System.Drawing.Size(47, 49);
            this.img_carro.TabIndex = 4;
            this.img_carro.TabStop = false;
            // 
            // bt_iniciarcarro_tcarro
            // 
            this.bt_iniciarcarro_tcarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_iniciarcarro_tcarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_iniciarcarro_tcarro.Location = new System.Drawing.Point(12, 173);
            this.bt_iniciarcarro_tcarro.Name = "bt_iniciarcarro_tcarro";
            this.bt_iniciarcarro_tcarro.Size = new System.Drawing.Size(82, 23);
            this.bt_iniciarcarro_tcarro.TabIndex = 5;
            this.bt_iniciarcarro_tcarro.Text = "Iniciar Carro";
            this.bt_iniciarcarro_tcarro.UseVisualStyleBackColor = false;
            this.bt_iniciarcarro_tcarro.Click += new System.EventHandler(this.bt_iniciarcarro_tcarro_Click);
            // 
            // timer_carro
            // 
            this.timer_carro.Interval = 1;
            this.timer_carro.Tick += new System.EventHandler(this.timer_carro_Tick);
            // 
            // bt_pararcarro_tcarro
            // 
            this.bt_pararcarro_tcarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_pararcarro_tcarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pararcarro_tcarro.Location = new System.Drawing.Point(100, 173);
            this.bt_pararcarro_tcarro.Name = "bt_pararcarro_tcarro";
            this.bt_pararcarro_tcarro.Size = new System.Drawing.Size(82, 23);
            this.bt_pararcarro_tcarro.TabIndex = 6;
            this.bt_pararcarro_tcarro.Text = "Parar Carro";
            this.bt_pararcarro_tcarro.UseVisualStyleBackColor = false;
            this.bt_pararcarro_tcarro.Click += new System.EventHandler(this.bt_pararcarro_tcarro_Click);
            // 
            // FormTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 453);
            this.Controls.Add(this.bt_pararcarro_tcarro);
            this.Controls.Add(this.bt_iniciarcarro_tcarro);
            this.Controls.Add(this.img_carro);
            this.Controls.Add(this.bt_reiniciar_t1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_parar_t1);
            this.Controls.Add(this.bt_iniciar_t1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTimer";
            this.Load += new System.EventHandler(this.FormTimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_carro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button bt_iniciar_t1;
        private Button bt_parar_t1;
        private Label label1;
        private Button bt_reiniciar_t1;
        private PictureBox img_carro;
        private Button bt_iniciarcarro_tcarro;
        private System.Windows.Forms.Timer timer_carro;
        private Button bt_pararcarro_tcarro;
    }
}