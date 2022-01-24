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
    public partial class B_Return : Form
    {
        private readonly LibraryMSEntities db;
        public static int orderid;
        public B_Return()
        {
            InitializeComponent();
            db = new LibraryMSEntities();
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

            Reader reader = db.Readers.FirstOrDefault(x => x.IdentityNum.ToLower() == identity.ToLower());

            if (reader == null)
            {
                MessageBox.Show("This Reader not Registered", "Warning",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            gridviewrefresh(reader.id);

            //dataGridView1.DataSource = db.Orderrs.Where(x => x.ReaderId == reader.id && x.returned == false).Select(x => new
            //{
            //    x.id,
            //    Book = x.Book.Name,
            //    Reader = x.Reader.Fullname,
            //    x.StartDate,
            //    x.EndDate,
            //    x.Debtbook


            //}).ToList();



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int idd =int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            Orderr order = db.Orderrs.FirstOrDefault(x => x.id == idd);

           
            DateTime datanow = DateTime.Now;

            DateTime EndDate = Convert.ToDateTime(order.EndDate);
            int dfday = (datanow.Date - EndDate.Date).Days;

           // MessageBox.Show(idd.ToString(), "Warning", MessageBoxButtons.OK);

            double debt=0;
            if (dfday > 0)
            {
                debt =double.Parse(order.Debtbook.ToString())/200;
            }

            orderid = idd;

            debt = Math.Round(debt,2);
            double payment = debt + double.Parse(order.Debtbook.ToString());
            txtBookname.Text = order.Book.Name;
            txtReadername.Text = order.Reader.Fullname;
            txtPrice.Text = order.Debtbook.ToString();
            txtPayment.Text = payment.ToString();

            idd = 0;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Reader reader = db.Readers.FirstOrDefault(x => x.IdentityNum.ToLower() == txtidentity.Text.ToLower());
            Orderr order = db.Orderrs.FirstOrDefault(x => x.id == orderid);
            order.returned = true;
           
            db.SaveChanges();

           // MessageBox.Show(reader.id.ToString(), "Warning", MessageBoxButtons.OK);

              gridviewrefresh(reader.id);

           
            txtBookname.Text = "";
            txtPayment.Text = "";
            txtPrice.Text = "";
            txtReadername.Text = "";

        }

        private void gridviewrefresh(int id)
        {
           // MessageBox.Show(id.ToString(), "Warning", MessageBoxButtons.OK);
            dataGridView1.DataSource = db.Orderrs.Where(x => x.ReaderId == id && x.returned == false).Select(x => new
            {
                x.id,
                Book = x.Book.Name,
                Reader = x.Reader.Fullname,
                x.StartDate,
                x.EndDate,
                x.Debtbook

            }).ToList();
        }
    }
}
