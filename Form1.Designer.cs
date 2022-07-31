namespace My_Utilities
{
    partial class My_Utilities
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.блокнотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_insert_date = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_insert_time = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_load = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_about = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tc_convert = new System.Windows.Forms.TabPage();
            this.tb_to = new System.Windows.Forms.TextBox();
            this.tb_from = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.cb_to = new System.Windows.Forms.ComboBox();
            this.cb_from = new System.Windows.Forms.ComboBox();
            this.tc_password = new System.Windows.Forms.TabPage();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_create_password = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_password_length = new System.Windows.Forms.NumericUpDown();
            this.clb_password = new System.Windows.Forms.CheckedListBox();
            this.tc_notebook = new System.Windows.Forms.TabPage();
            this.rtb_notepad = new System.Windows.Forms.RichTextBox();
            this.tc_random = new System.Windows.Forms.TabPage();
            this.cb_repeat_rnd = new System.Windows.Forms.CheckBox();
            this.btn_copy_rnd = new System.Windows.Forms.Button();
            this.btn_clear_rnd = new System.Windows.Forms.Button();
            this.tb_rnd_text = new System.Windows.Forms.TextBox();
            this.btn_random = new System.Windows.Forms.Button();
            this.nud_upper = new System.Windows.Forms.NumericUpDown();
            this.nud_lower = new System.Windows.Forms.NumericUpDown();
            this.lbl_rnd_number = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tc_counter = new System.Windows.Forms.TabPage();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn_swap = new System.Windows.Forms.Button();
            this.cb_metric = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tc_convert.SuspendLayout();
            this.tc_password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_password_length)).BeginInit();
            this.tc_notebook.SuspendLayout();
            this.tc_random.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_upper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_lower)).BeginInit();
            this.tc_counter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.блокнотToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // tsmi_exit
            // 
            this.tsmi_exit.Name = "tsmi_exit";
            this.tsmi_exit.Size = new System.Drawing.Size(136, 26);
            this.tsmi_exit.Text = "Выход";
            this.tsmi_exit.Click += new System.EventHandler(this.tsmi_exit_Click);
            // 
            // блокнотToolStripMenuItem
            // 
            this.блокнотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_insert_date,
            this.tsmi_insert_time,
            this.toolStripMenuItem1,
            this.tsmi_save,
            this.tsmi_load});
            this.блокнотToolStripMenuItem.Name = "блокнотToolStripMenuItem";
            this.блокнотToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.блокнотToolStripMenuItem.Text = "Блокнот";
            // 
            // tsmi_insert_date
            // 
            this.tsmi_insert_date.Name = "tsmi_insert_date";
            this.tsmi_insert_date.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.tsmi_insert_date.Size = new System.Drawing.Size(299, 26);
            this.tsmi_insert_date.Text = "Вставить дату";
            this.tsmi_insert_date.Click += new System.EventHandler(this.tsmi_insert_date_Click);
            // 
            // tsmi_insert_time
            // 
            this.tsmi_insert_time.Name = "tsmi_insert_time";
            this.tsmi_insert_time.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.tsmi_insert_time.Size = new System.Drawing.Size(299, 26);
            this.tsmi_insert_time.Text = "Вставить время";
            this.tsmi_insert_time.Click += new System.EventHandler(this.tsmi_insert_time_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(296, 6);
            // 
            // tsmi_save
            // 
            this.tsmi_save.Name = "tsmi_save";
            this.tsmi_save.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmi_save.Size = new System.Drawing.Size(299, 26);
            this.tsmi_save.Text = "Сохранить";
            this.tsmi_save.Click += new System.EventHandler(this.tsmi_save_Click);
            // 
            // tsmi_load
            // 
            this.tsmi_load.Name = "tsmi_load";
            this.tsmi_load.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.tsmi_load.Size = new System.Drawing.Size(299, 26);
            this.tsmi_load.Text = "Загрузить";
            this.tsmi_load.Click += new System.EventHandler(this.tsmi_load_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_about});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // tsmi_about
            // 
            this.tsmi_about.Name = "tsmi_about";
            this.tsmi_about.Size = new System.Drawing.Size(187, 26);
            this.tsmi_about.Text = "О программе";
            this.tsmi_about.Click += new System.EventHandler(this.tsmi_about_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tc_convert);
            this.TabControl.Controls.Add(this.tc_password);
            this.TabControl.Controls.Add(this.tc_notebook);
            this.TabControl.Controls.Add(this.tc_random);
            this.TabControl.Controls.Add(this.tc_counter);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 28);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 422);
            this.TabControl.TabIndex = 1;
            // 
            // tc_convert
            // 
            this.tc_convert.Controls.Add(this.cb_metric);
            this.tc_convert.Controls.Add(this.btn_swap);
            this.tc_convert.Controls.Add(this.tb_to);
            this.tc_convert.Controls.Add(this.tb_from);
            this.tc_convert.Controls.Add(this.btn_convert);
            this.tc_convert.Controls.Add(this.cb_to);
            this.tc_convert.Controls.Add(this.cb_from);
            this.tc_convert.Location = new System.Drawing.Point(4, 29);
            this.tc_convert.Name = "tc_convert";
            this.tc_convert.Size = new System.Drawing.Size(792, 389);
            this.tc_convert.TabIndex = 4;
            this.tc_convert.Text = "Конвертер";
            this.tc_convert.UseVisualStyleBackColor = true;
            // 
            // tb_to
            // 
            this.tb_to.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_to.Location = new System.Drawing.Point(529, 171);
            this.tb_to.Name = "tb_to";
            this.tb_to.ReadOnly = true;
            this.tb_to.Size = new System.Drawing.Size(237, 49);
            this.tb_to.TabIndex = 4;
            this.tb_to.Text = "1";
            // 
            // tb_from
            // 
            this.tb_from.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_from.Location = new System.Drawing.Point(8, 171);
            this.tb_from.Name = "tb_from";
            this.tb_from.Size = new System.Drawing.Size(195, 49);
            this.tb_from.TabIndex = 3;
            // 
            // btn_convert
            // 
            this.btn_convert.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_convert.Location = new System.Drawing.Point(226, 171);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(281, 49);
            this.btn_convert.TabIndex = 2;
            this.btn_convert.Text = "Конвертировать";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // cb_to
            // 
            this.cb_to.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_to.FormattingEnabled = true;
            this.cb_to.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cb_to.Location = new System.Drawing.Point(529, 94);
            this.cb_to.Name = "cb_to";
            this.cb_to.Size = new System.Drawing.Size(237, 49);
            this.cb_to.TabIndex = 1;
            this.cb_to.Text = "mm";
            // 
            // cb_from
            // 
            this.cb_from.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_from.FormattingEnabled = true;
            this.cb_from.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cb_from.Location = new System.Drawing.Point(8, 94);
            this.cb_from.Name = "cb_from";
            this.cb_from.Size = new System.Drawing.Size(195, 49);
            this.cb_from.TabIndex = 0;
            this.cb_from.Text = "mm";
            // 
            // tc_password
            // 
            this.tc_password.Controls.Add(this.tb_password);
            this.tc_password.Controls.Add(this.btn_create_password);
            this.tc_password.Controls.Add(this.label3);
            this.tc_password.Controls.Add(this.nud_password_length);
            this.tc_password.Controls.Add(this.clb_password);
            this.tc_password.Location = new System.Drawing.Point(4, 29);
            this.tc_password.Name = "tc_password";
            this.tc_password.Size = new System.Drawing.Size(792, 389);
            this.tc_password.TabIndex = 3;
            this.tc_password.Text = "Пароли";
            this.tc_password.UseVisualStyleBackColor = true;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_password.Location = new System.Drawing.Point(24, 325);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(743, 49);
            this.tb_password.TabIndex = 4;
            // 
            // btn_create_password
            // 
            this.btn_create_password.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_create_password.Location = new System.Drawing.Point(160, 253);
            this.btn_create_password.Name = "btn_create_password";
            this.btn_create_password.Size = new System.Drawing.Size(433, 60);
            this.btn_create_password.TabIndex = 3;
            this.btn_create_password.Text = "Создать пароль";
            this.btn_create_password.UseVisualStyleBackColor = true;
            this.btn_create_password.Click += new System.EventHandler(this.btn_create_password_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Длина пароля";
            // 
            // nud_password_length
            // 
            this.nud_password_length.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nud_password_length.Location = new System.Drawing.Point(274, 198);
            this.nud_password_length.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nud_password_length.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_password_length.Name = "nud_password_length";
            this.nud_password_length.Size = new System.Drawing.Size(84, 49);
            this.nud_password_length.TabIndex = 1;
            this.nud_password_length.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // clb_password
            // 
            this.clb_password.CheckOnClick = true;
            this.clb_password.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clb_password.FormattingEnabled = true;
            this.clb_password.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Спец.символы @,%,*,~,?,#,$,&,^,!"});
            this.clb_password.Location = new System.Drawing.Point(8, 12);
            this.clb_password.Name = "clb_password";
            this.clb_password.Size = new System.Drawing.Size(628, 180);
            this.clb_password.TabIndex = 0;
            // 
            // tc_notebook
            // 
            this.tc_notebook.Controls.Add(this.rtb_notepad);
            this.tc_notebook.Location = new System.Drawing.Point(4, 29);
            this.tc_notebook.Name = "tc_notebook";
            this.tc_notebook.Size = new System.Drawing.Size(792, 389);
            this.tc_notebook.TabIndex = 2;
            this.tc_notebook.Text = "Блокнот";
            this.tc_notebook.UseVisualStyleBackColor = true;
            // 
            // rtb_notepad
            // 
            this.rtb_notepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_notepad.Location = new System.Drawing.Point(0, 0);
            this.rtb_notepad.Name = "rtb_notepad";
            this.rtb_notepad.Size = new System.Drawing.Size(792, 389);
            this.rtb_notepad.TabIndex = 0;
            this.rtb_notepad.Text = "";
            // 
            // tc_random
            // 
            this.tc_random.Controls.Add(this.cb_repeat_rnd);
            this.tc_random.Controls.Add(this.btn_copy_rnd);
            this.tc_random.Controls.Add(this.btn_clear_rnd);
            this.tc_random.Controls.Add(this.tb_rnd_text);
            this.tc_random.Controls.Add(this.btn_random);
            this.tc_random.Controls.Add(this.nud_upper);
            this.tc_random.Controls.Add(this.nud_lower);
            this.tc_random.Controls.Add(this.lbl_rnd_number);
            this.tc_random.Controls.Add(this.label2);
            this.tc_random.Controls.Add(this.label1);
            this.tc_random.Location = new System.Drawing.Point(4, 29);
            this.tc_random.Name = "tc_random";
            this.tc_random.Padding = new System.Windows.Forms.Padding(3);
            this.tc_random.Size = new System.Drawing.Size(792, 389);
            this.tc_random.TabIndex = 1;
            this.tc_random.Text = "Генератор";
            this.tc_random.UseVisualStyleBackColor = true;
            // 
            // cb_repeat_rnd
            // 
            this.cb_repeat_rnd.AutoSize = true;
            this.cb_repeat_rnd.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_repeat_rnd.Location = new System.Drawing.Point(39, 321);
            this.cb_repeat_rnd.Name = "cb_repeat_rnd";
            this.cb_repeat_rnd.Size = new System.Drawing.Size(271, 45);
            this.cb_repeat_rnd.TabIndex = 9;
            this.cb_repeat_rnd.Text = "без повторений";
            this.cb_repeat_rnd.UseVisualStyleBackColor = true;
            // 
            // btn_copy_rnd
            // 
            this.btn_copy_rnd.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_copy_rnd.Location = new System.Drawing.Point(35, 260);
            this.btn_copy_rnd.Name = "btn_copy_rnd";
            this.btn_copy_rnd.Size = new System.Drawing.Size(224, 55);
            this.btn_copy_rnd.TabIndex = 8;
            this.btn_copy_rnd.Text = "Копировать";
            this.btn_copy_rnd.UseVisualStyleBackColor = true;
            this.btn_copy_rnd.Click += new System.EventHandler(this.btn_copy_rnd_Click);
            // 
            // btn_clear_rnd
            // 
            this.btn_clear_rnd.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear_rnd.Location = new System.Drawing.Point(35, 193);
            this.btn_clear_rnd.Name = "btn_clear_rnd";
            this.btn_clear_rnd.Size = new System.Drawing.Size(224, 55);
            this.btn_clear_rnd.TabIndex = 7;
            this.btn_clear_rnd.Text = "Очистить";
            this.btn_clear_rnd.UseVisualStyleBackColor = true;
            this.btn_clear_rnd.Click += new System.EventHandler(this.btn_clear_rnd_Click);
            // 
            // tb_rnd_text
            // 
            this.tb_rnd_text.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_rnd_text.Location = new System.Drawing.Point(546, 165);
            this.tb_rnd_text.Multiline = true;
            this.tb_rnd_text.Name = "tb_rnd_text";
            this.tb_rnd_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_rnd_text.Size = new System.Drawing.Size(173, 199);
            this.tb_rnd_text.TabIndex = 6;
            // 
            // btn_random
            // 
            this.btn_random.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_random.Location = new System.Drawing.Point(254, 77);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(205, 53);
            this.btn_random.TabIndex = 5;
            this.btn_random.Text = "Сгенерировать";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // nud_upper
            // 
            this.nud_upper.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nud_upper.Location = new System.Drawing.Point(112, 122);
            this.nud_upper.Name = "nud_upper";
            this.nud_upper.Size = new System.Drawing.Size(112, 49);
            this.nud_upper.TabIndex = 4;
            // 
            // nud_lower
            // 
            this.nud_lower.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nud_lower.Location = new System.Drawing.Point(112, 42);
            this.nud_lower.Name = "nud_lower";
            this.nud_lower.Size = new System.Drawing.Size(112, 49);
            this.nud_lower.TabIndex = 3;
            // 
            // lbl_rnd_number
            // 
            this.lbl_rnd_number.AutoSize = true;
            this.lbl_rnd_number.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_rnd_number.Location = new System.Drawing.Point(543, 80);
            this.lbl_rnd_number.Name = "lbl_rnd_number";
            this.lbl_rnd_number.Size = new System.Drawing.Size(36, 41);
            this.lbl_rnd_number.TabIndex = 2;
            this.lbl_rnd_number.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "До";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "От";
            // 
            // tc_counter
            // 
            this.tc_counter.Controls.Add(this.lblCount);
            this.tc_counter.Controls.Add(this.btnReset);
            this.tc_counter.Controls.Add(this.btn_minus);
            this.tc_counter.Controls.Add(this.btnPlus);
            this.tc_counter.Location = new System.Drawing.Point(4, 29);
            this.tc_counter.Name = "tc_counter";
            this.tc_counter.Padding = new System.Windows.Forms.Padding(3);
            this.tc_counter.Size = new System.Drawing.Size(792, 389);
            this.tc_counter.TabIndex = 0;
            this.tc_counter.Text = "Счётчик";
            this.tc_counter.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCount.Location = new System.Drawing.Point(228, 148);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(36, 41);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(403, 110);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(153, 117);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_minus.Location = new System.Drawing.Point(167, 236);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(162, 80);
            this.btn_minus.TabIndex = 1;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Location = new System.Drawing.Point(167, 27);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(162, 71);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btn_swap
            // 
            this.btn_swap.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_swap.Location = new System.Drawing.Point(226, 94);
            this.btn_swap.Name = "btn_swap";
            this.btn_swap.Size = new System.Drawing.Size(281, 49);
            this.btn_swap.TabIndex = 5;
            this.btn_swap.Text = "<->";
            this.btn_swap.UseVisualStyleBackColor = true;
            this.btn_swap.Click += new System.EventHandler(this.btn_swap_Click);
            // 
            // cb_metric
            // 
            this.cb_metric.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_metric.FormattingEnabled = true;
            this.cb_metric.Items.AddRange(new object[] {
            "длина",
            "вес"});
            this.cb_metric.Location = new System.Drawing.Point(296, 20);
            this.cb_metric.Name = "cb_metric";
            this.cb_metric.Size = new System.Drawing.Size(150, 49);
            this.cb_metric.TabIndex = 6;
            this.cb_metric.Text = "длина";
            this.cb_metric.SelectedIndexChanged += new System.EventHandler(this.cb_metric_SelectedIndexChanged);
            // 
            // My_Utilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "My_Utilities";
            this.Text = "Мои утилиты";
            this.Load += new System.EventHandler(this.My_Utilities_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tc_convert.ResumeLayout(false);
            this.tc_convert.PerformLayout();
            this.tc_password.ResumeLayout(false);
            this.tc_password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_password_length)).EndInit();
            this.tc_notebook.ResumeLayout(false);
            this.tc_random.ResumeLayout(false);
            this.tc_random.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_upper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_lower)).EndInit();
            this.tc_counter.ResumeLayout(false);
            this.tc_counter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem tsmi_exit;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private ToolStripMenuItem tsmi_about;
        private TabControl TabControl;
        private TabPage tc_counter;
        private Label lblCount;
        private Button btnReset;
        private Button btn_minus;
        private Button btnPlus;
        private TabPage tc_random;
        private Button btn_random;
        private NumericUpDown nud_upper;
        private NumericUpDown nud_lower;
        private Label lbl_rnd_number;
        private Label label2;
        private Label label1;
        private CheckBox cb_repeat_rnd;
        private Button btn_copy_rnd;
        private Button btn_clear_rnd;
        private TextBox tb_rnd_text;
        private ToolStripMenuItem блокнотToolStripMenuItem;
        private ToolStripMenuItem tsmi_insert_date;
        private ToolStripMenuItem tsmi_insert_time;
        private TabPage tc_notebook;
        private RichTextBox rtb_notepad;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem tsmi_save;
        private ToolStripMenuItem tsmi_load;
        private TabPage tc_password;
        private CheckedListBox clb_password;
        private Label label3;
        private NumericUpDown nud_password_length;
        private TextBox tb_password;
        private Button btn_create_password;
        private TabPage tc_convert;
        private TextBox tb_to;
        private TextBox tb_from;
        private Button btn_convert;
        private ComboBox cb_to;
        private ComboBox cb_from;
        private Button btn_swap;
        private ComboBox cb_metric;
    }
}