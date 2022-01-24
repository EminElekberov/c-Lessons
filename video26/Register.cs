using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using video26.Model;

namespace video26
{
    public partial class Register : Form
    {
        private readonly MedicineCsharp03Entities _db;
        private readonly Form _login;
       public Register(Form login)
        {
            InitializeComponent();
            _db = new MedicineCsharp03Entities();
            _login = login;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string Fullname = txtName.Text.Trim();
            string pass = txtPass.Text.Trim();
            string Reppass = txtRepPass.Text.Trim();
            if (!(IsValid(email,Fullname,pass,Reppass)))
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool EmailInDb = _db.Users.Any(x => x.Email == email);
            if (EmailInDb)
            {
                MessageBox.Show("Email alredat exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                User user = new User
                {
                    Fullname = Fullname,
                    Pasword = pass,
                    Email = email,
                    IsActive = true,
                    IsDeleted = false,
                    IsAdmin = false
                };
                _db.Users.Add(user);
                _db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            
           
            MessageBox.Show("Successfully Registr", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private bool IsValid(string email,string fullname,string pass,string reppas)
        {
            if (email == "" || fullname == "" || pass == "" || reppas == "")
            {
                MessageBox.Show("Fill", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            if (!(email.Contains("@")))
            {
                return false;
            }
            if (pass!=reppas)
            {
                MessageBox.Show("Please repeat password", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            return true;
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Show();
        }
    }
}
