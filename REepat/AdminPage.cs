using REepat.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REepat
{
    public partial class AdminPage : Form
    {
        private readonly LibraryMSEntities db;
        private static int userid;
        public AdminPage()
        {
            InitializeComponent();
            db = new LibraryMSEntities();
        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBook dltbook = new DeleteBook();
            dltbook.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register rgst = new Register();
            rgst.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser dltuser = new DeleteUser();
            dltuser.Show();
        }

        private void userDashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
        }

        private void hesabatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.Show();
           
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            gridviewrefresh();
        }

        private void gridviewrefresh()
        {
            dataGridView1.DataSource = db.Users.Where(x => x.isAdmin == false && x.isDeleted == false && x.isUser == false).
                Select(x => new
                {
                    UserId = x.id,
                    x.Fullname,
                    x.Email
                }).ToList() ;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            userid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["UserId"].Value.ToString());
            Model. user = db.Users.FirstOrDefault(x => x.id == userid);
            textBox1.Text = user.Fullname;

        }

        private void btnpermission_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (name == "")
            {
                MessageBox.Show("Select a User", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            Model.User user = db.Users.FirstOrDefault(x => x.id == userid);

            user.isUser = true;
            db.SaveChanges();
            textBox1.Text = "";
            gridviewrefresh();
        }
    }
}
