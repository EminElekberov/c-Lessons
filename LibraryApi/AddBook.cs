using LibraryApi.Helper;
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
    public partial class AddBook : Form
    {
        private readonly LibraryEntities3 _db;
        public static int bookid;
        public AddBook()
        {
            InitializeComponent();
            _db = new LibraryEntities3();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenre.DataSource = _db.Genres.Select(x => new Cb_genre
            {
                Id = x.Id,
                Name = x.Name
            }).ToArray();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int TypeId = ((Cb_genre)cmbGenre.SelectedItem).Id;
            string name = txtAddName.Text.Trim().ToLower();
            string Writer = txtwriter.Text.Trim().ToLower();
            double price = double.Parse(txtprice.Value.ToString());
            int amount = int.Parse(txtamount.Value.ToString());
            if (name == "" || Writer == "" || price == null || amount == null)
            {
                MessageBox.Show("Please Fill All TextBox", "Warning",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Model.Book books = new Model.Book
                {
                    GenreId = TypeId,
                    Name = name,
                    Writer = Writer,
                    Amount = amount,
                    Price = price,
                    IsDeleted = false
                };
                _db.Books.Add(books);
                _db.SaveChanges();
                ClearArea();
            }
        }
        private void ClearArea()
        {
            txtAddName.Text = "";
            txtamount.Value = 0;
            txtprice.Value = 0;
            txtAddName.Text = "";
            txtwriter.Text = "";
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            int TypeId = ((Cb_genre)cmbGenre.SelectedItem).Id;
            string name = txtAddName.Text.Trim().ToLower();
            string Writer = txtwriter.Text.Trim().ToLower();
            double price = double.Parse(txtprice.Value.ToString());
            int amount = int.Parse(txtamount.Value.ToString());
            if (name == "" || Writer == "" || amount == 0 || price == 0)
            {
                MessageBox.Show("Please Fill All TextBox !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Model.Book updBook = _db.Books.FirstOrDefault(x => x.Id == bookid);
            updBook.GenreId = TypeId;
            updBook.Name = name;
            updBook.Writer = Writer;
            updBook.Price = price;
            updBook.Amount = amount;
            updBook.IsDeleted = false;
            _db.SaveChanges();
            ClearArea();
        }
        //

        private void label3_Click(object sender, EventArgs e)
        {
            BookList bookList = new BookList();
            bookList.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchname = txtAddName.Text.Trim().ToLower();

            if (searchname == "")
            {
                MessageBox.Show("Please Fill All TextBox ", "Warning",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Model.Book book = _db.Books.FirstOrDefault(x => x.Name.ToLower().Trim() == searchname);
            if (book != null)
            {
                _db.Books.Remove(book);
                MessageBox.Show("Success");
                //
            }
            else
            {
                MessageBox.Show("this book not exist", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //_db.SaveChanges();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReader addReader = new AddReader();
            addReader.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReader addReader = new AddReader();
            addReader.ShowDialog();
        }

        private void bookListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookList bookList = new BookList();
            bookList.ShowDialog();
        }

        private void giveBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserOrder userOrder = new UserOrder();
            userOrder.ShowDialog();
        }
    }
}