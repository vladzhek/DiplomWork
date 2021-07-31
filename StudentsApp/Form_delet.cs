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
    public partial class Form_delet : Form
    {
        static string ComBoxText;
        string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbStud.mdf;Integrated Security=True";


        public Form_delet()
        {
            InitializeComponent();
            ReadOrderData(str);
            ComBoxText = textBox1.Text;
            if (textBox1.Text == "")
            {
                labelN.Text = "Имя: не выбран";
                labelF.Text = "Фамилия: не выбран";
                labelO.Text = "Отчество: не выбран";
            }
        }

        private void Form_delet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.Students". При необходимости она может быть перемещена или удалена.
        
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet1.Students". При необходимости она может быть перемещена или удалена.
           // this.studentsTableAdapter.Fill(this.dbStudDataSet1.Students);

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("",MessageBoxButtons.YesNo.ToString);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Студент не выбран");
            }
            else
            {


                int Index = Convert.ToInt32(textBox1.Text);

                DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить этого студента " +
                                                             "\n_________________________________\n\n" +
                                                             "Номер зачётной книжки: " + Index, "УДАЛЕНИЕ СТУДЕНТА", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbStud.mdf;Integrated Security=True";

                        string sqlExpression2 = "DELETE FROM Students WHERE NumStudBook = " + Index + " ; ";
                                               
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(sqlExpression2, connection);
                            int number = command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ComBoxText = textBox1.Text;
            //MessageBox.Show(ComBoxText);
            ReadOrderData(str);
            if (textBox1.Text == "")
            {
                labelN.Text = "Имя: не выбран";
                labelF.Text = "Фамилия: не выбран";
                labelO.Text = "Отчество: не выбран";
            }
        }

        private void ReadOrderData(string connectionString)
        {
            try
            {
                string queryString =
                "SELECT NameRus, SurNameRus, PatronymicRus FROM Students WHERE NumStudBook LIKE '%" + ComBoxText + "%'";

                using (SqlConnection connection =
                           new SqlConnection(connectionString))
                {
                    SqlCommand command =
                        new SqlCommand(queryString, connection);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ReadSingleRow(IDataRecord record)
        {
            labelN.Text = "Имя: " + record[0].ToString();
            labelF.Text = "Фамилия: " + record[1].ToString();
            labelO.Text = "Отчество: " + record[2].ToString();
        }


    }
}
