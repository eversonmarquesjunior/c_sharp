namespace ProjetoCurso
{
    partial class FormTreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Vermelha");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Preto");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Ferrari", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Azul");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Cinza");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("BMW", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_removersele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "vermelha";
            treeNode1.Tag = "https://github.com/eversonmarquesjunior/c_sharp";
            treeNode1.Text = "Vermelha";
            treeNode2.Name = "preto";
            treeNode2.Text = "Preto";
            treeNode3.Name = "ferrari";
            treeNode3.Text = "Ferrari";
            treeNode4.Name = "azul";
            treeNode4.Text = "Azul";
            treeNode5.Name = "cinza";
            treeNode5.Text = "Cinza";
            treeNode6.Name = "bmw";
            treeNode6.Text = "BMW";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(178, 242);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add.Location = new System.Drawing.Point(196, 12);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(162, 23);
            this.bt_add.TabIndex = 1;
            this.bt_add.Text = "Adicionar";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_remover.Location = new System.Drawing.Point(196, 41);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(162, 23);
            this.bt_remover.TabIndex = 2;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = false;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(196, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 23);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tag";
            // 
            // bt_removersele
            // 
            this.bt_removersele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_removersele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_removersele.Location = new System.Drawing.Point(196, 70);
            this.bt_removersele.Name = "bt_removersele";
            this.bt_removersele.Size = new System.Drawing.Size(162, 23);
            this.bt_removersele.TabIndex = 6;
            this.bt_removersele.Text = "Remover Selecionado";
            this.bt_removersele.UseVisualStyleBackColor = false;
            this.bt_removersele.Click += new System.EventHandler(this.bt_removersele_Click);
            // 
            // FormTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 483);
            this.Controls.Add(this.bt_removersele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormTreeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView treeView1;
        private Button bt_add;
        private Button bt_remover;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button bt_removersele;
    }
}