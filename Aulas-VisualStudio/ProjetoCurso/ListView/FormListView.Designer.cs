namespace ProjetoCurso
{
    partial class FormListView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Arroz",
            "500",
            "R$ 20,00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Feijão",
            "250",
            "R$ 8,00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Macarrão",
            "100",
            "R$ 12,50"}, -1);
            this.listview_produtos = new System.Windows.Forms.ListView();
            this.coluna_nome = new System.Windows.Forms.ColumnHeader();
            this.coluna_qtde = new System.Windows.Forms.ColumnHeader();
            this.coluna_preco = new System.Windows.Forms.ColumnHeader();
            this.tbox_produto = new System.Windows.Forms.TextBox();
            this.tbox_preco = new System.Windows.Forms.TextBox();
            this.tbox_qtde = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.label_qtde = new System.Windows.Forms.Label();
            this.label_preco = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.bt_obter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listview_produtos
            // 
            this.listview_produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna_nome,
            this.coluna_qtde,
            this.coluna_preco});
            this.listview_produtos.FullRowSelect = true;
            this.listview_produtos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listview_produtos.Location = new System.Drawing.Point(12, 12);
            this.listview_produtos.MultiSelect = false;
            this.listview_produtos.Name = "listview_produtos";
            this.listview_produtos.Size = new System.Drawing.Size(286, 147);
            this.listview_produtos.TabIndex = 0;
            this.listview_produtos.UseCompatibleStateImageBehavior = false;
            this.listview_produtos.View = System.Windows.Forms.View.Details;
            this.listview_produtos.SelectedIndexChanged += new System.EventHandler(this.listview_produtos_SelectedIndexChanged);
            // 
            // coluna_nome
            // 
            this.coluna_nome.Text = "Nome Produto";
            this.coluna_nome.Width = 100;
            // 
            // coluna_qtde
            // 
            this.coluna_qtde.Text = "Quantidade";
            this.coluna_qtde.Width = 80;
            // 
            // coluna_preco
            // 
            this.coluna_preco.Text = "Preço Produto";
            this.coluna_preco.Width = 90;
            // 
            // tbox_produto
            // 
            this.tbox_produto.Location = new System.Drawing.Point(14, 211);
            this.tbox_produto.Name = "tbox_produto";
            this.tbox_produto.Size = new System.Drawing.Size(86, 23);
            this.tbox_produto.TabIndex = 1;
            // 
            // tbox_preco
            // 
            this.tbox_preco.Location = new System.Drawing.Point(181, 211);
            this.tbox_preco.Name = "tbox_preco";
            this.tbox_preco.Size = new System.Drawing.Size(69, 23);
            this.tbox_preco.TabIndex = 2;
            // 
            // tbox_qtde
            // 
            this.tbox_qtde.Location = new System.Drawing.Point(106, 211);
            this.tbox_qtde.Name = "tbox_qtde";
            this.tbox_qtde.Size = new System.Drawing.Size(69, 23);
            this.tbox_qtde.TabIndex = 3;
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(14, 193);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(86, 15);
            this.label_nome.TabIndex = 4;
            this.label_nome.Text = "Nome Produto";
            // 
            // label_qtde
            // 
            this.label_qtde.AutoSize = true;
            this.label_qtde.Location = new System.Drawing.Point(106, 193);
            this.label_qtde.Name = "label_qtde";
            this.label_qtde.Size = new System.Drawing.Size(69, 15);
            this.label_qtde.TabIndex = 5;
            this.label_qtde.Text = "Quantidade";
            // 
            // label_preco
            // 
            this.label_preco.AutoSize = true;
            this.label_preco.Location = new System.Drawing.Point(181, 193);
            this.label_preco.Name = "label_preco";
            this.label_preco.Size = new System.Drawing.Size(37, 15);
            this.label_preco.TabIndex = 6;
            this.label_preco.Text = "Preço";
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add.Location = new System.Drawing.Point(87, 240);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(107, 23);
            this.bt_add.TabIndex = 7;
            this.bt_add.Text = "Adicionar";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_remover.Location = new System.Drawing.Point(87, 269);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(107, 23);
            this.bt_remover.TabIndex = 8;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = false;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // bt_obter
            // 
            this.bt_obter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_obter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_obter.Location = new System.Drawing.Point(87, 298);
            this.bt_obter.Name = "bt_obter";
            this.bt_obter.Size = new System.Drawing.Size(107, 23);
            this.bt_obter.TabIndex = 9;
            this.bt_obter.Text = "Obter";
            this.bt_obter.UseVisualStyleBackColor = false;
            this.bt_obter.Click += new System.EventHandler(this.bt_obter_Click);
            // 
            // FormListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 464);
            this.Controls.Add(this.bt_obter);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.label_preco);
            this.Controls.Add(this.label_qtde);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.tbox_qtde);
            this.Controls.Add(this.tbox_preco);
            this.Controls.Add(this.tbox_produto);
            this.Controls.Add(this.listview_produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListView";
            this.Load += new System.EventHandler(this.FormListView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listview_produtos;
        private ColumnHeader coluna_nome;
        private ColumnHeader coluna_qtde;
        private ColumnHeader coluna_preco;
        private TextBox tbox_produto;
        private TextBox tbox_preco;
        private TextBox tbox_qtde;
        private Label label_nome;
        private Label label_qtde;
        private Label label_preco;
        private Button bt_add;
        private Button bt_remover;
        private Button bt_obter;
    }
}