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
    public partial class UserOrder : Form
    {
        private readonly LibraryEntities3 _db;

        public UserOrder()
        {
            InitializeComponent();
            _db = new LibraryEntities3();
        }

        private void SearchBook_Click(object sender, EventArgs e)
        {
            string name = txtSearchname.Text.Trim();
            if (name=="")
            {
                MessageBox.Show("Please Fill Textbox", "Warning",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Model.Book books = _db.Books.FirstOrDefault(x => x.Name == name);
            if (books == null)
            {
                MessageBox.Show("This Book Not Exist", "Warning",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                dataGridView1.DataSource = _db.Books.Where(x => x.IsDeleted == false && x.Name==name).Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Writer,
                    x.Amount,
                    x.Price,
                    Genre = x.Genre.Name
                }).ToArray();
            }
        }

        private void UserOrder_Load(object sender, EventArgs e)
        {
            cmbgenre.DataSource = _db.Genres.Select(x => new Cb_genre
            {
                Id=x.Id,
                Name=x.Name
            }).ToArray();
            dataGridView1.DataSource = _db.Books.Where(x => x.IsDeleted == false).Select(x => new
            {
                x.Id,
                x.Name,
                x.Writer,
                x.Amount,
                x.Price,
                Genre = x.Genre.Name
            }).ToArray();
            dataGridView2.DataSource = _db.Readers.Select(x => new
            {
                x.Id,
                x.Fullanme,
                x.Email,
                x.IdentityNum
            }).ToArray();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txtSearchname.Text = name;
        }

        private void SearchPerson_Click(object sender, EventArgs e)
        {
            string serchName = textBox1.Text.Trim();
            if (serchName=="")
            {
                MessageBox.Show("Please Fill Textbox", "Warning",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Reader reader = _db.Readers.FirstOrDefault(x => x.IdentityNum.ToLower() == serchName.ToLower());

            if (reader == null)
            {

                MessageBox.Show("this Reader does not Registred", "Warning",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                dataGridView2.DataSource = _db.Readers.Where(x => x.Id == reader.Id).Select(x => new
                {
                    x.Id,
                    x.Fullanme,
                    x.Email,
                    x.IdentityNum
                }).ToList();
            }
            }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dataGridView2.Rows[e.RowIndex].Cells["Fullanme"].Value.ToString();
            textBox1.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookname = txtSearchname.Text;
            string readerIdentity = textBox1.Text;
            DateTime buy = buyBookTime.Value;
            DateTime give = sendBookTime.Value;
            if (bookname == "" || readerIdentity == "")
            {
                MessageBox.Show("Fill book name and Reader identity Number", "Warning",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Reader reader = _db.Readers.FirstOrDefault(x => x.IdentityNum.ToLower() == readerIdentity.ToLower());
            Book book = _db.Books.FirstOrDefault(x => x.Name.ToLower() == bookname.ToLower());
            if (reader == null)
            {
                MessageBox.Show("This Reader not Registered", "Warning",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (book == null)
            {
                MessageBox.Show("This book Not Exist", "Warning",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Model.Order orderr = new Model.Order
            {
                Startdate = buy,
                EndDate = give,
                DebtBook = book.Price.ToString(),
                Returned = false,
                ReaderID = reader.Id,
                BookId = book.Id,
            };
            _db.Orders.Add(orderr);
            _db.SaveChanges();

            dataGridView3.DataSource = _db.Orders.Where(x => x.ReaderID == reader.Id && x.Returned == false).Select(x => new
            {
                OrderNum = x.Id,
                Reader = x.Reader.Fullanme,
                Book = x.Book.Name,
                x.Startdate,
                x.EndDate,
                x.DebtBook,

            }).ToList();

            txtSearchname.Text = "";
            textBox1.Text = "";
        }

        private void cmbgenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
