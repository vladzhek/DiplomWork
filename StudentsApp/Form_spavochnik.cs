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
    public partial class Form_spavochnik : Form
    {
        string SQL_My_Con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbStud.mdf;Integrated Security=True";

        public Form_spavochnik()
        {
            InitializeComponent();
        }

        string[] array_command = new string[] 
        { "SELECT CodeSpec 'Номер', Name 'Специальность' FROM [Spec]"
        , "SELECT idSpecialz 'Номер', NameSpecialization 'Специализация' FROM [Specializations]"
        , "SELECT [IdCodeCountry] 'Номер', [Name] 'Страна' FROM [CodeCountry]"
        , "SELECT [CodeObSoato] 'Номер', Name 'Область' FROM [SOATO]"
        , "SELECT [CodeOkfc] 'Номер', Name 'Район' FROM [OKFC]"
        , "SELECT [idfaculty] 'Номер', namerus 'Наименование', shortnamerus 'Краткое название' FROM [Faculties]"
        , "SELECT [idVuz] 'Номер', NameRus 'Наименование', ShortNameRus 'Краткое название',Rector 'Ректор', Phone 'Телефон' FROM [VUZ]"
        };


        private void Form_spavochnik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.OKFC". При необходимости она может быть перемещена или удалена.
            this.oKFCTableAdapter.Fill(this.dbStudDataSet.OKFC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbStudDataSet.SOATO". При необходимости она может быть перемещена или удалена.
            this.sOATOTableAdapter.Fill(this.dbStudDataSet.SOATO);
            try
            {
                for (int i = 0; i <= 6; i++)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = SQL_My_Con;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = array_command[i];
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
                    switch (i)
                    {
                        case 0: dataGridView1.DataSource = records; break;
                        case 1: dataGridView2.DataSource = records; break;
                        case 2: dataGridView3.DataSource = records; break;
                        case 3: dataGridView4.DataSource = records; break;
                        case 4: dataGridView5.DataSource = records; break;
                        case 5: dataGridView6.DataSource = records; break;
                        case 6: dataGridView7.DataSource = records; break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // ===========================  СПЕЦИАЛЬНОСТь  ===========================


        private void buttonSpecAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = SQL_My_Con;

                string sqlExpression = "INSERT INTO [Spec] VALUES ('"+ (dataGridView1.Rows.Count+1) + "' ,N'" + textBoxSpec.Text + "' );";
                //string sqlExpression = "exec [add] '"+emailTextBox1.Text+ "', '" +passTextBox1.Text + "', '" + fNameTextBox1.Text + "', '" + lNameTextBox1.Text + "', '" + comboBox2.SelectedValue.ToString() + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                }

                Form_spavochnik_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonSpecDelet_Click(object sender, EventArgs e)
        {
            int row = (dataGridView1.CurrentCell.RowIndex);
            int Deletline = Convert.ToInt32(dataGridView1.Rows[row].Cells[0].Value);
            try
            {
                string connectionString = SQL_My_Con;
                int GridIndex = Deletline;
                string sqlExpression = "DELETE FROM Spec WHERE CodeSpec = " + GridIndex + " ;";


                //string sqlExpression = "exec [add] '"+emailTextBox1.Text+ "', '" +passTextBox1.Text + "', '" + fNameTextBox1.Text + "', '" + lNameTextBox1.Text + "', '" + comboBox2.SelectedValue.ToString() + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                }
                MessageBox.Show("Специальность с ID " + GridIndex + " была успешно удалена");
                Form_spavochnik_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        // ===========================   СПЕЦИАЛИЗАЦИЯ   ===========================


        private void buttonSpecialzAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = SQL_My_Con;

                string sqlExpression = "INSERT INTO [Specializations] VALUES ('" + (dataGridView2.Rows.Count + 1) + "' ,N'" + textBoxSpecialz.Text + "' );";
                //string sqlExpression = "exec [add] '"+emailTextBox1.Text+ "', '" +passTextBox1.Text + "', '" + fNameTextBox1.Text + "', '" + lNameTextBox1.Text + "', '" + comboBox2.SelectedValue.ToString() + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                }

                Form_spavochnik_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonSpecialzDelet_Click(object sender, EventArgs e)
        {
            int row = (dataGridView2.CurrentCell.RowIndex);
            int Deletline = Convert.ToInt32(dataGridView2.Rows[row].Cells[0].Value);
            try
            {
                string connectionString = SQL_My_Con;
                int GridIndex = Deletline;
                string sqlExpression = "DELETE FROM [Specializations] WHERE [idSpecialz] = " + GridIndex + " ;";


                //string sqlExpression = "exec [add] '"+emailTextBox1.Text+ "', '" +passTextBox1.Text + "', '" + fNameTextBox1.Text + "', '" + lNameTextBox1.Text + "', '" + comboBox2.SelectedValue.ToString() + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                }
                MessageBox.Show("Специализация с ID " + GridIndex + " была успешно удалена");
                Form_spavochnik_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        

        // ===========================   СТРАНА   ===========================


        private void buttonCountryAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = SQL_My_Con;

                string sqlExpression = "INSERT INTO [CodeCountry] VALUES ('" + (dataGridView3.Rows.Count + 1) + "' ,N'" + textBoxCountry.Text + "' );";
                //string sqlExpression = "exec [add] '"+emailTextBox1.Text+ "', '" +passTextBox1.Text + "', '" + fNameTextBox1.Text + "', '" + lNameTextBox1.Text + "', '" + comboBox2.SelectedValue.ToString() + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                }

                Form_spavochnik_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonCountryDelet_Click(object sender, EventArgs e)
        {
            int row = (dataGridView3.CurrentCell.RowIndex);
            int Deletline = Convert.ToInt32(dataGridView3.Rows[row].Cells[0].Value);
            try
            {
                string connectionString = SQL_My_Con;
                int GridIndex = Deletline;
                string sqlExpression = "DELETE FROM [CodeCountry] WHERE [IdCodeCountry] = " + GridIndex + " ;";


                //string sqlExpression = "exec [add] '"+emailTextBox1.Text+ "', '" +passTextBox1.Text + "', '" + fNameTextBox1.Text + "', '" + lNameTextBox1.Text + "', '" + comboBox2.SelectedValue.ToString() + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                }
                MessageBox.Show("Страна с ID " + GridIndex + " была успешно удалена");
                Form_spavochnik_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        // ===========================   ОБЛАСТЬ / SOATO   ===========================


        private void buttonSOATOAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = SQL_My_Con;

                string sqlExpression = "INSERT INTO [SOATO] VALUES ('" + (dataGridView4.Rows.Count + 1) + "','" + (dataGridView4.Rows.Count + 1) + "',N'" + textBoxSOATO.Text + "' );";
                //string sqlExpression = "exec [add] '"+emailTextBox1.Text+ "', '" +passTextBox1.Text + "', '" + fNameTextBox1.Text + "', '" + lNameTextBox1.Text + "', '" + comboBox2.SelectedValue.ToString() + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                }

                Form_spavochnik_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonSOATODelet_Click(object sender, EventArgs e)
        {
            int row = (dataGridView4.CurrentCell.RowIndex);
            int Deletline = Convert.ToInt32(dataGridView4.Rows[row].Cells[0].Value);
            try
            {
                string connectionString = SQL_My_Con;
                int GridIndex = Deletline;
                string sqlExpression = "DELETE FROM [SOATO] WHERE [CodeObSoato] = " + GridIndex + " ;";


                //string sqlExpression = "exec [add] '"+emailTextBox1.Text+ "', '" +passTextBox1.Text + "', '" + fNameTextBox1.Text + "', '" + lNameTextBox1.Text + "', '" + comboBox2.SelectedValue.ToString() + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                }
                MessageBox.Show("Область с ID " + GridIndex + " была успешно удалена");
                Form_spavochnik_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        // ===========================   РАЙОН / OKFC   ===========================


        private void buttonOKFCAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = SQL_My_Con;

                string sqlExpression = "INSERT INTO [OKFC] VALUES ('" + (dataGridView5.Rows.Count + 1) + "',N'" + textBoxOKFC.Text + "' );";
                //string sqlExpression = "exec [add] '"+emailTextBox1.Text+ "', '" +passTextBox1.Text + "', '" + fNameTextBox1.Text + "', '" + lNameTextBox1.Text + "', '" + comboBox2.SelectedValue.ToString() + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                }

                Form_spavochnik_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonOKFCDelet_Click(object sender, EventArgs e)
        {
            int row = (dataGridView5.CurrentCell.RowIndex);
            int Deletline = Convert.ToInt32(dataGridView5.Rows[row].Cells[0].Value);
            try
            {
                string connectionString = SQL_My_Con;
                int GridIndex = Deletline;
                string sqlExpression = "DELETE FROM [OKFC] WHERE [CodeOkfc] = " + GridIndex + " ;";


                //string sqlExpression = "exec [add] '"+emailTextBox1.Text+ "', '" +passTextBox1.Text + "', '" + fNameTextBox1.Text + "', '" + lNameTextBox1.Text + "', '" + comboBox2.SelectedValue.ToString() + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                }
                MessageBox.Show("Район с ID " + GridIndex + " была успешно удалена");
                Form_spavochnik_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // ===========================   ФАКУЛЬТЕТ   ===========================


        private void buttonFacAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = SQL_My_Con;

                string sqlExpression = "INSERT INTO [Faculties] VALUES ('" + (dataGridView6.Rows.Count + 1) + "',N'" + textBoxFacName.Text + "',N'" + textBoxFacSName.Text + "' );";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                }

                Form_spavochnik_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonFacDelet_Click(object sender, EventArgs e)
        {
            int row = (dataGridView6.CurrentCell.RowIndex);
            int Deletline = Convert.ToInt32(dataGridView6.Rows[row].Cells[0].Value);
            try
            {
                string connectionString = SQL_My_Con;
                int GridIndex = Deletline;
                string sqlExpression = "DELETE FROM [Faculties] WHERE [idfaculty] = " + GridIndex + " ;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                }
                MessageBox.Show("Район с ID " + GridIndex + " была успешно удалена");
                Form_spavochnik_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        // ===========================   ВУЗЫ / VUZ   ===========================


        private void buttoVUZAdd_Click(object sender, EventArgs e)
        {
            int odin = 1;
            try
            {
                string connectionString = SQL_My_Con;

                string sqlExpression = "INSERT INTO [VUZ] VALUES ('" + (dataGridView7.Rows.Count + 1) + "',  N'" + textBoxVUZName.Text + "' , N'" + textBoxVUZSName.Text + "' , '1' , '1'" +
                    ",N'" + textBoxVUZRector.Text + "', '" + odin + "','" + odin + "', N'" +/**/Convert.ToInt32(cbVUZCodeOblast.SelectedValue) + "','"+ odin + "', N'" + /**/textboxVUZCodeRaion.Text + "',N'" + textBoxUVZPhone.Text + "' ); ";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                }

                Form_spavochnik_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonVUZDelet_Click(object sender, EventArgs e)
        {
            int row = (dataGridView7.CurrentCell.RowIndex);
            int Deletline = Convert.ToInt32(dataGridView7.Rows[row].Cells[0].Value);
            try
            {
                string connectionString = SQL_My_Con;
                int GridIndex = Deletline;
                string sqlExpression = "DELETE FROM [VUZ] WHERE [idVuz] = " + GridIndex + " ;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                }
                MessageBox.Show("Вуз с ID " + GridIndex + " был успешно удален");
                Form_spavochnik_Load(sender, e);
            }
            catch (Exception ex)
            {
                if(ex.Message == "0x80131904") MessageBox.Show("123");
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
