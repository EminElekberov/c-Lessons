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
    public partial class AdminPage : Form
    {
        private readonly LibraryEntities3 _db;
        public AdminPage()
        {
            InitializeComponent();
            _db = new LibraryEntities3();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            StudentListDgv.DataSource = _db.Login_User.Where(x => x.IsAdmin == false && x.IsDeleted == false).Select(x => new
                {
                    UserId = x.Id,
                    x.Fullname,
                    x.Email
                }).ToList();
        }

        private void StudentListDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int userId = int.Parse(StudentListDgv.Rows[e.RowIndex].Cells["UserId"].Value.ToString());
            Model.Login_User login = _db.Login_User.FirstOrDefault(x => x.Id == userId);
            txtname.Text = login.Fullname;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            if (name=="")
            {
                MessageBox.Show("Select a User", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Model.Login_User login_User = _db.Login_User.FirstOrDefault(x => x.Fullname == name);
            login_User.IsDeleted = true;
            _db.SaveChanges();
            MessageBox.Show("Selected Name is Accepted", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtname.Text = "";
            StudentListDgv.DataSource = _db.Login_User.Where(x => x.IsAdmin == false && x.IsDeleted == false).Select(x => new
            {
                UserId = x.Id,
                x.Fullname,
                x.Email
            }).ToList();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            if (name == "")
            {
                MessageBox.Show("Select a User", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Model.Login_User login_User = _db.Login_User.FirstOrDefault(x => x.Fullname == name);
            _db.Login_User.Remove(login_User);
            _db.SaveChanges();
            MessageBox.Show("Selected Name is Deleted","Sucess",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtname.Text = "";
            StudentListDgv.DataSource = _db.Login_User.Where(x => x.IsAdmin == false && x.IsDeleted == false).Select(x => new
            {
                UserId = x.Id,
                x.Fullname,
                x.Email
            }).ToList();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.ShowDialog();
        }
    }
}
