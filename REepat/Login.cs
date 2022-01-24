using Llibrary_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Llibrary_Management_System
{
    public partial class Login : Form
    {
        private readonly LibraryMSEntities db;

        public Login()
        {
            InitializeComponent();
            db = new LibraryMSEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  string ss = "12-30-2021";
            //  DateTime EndDate = DateTime.Now;
            //  // DateTime StartDate = DateTime.Now.AddDays(-5);
            //  DateTime StartDate = Convert.ToDateTime(ss);
            //  int dfday = (EndDate.Date - StartDate.Date).Days;
            //string dtime =  DateTime.Now.ToString("MM-dd-yyyy");
            //  MessageBox.Show(dfday.ToString());

            string email = txtmail.Text;
            string password = txtpassword.Text;
            if ( email == "" || password == "")
            {
                MessageBox.Show("Please Fill All TextBox !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (!email.Contains("@"))
            {
                MessageBox.Show("Email is Wrong !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool emaildb = db.Users.Any(x=>x.Email == email);

            if (!emaildb)
            {
                MessageBox.Show("User Not Registered !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Model.User user = db.Users.FirstOrDefault(x => x.Email == email);

            if (user.isAdmin == true)
            {
                this.Close();
                th = new Thread(openadminpage);
                th.Start();
                return;
            }

            if(user.isUser == true && user.isDeleted==false)
            {
                this.Close();
                th = new Thread(openuser);
                th.Start();
            }



        }

        Thread th;

        public void openadminpage(object obj)
        {
            Application.Run(new AdminPage());
        }

        public void openuser(object obj)
        {
            Application.Run(new User());
        }
        public void openform(object obj)
        {
            Application.Run(new Register());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openform);
            th.Start();
            
        }
    }
}
