using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Video25_task_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dreader;
        string connstring = ConfigurationManager.ConnectionStrings["FirstRegisterApiStudent"].ConnectionString;
        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_Role.Clear();
            txtCourse.Clear();
            txtFullName.Clear();
            txtPassword.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["FirstRegisterApiStudent"].ConnectionString;
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;
            SqlDataReader sqlDataReader = null;
            try
            {
                sqlConnection = new SqlConnection(conn);
                sqlConnection.Open();
                sqlCommand = new SqlCommand("insert into StudentsRegister (Rol_Number,Names,Age,Course) values ('" + txt_Role.Text.Trim() + "','" + txtFullName.Text.Trim() + "','" + txtPassword.Text.Trim() + "','" + txtCourse.Text.Trim() + "')", sqlConnection);
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (dr.Read() == true)
                {
                    MessageBox.Show("Success");
                }
            }
            catch (Exception)
            {

                throw new Exception();
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["FirstRegisterApiStudent"].ConnectionString;
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;
            SqlDataReader sqlDataReader = null;
            try
            {
                sqlConnection = new SqlConnection(conn);
                sqlConnection.Open();
                sqlCommand = new SqlCommand("delete from StudentsRegister where Rol_Number =" + txt_Role.Text.Trim() + "", sqlConnection);
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (dr.Read() == true)
                {
                    MessageBox.Show("Success");
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["FirstRegisterApiStudent"].ConnectionString;
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;
            SqlDataReader sqlDataReader = null;
            try
            {
                sqlConnection = new SqlConnection(conn);
                sqlConnection.Open();
                sqlCommand = new SqlCommand("update StudentsRegister set  where Rol_Number =" + txt_Role.Text.Trim() + "", sqlConnection);
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (dr.Read() == true)
                {
                    MessageBox.Show("Success");
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            comm = new SqlCommand("select * from StudentsRegister where id = " + txt_Role.Text + " ", conn);
            try
            {
                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    txtFullName.Text = dreader[1].ToString();
                    txtCourse.Text = dreader[2].ToString();
                }
                else
                {
                    MessageBox.Show(" No Record");
                }
                dreader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(" No Record");
            }
            finally
            {
                conn.Close();
            }
            #region
            //    string conn = ConfigurationManager.ConnectionStrings["FirstRegisterApiStudent"].ConnectionString;
            //    SqlConnection sqlConnection = null;
            //    SqlCommand sqlCommand = null;
            //    SqlDataReader sqlDataReader = null;
            //    try
            //    {
            //        sqlConnection = new SqlConnection(conn);
            //        sqlConnection.Open();
            //        string command = "select * from student_detail where id = " + txt_Role.Text;
            //        sqlCommand = new SqlCommand(command, sqlConnection);
            //        sqlDataReader = sqlCommand.ExecuteReader();
            //        while (sqlDataReader.Read())
            //        {
            //            txtFullName.Text = sqlDataReader[1].ToString();
            //            txtCourse.Text = sqlDataReader[2].ToString();
            //        }
            //    }
            //    catch (Exception ex)
            //    {

            //        throw new Exception();
            //    }
            //    finally
            //    {
            //        sqlConnection.Close();
            //    }
            //}
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

