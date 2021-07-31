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

namespace StudentsApp
{
    public partial class Form_analytics : Form
    {
        string SQL_My_Con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbStud.mdf;Integrated Security=True";

        public Form_analytics()
        {
            InitializeComponent();
        }

        private void Form_analytics_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.PayType". При необходимости она может быть перемещена или удалена.
            this.payTypeTableAdapter.Fill(this.dbStudDataSet.PayType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.dbStudDataSet.Students);
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = SQL_My_Con;
                con.Open();
                SqlDataReader myReader = null;
                //SqlCommand myCommand = new SqlCommand("SELECT TOP 1 * FROM Students ORDER BY IdStudent DESC", con);    ====
                SqlCommand myCommand = new SqlCommand("SELECT Sex, (Count(Sex) * 100 / (Select Count(*) From Students)) as Score,(Select Count(*) From Students) as AllStud, " +
                                                     "(Select Count(*) From Students Where Sex = N'Мужчина') as SexmMan,(Select Count(*) From Students Where Sex = N'Женщина') as SexWoman, " +
                                                     "(Select Count(*) From Students Where idPayType = '1') as PayTypeB,(Select Count(*) From Students Where idPayType = '3') as PayTypeP, " +
                                                     "(Select Count(*) From Students Where idPayType = '2') as PayTypeSO FROM Students " +
                                                      " GROUP BY Sex", con);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    string num = myReader["Score"].ToString();
                    string all = myReader["AllStud"].ToString();
                    string SexMan = myReader["SexmMan"].ToString();
                    string SexWom = myReader["SexWoman"].ToString();
                    string PayType_allP = myReader["PayTypeP"].ToString();
                    string PayType_allB = myReader["PayTypeB"].ToString();
                    string PayType_allSO = myReader["PayTypeSO"].ToString();
                    label2.Text = num.ToString()+"%";
                    labelAllStud.Text ="Всего студентов: "+ all.ToString();
                    labelAllM.Text = "мужчин: " + SexMan;
                    labelAllW.Text = "женщин: " + SexWom;
                    labelP_all.Text = "платников: " + PayType_allP;
                    labelB_all.Text = "биджетников: " + PayType_allB;
                    labelSO_all.Text = "средства организации: " + PayType_allSO;
                }
                try
                {
                    //using (No)
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            this.reportViewer2.RefreshReport();
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_sex_an_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = SQL_My_Con;
                con.Open();
                SqlDataReader myReader = null;
                //SqlCommand myCommand = new SqlCommand("SELECT TOP 1 * FROM Students ORDER BY IdStudent DESC", con);
                SqlCommand myCommand = new SqlCommand("Select(NULLIF(Count(Sex),0) * 100 / (Select Count(*) From Students WHERE Course = " + comboBoxCourse.Text + " AND Sex = N'Мужчина')) as Score " +                                                      
                                                     " From Students " + " WHERE Course = " + comboBoxCourse.Text + " AND Sex = N'Мужчина' " +
                                                     " ", con);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    string num = myReader["Score"].ToString();
                    if (num == "") num = "0";
                    labelCourseM.Text = "составляет: "+ num.ToString() + "%";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        private void button_sex_an_w_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = SQL_My_Con;
                con.Open();
                SqlDataReader myReader = null;
                //SqlCommand myCommand = new SqlCommand("SELECT TOP 1 * FROM Students ORDER BY IdStudent DESC", con);
                SqlCommand myCommand = new SqlCommand("Select(NULLIF(Count(Sex),0) * 100 / (Select Count(*) From Students WHERE Course = " + comboBoxCourse.Text + " AND Sex = N'Женщина')) as Score " +
                                                     " From Students " + " WHERE Course = " + comboBoxCourse.Text + " AND Sex = N'Женщина' " +
                                                     " ", con);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    string num = myReader["Score"].ToString();
                    if (num == "") num = "0";
                    labelCourseW.Text = "составляет: " + num.ToString() + "%";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Платники
        private void buttonPayType_1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = SQL_My_Con;
                con.Open();
                SqlDataReader myReader = null;
                //SqlCommand myCommand = new SqlCommand("SELECT TOP 1 * FROM Students ORDER BY IdStudent DESC", con);
                SqlCommand myCommand = new SqlCommand("Select(NULLIF(Count(IdPayType),0) * 100 / (Select Count(*) From Students WHERE Course = " + comboBoxCourse.Text + " AND IdPayType = '3' )) as Score " +
                                                     " From Students " + " WHERE Course = " + comboBoxCourse.Text + " AND IdPayType = '3' " +
                                                     " ", con);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    string num = myReader["Score"].ToString();
                    if (num == "") num = "0";
                    labelP.Text = "составляет: " + num.ToString() + "%";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Бюджетники
        private void buttonPayType_2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = SQL_My_Con;
                con.Open();
                SqlDataReader myReader = null;               
                SqlCommand myCommand = new SqlCommand("Select(NULLIF(Count(IdPayType),0) * 100 / (Select Count(*) From Students WHERE Course = " + comboBoxCourse.Text + " AND IdPayType = '1')  ) as Score " +
                                                     " From Students " + " WHERE Course = " + comboBoxCourse.Text + " AND IdPayType = '1' " +
                                                     " ", con);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    string num = myReader["Score"].ToString();
                    if (num == "") num = "0";
                    labelB.Text = "составляет: " + num.ToString() + "%";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Cредства организации
        private void buttonPayType_3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = SQL_My_Con;
                con.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("Select(NULLIF(Count(IdPayType),0) * 100 / (Select Count(*) From Students WHERE Course = " + comboBoxCourse.Text + " AND  IdPayType = '2')) as Score " +
                                                     " From Students " + " WHERE Course = " + comboBoxCourse.Text + " AND IdPayType = '2' " +
                                                     " ", con);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    string num = myReader["Score"].ToString();
                    if (num == "") num = "0";
                    labelSO.Text = "составляет: " + num.ToString() + "%";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
    }
}
