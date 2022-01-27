using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace video24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["uniqueAd"].ConnectionString;
            #region
        //    SqlConnection sqlConnection = null;
        //    SqlCommand sqlCommand = null;
        //    SqlDataReader sqlDataReader = null;
        //    try
        //    {
        //        sqlConnection = new SqlConnection(connString);
        //        sqlConnection.Open();
        //        string command = "select * from Country";
        //        sqlCommand = new SqlCommand(command, sqlConnection);
        //        sqlDataReader = sqlCommand.ExecuteReader();
        //        while (sqlDataReader.Read())
        //        {
        //            cmbconutry.Items.Add(sqlDataReader[1]);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        sqlConnection.Close();
        //    }
        //}
            #endregion
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                string command = "select * from Country";
                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader sqlDataReader=sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            cmbconutry.Items.Add(sqlDataReader[1]);
                        }
                    }
                }
            }
        }

        private void cmbconutry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
