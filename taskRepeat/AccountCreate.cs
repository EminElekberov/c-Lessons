using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskRepeat
{
    public partial class AccountCreate : Form
    {
        public AccountCreate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["dbo"].ConnectionString;
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;
            SqlDataReader sqlDataReader = null;
            try
            {
                sqlConnection = new SqlConnection(conn);
                sqlConnection.Open();
                sqlCommand=new SqlCommand("insert into tbl_login (Username,Password) values ('" + txtCreateName.Text.Trim() + "','" + txtCreatPassword.Text.Trim() + "')", sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand.ExecuteReader();

                if (sqlDataReader1.Read()==true)
                {
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }
                    MessageBox.Show("Success");
                this.Close();
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

        private void AccountCreate_Load(object sender, EventArgs e)
        {

        }
    }
}
