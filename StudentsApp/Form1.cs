using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using word = Microsoft.Office.Interop.Word;

namespace StudentsApp
{
    public partial class Form1 : Form
    {

        public static string STR_TBFind;
        // Data Source=DESKTOP-9PBGB2Q;Initial Catalog=dbStud;Integrated Security=True
        string SQL_My_Con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbStud.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            groupBoxBF.Hide();
            textBox_Find.Enabled = true;

            labelFind.Location = new Point(12, 69);

            dataGridView1.Size = new Size(dataGridView1.Size.Width, dataGridView1.Size.Height + 166);
            dataGridView1.Location = new Point(12, 92);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_add f_add = new Form_add();
            //this.Hide();
            f_add.Show();
        }

        private void button_create_DocStud_Click(object sender, EventArgs e)
        {
            Form_doc fd = new Form_doc();
            fd.Show();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.Spec". При необходимости она может быть перемещена или удалена.
            this.specTableAdapter.Fill(this.dbStudDataSet.Spec);
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = SQL_My_Con;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT SurNameRus 'Фамилия', NameRus 'Имя', PatronymicRus 'Отчество'," +
                                  "Course 'Курс', NumGroup 'Номер группы', NumStudBook 'Зачётка' FROM [Students]";
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                ArrayList records = new ArrayList();
                if (rdr.HasRows)
                {
                    foreach (DbDataRecord rec in rdr)
                    {
                        records.Add(rec);
                    }
                }
                con.Close();
                dataGridView1.DataSource = records;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void refresh()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = SQL_My_Con;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT NameRus 'Имя',SurNameRus 'Фамилия', PatronymicRus 'Отчество'," +
                              "Course 'Курс', NumGroup 'Номер группы', NumStudBook 'Зачётка', IdPayType 'Форма оплаты' FROM [Students]";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            ArrayList records = new ArrayList();
            if (rdr.HasRows)
            {
                foreach (DbDataRecord rec in rdr)
                {
                    records.Add(rec);
                }
            }
            con.Close();
            dataGridView1.DataSource = records;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {            
            int row = (dataGridView1.CurrentCell.RowIndex);
            int Deletline = Convert.ToInt32(dataGridView1.Rows[row].Cells[5].Value);
            int GridIndex = Deletline;
            textBox_Find.Text = GridIndex.ToString();
                STR_TBFind = textBox_Find.Text;
                Form_edit fe = new Form_edit();
                fe.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form_delet fd = new Form_delet();
                fd.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox_Find.Text.Length; i++)
            {
                if (!Char.IsDigit(textBox_Find.Text[i]))
                {
                    textBox_Find.Text = textBox_Find.Text.Remove(i, 1);
                    textBox_Find.SelectionStart = textBox_Find.Text.Length;
                    break;
                }
            }
            if (textBox_Find.Text == "") Form1_Load(sender, e);
            if (textBox_Find.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = SQL_My_Con;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT SurNameRus 'Фамилия', NameRus 'Имя', PatronymicRus 'Отчество'," +
                                      "Course 'Курс', NumGroup 'Номер группы', NumStudBook 'Зачётка' FROM [Students]" +
                                      "WHERE NumStudBook LIKE '" + textBox_Find.Text + "%'";
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    ArrayList records = new ArrayList();
                    if (rdr.HasRows)
                    {
                        foreach (DbDataRecord rec in rdr)
                        {
                            records.Add(rec);
                        }
                    }
                    con.Close();
                    dataGridView1.DataSource = records;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        // ================== ADD ==================
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label_help.Text = "Данный объект откроет форму добавления студента";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label_help.Text = "Выберите объект";
        }
        // ================== EDIT ==================
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            label_help.Text = "Данный объект откроет форму изменения данных о студенте";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label_help.Text = "Выберите объект";
        }

        // ================== DELET ==================
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label_help.Text = "Данный объект откроет форму удаления данных о студенте";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label_help.Text = "Выберите объект";
        }

        // ================== REFRESH ==================
        private void btn_Refresh_MouseEnter(object sender, EventArgs e)
        {
            label_help.Text = "При нажатии на объект будет обновлён список студентов";
        }

        private void btn_Refresh_MouseLeave(object sender, EventArgs e)
        {
            label_help.Text = "Выберите объект";
        }
        // ================== FIND ==================
        private void textBox_Find_MouseEnter(object sender, EventArgs e)
        {
            label_help.Text = "Поиск по зачётной книжки студента";
        }

        private void textBox_Find_MouseLeave(object sender, EventArgs e)
        {
            label_help.Text = "Выберите объект";
        }
        // ================== DATA GRID ==================
        private void dataGridView1_MouseEnter_1(object sender, EventArgs e)
        {
            label_help.Text = "Список студентов хранящихся в базе данных";
        }

        private void dataGridView1_MouseLeave_1(object sender, EventArgs e)
        {
            label_help.Text = "Выберите объект";
        }
        // ================== ALL DATA ==================
        private void button_all_MouseEnter(object sender, EventArgs e)
        {
            label_help.Text = "Отоброзитит все возможные данные о студенте";
        }

        private void button_all_MouseLeave(object sender, EventArgs e)
        {
            label_help.Text = "Выберите объект";
        }
        // ================== СREATE DOC ==================
        private void button_create_DocStud_MouseEnter(object sender, EventArgs e)
        {
            label_help.Text = "Данная кнопка откроет форму создания документов";
        }

        private void button_create_DocStud_MouseLeave(object sender, EventArgs e)
        {
            label_help.Text = "Выберите объект";
        }



        private void button_all_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = SQL_My_Con;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT [SurnameRus] 'Фамилия рус',[NameRus] 'Имя рус',[PatronymicRus] 'Отчество рус',[SurnameBel] 'Фамилия бел',[NameBel] 'Имя бел',[PatronymicBel] 'Отчество бел'," +
            " [FIOlatin] 'ФИО латиницей',[Birthday] 'Дата рождения',[IdDocType] 'Тип документов',[Docseries]  'Серия документов',[Docnum] 'Номер документов',[Docwhere] 'Кем выданы документы',[Docdate]'Дата док',[Docenddate],[PerconalNum]'Персональный номер',[IdFamilyStatus]'Семейный статус',[Sex]'Пол студента',[IdCitizenship]'Город'," +
            " [Nationality] 'Нацианальность',[PhoneHome] 'Домашний номер',[PhoneMobile] 'Мобильный номер',[Email],[Country],[Area],[Region],[CityType],[City],[StreetType],[Street],[House],[HouseExt],[Flat]," +
            " [IndexMail],[Campus],[IdEduStatus],[Course] 'Курс',[IdFacultyVuz],[IdPayType],[NumGroup] 'Номер группы',[NumStudBook],[DateIn] 'Дата поступления',[BaseForeignLan],[DogNum],[DogDate],[TargetOrganization]," +
            " [PerconalGrant] 'Персональный номер',[UzBeforeSname] 'Пред. место обучения', [IdStudentVuz] 'ВУЗ стуеднта',[IdSpec] 'Специальность',[IdSpecialization] 'Специализация',[IdEducationForm] 'Форма обучения' " +
            " FROM [Students];";
                                 
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                ArrayList records = new ArrayList();
                if (rdr.HasRows)
                {
                    foreach (DbDataRecord rec in rdr)
                    {
                        records.Add(rec);
                    }
                }
                con.Close();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dataGridView1.DataSource = records;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        /* С ID СТРОКА ВЫВОДА
            cmd.CommandText = "SELECT [IdStudentVuz][IdSpec][IdSpecialization][IdEducationForm] [SurnameRus][NameRus][PatronymicRus][SurnameBel],[NameBel],[PatronymicBel],"+
            " [FIOlatin],[Birthday],[IdDocType],[Docseries] ,[Docnum] ,[Docwhere],[Docdate],[Docenddate],[PerconalNum],[IdFamilyStatus],[Sex],[IdCitizenship],"+
            " [Nationality],[PhoneHome],[PhoneMobile],[Email],[Country],[Area],[Region],[CityType],[City],[StreetType],[Street],[House],[HouseExt],[Flat],"+
            " [IndexMail],[Campus],[IdEduStatus],[Course],[IdFacultyVuz],[IdPayType],[NumGroup],[NumStudBook],[DateIn],[BaseForeignLan],[DogNum],[DogDate],[TargetOrganization],"+
            " [PerconalGrant],[UzBeforeSname] " +
             */

        private void checkBox1_EnabledChanged(object sender, EventArgs e)
        {
            //TRUE
            //loc 12; 235  size 140; 20
            //FALSE
            //loc 12^ 0 size 140; 20
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox1.Checked == true)
            {
                groupBoxBF.Show();
                textBox_Find.Enabled = false;

                labelFind.Location = new Point(12, 235);

                dataGridView1.Size = new Size(dataGridView1.Size.Width, dataGridView1.Size.Height - 166);
                dataGridView1.Location = new Point(12, 258);
            }
            else
            {
                groupBoxBF.Hide();
                textBox_Find.Enabled = true;

                labelFind.Location = new Point(12, 69);

                dataGridView1.Size = new Size(dataGridView1.Size.Width, dataGridView1.Size.Height + 166);
                dataGridView1.Location = new Point(12, 92);
            }
            comboBoxvuz.Text = "";
        }

        string cmdSurname, cmdName, cmdCurse, cmdVuz, cmdBday;


        //=====================  FAMILIYA =====================
        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            cmdSurname = " SurNameRus = N'" + textBoxSurname.Text + "' ";
        }
        private void checkBoxSurname_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSurname.Checked == true)
            {
                textBoxSurname.Enabled = true;
            }
            else
            {
                textBoxSurname.Enabled = false;
                textBoxSurname.Text = "";
                cmdSurname = "";
            }
        }
        //=====================  FAMILIYA =====================


        //===================== NAME =====================
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {            
            cmdName = "AND NameRus = N'" + textBoxName.Text + "' ";
            if (!checkBoxSurname.Checked)
                cmdName = "NameRus = N'" + textBoxName.Text + "' ";
        }
        private void checkBoxName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxName.Checked == true)
            {
                textBoxName.Enabled = true;
            }
            else
            {
                textBoxName.Enabled = false;
                textBoxName.Text = "";
                cmdName = "";
            }
        }
        //===================== NAME =====================


        // ===================== CURSE =====================
        private void textBoxCurse_TextChanged(object sender, EventArgs e)
        {           
            cmdCurse = "AND Course = N'" + textBoxCurse.Text + "' ";
            if(!checkBoxSurname.Checked && !checkBoxName.Checked)
                cmdCurse = "Course = N'" + textBoxCurse.Text + "' ";
        }
        private void checkBoxCurse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCurse.Checked == true)
            {
                textBoxCurse.Enabled = true;                
            }
            else
            {
                textBoxCurse.Enabled = false;
                textBoxCurse.Text = "";
                cmdCurse = "";
            }   
        }
        // ===================== CURSE =====================


        //===================== SPEC =====================
        private void comboBoxvuz_TextChanged(object sender, EventArgs e)
        {            
            cmdVuz = "AND IdSpec = N'" + comboBoxvuz.SelectedValue + "' ";
            if (!checkBoxSurname.Checked && !checkBoxName.Checked && !checkBoxCurse.Checked)
                cmdVuz = "IdSpec = N'" + comboBoxvuz.SelectedValue + "' ";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form_spavochnik fspr = new Form_spavochnik();
            fspr.Show();
        }

        private void button_analytics_Click(object sender, EventArgs e)
        {
            Form_analytics fa = new Form_analytics();
            fa.Show();
        }

        private void ReplaceStub(string stubToReplace, string text, word.Document wordDocument)
        {
            var range = wordDocument.Content; //переменная для хранения данных документа
            range.Find.ClearFormatting(); //метод сброса всех настроек текста
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text); //находим ключевые слова и заменяем их
        }

        private void buttonSpravka_Click(object sender, EventArgs e)
        {
        
        }

        private void buttonSpravka_Click_1(object sender, EventArgs e)
        {
            var wordApp = new word.Application();
            wordApp.Visible = true;
            var wordDocument = wordApp.Documents.Open(System.Windows.Forms.Application.StartupPath + @"\справка.docx");
        }

        private void checkBoxVuz_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVuz.Checked == true)
            {
                comboBoxvuz.Enabled = true;
            }
            else
            {
                comboBoxvuz.Enabled = false;
                comboBoxvuz.Text = "";
                cmdVuz = "";
            }            
        }
        //===================== VUZ =====================


        //===================== BITTHDAY =====================
        private void dateBirthday_ValueChanged(object sender, EventArgs e)
        {   
            cmdBday = "AND Birthday = N'" + dateBirthday.Text + "' ";
            if (!checkBoxSurname.Checked && !checkBoxName.Checked && !checkBoxCurse.Checked && !checkBoxVuz.Checked)
                cmdBday = "Birthday = N'" + dateBirthday.Text + "' ";
        }
        private void checkBoxBirthday_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBirthday.Checked == true)
            {
                dateBirthday.Enabled = true;
            }
            else
            {
                dateBirthday.Enabled = false;
                dateBirthday.Text = "01.01.1999";
                cmdBday = "";
            }            
        }
        //===================== BITTHDAY =====================


        // Кнопка расширеного поиска
        private void buttonFind_Click(object senъder, EventArgs e)
        {
            if (!checkBoxSurname.Checked && !checkBoxName.Checked && !checkBoxCurse.Checked && !checkBoxVuz.Checked && !checkBoxBirthday.Checked)
                MessageBox.Show("Выберите хотя бы один пунтк");
            /*else if (textBoxSurname.Text == "" || textBoxName.Text == "" || textBoxCurse.Text == "" || comboBoxvuz.Text == "")
                MessageBox.Show("Заполните пустые поля");*/
            else
            try
            {
                

                SqlConnection con = new SqlConnection();
                con.ConnectionString = SQL_My_Con;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT SurNameRus 'Фамилия', NameRus 'Имя', PatronymicRus 'Отчество'," +
                                    "Course 'Курс', NumGroup 'Номер группы', NumStudBook 'Зачётка', Birthday 'Дата рождения' FROM [Students] [Spec]" +
                                    "WHERE "+ cmdSurname  + cmdName + cmdCurse + cmdVuz + cmdBday;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                ArrayList records = new ArrayList();
                if (rdr.HasRows)
                {
                    foreach (DbDataRecord rec in rdr)
                    {
                        records.Add(rec);
                    }
                }
                con.Close();
                dataGridView1.DataSource = records;

                cmdSurname = ""; cmdName = ""; cmdCurse = ""; cmdVuz = ""; cmdBday = "";

                if (checkBoxSurname.Checked) textBoxSurname.Text = "";
                if (checkBoxName.Checked) textBoxName.Text = "";
                if (checkBoxCurse.Checked) textBoxCurse.Text = "";
                if (checkBoxVuz.Checked) comboBoxvuz.Text = "";
                if (checkBoxBirthday.Checked) dateBirthday.Text = "23.04.2019";
                textBox_Find.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();                

                }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }
    }
}
