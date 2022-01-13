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

namespace video25_DisconnctedModel_
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
            using (SqlConnection conn=new SqlConnection(connString))
            {
                string command = "select * from Country";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, connString);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
