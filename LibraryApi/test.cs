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
    public partial class test : Form
    {
        private readonly LibraryEntities3 _db;
        public static int orderid;

        public test()
        {
            InitializeComponent();
            _db = new LibraryEntities3();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string identity = txtidentity.Text;
            if (identity == "")
            {
                MessageBox.Show("Fill Identity Number", "Warning",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Model.Reader reader = _db.Readers.FirstOrDefault(x => x.IdentityNum.ToLower() == identity.ToLower());

            if (reader == null)
            {
                MessageBox.Show("This Reader not Registered", "Warning",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            gridviewrefresh(reader.Id);
            dataGridView1.DataSource = _db.Orders.Where(x => x.ReaderID == reader.Id && x.Returned == false).Select(x => new
            {
                x.Id,
                Book = x.Book.Name,
                Reader = x.Reader.Fullanme,
                x.Startdate,
                x.EndDate,
                x.DebtBook


            }).ToList();
        }
        private void gridviewrefresh(int id)
        {
            // MessageBox.Show(id.ToString(), "Warning", MessageBoxButtons.OK);
            dataGridView1.DataSource = _db.Orders.Where(x => x.ReaderID == id && x.Returned == false).Select(x => new
            {
                x.Id,
                Book = x.Book.Name,
                Reader = x.Reader.Fullanme,
                x.Startdate,
                x.EndDate,
                x.DebtBook

            }).ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idd = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            MessageBox.Show(idd.ToString());
            Model.Order order = _db.Orders.FirstOrDefault(x => x.Id == idd);


            DateTime datanow = DateTime.Now;

            DateTime EndDate = Convert.ToDateTime(order.EndDate);
            int dfday = (datanow.Date - EndDate.Date).Days;

            // MessageBox.Show(idd.ToString(), "Warning", MessageBoxButtons.OK);

            double debt = 0;
            if (dfday > 0)
            {
                debt = double.Parse(order.DebtBook.ToString()) / 200;
            }

            int orderid = idd;

            debt = Math.Round(debt, 2);
            double payment = debt + double.Parse(order.DebtBook.ToString());
            txtBookname.Text = order.Book.Name;
            txtReadername.Text = order.Reader.Fullanme;
            txtPrice.Text = order.DebtBook.ToString();
            txtPayment.Text = payment.ToString();

            idd = 0;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Reader reader = _db.Readers.FirstOrDefault(x => x.IdentityNum.ToLower() == txtidentity.Text.ToLower());
            Model.Order order = _db.Orders.FirstOrDefault(x => x.Id ==orderid);
            order.Returned = true;

            _db.SaveChanges();

            // MessageBox.Show(reader.id.ToString(), "Warning", MessageBoxButtons.OK);

            gridviewrefresh(reader.Id);


            txtBookname.Text = "";
            txtPayment.Text = "";
            txtPrice.Text = "";
            txtReadername.Text = "";
        }

        private void test_Load(object sender, EventArgs e)
        {

        }
    }
}
