using Llibrary_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Llibrary_Management_System
{
    public partial class DeleteUser : Form
    {
        private readonly LibraryMSEntities db;
        public DeleteUser()
        {
            InitializeComponent();
            db = new LibraryMSEntities();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            datagridrefresh();
        }
        public void datagridrefresh()
        {
            dataGridView1.DataSource = db.Users.Where(x=>x.isAdmin==false && x.isDeleted == false && x.isUser==true).Select(x => new
            {
                UserNum = x.id,
                x.Fullname,
                x.Email,
            }).ToList();
        }

        private void cleartxt()
        {
            txtemail.Text = "";

            txtname.Text = "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string email = txtemail.Text;

            if (name == "" || email == "")
            {
                MessageBox.Show("Please Fill All TextBox !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("email does not Correct !!!", "Warning",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Model.User emaildb = db.Users.FirstOrDefault(x=>x.Email.ToLower()==email.ToLower());

            if (emaildb==null)
            {
                MessageBox.Show("this User does not Registered", "Warning",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else 
            if(emaildb.isAdmin==false)
            {

                emaildb.isDeleted = true;
                db.SaveChanges();
                datagridrefresh();
                cleartxt();
            }
            else
            {
                MessageBox.Show("You can not Delete! This Admin!!!", "Warning",
     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           txtname.Text = dataGridView1.Rows[e.RowIndex].Cells["Fullname"].Value.ToString();
           txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
        }
    }
}
