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
        private readonly LibraryEntities2 _db;
        public AdminPage()
        {
            InitializeComponent();
            _db = new LibraryEntities2();
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
    }
}
