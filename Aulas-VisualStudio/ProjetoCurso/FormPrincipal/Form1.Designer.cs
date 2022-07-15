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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.label_titulo = new System.Windows.Forms.Label();
            this.tbox_animal = new System.Windows.Forms.TextBox();
            this.tbox_listaanimais = new System.Windows.Forms.TextBox();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_mostrar = new System.Windows.Forms.Button();
            this.bt_var = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkedLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskedTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuNotificacoes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuitem_restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_msg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MenuNotificacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_adicionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_adicionar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_adicionar.Location = new System.Drawing.Point(228, 70);
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
            this.label_titulo.Location = new System.Drawing.Point(52, 42);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(129, 21);
            this.label_titulo.TabIndex = 1;
            this.label_titulo.Text = "Digite um animal";
            // 
            // tbox_animal
            // 
            this.tbox_animal.Location = new System.Drawing.Point(52, 70);
            this.tbox_animal.Name = "tbox_animal";
            this.tbox_animal.Size = new System.Drawing.Size(170, 23);
            this.tbox_animal.TabIndex = 2;
            // 
            // tbox_listaanimais
            // 
            this.tbox_listaanimais.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbox_listaanimais.Location = new System.Drawing.Point(52, 99);
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
            this.bt_limpar.Location = new System.Drawing.Point(52, 298);
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
            this.bt_mostrar.Location = new System.Drawing.Point(52, 327);
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
            this.bt_var.Location = new System.Drawing.Point(52, 356);
            this.bt_var.Name = "bt_var";
            this.bt_var.Size = new System.Drawing.Size(295, 23);
            this.bt_var.TabIndex = 6;
            this.bt_var.Text = "Valor variável";
            this.bt_var.UseVisualStyleBackColor = false;
            this.bt_var.Click += new System.EventHandler(this.bt_var_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(407, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem,
            this.checkedListBoxToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.dateTimePickerToolStripMenuItem,
            this.linkedLabelToolStripMenuItem,
            this.listBoxToolStripMenuItem,
            this.listViewToolStripMenuItem,
            this.maskedTextBoxToolStripMenuItem,
            this.monthCalendarToolStripMenuItem,
            this.numericUpDownToolStripMenuItem,
            this.pictureBoxToolStripMenuItem,
            this.progressbarToolStripMenuItem,
            this.radioButtonToolStripMenuItem,
            this.editorTextoToolStripMenuItem,
            this.trackBarToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkBoxToolStripMenuItem.Text = "CheckBox";
            this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.checkBoxToolStripMenuItem_Click);
            // 
            // checkedListBoxToolStripMenuItem
            // 
            this.checkedListBoxToolStripMenuItem.Name = "checkedListBoxToolStripMenuItem";
            this.checkedListBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkedListBoxToolStripMenuItem.Text = "CheckedListBox";
            this.checkedListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkedListBoxToolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // dateTimePickerToolStripMenuItem
            // 
            this.dateTimePickerToolStripMenuItem.Name = "dateTimePickerToolStripMenuItem";
            this.dateTimePickerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dateTimePickerToolStripMenuItem.Text = "DateTimePicker";
            this.dateTimePickerToolStripMenuItem.Click += new System.EventHandler(this.dateTimePickerToolStripMenuItem_Click);
            // 
            // linkedLabelToolStripMenuItem
            // 
            this.linkedLabelToolStripMenuItem.Name = "linkedLabelToolStripMenuItem";
            this.linkedLabelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linkedLabelToolStripMenuItem.Text = "LinkedLabel";
            this.linkedLabelToolStripMenuItem.Click += new System.EventHandler(this.linkedLabelToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listViewToolStripMenuItem.Text = "ListView";
            this.listViewToolStripMenuItem.Click += new System.EventHandler(this.listViewToolStripMenuItem_Click);
            // 
            // maskedTextBoxToolStripMenuItem
            // 
            this.maskedTextBoxToolStripMenuItem.Name = "maskedTextBoxToolStripMenuItem";
            this.maskedTextBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maskedTextBoxToolStripMenuItem.Text = "MaskedTextBox";
            this.maskedTextBoxToolStripMenuItem.Click += new System.EventHandler(this.maskedTextBoxToolStripMenuItem_Click);
            // 
            // monthCalendarToolStripMenuItem
            // 
            this.monthCalendarToolStripMenuItem.Name = "monthCalendarToolStripMenuItem";
            this.monthCalendarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monthCalendarToolStripMenuItem.Text = "MonthCalendar";
            this.monthCalendarToolStripMenuItem.Click += new System.EventHandler(this.monthCalendarToolStripMenuItem_Click);
            // 
            // numericUpDownToolStripMenuItem
            // 
            this.numericUpDownToolStripMenuItem.Name = "numericUpDownToolStripMenuItem";
            this.numericUpDownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.numericUpDownToolStripMenuItem.Text = "NumericUpDown";
            this.numericUpDownToolStripMenuItem.Click += new System.EventHandler(this.numericUpDownToolStripMenuItem_Click);
            // 
            // pictureBoxToolStripMenuItem
            // 
            this.pictureBoxToolStripMenuItem.Name = "pictureBoxToolStripMenuItem";
            this.pictureBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pictureBoxToolStripMenuItem.Text = "PictureBox";
            this.pictureBoxToolStripMenuItem.Click += new System.EventHandler(this.pictureBoxToolStripMenuItem_Click);
            // 
            // progressbarToolStripMenuItem
            // 
            this.progressbarToolStripMenuItem.Name = "progressbarToolStripMenuItem";
            this.progressbarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.progressbarToolStripMenuItem.Text = "Progressbar";
            this.progressbarToolStripMenuItem.Click += new System.EventHandler(this.progressbarToolStripMenuItem_Click);
            // 
            // radioButtonToolStripMenuItem
            // 
            this.radioButtonToolStripMenuItem.Name = "radioButtonToolStripMenuItem";
            this.radioButtonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.radioButtonToolStripMenuItem.Text = "RadioButton";
            this.radioButtonToolStripMenuItem.Click += new System.EventHandler(this.radioButtonToolStripMenuItem_Click);
            // 
            // editorTextoToolStripMenuItem
            // 
            this.editorTextoToolStripMenuItem.Name = "editorTextoToolStripMenuItem";
            this.editorTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editorTextoToolStripMenuItem.Text = "EditorTexto";
            this.editorTextoToolStripMenuItem.Click += new System.EventHandler(this.editorTextoToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.MenuNotificacoes;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Menu";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // MenuNotificacoes
            // 
            this.MenuNotificacoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitem_restaurar,
            this.menuitem_msg,
            this.menuitem_fechar});
            this.MenuNotificacoes.Name = "contextMenuStrip1";
            this.MenuNotificacoes.Size = new System.Drawing.Size(134, 70);
            this.MenuNotificacoes.Opening += new System.ComponentModel.CancelEventHandler(this.MenuNotificacoes_Opening);
            this.MenuNotificacoes.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuNotificacoes_ItemClicked);
            // 
            // menuitem_restaurar
            // 
            this.menuitem_restaurar.Name = "menuitem_restaurar";
            this.menuitem_restaurar.Size = new System.Drawing.Size(133, 22);
            this.menuitem_restaurar.Text = "Restaurar";
            // 
            // menuitem_msg
            // 
            this.menuitem_msg.Name = "menuitem_msg";
            this.menuitem_msg.Size = new System.Drawing.Size(133, 22);
            this.menuitem_msg.Text = "Mensagem";
            // 
            // menuitem_fechar
            // 
            this.menuitem_fechar.Name = "menuitem_fechar";
            this.menuitem_fechar.Size = new System.Drawing.Size(133, 22);
            this.menuitem_fechar.Text = "Fechar";
            // 
            // trackBarToolStripMenuItem
            // 
            this.trackBarToolStripMenuItem.Name = "trackBarToolStripMenuItem";
            this.trackBarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trackBarToolStripMenuItem.Text = "TrackBar";
            this.trackBarToolStripMenuItem.Click += new System.EventHandler(this.trackBarToolStripMenuItem_Click);
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
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuNotificacoes.ResumeLayout(false);
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem componentesToolStripMenuItem;
        private ToolStripMenuItem checkBoxToolStripMenuItem;
        private ToolStripMenuItem checkedListBoxToolStripMenuItem;
        private ToolStripMenuItem comboBoxToolStripMenuItem;
        private ToolStripMenuItem dateTimePickerToolStripMenuItem;
        private ToolStripMenuItem linkedLabelToolStripMenuItem;
        private ToolStripMenuItem listBoxToolStripMenuItem;
        private ToolStripMenuItem listViewToolStripMenuItem;
        private ToolStripMenuItem maskedTextBoxToolStripMenuItem;
        private ToolStripMenuItem monthCalendarToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip MenuNotificacoes;
        private ToolStripMenuItem menuitem_restaurar;
        private ToolStripMenuItem menuitem_msg;
        private ToolStripMenuItem menuitem_fechar;
        private ToolStripMenuItem numericUpDownToolStripMenuItem;
        private ToolStripMenuItem pictureBoxToolStripMenuItem;
        private ToolStripMenuItem progressbarToolStripMenuItem;
        private ToolStripMenuItem radioButtonToolStripMenuItem;
        private ToolStripMenuItem editorTextoToolStripMenuItem;
        private ToolStripMenuItem trackBarToolStripMenuItem;

        public EventHandler FormPrincipal_Load { get; private set; }
    }
}