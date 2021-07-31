namespace StudentsApp
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_add = new System.Windows.Forms.Button();
            this.button_delet = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.textBox_Find = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_edit = new System.Windows.Forms.Button();
            this.labelFind = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_help = new System.Windows.Forms.Label();
            this.button_all = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_analytics = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_create_DocStud = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonFind = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBoxBF = new System.Windows.Forms.GroupBox();
            this.checkBoxBirthday = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxSurname = new System.Windows.Forms.CheckBox();
            this.checkBoxVuz = new System.Windows.Forms.CheckBox();
            this.checkBoxCurse = new System.Windows.Forms.CheckBox();
            this.comboBoxvuz = new System.Windows.Forms.ComboBox();
            this.specBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbStudDataSet = new StudentsApp.dbStudDataSet();
            this.dateBirthday = new System.Windows.Forms.DateTimePicker();
            this.textBoxCurse = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.buttonSpravka = new System.Windows.Forms.Button();
            this.specTableAdapter = new StudentsApp.dbStudDataSetTableAdapters.SpecTableAdapter();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxBF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbStudDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.White;
            this.button_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(217)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.button_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.button_add.Location = new System.Drawing.Point(2, 3);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(243, 36);
            this.button_add.TabIndex = 50;
            this.button_add.Text = "Добавить студента";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button1_Click);
            this.button_add.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button_add.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button_delet
            // 
            this.button_delet.BackColor = System.Drawing.Color.White;
            this.button_delet.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_delet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.button_delet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(217)))));
            this.button_delet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delet.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.button_delet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.button_delet.Location = new System.Drawing.Point(2, 75);
            this.button_delet.Name = "button_delet";
            this.button_delet.Size = new System.Drawing.Size(243, 36);
            this.button_delet.TabIndex = 2;
            this.button_delet.Text = "Удалить студента";
            this.button_delet.UseVisualStyleBackColor = false;
            this.button_delet.Click += new System.EventHandler(this.button2_Click);
            this.button_delet.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button_delet.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BackColor = System.Drawing.Color.White;
            this.btn_Refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(217)))));
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.btn_Refresh.Location = new System.Drawing.Point(533, 50);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(106, 31);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "ОБНОВИТЬ";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.button3_Click);
            this.btn_Refresh.MouseEnter += new System.EventHandler(this.btn_Refresh_MouseEnter);
            this.btn_Refresh.MouseLeave += new System.EventHandler(this.btn_Refresh_MouseLeave);
            // 
            // textBox_Find
            // 
            this.textBox_Find.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.textBox_Find.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.textBox_Find.Location = new System.Drawing.Point(12, 27);
            this.textBox_Find.Name = "textBox_Find";
            this.textBox_Find.Size = new System.Drawing.Size(237, 26);
            this.textBox_Find.TabIndex = 4;
            this.textBox_Find.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox_Find.MouseEnter += new System.EventHandler(this.textBox_Find_MouseEnter);
            this.textBox_Find.MouseLeave += new System.EventHandler(this.textBox_Find_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Номер зачётной книжки студента";
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.White;
            this.button_edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.button_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(217)))));
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.button_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.button_edit.Location = new System.Drawing.Point(2, 39);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(243, 36);
            this.button_edit.TabIndex = 6;
            this.button_edit.Text = "Изменить данные";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button4_Click);
            this.button_edit.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button_edit.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.labelFind.ForeColor = System.Drawing.Color.White;
            this.labelFind.Location = new System.Drawing.Point(12, 235);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(148, 20);
            this.labelFind.TabIndex = 7;
            this.labelFind.Text = "Найденные студенты";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.label_help);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 174);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "!?! Описание !?!";
            // 
            // label_help
            // 
            this.label_help.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_help.Location = new System.Drawing.Point(7, 24);
            this.label_help.Name = "label_help";
            this.label_help.Size = new System.Drawing.Size(219, 94);
            this.label_help.TabIndex = 0;
            this.label_help.Text = "Наведите на объект";
            // 
            // button_all
            // 
            this.button_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_all.BackColor = System.Drawing.Color.White;
            this.button_all.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.button_all.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(217)))));
            this.button_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_all.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.button_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.button_all.Location = new System.Drawing.Point(533, 13);
            this.button_all.Name = "button_all";
            this.button_all.Size = new System.Drawing.Size(106, 31);
            this.button_all.TabIndex = 10;
            this.button_all.Text = "ВСЕ ДАННЫЕ";
            this.button_all.UseVisualStyleBackColor = false;
            this.button_all.Click += new System.EventHandler(this.button_all_Click);
            this.button_all.MouseEnter += new System.EventHandler(this.button_all_MouseEnter);
            this.button_all.MouseLeave += new System.EventHandler(this.button_all_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(88)))), ((int)(((byte)(121)))));
            this.panel1.Controls.Add(this.button_analytics);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button_create_DocStud);
            this.panel1.Controls.Add(this.button_delet);
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(643, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.panel1.Size = new System.Drawing.Size(247, 436);
            this.panel1.TabIndex = 11;
            // 
            // button_analytics
            // 
            this.button_analytics.BackColor = System.Drawing.Color.White;
            this.button_analytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_analytics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.button_analytics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(217)))));
            this.button_analytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_analytics.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.button_analytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.button_analytics.Location = new System.Drawing.Point(2, 183);
            this.button_analytics.Name = "button_analytics";
            this.button_analytics.Size = new System.Drawing.Size(243, 36);
            this.button_analytics.TabIndex = 52;
            this.button_analytics.Text = "Аналитика";
            this.button_analytics.UseVisualStyleBackColor = false;
            this.button_analytics.Click += new System.EventHandler(this.button_analytics_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(217)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.button1.Location = new System.Drawing.Point(2, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 36);
            this.button1.TabIndex = 51;
            this.button1.Text = "Справочники";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_create_DocStud
            // 
            this.button_create_DocStud.BackColor = System.Drawing.Color.White;
            this.button_create_DocStud.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_create_DocStud.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.button_create_DocStud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(217)))));
            this.button_create_DocStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create_DocStud.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.button_create_DocStud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.button_create_DocStud.Location = new System.Drawing.Point(2, 111);
            this.button_create_DocStud.Name = "button_create_DocStud";
            this.button_create_DocStud.Size = new System.Drawing.Size(243, 36);
            this.button_create_DocStud.TabIndex = 10;
            this.button_create_DocStud.Text = "Создание документов";
            this.button_create_DocStud.UseVisualStyleBackColor = false;
            this.button_create_DocStud.Click += new System.EventHandler(this.button_create_DocStud_Click);
            this.button_create_DocStud.MouseEnter += new System.EventHandler(this.button_create_DocStud_MouseEnter);
            this.button_create_DocStud.MouseLeave += new System.EventHandler(this.button_create_DocStud_MouseLeave);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(168)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Size = new System.Drawing.Size(625, 166);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.MouseEnter += new System.EventHandler(this.dataGridView1_MouseEnter_1);
            this.dataGridView1.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave_1);
            // 
            // buttonFind
            // 
            this.buttonFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFind.BackColor = System.Drawing.Color.White;
            this.buttonFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.buttonFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(217)))));
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFind.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.buttonFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.buttonFind.Location = new System.Drawing.Point(385, 135);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(121, 31);
            this.buttonFind.TabIndex = 52;
            this.buttonFind.Text = "Искать";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(255, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(163, 24);
            this.checkBox1.TabIndex = 53;
            this.checkBox1.Text = "Расширенный поиск";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.EnabledChanged += new System.EventHandler(this.checkBox1_EnabledChanged);
            // 
            // groupBoxBF
            // 
            this.groupBoxBF.Controls.Add(this.checkBoxBirthday);
            this.groupBoxBF.Controls.Add(this.checkBoxName);
            this.groupBoxBF.Controls.Add(this.checkBoxSurname);
            this.groupBoxBF.Controls.Add(this.checkBoxVuz);
            this.groupBoxBF.Controls.Add(this.checkBoxCurse);
            this.groupBoxBF.Controls.Add(this.comboBoxvuz);
            this.groupBoxBF.Controls.Add(this.dateBirthday);
            this.groupBoxBF.Controls.Add(this.textBoxCurse);
            this.groupBoxBF.Controls.Add(this.textBoxName);
            this.groupBoxBF.Controls.Add(this.buttonFind);
            this.groupBoxBF.Controls.Add(this.textBoxSurname);
            this.groupBoxBF.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxBF.ForeColor = System.Drawing.Color.White;
            this.groupBoxBF.Location = new System.Drawing.Point(12, 59);
            this.groupBoxBF.Name = "groupBoxBF";
            this.groupBoxBF.Size = new System.Drawing.Size(515, 173);
            this.groupBoxBF.TabIndex = 54;
            this.groupBoxBF.TabStop = false;
            this.groupBoxBF.Text = "Расширенный поиск";
            // 
            // checkBoxBirthday
            // 
            this.checkBoxBirthday.AutoSize = true;
            this.checkBoxBirthday.Checked = true;
            this.checkBoxBirthday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBirthday.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxBirthday.ForeColor = System.Drawing.Color.White;
            this.checkBoxBirthday.Location = new System.Drawing.Point(259, 64);
            this.checkBoxBirthday.Name = "checkBoxBirthday";
            this.checkBoxBirthday.Size = new System.Drawing.Size(125, 24);
            this.checkBoxBirthday.TabIndex = 85;
            this.checkBoxBirthday.Text = "Дата рождения";
            this.checkBoxBirthday.UseVisualStyleBackColor = true;
            this.checkBoxBirthday.CheckedChanged += new System.EventHandler(this.checkBoxBirthday_CheckedChanged);
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Checked = true;
            this.checkBoxName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxName.ForeColor = System.Drawing.Color.White;
            this.checkBoxName.Location = new System.Drawing.Point(259, 16);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(55, 24);
            this.checkBoxName.TabIndex = 84;
            this.checkBoxName.Text = "Имя";
            this.checkBoxName.UseVisualStyleBackColor = true;
            this.checkBoxName.CheckedChanged += new System.EventHandler(this.checkBoxName_CheckedChanged);
            // 
            // checkBoxSurname
            // 
            this.checkBoxSurname.AutoSize = true;
            this.checkBoxSurname.Checked = true;
            this.checkBoxSurname.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSurname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxSurname.ForeColor = System.Drawing.Color.White;
            this.checkBoxSurname.Location = new System.Drawing.Point(20, 16);
            this.checkBoxSurname.Name = "checkBoxSurname";
            this.checkBoxSurname.Size = new System.Drawing.Size(88, 24);
            this.checkBoxSurname.TabIndex = 83;
            this.checkBoxSurname.Text = "Фамилия";
            this.checkBoxSurname.UseVisualStyleBackColor = true;
            this.checkBoxSurname.CheckedChanged += new System.EventHandler(this.checkBoxSurname_CheckedChanged);
            // 
            // checkBoxVuz
            // 
            this.checkBoxVuz.AutoSize = true;
            this.checkBoxVuz.Checked = true;
            this.checkBoxVuz.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVuz.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxVuz.ForeColor = System.Drawing.Color.White;
            this.checkBoxVuz.Location = new System.Drawing.Point(20, 114);
            this.checkBoxVuz.Name = "checkBoxVuz";
            this.checkBoxVuz.Size = new System.Drawing.Size(128, 24);
            this.checkBoxVuz.TabIndex = 82;
            this.checkBoxVuz.Text = "Специальность";
            this.checkBoxVuz.UseVisualStyleBackColor = true;
            this.checkBoxVuz.CheckedChanged += new System.EventHandler(this.checkBoxVuz_CheckedChanged);
            // 
            // checkBoxCurse
            // 
            this.checkBoxCurse.AutoSize = true;
            this.checkBoxCurse.Checked = true;
            this.checkBoxCurse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCurse.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxCurse.ForeColor = System.Drawing.Color.White;
            this.checkBoxCurse.Location = new System.Drawing.Point(20, 64);
            this.checkBoxCurse.Name = "checkBoxCurse";
            this.checkBoxCurse.Size = new System.Drawing.Size(58, 24);
            this.checkBoxCurse.TabIndex = 81;
            this.checkBoxCurse.Text = "Курс";
            this.checkBoxCurse.UseVisualStyleBackColor = true;
            this.checkBoxCurse.CheckedChanged += new System.EventHandler(this.checkBoxCurse_CheckedChanged);
            // 
            // comboBoxvuz
            // 
            this.comboBoxvuz.DataSource = this.specBindingSource;
            this.comboBoxvuz.DisplayMember = "Name";
            this.comboBoxvuz.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxvuz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.comboBoxvuz.FormattingEnabled = true;
            this.comboBoxvuz.Location = new System.Drawing.Point(20, 138);
            this.comboBoxvuz.MaxLength = 80;
            this.comboBoxvuz.Name = "comboBoxvuz";
            this.comboBoxvuz.Size = new System.Drawing.Size(359, 28);
            this.comboBoxvuz.TabIndex = 80;
            this.comboBoxvuz.ValueMember = "CodeSpec";
            this.comboBoxvuz.TextChanged += new System.EventHandler(this.comboBoxvuz_TextChanged);
            // 
            // specBindingSource
            // 
            this.specBindingSource.DataMember = "Spec";
            this.specBindingSource.DataSource = this.dbStudDataSet;
            // 
            // dbStudDataSet
            // 
            this.dbStudDataSet.DataSetName = "dbStudDataSet";
            this.dbStudDataSet.EnforceConstraints = false;
            this.dbStudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateBirthday
            // 
            this.dateBirthday.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.dateBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBirthday.Location = new System.Drawing.Point(265, 91);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Size = new System.Drawing.Size(227, 26);
            this.dateBirthday.TabIndex = 79;
            this.dateBirthday.ValueChanged += new System.EventHandler(this.dateBirthday_ValueChanged);
            // 
            // textBoxCurse
            // 
            this.textBoxCurse.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxCurse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.textBoxCurse.Location = new System.Drawing.Point(20, 88);
            this.textBoxCurse.Name = "textBoxCurse";
            this.textBoxCurse.Size = new System.Drawing.Size(233, 26);
            this.textBoxCurse.TabIndex = 63;
            this.textBoxCurse.TextChanged += new System.EventHandler(this.textBoxCurse_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.textBoxName.Location = new System.Drawing.Point(259, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(233, 26);
            this.textBoxName.TabIndex = 57;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.textBoxSurname.Location = new System.Drawing.Point(20, 39);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(233, 26);
            this.textBoxSurname.TabIndex = 55;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // buttonSpravka
            // 
            this.buttonSpravka.BackColor = System.Drawing.Color.White;
            this.buttonSpravka.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.buttonSpravka.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(217)))));
            this.buttonSpravka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpravka.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSpravka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.buttonSpravka.Location = new System.Drawing.Point(424, 13);
            this.buttonSpravka.Name = "buttonSpravka";
            this.buttonSpravka.Size = new System.Drawing.Size(106, 31);
            this.buttonSpravka.TabIndex = 56;
            this.buttonSpravka.Text = "Справка";
            this.buttonSpravka.UseVisualStyleBackColor = false;
            this.buttonSpravka.Click += new System.EventHandler(this.buttonSpravka_Click_1);
            // 
            // specTableAdapter
            // 
            this.specTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(890, 436);
            this.Controls.Add(this.buttonSpravka);
            this.Controls.Add(this.groupBoxBF);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_all);
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Find);
            this.Controls.Add(this.btn_Refresh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(906, 475);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentsApplication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxBF.ResumeLayout(false);
            this.groupBoxBF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbStudDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delet;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox textBox_Find;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_help;
        private System.Windows.Forms.Button button_all;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_create_DocStud;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBoxBF;
        private System.Windows.Forms.TextBox textBoxCurse;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.ComboBox comboBoxvuz;
        private System.Windows.Forms.DateTimePicker dateBirthday;
        private System.Windows.Forms.CheckBox checkBoxBirthday;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxVuz;
        private System.Windows.Forms.CheckBox checkBoxCurse;
        private System.Windows.Forms.CheckBox checkBoxSurname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_analytics;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSpravka;
        private dbStudDataSet dbStudDataSet;
        private System.Windows.Forms.BindingSource specBindingSource;
        private dbStudDataSetTableAdapters.SpecTableAdapter specTableAdapter;
    }
}

