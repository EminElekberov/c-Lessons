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
    public partial class DeleteBook : Form
    {
        private readonly LibraryMSEntities db;
        public DeleteBook()
        {
            InitializeComponent();
            db = new LibraryMSEntities();
        }
        public void datagridrefresh()
        {

            dataGridView1.DataSource = db.Books.Where(x => x.isDeleted == false).Select(x => new
            {
                x.id,
                x.Name,
                x.Writer,
                x.Amount,
                x.Price,
                Genre = x.Genre.Name

            }).ToList();
        }
        private void DeleteBook_Load(object sender, EventArgs e)
        {
            datagridrefresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string searchname = txtSearchname.Text.Trim().ToLower();

            if (searchname == "")
            {
                MessageBox.Show("Please Fill All TextBox !!!", "Warning",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Book book = db.Books.FirstOrDefault(x => x.Name.ToLower() == searchname);
            if (book == null)
            {
                MessageBox.Show("this book not exist!!!", "Warning",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                book.isDeleted = true;
                db.SaveChanges();
                datagridrefresh();
                txtSearchname.Text = "";
            }
            


        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string name = dtgvMedicine.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            string name = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txtSearchname.Text = name;

        }
    }
}
