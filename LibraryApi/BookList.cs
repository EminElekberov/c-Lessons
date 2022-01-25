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
    public partial class BookList : Form
    {
        private readonly LibraryEntities3 _db;
        public static int bookId;
        public BookList()
        {
            InitializeComponent();
            _db = new LibraryEntities3();
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            bookDtvgrd.DataSource = _db.Books.Where(x => x.IsDeleted == false).Select(x => new
            {
                x.Id,
                x.Name,
                x.Writer,
                x.Amount,
                x.Price,
                Genre = x.Genre.Name

            }).ToList();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string searchname = txtSearchname.Text;
            if (searchname=="")
            {
                MessageBox.Show("Please Fill Search Textbox", "Warning",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Model.Book books = _db.Books.First(x => x.Name == searchname);
            bookId = books.Id;
            bookDtvgrd.DataSource = _db.Books.Where(x => x.Name == searchname).Select(x => new
            {
                x.Id,
                x.Name,
                x.Amount,
                x.Price,
                x.Writer,
                Type = x.Genre.Name
            }).ToArray();

        }
    }
}
