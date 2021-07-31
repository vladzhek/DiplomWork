using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsApp
{
    public partial class Form_edit : Form
    {

        string SQL_My_Con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbStud.mdf;Integrated Security=True";

        string StrLike = Form1.STR_TBFind;

        public Form_edit()
        {
            InitializeComponent();
            //Прячу от юзера таб контрол
            /*tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabStop = false;*/
            label_main.Text = "Изменяемый студент с зачётной книжкой: " + StrLike;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_edit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.Faculties". При необходимости она может быть перемещена или удалена.
            this.facultiesTableAdapter.Fill(this.dbStudDataSet.Faculties);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.TypeStreet". При необходимости она может быть перемещена или удалена.
            this.typeStreetTableAdapter.Fill(this.dbStudDataSet.TypeStreet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.CityType". При необходимости она может быть перемещена или удалена.
            this.cityTypeTableAdapter.Fill(this.dbStudDataSet.CityType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.OKFC". При необходимости она может быть перемещена или удалена.
            this.oKFCTableAdapter.Fill(this.dbStudDataSet.OKFC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.SOATO". При необходимости она может быть перемещена или удалена.
            this.sOATOTableAdapter.Fill(this.dbStudDataSet.SOATO);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.PayType". При необходимости она может быть перемещена или удалена.
            this.payTypeTableAdapter.Fill(this.dbStudDataSet.PayType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.Specializations". При необходимости она может быть перемещена или удалена.
            this.specializationsTableAdapter.Fill(this.dbStudDataSet.Specializations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.Spec". При необходимости она может быть перемещена или удалена.
            this.specTableAdapter.Fill(this.dbStudDataSet.Spec);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.VUZ". При необходимости она может быть перемещена или удалена.
            this.vUZTableAdapter.Fill(this.dbStudDataSet.VUZ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.EducationForm". При необходимости она может быть перемещена или удалена.
            this.educationFormTableAdapter.Fill(this.dbStudDataSet.EducationForm);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.CodeCountry". При необходимости она может быть перемещена или удалена.
            this.codeCountryTableAdapter.Fill(this.dbStudDataSet.CodeCountry);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.DocType". При необходимости она может быть перемещена или удалена.
            this.docTypeTableAdapter.Fill(this.dbStudDataSet.DocType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.EduStatus". При необходимости она может быть перемещена или удалена.
            this.eduStatusTableAdapter.Fill(this.dbStudDataSet.EduStatus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.FamilyStatus". При необходимости она может быть перемещена или удалена.
            this.familyStatusTableAdapter.Fill(this.dbStudDataSet.FamilyStatus);
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.VUZ". При необходимости она может быть перемещена или удалена.
            this.vUZTableAdapter.Fill(this.dbStudDataSet.VUZ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.DocType". При необходимости она может быть перемещена или удалена.
            this.docTypeTableAdapter.Fill(this.dbStudDataSet.DocType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.EduStatus". При необходимости она может быть перемещена или удалена.
            this.eduStatusTableAdapter.Fill(this.dbStudDataSet.EduStatus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.CodeCountry". При необходимости она может быть перемещена или удалена.
            this.codeCountryTableAdapter.Fill(this.dbStudDataSet.CodeCountry);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.FamilyStatus". При необходимости она может быть перемещена или удалена.
            this.familyStatusTableAdapter.Fill(this.dbStudDataSet.FamilyStatus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet1.EduStatus". При необходимости она может быть перемещена или удалена.
            this.eduStatusTableAdapter.Fill(this.dbStudDataSet.EduStatus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet1.CodeCountry". При необходимости она может быть перемещена или удалена.
            this.codeCountryTableAdapter.Fill(this.dbStudDataSet.CodeCountry);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.FamilyStatus". При необходимости она может быть перемещена или удалена.
            this.familyStatusTableAdapter.Fill(this.dbStudDataSet.FamilyStatus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.FamilyStatus". При необходимости она может быть перемещена или удалена.
            this.familyStatusTableAdapter.Fill(this.dbStudDataSet.FamilyStatus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.FamilyStatus". При необходимости она может быть перемещена или удалена.
            this.familyStatusTableAdapter.Fill(this.dbStudDataSet.FamilyStatus);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = SQL_My_Con;
            con.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("SELECT * FROM Students WHERE NumStudBook = '" + StrLike + "' ", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                string IdFamilyStatus = myReader["IdFamilyStatus"].ToString();
                string IdEduStatus = myReader["IdEduStatus"].ToString();
                string IdDocType = myReader["IdDocType"].ToString();
                string IdFacultyVuz = myReader["IdFacultyVuz"].ToString();
                string IdCitizenship = myReader["IdCitizenship"].ToString();
                string IdEducationForm = myReader["IdEducationForm"].ToString();
                string Country = myReader["Country"].ToString();
                string Area = myReader["Area"].ToString();
                string Region = myReader["Region"].ToString();
                string CityType = myReader["CityType"].ToString();
                string StreetType = myReader["StreetType"].ToString();
                string PayType = myReader["IdPayType"].ToString();
                string IdStudentVuz = myReader["IdStudentVuz"].ToString();
                string IdSpec = myReader["IdSpec"].ToString();
                string IdSpecialization = myReader["IdSpecialization"].ToString();
                comboBoxFamilyStatus.SelectedValue = IdFamilyStatus;
                comboBoxIdStatus.SelectedValue = IdEduStatus;
                comboBoxTypeDoc.SelectedValue = IdDocType;
                textBoxNameFacult.SelectedValue = IdFacultyVuz;
                comboBoxIdCountry.SelectedValue = IdCitizenship;
                textBoxIdEduForm.SelectedValue = IdEducationForm;
                textBoxCodeCountry.SelectedValue = Country;
                textBoxCodeOblast.SelectedValue = Area;
                textBoxCodeRaion.SelectedValue = Region;
                comboBoxTypeLivePunkt.SelectedValue = CityType;
                comboBoxTypeStreet.SelectedValue = StreetType;
                comboBoxFormPay.SelectedValue = PayType;
                textBoxIdStudVuz.SelectedValue = IdStudentVuz;
                textBoxIdSpec.SelectedValue = IdSpec;
                textBoxIdSpecaliz.SelectedValue = IdSpecialization;
                //
                textBoxNumStudBook.Text = myReader["NumStudBook"].ToString();
                textBoxFamiliya.Text = myReader["SurnameRus"].ToString();
                textBoxName.Text = myReader["NameRus"].ToString();
                textBoxOtchestvo.Text = myReader["PatronymicRus"].ToString();
                textBoxFamiliyaBel.Text = myReader["SurnameBel"].ToString();
                textBoxNameBel.Text = myReader["NameBel"].ToString();
                textBoxOtchestvoBel.Text = myReader["PatronymicBel"].ToString();
                dateBirthday.Text = myReader["Birthday"].ToString();
                textBoxFIO_Lat.Text = myReader["FIOlatin"].ToString();
                textBoxCourseStud.Text = myReader["Course"].ToString();
                textBoxNumGroup.Text = myReader["NumGroup"].ToString();
                textBoxMainLangue.Text = myReader["BaseForeignLan"].ToString();
                textBoxNationality.Text = myReader["Nationality"].ToString();
                textBoxSeriaDoc.Text = myReader["Docseries"].ToString();
                KemVidan.Text = myReader["Docwhere"].ToString();
                textBoxNumDoc.Text = myReader["Docnum"].ToString();
                dateVidach.Text = myReader["Docdate"].ToString();
                dateSrokdeystv.Text = myReader["Docenddate"].ToString();
                UzBefore.Text = myReader["UzBeforeSname"].ToString();
                textBoxNumPassport.Text = myReader["PerconalNum"].ToString();
                PerconalGrant.Text = myReader["PerconalGrant"].ToString();
                datePostup.Text = myReader["DateIn"].ToString();
                dateDog.Text = myReader["DogDate"].ToString();
                textBoxNameLivePunkt.Text = myReader["City"].ToString();
                textBoxNameStreet.Text = myReader["Street"].ToString();
                textBoxNumHome.Text = myReader["House"].ToString();
                textBoxMail_Index.Text = myReader["IndexMail"].ToString();
                textBoxNumObschaga.Text = myReader["Campus"].ToString();
                textBoxNumHomePhone.Text = myReader["PhoneHome"].ToString();
                textBoxNumMobPhone.Text = myReader["PhoneMobile"].ToString();
                textBoxEmail.Text = myReader["Email"].ToString();
                textBoxNumKorpus.Text = myReader["HouseExt"].ToString();
                textBoxNumKvartir.Text = myReader["Flat"].ToString();
                textBoxNumDogOplat.Text = myReader["DogNum"].ToString();
                textBoxNapravNCO.Text = myReader["TargetOrganization"].ToString();
                textBoxQual.Text = myReader["Qualification"].ToString();
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
        

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {

                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbStud.mdf;Integrated Security=True";
                StrLike = Form1.STR_TBFind;
                // "UPDATE [АБОНЕНТЫ] SET [№] = @ПриложениеАбонента, [Фамилия] = @Фамилия, [Имя] = @Имя, 
                string sqlExpression = "UPDATE [Students] SET  [IdStudentVuz] = N'" + Convert.ToInt32(textBoxIdStudVuz.SelectedValue) + "', " +
                "[IdSpec] = N'" + Convert.ToInt32(textBoxIdSpec.SelectedValue) + "', [IdSpecialization] = N'" + Convert.ToInt32(textBoxIdSpecaliz.SelectedValue) + "', [IdEducationForm] = N'" + Convert.ToInt32(textBoxIdEduForm.SelectedValue) + "', [SurnameRus] = N'" + textBoxFamiliya.Text + "', " +
                "[NameRus] = N'" + textBoxName.Text + "',[PatronymicRus] = N'" + textBoxOtchestvo.Text + "',[SurnameBel] = N'" + textBoxFamiliyaBel.Text + "',[NameBel] = N'" + textBoxNameBel.Text + "', " +
                "[PatronymicBel] = N'" + textBoxOtchestvoBel.Text + "',[FIOlatin] = N'" + textBoxFIO_Lat.Text + "',[Birthday] = N'" + dateBirthday.Text + "',[IdDocType] = N'" + Convert.ToInt32(comboBoxTypeDoc.SelectedValue) + "', " +
                "[Docseries] = N'" + textBoxSeriaDoc.Text + "',[Docnum] = N'" + textBoxNumDoc.Text + "',[Docwhere] = N'" + KemVidan.Text + "',[Docdate] = N'" + dateVidach.Text + "',[Docenddate] = N'" + dateSrokdeystv.Text + "', " +
                "[PerconalNum] = N'" + textBoxNumPassport.Text + "',[IdFamilyStatus] = N'" + /**/Convert.ToInt32(comboBoxFamilyStatus.SelectedValue) + "',[Sex] = N'" + comboBoxSex.Text + "',[IdCitizenship] = N'" + Convert.ToInt32(comboBoxIdCountry.SelectedValue) + "',[Nationality] = N'" + textBoxNationality.Text + "', " +

                "[PhoneHome] = N'" + textBoxNumHomePhone.Text + "',[PhoneMobile] = N'" + textBoxNumMobPhone.Text + "',[Email] = N'" + textBoxEmail.Text + "',[Country] = N'" + Convert.ToInt32(textBoxCodeCountry.SelectedValue) + "',[Area] = N'" + Convert.ToInt32(textBoxCodeOblast.SelectedValue) + "', " +
                "[Region] = N'" + Convert.ToInt32(textBoxCodeRaion.SelectedValue) + "',[CityType] = N'" + Convert.ToInt32(comboBoxTypeLivePunkt.SelectedValue) + "',[City] = N'" + textBoxNameLivePunkt.Text + "',[StreetType] = N'" + Convert.ToInt32(comboBoxTypeStreet.SelectedValue) + "',[Street] = N'" + textBoxNameStreet.Text + "', " +
                "[House] = N'" + textBoxNumHome.Text + "',[HouseExt] = N'" + textBoxNumKorpus.Text + "',[Flat] = N'" + textBoxNumKvartir.Text + "',[IndexMail] = N'" + textBoxMail_Index.Text + "',[Campus] = N'" + textBoxNumObschaga.Text + "', " +
                "[IdEduStatus] = N'" + /**/Convert.ToInt32(comboBoxIdStatus.SelectedValue) + "',[Course] = N'" + textBoxCourseStud.Text + "',[IdFacultyVuz] = N'" + Convert.ToInt32(textBoxNameFacult.SelectedValue) + "',[IdPayType] = N'" + Convert.ToInt32(comboBoxFormPay.SelectedValue) + "',[NumGroup] = N'" + textBoxNumGroup.Text + "', " +
                "[NumStudBook] = N'" + StrLike + "',[DateIn] = N'" + datePostup.Text + "',[BaseForeignLan] = N'" + textBoxMainLangue.Text + "',[DogNum] = N'" + textBoxNumDogOplat.Text + "',[DogDate] = N'" + dateDog.Text + "',[TargetOrganization] = N'" + textBoxNapravNCO.Text + "'," +
                "[PerconalGrant] = N'" + PerconalGrant.Text + "', [UzBeforeSname] = N'" + UzBefore.Text + "', [Qualification] = N'" + textBoxQual.Text + "' " +
                "WHERE NumStudBook LIKE '%" + StrLike + "%'";
                //string sqlExpression = "exec [add] '"+emailTextBox1.Text+ "', '" +passTextBox1.Text + "', '" + fNameTextBox1.Text + "', '" + lNameTextBox1.Text + "', '" + comboBox2.SelectedValue.ToString() + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show("Ошибка: " + msg.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
