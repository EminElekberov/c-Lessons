using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Llibrary_Management_System
{
    public partial class User : Form
    {
       // private readonly LibraryMSEntities db;
        public User()
        {
            InitializeComponent();
           // db = new LibraryMSEntities();
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
        private void readersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddReader rd = new AddReader();
           // rd.ShowDialog();
        }

        private void User_Load(object sender, EventArgs e)
        {
           
            cmbgenre.DataSource = db.Genres.Select(x => new CB_Genre
            {
                id = x.id,
                Name = x.Name
            }).ToArray();

            datagridrefresh();
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

            Book book = db.Books.FirstOrDefault(x => x.Name == searchname);

            if (book == null)
            {
                MessageBox.Show("This Book Not Exist", "Warning",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                //dataGridView1.DataSource = db.Books.Where(x => x.Name == searchname && x.isDeleted==false).Select(x => new
                //{
                //    x.id,
                //    x.Name,
                //    x.Writer,
                //    x.Amount,
                //    x.Price,
                //    Genre = x.Genre.Name

                //}).ToList();
            }
        }

        private void cmbgenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int genreid = ((CB_Genre)cmbgenre.SelectedItem).id;
            //dataGridView1.DataSource = db.Books.Where(x => x.genreId == genreid && x.isDeleted==false).Select(x => new
            //{
            //    x.id,
            //    x.Name,
            //    x.Writer,
            //    x.Amount,
            //    x.Price,
            //    Genre = x.Genre.Name

            //}).ToList();
        }

        private void cmbgenre_SelectedValueChanged(object sender, EventArgs e)
        {

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
            Reader reader = db.Readers.FirstOrDefault(x => x.IdentityNum.ToLower() == identity.ToLower());

            if (reader == null)
            {

                MessageBox.Show("this Reader does not Registred", "Warning",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                dataGridView2.DataSource = db.Readers.Where(x => x.id == reader.id).Select(x => new
                {
                    x.id,
                    x.Fullname,
                    x.Email,
                    x.IdentityNum
                }).ToList();


                dataGridView3.DataSource = db.Orderrs.Where(x => x.ReaderId == reader.id && x.returned==false).Select(x => new
                {
                    OrderNum = x.id,
                     x.StartDate,
                     x.EndDate,
                     x.Debtbook,
                     Reader = x.Reader.Fullname,
                     Book = x.Book.Name
                }).ToList();
            }


            //dataGridView2.DataSource = db.Readers.Where(x=>x.)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (cmbDay.SelectedItem == null)
            {
                MessageBox.Show("Select DAY", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int dday =Convert.ToInt32(cmbDay.SelectedItem.ToString());
            string bookname = txtSearchname.Text;
            string readerIdentity = textBox1.Text;
            if (bookname == "" || readerIdentity == "")
            {
                MessageBox.Show("Fill book name and Reader identity Number", "Warning",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Reader reader = db.Readers.FirstOrDefault(x => x.IdentityNum.ToLower() == readerIdentity.ToLower());
            Book book = db.Books.FirstOrDefault(x => x.Name.ToLower() == bookname.ToLower());

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

            //  string ss = "12-30-2021";
            //  DateTime EndDate = DateTime.Now;
            //  // DateTime StartDate = DateTime.Now.AddDays(-5);
            //  DateTime StartDate = Convert.ToDateTime(ss);
            //  int dfday = (EndDate.Date - StartDate.Date).Days;
            //string dtime =  DateTime.Now.ToString("MM-dd-yyyy");
            //  MessageBox.Show(dfday.ToString());

            Orderr orderr = new Orderr
            {
                StartDate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")),
                EndDate = DateTime.Parse(DateTime.Now.AddDays(+dday).ToString("yyy-MM-dd")),
                Debtbook = book.Price,
                returned = false,
                ReaderId = reader.id,
                BookId = book.id


            };
            db.Orderrs.Add(orderr);
            db.SaveChanges();

            dataGridView3.DataSource = db.Orderrs.Where(x => x.ReaderId == reader.id && x.returned==false).Select(x => new
            {
                OrderNum = x.id,
                Reader = x.Reader.Fullname,
                Book = x.Book.Name,
                x.StartDate,
                x.EndDate,
                x.Debtbook,

            }).ToList();

            txtSearchname.Text = "";
            textBox1.Text = "";
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook addbook = new AddBook();
            addbook.Show();
        }

        private void deleteReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteReader dlr = new DeleteReader();
            dlr.Show();
        }

        private void bookTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tracking tr = new Tracking();
            tr.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bookReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            B_Return brt = new B_Return();
            brt.Show();
        }
    }
}