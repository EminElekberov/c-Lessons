using Llibrary_Management_System.Model;
using Llibrary_Management_System.ViewModel;
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
    public partial class AddBook : Form
    {
        private readonly LibraryMSEntities db;
        public static int bookid;
        public AddBook()
        {
            InitializeComponent();
            db = new LibraryMSEntities();
        }

        public void datagridrefresh()
        {
            dataGridView1.DataSource = db.Books.Where(x=>x.isDeleted==false).Select(x => new
            {
                x.id,
                x.Name,
                x.Writer,
                x.Amount,
                x.Price,
                Genre = x.Genre.Name

            }).ToList();
        }

        private void cleartxt()
        {
            txtAddName.Text = "";
            txtwriter.Text = "";
            txtamount.Value = 0;
            txtprice.Value = 0;
        }
        private void AddBook_Load(object sender, EventArgs e)
        {
            cmbGenre.DataSource = db.Genres.Select(x => new CB_Genre
            {
                id = x.id,
                Name = x.Name
            }).ToArray();

            datagridrefresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int genreid = ((CB_Genre)cmbGenre.SelectedItem).id;
            string name = txtAddName.Text;
            string writer = txtwriter.Text;
            int amount = int.Parse(txtamount.Value.ToString());
            double price = double.Parse(txtprice.Value.ToString());

            bool checkdb = db.Books.Any(x => x.Name == name);



            if (name == "" || writer == "" || amount ==0 || price ==0 )
            {
                MessageBox.Show("Please Fill All TextBox !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkdb)
            {
                MessageBox.Show("This Book Already Exist !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                Model.Book book = new Model.Book
                {
                    Name = name,
                    Writer = writer,
                    Amount = amount,
                    Price = price,
                    isDeleted = false,
                    genreId = genreid,
                };

                db.Books.Add(book);
                db.SaveChanges();
                datagridrefresh();
                cleartxt();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int genreid = ((CB_Genre)cmbGenre.SelectedItem).id;
            string name = txtAddName.Text;
            string writer = txtwriter.Text;
            int amount = int.Parse(txtamount.Value.ToString());
            double price = double.Parse(txtprice.Value.ToString());


            if (name == "" || writer == "" || amount == 0 || price == 0)
            {
                MessageBox.Show("Please Fill All TextBox !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Book book = db.Books.FirstOrDefault(x => x.id == bookid);

            book.Name = name;
            book.Writer = writer;
            book.Amount = amount;
            book.Price = price;
            book.isDeleted = false;
            book.genreId = genreid;

            db.SaveChanges();
            datagridrefresh();
            cleartxt();



        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchname = txtSearchname.Text;

            if (searchname == "")
            {
                MessageBox.Show("Please Fill Search Textbox", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Book book = db.Books.FirstOrDefault(x=>x.Name == searchname);

            if (book == null)
            {
                MessageBox.Show("This Book Not Exist", "Warning",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                bookid = book.id;

                dataGridView1.DataSource = db.Books.Where(x => x.Name == searchname).Select(x => new
                {
                    x.id,
                    x.Name,
                    x.Writer,
                    x.Amount,
                    x.Price,
                    Genre = x.Genre.Name

                }).ToList();

                txtAddName.Text = book.Name;
                txtwriter.Text = book.Writer;
                txtamount.Value = book.Amount;
                txtprice.Value = decimal.Parse(book.Price.ToString());
                cmbGenre.SelectedIndex = cmbGenre.FindString(book.Genre.Name);
            }

        }
    }
}
