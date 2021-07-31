using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsApp
{
    public partial class Form_add : Form
    {
        //   Data Source=DESKTOP-9PBGB2Q;Initial Catalog=dbStud;Integrated Security=True
        string SQL_My_Con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbStud.mdf;Integrated Security=True";


        string Fixed_dateBirthday, Fixed_dateVidach, Fixed_dateSrokdeystv, Fixed_datePostyp1y, fixed_dateDog
             ;
        Bitmap imageReact = new Bitmap("1.jpg");
        public Form_add()
        {
            InitializeComponent();
            //Прячу от юзера таб контрол
            /* tabControl1.Appearance = TabAppearance.FlatButtons;
             tabControl1.ItemSize = new Size(0, 1);
             tabControl1.SizeMode = TabSizeMode.Fixed;
             tabControl1.TabStop = false;
             comboBoxFormPay
             */
        }

        //myString = myString.Substring(0, myString.Length-3);       
        public void fix_date()
        {
            // ПРИСВАИВАЮ ДАТЫ
            //Student
            Fixed_dateBirthday = dateBirthday.Value.ToString(); 
            Fixed_dateVidach = dateVidach.Value.ToString(); 
            Fixed_dateSrokdeystv = dateSrokdeystv.Value.ToString(); 
            Fixed_datePostyp1y = datePostup.Value.ToString();
            fixed_dateDog = dateDog.Value.ToString();
            //diplom
            // ОБРЕЗАНИЕ 
            //Student
            Fixed_dateBirthday = Fixed_dateBirthday.Substring(0, Fixed_dateBirthday.Length - 8);
            Fixed_dateVidach = Fixed_dateVidach.Substring(0, Fixed_dateVidach.Length - 8);
            Fixed_dateSrokdeystv = Fixed_dateSrokdeystv.Substring(0, Fixed_dateSrokdeystv.Length - 8);
            Fixed_datePostyp1y = Fixed_datePostyp1y.Substring(0, Fixed_datePostyp1y.Length - 8);
            fixed_dateDog = fixed_dateDog.Substring(0, fixed_dateDog.Length - 8);
            //diplom
           // Fixed_dateTime_DiplomDate = Fixed_dateTime_DiplomDate.Substring(0, Fixed_dateTime_DiplomDate.Length - 8);
           // Fixed_dateTime_DateGraduate = Fixed_dateTime_DateGraduate.Substring(0, Fixed_dateTime_DateGraduate.Length - 8);
           
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool haveStudBook = false;
        bool havespace = false;

        private void button_add_Click_1(object sender, EventArgs e)
        {
            NumStudbook_test();
            if (!haveStudBook)
            {
                
                HaveSpace();
                if (havespace == true) {
                    MessageBox.Show("Заполните пустые поля"); havespace = false;  }
                else
                    try
                    {
                        string connectionString = SQL_My_Con;
                        //fix_date();
                        string sqlExpression = "INSERT INTO [Students] VALUES (N'" + textBoxIdStud.Text + "', N'" + /**/Convert.ToInt32(cb_IdStudVuz.SelectedValue) + "', " +
                        "N'" + /**/Convert.ToInt32(cb_IdSpec.SelectedValue) + "', N'" + /**/Convert.ToInt32(cb_IdSpecaliz.SelectedValue) + "', N'" + /**/Convert.ToInt32(textBoxIdEduForm.SelectedValue) + "', N'" + textBoxFamiliya.Text + "', " +
                        "N'" + textBoxName.Text + "', N'" + textBoxOtchestvo.Text + "', N'" + textBoxFamiliyaBel.Text + "', N'" + textBoxNameBel.Text + "', " +
                        "N'" + textBoxOtchestvoBel.Text + "', N'" + textBoxFIO_Lat.Text + "', N'" + dateBirthday.Text + "', N'" + /**/Convert.ToInt32(comboBoxTypeDoc.SelectedValue) + "', " +
                        "N'" + textBoxSeriaDoc.Text + "', N'" + textBoxNumDoc.Text + "', N'" + KemVidan.Text + "', N'" + dateVidach.Text + "', " + "N'" + dateSrokdeystv.Text + "', " +
                        "N'" + textBoxNumPassport.Text + "', N'" + /**/Convert.ToInt32(comboBoxFamilyStatus.SelectedValue) + "', N'" + comboBoxSex.Text + "', N'" + /**/Convert.ToInt32(comboBoxIdCountry.SelectedValue) + "', " + "N'" + textBoxNationality.Text + "', " +

                        "N'" + textBoxNumHomePhone.Text + "', N'" + textBoxNumMobPhone.Text + "', N'" + textBoxEmail.Text + "', N'" + /**/Convert.ToInt32(textBoxCodeCountry.SelectedValue) + "', " + "N'" + /**/Convert.ToInt32(textBoxCodeOblast.SelectedValue) + "', " +
                        "N'" + /**/Convert.ToInt32(textBoxCodeRaion.SelectedValue) + "', N'" + /**/Convert.ToInt32(comboBoxTypeLivePunkt.SelectedValue) + "', N'" + textBoxNameLivePunkt.Text + "', N'" + /**/Convert.ToInt32(comboBoxTypeStreet.SelectedValue) + "', " + "N'" + textBoxNameStreet.Text + "', " +
                        "N'" + textBoxNumHome.Text + "', N'" + textBoxNumKorpus.Text + "', N'" + textBoxNumKvartir.Text + "', N'" + textBoxMail_Index.Text + "', " + "N'" + textBoxNumObschaga.Text + "', " +
                        "N'" + /**/Convert.ToInt32(comboBoxIdStatus.SelectedValue) + "', N'" + textBoxCourseStud.Text + "', N'" + /**/Convert.ToInt32(textBoxNameFacult.SelectedValue) + "', N'" + /**/Convert.ToInt32(comboBoxFormPay.SelectedValue) + "', " + "N'" + textBoxNumGroup.Text + "', " +
                        "N'" + textBoxNumStudBook.Text + "', N'" + datePostup.Text + "',N'" + textBoxMainLangue.Text + "', N'" + textBoxNumDogOplat.Text + "', N'" + dateDog.Text + "', N'" + textBoxNapravNCO.Text + "'," +
                        "N'" + PerconalGrant.Text + "', N'" + UzBefore.Text + "', N'" + textBoxQual.Text + "');";
                        //string sqlExpression = "exec [add] '"+emailTextBox1.Text+ "', '" +passTextBox1.Text + "', '" + fNameTextBox1.Text + "', '" + lNameTextBox1.Text + "', '" + comboBox2.SelectedValue.ToString() + "'";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(sqlExpression, connection);
                            int number = command.ExecuteNonQuery();
                        }


                        MessageBox.Show("Студента успешно добавлен");
                        this.Close();
                        // Form1.labelRefPlz.Show();
                                         

                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show("Ошибка: " + msg.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        string connectionString = SQL_My_Con;

                        string sqlExpression2 = "DELETE FROM Students WHERE IdStudent = '" + textBoxIdStud.Text + "' ";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(sqlExpression2, connection);
                            int number = command.ExecuteNonQuery();
                        }
                    }
            }
            else
            {
                MessageBox.Show("Данная зачётная кнжка уже существует");
                haveStudBook = false;
            }            
        }

        public void HaveSpace()
        {
            if (textBoxFamiliya.Text == "") havespace = true;
            if (textBoxName.Text == "") havespace = true;
            if (textBoxOtchestvo.Text == "") havespace = true;
            if (textBoxFamiliyaBel.Text == "") havespace = true;
            if (textBoxNameBel.Text == "") havespace = true;
            if (textBoxOtchestvoBel.Text == "") havespace = true;
            if (textBoxNumGroup.Text == "") havespace = true;
            if (textBoxNationality.Text == "") havespace = true;
            if (textBoxCourseStud.Text == "") havespace = true;
            if (textBoxSeriaDoc.Text == "") havespace = true;
            if (KemVidan.Text == "") havespace = true;
            if (textBoxNumDoc.Text == "") havespace = true;
            if (textBoxNumPassport.Text == "") havespace = true;
            if (PerconalGrant.Text == "") havespace = true;
            if (textBoxMainLangue.Text == "") havespace = true;
            if (textBoxNumStudBook.Text == "") havespace = true;
            if (UzBefore.Text == "") havespace = true;
            if (textBoxNameLivePunkt.Text == "") havespace = true;
            if (textBoxNameStreet.Text == "") havespace = true;
            if (textBoxNumHome.Text == "") havespace = true;
            if (textBoxMail_Index.Text == "") havespace = true;
            if (textBoxNumObschaga.Text == "") havespace = true;
            if (textBoxNumHomePhone.Text == "") havespace = true;
            if (textBoxNumMobPhone.Text == "") havespace = true;
            if (textBoxEmail.Text == "") havespace = true;
            if (textBoxNumKorpus.Text == "") havespace = true;
            if (textBoxNumKvartir.Text == "") havespace = true;
            if (textBoxNumDogOplat.Text == "") havespace = true;
            if (textBoxNapravNCO.Text == "") havespace = true;
            if (textBoxQual.Text == "") havespace = true;
        }


        public void NumStudbook_test()
        {      
            SqlConnection con = new SqlConnection();
            con.ConnectionString = SQL_My_Con;
            con.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("SELECT NumStudBook FROM Students ", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                string studbook = myReader["NumStudBook"].ToString();
                if (textBoxNumStudBook.Text == studbook) haveStudBook = true;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button_back_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void Form_add_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.VUZ". При необходимости она может быть перемещена или удалена.
            this.vUZTableAdapter.Fill(this.dbStudDataSet.VUZ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.Specializations". При необходимости она может быть перемещена или удалена.
            this.specializationsTableAdapter.Fill(this.dbStudDataSet.Specializations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.Spec". При необходимости она может быть перемещена или удалена.
            this.specTableAdapter.Fill(this.dbStudDataSet.Spec);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.PayType". При необходимости она может быть перемещена или удалена.
            this.payTypeTableAdapter.Fill(this.dbStudDataSet.PayType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.TypeStreet". При необходимости она может быть перемещена или удалена.
            this.typeStreetTableAdapter.Fill(this.dbStudDataSet.TypeStreet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.CityType". При необходимости она может быть перемещена или удалена.
            this.cityTypeTableAdapter.Fill(this.dbStudDataSet.CityType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.OKFC". При необходимости она может быть перемещена или удалена.
            this.oKFCTableAdapter.Fill(this.dbStudDataSet.OKFC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.SOATO". При необходимости она может быть перемещена или удалена.
            this.sOATOTableAdapter.Fill(this.dbStudDataSet.SOATO);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.EducationForm". При необходимости она может быть перемещена или удалена.
            this.educationFormTableAdapter.Fill(this.dbStudDataSet.EducationForm);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.Faculties". При необходимости она может быть перемещена или удалена.
            this.facultiesTableAdapter.Fill(this.dbStudDataSet.Faculties);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.DocType". При необходимости она может быть перемещена или удалена.
            this.docTypeTableAdapter.Fill(this.dbStudDataSet.DocType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.EduStatus". При необходимости она может быть перемещена или удалена.
            this.eduStatusTableAdapter.Fill(this.dbStudDataSet.EduStatus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.CodeCountry". При необходимости она может быть перемещена или удалена.
            this.codeCountryTableAdapter.Fill(this.dbStudDataSet.CodeCountry);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.FamilyStatus". При необходимости она может быть перемещена или удалена.
            this.familyStatusTableAdapter.Fill(this.dbStudDataSet.FamilyStatus);


            SqlConnection con = new SqlConnection();
            con.ConnectionString = SQL_My_Con;
            con.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("SELECT TOP 1 * FROM Students ORDER BY IdStudent DESC", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                string num = myReader["IdStudent"].ToString();
                int GoodNum = Convert.ToInt32(num) + 1;
                  textBoxIdStud.Text = GoodNum.ToString();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNumHomePhone_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBoxNumHomePhone.Text.Length; i++)
            {
                if (!Char.IsDigit(textBoxNumHomePhone.Text[i]))
                {
                    textBoxNumHomePhone.Text = textBoxNumHomePhone.Text.Remove(i, 1);
                    textBoxNumHomePhone.SelectionStart = textBoxNumHomePhone.Text.Length;
                    break;
                }
            }
        }

        private void textBoxNumStudBook_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBoxNumStudBook.Text.Length; i++)
            {
                if (!Char.IsDigit(textBoxNumStudBook.Text[i]))
                {
                    textBoxNumStudBook.Text = textBoxNumStudBook.Text.Remove(i, 1);
                    textBoxNumStudBook.SelectionStart = textBoxNumStudBook.Text.Length;
                    break;
                }
            }
        }

        private void textBoxCourseStud_TextChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < textBoxCourseStud.Text.Length; i++)
            {
                if (!Char.IsDigit(textBoxCourseStud.Text[i]))
                {
                    textBoxCourseStud.Text = textBoxCourseStud.Text.Remove(i, 1);
                    textBoxCourseStud.SelectionStart = textBoxCourseStud.Text.Length;
                    break;
                }
            }
        }

        private void textBoxNumMobPhone_TextChanged(object sender, EventArgs e)
        {
           /* for (int i = 0; i < textBoxNumMobPhone.Text.Length; i++)
            {
                if (!Char.IsNumber(textBoxNumMobPhone.Text[i]))
                {
                    textBoxNumMobPhone.Text = textBoxNumMobPhone.Text.Remove(i, 1);
                    textBoxNumMobPhone.SelectionStart = textBoxNumMobPhone.Text.Length;
                    break;
                }
            }  */
        }

        private void textBoxFamiliya_TextChanged(object sender, EventArgs e)
        {
             for (int i = 0; i < textBoxFamiliya.Text.Length; i++)
             {
                 if (!Char.IsLetter(textBoxFamiliya.Text[i]))
                 {
                    textBoxFamiliya.Text = textBoxFamiliya.Text.Remove(i, 1);
                    textBoxFamiliya.SelectionStart = textBoxFamiliya.Text.Length;
                     break;
                 }
             }  
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBoxName.Text.Length; i++)
            {
                if (!Char.IsLetter(textBoxName.Text[i]))
                {
                    textBoxName.Text = textBoxName.Text.Remove(i, 1);
                    textBoxName.SelectionStart = textBoxName.Text.Length;
                    break;
                }
            }
        }

        private void textBoxOtchestvo_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBoxOtchestvo.Text.Length; i++)
            {
                if (!Char.IsLetter(textBoxOtchestvo.Text[i]))
                {
                    textBoxOtchestvo.Text = textBoxOtchestvo.Text.Remove(i, 1);
                    textBoxOtchestvo.SelectionStart = textBoxOtchestvo.Text.Length;
                    break;
                }
            }
        }

        private void textBoxNumKorpus_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBoxNumKorpus.Text.Length; i++)
            {
                if (!Char.IsDigit(textBoxNumKorpus.Text[i]))
                {
                    textBoxNumKorpus.Text = textBoxNumKorpus.Text.Remove(i, 1);
                    textBoxNumKorpus.SelectionStart = textBoxNumKorpus.Text.Length;
                    break;
                }
            }
        }

        private void textBoxNumKvartir_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBoxNumKvartir.Text.Length; i++)
            {
                if (!Char.IsDigit(textBoxNumKvartir.Text[i]))
                {
                    textBoxNumKvartir.Text = textBoxNumKvartir.Text.Remove(i, 1);
                    textBoxNumKvartir.SelectionStart = textBoxNumKvartir.Text.Length;
                    break;
                }
            }
        }

        private void textBoxNumObschaga_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBoxNumObschaga.Text.Length; i++)
            {
                if (!Char.IsDigit(textBoxNumObschaga.Text[i]))
                {
                    textBoxNumObschaga.Text = textBoxNumObschaga.Text.Remove(i, 1);
                    textBoxNumObschaga.SelectionStart = textBoxNumObschaga.Text.Length;
                    break;
                }
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCourseStud_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
