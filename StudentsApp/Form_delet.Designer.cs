namespace StudentsApp
{
    partial class Form_delet
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
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
        
            this.label2 = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.labelO = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_add = new System.Windows.Forms.Button();
          
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
           
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
           
            // 
            // dbStudDataSet
            // 
 
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Номер зачётки на удаление";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.labelN.ForeColor = System.Drawing.Color.White;
            this.labelN.Location = new System.Drawing.Point(15, 22);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(96, 20);
            this.labelN.TabIndex = 9;
            this.labelN.Text = "Имя студента";
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.labelF.ForeColor = System.Drawing.Color.White;
            this.labelF.Location = new System.Drawing.Point(15, 51);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(129, 20);
            this.labelF.TabIndex = 10;
            this.labelF.Text = "Фамилия студента";
            // 
            // labelO
            // 
            this.labelO.AutoSize = true;
            this.labelO.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.labelO.ForeColor = System.Drawing.Color.White;
            this.labelO.Location = new System.Drawing.Point(15, 81);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(129, 20);
            this.labelO.TabIndex = 11;
            this.labelO.Text = "Отчество студента";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelN);
            this.groupBox1.Controls.Add(this.labelO);
            this.groupBox1.Controls.Add(this.labelF);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(233, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 110);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбраный студент";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.White;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.button_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(129)))), ((int)(((byte)(168)))));
            this.button_add.Location = new System.Drawing.Point(7, 54);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(220, 36);
            this.button_add.TabIndex = 13;
            this.button_add.Text = "Удалить студента";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // studentsTableAdapter
            // 
          
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(7, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 26);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form_delet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(483, 121);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(499, 160);
            this.MinimumSize = new System.Drawing.Size(499, 160);
            this.Name = "Form_delet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление студента";
            this.Load += new System.EventHandler(this.Form_delet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Label labelO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.TextBox textBox1;
    }
}