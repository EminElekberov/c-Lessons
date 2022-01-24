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
    public partial class UsersOrder : Form
    {
        private readonly LibraryEntities2 _db;

        public UsersOrder()
        {
            InitializeComponent();
            _db = new LibraryEntities2();
        }

        private void UsersOrder_Load(object sender, EventArgs e)
        {
            cmbgenre.DataSource = _db.Genres.Select(x => new Cb_genre
            {
                Id = x.Id,
                Name = x.Name
            }).ToArray();
            datagridrefresh();
        }
        public void datagridrefresh()
        {

            dataGridView1.DataSource = _db.Books.Where(x => x.IsDeleted == false).Select(x => new
            {
                x.Id,
                x.Name,
                x.Writer,
                x.Amount,
                x.Price,
                Genre = x.Genre.Name

            }).ToList();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string searchname = txtSearchname.Text;

            if (searchname == "")
            {
                MessageBox.Show("Please Fill Search Textbox", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Book book = _db.Books.FirstOrDefault(x => x.Name == searchname);

            if (book == null)
            {
                MessageBox.Show("This Book Not Exist", "Warning",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                 dataGridView1.DataSource = _db.Books.Where(x => x.Name == searchname && x.IsDeleted == false).Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Writer,
                    x.Amount,
                    x.Price,
                    Genre = x.Genre.Name

                }).ToList();
            }
        }

        private void cmbgenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            int genreid = ((Cb_genre)cmbgenre.SelectedItem).Id;
            dataGridView1.DataSource = _db.Books.Where(x => x.GenreId == genreid && x.IsDeleted == false).Select(x => new
            {
                x.Id,
                x.Name,
                x.Writer,
                x.Amount,
                x.Price,
                Genre = x.Genre.Name

            }).ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txtSearchname.Text = name;
        }

        private void btnSearchReader_Click(object sender, EventArgs e)
        {
            string identity = textBox1.Text.Trim().ToLower();
            if (identity == "")
            {

                MessageBox.Show("Fill Reader Identity Number", "Warning",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Reader reader = _db.Readers.FirstOrDefault(x => x.IdentityNum.ToLower() == identity.ToLower());

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


                dataGridView3.DataSource = _db.Orders.Where(x => x.ReaderID == reader.Id && x.Returned == false).Select(x => new
                {
                    OrderNum = x.Id,
                    x.Startdate,
                    x.EndDate,
                    x.DebtBook,
                    Reader = x.Reader.Fullanme,
                    Book = x.Book.Name
                }).ToList();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbDay.SelectedItem == null)
            {
                MessageBox.Show("Select DAY", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int dday = Convert.ToInt32(cmbDay.SelectedItem.ToString());
            string bookname = txtSearchname.Text;
            string readerIdentity = textBox1.Text;
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
                Startdate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")),
                EndDate = DateTime.Parse(DateTime.Now.AddDays(+dday).ToString("yyy-MM-dd")),
                DebtBook = book.Price.ToString(),
                Returned = false,
                ReaderID = reader.Id,
                BookId = book.Id


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
    }
}
