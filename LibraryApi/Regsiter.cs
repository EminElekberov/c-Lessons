using LibraryApi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApi
{
    public partial class Regsiter : Form
    {
        private readonly LibraryEntities3 _db;

        public Regsiter()
        {
            InitializeComponent();
            _db = new LibraryEntities3();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string Fullname = txtName.Text.Trim();
            string pass = txtPass.Text.Trim();
            string Reppass = txtRepPass.Text.Trim();
            if (!(Check(email, Fullname, pass, Reppass)))
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool EmailCheck = _db.Login_User.Any(x => x.Email == email);
            if (EmailCheck)
            {
                MessageBox.Show("Email alredat exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                Model.Login_User login_Users = new Model.Login_User
                {
                    Fullname = Fullname,
                    Password = pass,
                    Email = email,
                    IsDeleted = false,
                    IsAdmin = false
                };
                _db.Login_User.Add(login_Users);
                _db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            MessageBox.Show("Successfully Registr", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }
        private bool Check(string email, string fullname, string pass, string reppas)
        {
            if (email == "" || fullname == "" || pass == "" || reppas == "")
            {
                MessageBox.Show("Fill", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(email.Contains("@")))
            {
                return false;
            }
            if (pass != reppas)
            {
                MessageBox.Show("Please repeat password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            return true;
        }

        private void Regsiter_Load(object sender, EventArgs e)
        {

        }
    }
}
