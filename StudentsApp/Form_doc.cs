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
    public partial class Form_doc : Form
    {

        //Nashel esli
        static string StudBook;
        //int finded_StudentApp;
        static string SurNameRus, NameRus, PatronymicRus, Birthday,
            Nationality, DateIn, NumGroup,/*<Home*/Street, House, Flat, /*>*/
            City, PhoneMobile, PhoneHome, IdFamilyStatus, IdPayType, NumStudBook, IdSpec, sex, UzBeforeSname, DiplomeDate,
            IdStudentVuz;

        string Today = DateTime.Now.ToString("«dd» MMMM yyyyг");

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbStud.mdf;Integrated Security=True";
                //con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\dbStud.mdf;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT NameRus 'Имя',SurNameRus 'Фамилия' ,PatronymicRus 'Отчество' ," +
                                  "Course 'Курс', NumGroup 'Номер группы', NumStudBook 'Зачётка' FROM [Students]" +
                                  "WHERE SurNameRus LIKE N'" + textBox1.Text + "%' AND NumGroup = N'"+comboBoxGroup.Text+ "'  AND NameRus = N'" + textBox2.Text + "'   ";
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
           // buttonFind.Enabled = true;
        }

        public Form_doc()
        {
            InitializeComponent();
            buttonCreate.Enabled = false;
            buttonSpravka.Enabled = false;
            //buttonFind.Enabled = false;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            try
            {
                int row = (dataGridView1.CurrentCell.RowIndex);
                string SurName = dataGridView1.Rows[row].Cells[0].Value.ToString();
                string Name = dataGridView1.Rows[row].Cells[1].Value.ToString();
                int Group = Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);
                textBox1.Text = SurName.ToString();
                textBox2.Text = Name.ToString();
                comboBoxGroup.Text = Group.ToString();

                labelStudChoose.Text = "Студент: Выбран";
                labelStudChoose.ForeColor = Color.Lime;
                buttonCreate.Enabled = true;

                StudBook = textBox1.Text;

                string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbStud.mdf;Integrated Security=True";
                //string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\dbStud.mdf;Integrated Security=True";
                ReadOrderData(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            buttonCreate.Enabled = true;
            buttonSpravka.Enabled = true;
        }

        //Функция для замены меток
        private void ReplaceStub(string stubToReplace, string text, word.Document wordDocument)
        {
            var range = wordDocument.Content; //переменная для хранения данных документа
            range.Find.ClearFormatting(); //метод сброса всех настроек текста
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text); //находим ключевые слова и заменяем их
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            fix_date();
            var wordApp = new word.Application();
            wordApp.Visible = true;
            try
            {
                var wordDocument = wordApp.Documents.Open(System.Windows.Forms.Application.StartupPath + @"\templateStud.docx");
                //var wordDocument = wordApp.Documents.Open(@"H:\\БАЗЫ ДАННЫХ\!курсач БД\StudentApp\StudentApp\bin\Debug\templateStud.docx");  //переменная для хранения нашего документа
                ReplaceStub("{SurNameRus}", SurNameRus, wordDocument);
                ReplaceStub("{NameRus}", NameRus, wordDocument);
                ReplaceStub("{PatronymicRus}", PatronymicRus, wordDocument);
                ReplaceStub("{Birthday}", Birthday, wordDocument);
                ReplaceStub("{Nationality}", Nationality, wordDocument);
                ReplaceStub("{DateIn}", DateIn, wordDocument);
                ReplaceStub("{NumGroup}", NumGroup, wordDocument);
                ReplaceStub("{Street}", Street, wordDocument); ReplaceStub("{Street}", Street, wordDocument);
                ReplaceStub("{House}", House, wordDocument);   ReplaceStub("{House}", House, wordDocument);
                ReplaceStub("{Flat}", Flat, wordDocument);     ReplaceStub("{Flat}", Flat, wordDocument);
                ReplaceStub("{City}", City, wordDocument);
                ReplaceStub("{PhoneMobile}", PhoneMobile, wordDocument);
                ReplaceStub("{PhoneHome}", PhoneHome, wordDocument);
                ReplaceStub("{IdFamilyStatus}", IdFamilyStatus, wordDocument);
                ReplaceStub("{IdPayType}", IdPayType, wordDocument);
                ReplaceStub("{NumStudBook}", NumStudBook, wordDocument);
                //++++++++ NEW +++++++++
                ReplaceStub("{IdSpec}", IdSpec, wordDocument); 
                ReplaceStub("{Sex}", sex, wordDocument);
                ReplaceStub("{TodayDay}", Today, wordDocument);
                ReplaceStub("{UzBeforeSname}", UzBeforeSname, wordDocument);

                //wordDocument.SaveAs(@"E:\templateStud3.docx"); //сохраняем наш документ
                //wordDocument.Close(); //закрываем документ

                labelStudChoose.Text = "Студент: Не выбран";
                labelStudChoose.ForeColor = Color.Maroon;
                SQL_In_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            buttonCreate.Enabled = false;
           // buttonFind.Enabled = false;
        }

        private void buttonSpravka_Click(object sender, EventArgs e)
        {
            fix_date();
            var wordApp = new word.Application();
            wordApp.Visible = true;
            try
            {
                var wordDocument = wordApp.Documents.Open(System.Windows.Forms.Application.StartupPath + @"\Studspavka.docx");
                //var wordDocument = wordApp.Documents.Open(@"H:\\БАЗЫ ДАННЫХ\!курсач БД\StudentApp\StudentApp\bin\Debug\templateStud.docx");  //переменная для хранения нашего документа
                ReplaceStub("{SurNameRus}", SurNameRus, wordDocument);
                ReplaceStub("{NameRus}", NameRus, wordDocument);
                ReplaceStub("{PatronymicRus}", PatronymicRus, wordDocument);
                ReplaceStub("{TodayDay}", Today, wordDocument);
                ReplaceStub("{IdSpec}", IdSpec, wordDocument);

                ReplaceStub("{DiplomeDate}", DiplomeDate, wordDocument);
                ReplaceStub("{DateIn}", DateIn, wordDocument); 
                ReplaceStub("{IdStudentVuz}", IdStudentVuz, wordDocument);
                //wordDocument.SaveAs(@"E:\templateStud3.docx"); //сохраняем наш документ
                //wordDocument.Close(); //закрываем документ

                labelStudChoose.Text = "Студент: Не выбран";
                labelStudChoose.ForeColor = Color.Maroon;
                SQL_In_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            buttonCreate.Enabled = false;
           // buttonFind.Enabled = false;
            buttonSpravka.Enabled = false;
        }

        private static void ReadOrderData(string connectionString)
        {
            string queryString =
                "SELECT Students.NameRus, SurNameRus, PatronymicRus, Birthday, Nationality," +
                "DateIn, NumGroup, Street, House, Flat, " +
                "City, PhoneMobile, PhoneHome, IdFamilyStatus," +
                "IdPayType, NumStudBook, Name, Sex, UzBeforeSname, ShortNameRus " +
                "FROM Students, Spec, VUZ " +
                "WHERE SurNameRus LIKE N'%" + StudBook + "%' AND CodeSpec = IdSpec AND idVuz = IdStudentVuz";

            using (SqlConnection connection =
                       new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    ReadSingleRow((IDataRecord)reader);
                }

                // Call Close when done reading.
                reader.Close();
            }
        }

        private static void ReadSingleRow(IDataRecord record)
        {
            NameRus = record[0].ToString();
            SurNameRus = record[1].ToString();
            PatronymicRus = record[2].ToString();
            Birthday = record[3].ToString();
            Nationality = record[4].ToString();
            DateIn = record[5].ToString();
            NumGroup = record[6].ToString();
            Street = record[7].ToString();
            House = record[8].ToString();
            Flat = record[9].ToString();
            City = record[10].ToString();
            PhoneMobile = record[11].ToString();
            PhoneHome = record[12].ToString();
            IdFamilyStatus = record[13].ToString();
            IdPayType = record[14].ToString();
            NumStudBook = record[15].ToString();
            IdSpec = record[16].ToString();
            sex = record[17].ToString();
            UzBeforeSname = record[18].ToString();
            IdStudentVuz = record[19].ToString();
            MessageBox.Show(String.Format("Выбранный студент:{0}, {1}, {2}", record[0], record[1], record[2]));
        }

        public void fix_date()
        {
            string coockie = "";
            string coockie2 = "";
            for (int i = 0; i < 10; i++)
            {
                coockie += Birthday[i];
                coockie2 += DateIn[i];
            }
            Birthday = coockie;
            DateIn = coockie2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (!Char.IsDigit(textBox1.Text[i]))
                {
                    textBox1.Text = textBox1.Text.Remove(i, 1);
                    textBox1.SelectionStart = textBox1.Text.Length;
                    break;
                }
            }
            if (textBox1.Text == "") Form_doc_Load(sender, e);
            if (textBox1.Text != "")
            {
               SQL_In_Data();
            }*/
        }

        private void Form_doc_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.Students". При необходимости она может быть перемещена или удалена.
           // this.studentsTableAdapter.Fill(this.dbStudDataSet.Students);
            SQL_In_Data();
        }

        public void SQL_In_Data()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbStud.mdf;Integrated Security=True";
                //con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\dbStud.mdf;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT SurNameRus 'Фамилия' ,NameRus 'Имя',PatronymicRus 'Отчество' ," +
                                  "NumGroup 'Группа', Course 'Курс', NumStudBook 'Зачётка' FROM [Students]";
                                  
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
}
