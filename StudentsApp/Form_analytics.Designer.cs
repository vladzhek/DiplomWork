namespace StudentsApp
{
    partial class Form_analytics
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_analytics));
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbStudDataSet = new StudentsApp.dbStudDataSet();
            this.payTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new StudentsApp.dbStudDataSetTableAdapters.StudentsTableAdapter();
            this.button_menu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCourseW = new System.Windows.Forms.Label();
            this.button_sex_an_w = new System.Windows.Forms.Button();
            this.labelAllW = new System.Windows.Forms.Label();
            this.labelAllM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCourseM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.button_sex_an = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAllStud = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSO_all = new System.Windows.Forms.Label();
            this.labelSO = new System.Windows.Forms.Label();
            this.buttonPayType_3 = new System.Windows.Forms.Button();
            this.labelB = new System.Windows.Forms.Label();
            this.labelB_all = new System.Windows.Forms.Label();
            this.labelP_all = new System.Windows.Forms.Label();
            this.buttonPayType_2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.buttonPayType_1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.payTypeTableAdapter = new StudentsApp.dbStudDataSetTableAdapters.PayTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbStudDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payTypeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.dbStudDataSet;
            // 
            // dbStudDataSet
            // 
            this.dbStudDataSet.DataSetName = "dbStudDataSet";
            this.dbStudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payTypeBindingSource
            // 
            this.payTypeBindingSource.DataMember = "PayType";
            this.payTypeBindingSource.DataSource = this.dbStudDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // button_menu
            // 
            this.button_menu.BackColor = System.Drawing.Color.White;
            this.button_menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.button_menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(217)))));
            this.button_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.button_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.button_menu.Location = new System.Drawing.Point(12, 37);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(150, 36);
            this.button_menu.TabIndex = 50;
            this.button_menu.Text = "Меню";
            this.button_menu.UseVisualStyleBackColor = false;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelCourseW);
            this.groupBox1.Controls.Add(this.button_sex_an_w);
            this.groupBox1.Controls.Add(this.labelAllW);
            this.groupBox1.Controls.Add(this.labelAllM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelCourseM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxCourse);
            this.groupBox1.Controls.Add(this.button_sex_an);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 228);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пол студентов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(62, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 24);
            this.label6.TabIndex = 95;
            this.label6.Text = "курсе";
            // 
            // labelCourseW
            // 
            this.labelCourseW.AutoSize = true;
            this.labelCourseW.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.labelCourseW.ForeColor = System.Drawing.Color.White;
            this.labelCourseW.Location = new System.Drawing.Point(153, 159);
            this.labelCourseW.Name = "labelCourseW";
            this.labelCourseW.Size = new System.Drawing.Size(0, 24);
            this.labelCourseW.TabIndex = 90;
            // 
            // button_sex_an_w
            // 
            this.button_sex_an_w.BackColor = System.Drawing.Color.White;
            this.button_sex_an_w.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.button_sex_an_w.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(217)))));
            this.button_sex_an_w.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sex_an_w.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.button_sex_an_w.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.button_sex_an_w.Location = new System.Drawing.Point(9, 154);
            this.button_sex_an_w.Name = "button_sex_an_w";
            this.button_sex_an_w.Size = new System.Drawing.Size(139, 36);
            this.button_sex_an_w.TabIndex = 87;
            this.button_sex_an_w.Text = "Расчитать женщин";
            this.button_sex_an_w.UseVisualStyleBackColor = false;
            this.button_sex_an_w.Click += new System.EventHandler(this.button_sex_an_w_Click);
            // 
            // labelAllW
            // 
            this.labelAllW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAllW.AutoSize = true;
            this.labelAllW.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.labelAllW.ForeColor = System.Drawing.Color.White;
            this.labelAllW.Location = new System.Drawing.Point(204, 200);
            this.labelAllW.Name = "labelAllW";
            this.labelAllW.Size = new System.Drawing.Size(71, 20);
            this.labelAllW.TabIndex = 86;
            this.labelAllW.Text = "всегоЖун";
            // 
            // labelAllM
            // 
            this.labelAllM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAllM.AutoSize = true;
            this.labelAllM.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.labelAllM.ForeColor = System.Drawing.Color.White;
            this.labelAllM.Location = new System.Drawing.Point(63, 200);
            this.labelAllM.Name = "labelAllM";
            this.labelAllM.Size = new System.Drawing.Size(71, 20);
            this.labelAllM.TabIndex = 85;
            this.labelAllM.Text = "всегоМуж";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Всего:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "Соотношение лиц мужского пола к женскому:";
            // 
            // labelCourseM
            // 
            this.labelCourseM.AutoSize = true;
            this.labelCourseM.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.labelCourseM.ForeColor = System.Drawing.Color.White;
            this.labelCourseM.Location = new System.Drawing.Point(153, 117);
            this.labelCourseM.Name = "labelCourseM";
            this.labelCourseM.Size = new System.Drawing.Size(0, 24);
            this.labelCourseM.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(387, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "соотн";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxCourse.Location = new System.Drawing.Point(9, 78);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(49, 28);
            this.comboBoxCourse.TabIndex = 81;
            this.comboBoxCourse.Text = "1";
            // 
            // button_sex_an
            // 
            this.button_sex_an.BackColor = System.Drawing.Color.White;
            this.button_sex_an.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.button_sex_an.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(217)))));
            this.button_sex_an.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sex_an.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.button_sex_an.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.button_sex_an.Location = new System.Drawing.Point(9, 112);
            this.button_sex_an.Name = "button_sex_an";
            this.button_sex_an.Size = new System.Drawing.Size(139, 36);
            this.button_sex_an.TabIndex = 52;
            this.button_sex_an.Text = "Расчитать мужчин";
            this.button_sex_an.UseVisualStyleBackColor = false;
            this.button_sex_an.Click += new System.EventHandler(this.button_sex_an_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 29);
            this.label1.TabIndex = 53;
            this.label1.Text = "Соотношение лиц мужского пола или женского на:      курсе";
            // 
            // labelAllStud
            // 
            this.labelAllStud.AutoSize = true;
            this.labelAllStud.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.labelAllStud.ForeColor = System.Drawing.Color.White;
            this.labelAllStud.Location = new System.Drawing.Point(168, 42);
            this.labelAllStud.Name = "labelAllStud";
            this.labelAllStud.Size = new System.Drawing.Size(57, 24);
            this.labelAllStud.TabIndex = 83;
            this.labelAllStud.Text = "Всего";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.labelSO_all);
            this.groupBox3.Controls.Add(this.labelSO);
            this.groupBox3.Controls.Add(this.buttonPayType_3);
            this.groupBox3.Controls.Add(this.labelB);
            this.groupBox3.Controls.Add(this.labelB_all);
            this.groupBox3.Controls.Add(this.labelP_all);
            this.groupBox3.Controls.Add(this.buttonPayType_2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.labelP);
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Controls.Add(this.buttonPayType_1);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(14, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 226);
            this.groupBox3.TabIndex = 91;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Обучение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(232, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 94;
            this.label5.Text = " курса на";
            // 
            // labelSO_all
            // 
            this.labelSO_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSO_all.AutoSize = true;
            this.labelSO_all.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.labelSO_all.ForeColor = System.Drawing.Color.White;
            this.labelSO_all.Location = new System.Drawing.Point(63, 203);
            this.labelSO_all.Name = "labelSO_all";
            this.labelSO_all.Size = new System.Drawing.Size(63, 20);
            this.labelSO_all.TabIndex = 93;
            this.labelSO_all.Text = "всегоСО";
            // 
            // labelSO
            // 
            this.labelSO.AutoSize = true;
            this.labelSO.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.labelSO.ForeColor = System.Drawing.Color.White;
            this.labelSO.Location = new System.Drawing.Point(184, 101);
            this.labelSO.Name = "labelSO";
            this.labelSO.Size = new System.Drawing.Size(0, 24);
            this.labelSO.TabIndex = 92;
            // 
            // buttonPayType_3
            // 
            this.buttonPayType_3.BackColor = System.Drawing.Color.White;
            this.buttonPayType_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.buttonPayType_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(217)))));
            this.buttonPayType_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayType_3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.buttonPayType_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.buttonPayType_3.Location = new System.Drawing.Point(12, 97);
            this.buttonPayType_3.Name = "buttonPayType_3";
            this.buttonPayType_3.Size = new System.Drawing.Size(164, 36);
            this.buttonPayType_3.TabIndex = 91;
            this.buttonPayType_3.Text = "Средствах организации";
            this.buttonPayType_3.UseVisualStyleBackColor = false;
            this.buttonPayType_3.Click += new System.EventHandler(this.buttonPayType_3_Click);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.labelB.ForeColor = System.Drawing.Color.White;
            this.labelB.Location = new System.Drawing.Point(183, 60);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(0, 24);
            this.labelB.TabIndex = 90;
            // 
            // labelB_all
            // 
            this.labelB_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelB_all.AutoSize = true;
            this.labelB_all.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.labelB_all.ForeColor = System.Drawing.Color.White;
            this.labelB_all.Location = new System.Drawing.Point(204, 181);
            this.labelB_all.Name = "labelB_all";
            this.labelB_all.Size = new System.Drawing.Size(94, 20);
            this.labelB_all.TabIndex = 86;
            this.labelB_all.Text = "всегоБюджет";
            // 
            // labelP_all
            // 
            this.labelP_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelP_all.AutoSize = true;
            this.labelP_all.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.labelP_all.ForeColor = System.Drawing.Color.White;
            this.labelP_all.Location = new System.Drawing.Point(63, 181);
            this.labelP_all.Name = "labelP_all";
            this.labelP_all.Size = new System.Drawing.Size(113, 20);
            this.labelP_all.TabIndex = 85;
            this.labelP_all.Text = "всегоПдатников";
            // 
            // buttonPayType_2
            // 
            this.buttonPayType_2.BackColor = System.Drawing.Color.White;
            this.buttonPayType_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.buttonPayType_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(217)))));
            this.buttonPayType_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayType_2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPayType_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.buttonPayType_2.Location = new System.Drawing.Point(11, 55);
            this.buttonPayType_2.Name = "buttonPayType_2";
            this.buttonPayType_2.Size = new System.Drawing.Size(164, 36);
            this.buttonPayType_2.TabIndex = 87;
            this.buttonPayType_2.Text = "Бюджетной основе";
            this.buttonPayType_2.UseVisualStyleBackColor = false;
            this.buttonPayType_2.Click += new System.EventHandler(this.buttonPayType_2_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 84;
            this.label10.Text = "Всего:";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.labelP.ForeColor = System.Drawing.Color.White;
            this.labelP.Location = new System.Drawing.Point(183, 144);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(0, 24);
            this.labelP.TabIndex = 82;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox3.Location = new System.Drawing.Point(186, 27);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(49, 28);
            this.comboBox3.TabIndex = 81;
            this.comboBox3.Text = "1";
            // 
            // buttonPayType_1
            // 
            this.buttonPayType_1.BackColor = System.Drawing.Color.White;
            this.buttonPayType_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.buttonPayType_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(217)))));
            this.buttonPayType_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayType_1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPayType_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.buttonPayType_1.Location = new System.Drawing.Point(12, 139);
            this.buttonPayType_1.Name = "buttonPayType_1";
            this.buttonPayType_1.Size = new System.Drawing.Size(164, 36);
            this.buttonPayType_1.TabIndex = 52;
            this.buttonPayType_1.Text = "Платной основе";
            this.buttonPayType_1.UseVisualStyleBackColor = false;
            this.buttonPayType_1.Click += new System.EventHandler(this.buttonPayType_1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(7, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(188, 24);
            this.label14.TabIndex = 53;
            this.label14.Text = "Рассчитать учащихся";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reportViewer2);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.labelAllStud);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.button_menu);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1007, 544);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Аналитика студентов";
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "DataSetSex";
            reportDataSource1.Value = this.studentsBindingSource;
            reportDataSource2.Name = "DataSetPayType";
            reportDataSource2.Value = this.payTypeBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "StudentsApp.Report.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(479, 42);
            this.reportViewer2.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(507, 485);
            this.reportViewer2.TabIndex = 93;
            // 
            // payTypeTableAdapter
            // 
            this.payTypeTableAdapter.ClearBeforeFill = true;
            // 
            // Form_analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(1007, 544);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1023, 583);
            this.Name = "Form_analytics";
            this.Text = "Аналитика";
            this.Load += new System.EventHandler(this.Form_analytics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbStudDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payTypeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private dbStudDataSet dbStudDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private dbStudDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCourseW;
        private System.Windows.Forms.Button button_sex_an_w;
        private System.Windows.Forms.Label labelAllW;
        private System.Windows.Forms.Label labelAllM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCourseM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Button button_sex_an;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAllStud;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelSO_all;
        private System.Windows.Forms.Label labelSO;
        private System.Windows.Forms.Button buttonPayType_3;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelB_all;
        private System.Windows.Forms.Label labelP_all;
        private System.Windows.Forms.Button buttonPayType_2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button buttonPayType_1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource payTypeBindingSource;
        private dbStudDataSetTableAdapters.PayTypeTableAdapter payTypeTableAdapter;
    }
}