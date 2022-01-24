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
    public partial class Login : Form
    {
        private readonly MedicineCsharp03Entities _db;

        public Login()
        {
            InitializeComponent();
            _db = new MedicineCsharp03Entities();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmailLogin.Text.Trim();
            string pass = txtPassLogin.Text.Trim();
            if (email=="" || pass=="")
            {
                MessageBox.Show("Fill", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            User user = _db.Users.FirstOrDefault(u => u.Email == email);
            if (user==null)
            {
                MessageBox.Show("Please register", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register(this);
            register.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
