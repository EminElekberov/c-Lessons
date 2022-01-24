using Llibrary_Management_System.Extentions;
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
    public partial class Register : Form
    {
        private readonly LibraryMSEntities db;
        public Register()
        {
            InitializeComponent();
            db = new LibraryMSEntities();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string name = txtname.Text;
            string email = txtmail.Text;
            string password = txtpassword.Text;
            string rptpass = txtrptpass.Text;
            if(name == "" || email == "" || password == "" || rptpass == "")
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

            if(password != rptpass)
            {
                MessageBox.Show("the reset password is incorrect", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            bool emaildb = db.Users.Any(x => x.Email == email);

            if (emaildb)
            {
                MessageBox.Show("This User Already Registered", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Model.User user = new Model.User
            {
                Fullname = name,
                Email = email,
                Pasword = Cryptography.Encode(password),
                isAdmin = false,
                isDeleted = false,
                isUser = false
            };

            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Registered Saccesfully", "Warning",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login lg = new Login();

            this.Close();
            th = new Thread(openform);
            th.Start();


        }
        Thread th;
        public void openform(object obj)
        {
            Application.Run(new Login());
        }
        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
