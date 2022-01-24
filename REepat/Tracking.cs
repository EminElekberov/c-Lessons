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
    public partial class Tracking : Form
    {
        private readonly LibraryMSEntities db;

        public Tracking()
        {
            InitializeComponent();
            db = new LibraryMSEntities();
        }

       private void gridviewrefres3()   
        {
            //Today
            string datenow = DateTime.Now.ToString("yyy/MM/dd");
            DateTime dateTime = DateTime.Parse(datenow);
            dataGridView3.DataSource = db.Orderrs.Where(x => x.EndDate==dateTime && x.returned==false).Select(x => new
            {
                x.EndDate,
                orderID = x.id,
                FullName = x.Reader.Fullname,
                BookName = x.Book.Name,
                x.Debtbook
            }).ToList();
        }

        private void gridviewrefres2()
        {
            //Tomorrow
            string datenow = DateTime.Now.ToString("yyy/MM/dd");
            DateTime dateTime = DateTime.Parse(DateTime.Now.AddDays(+1).ToString("yyy/MM/dd"));
            dataGridView2.DataSource = db.Orderrs.Where(x => x.EndDate == dateTime && x.returned==false).Select(x => new
            {
                x.EndDate,
                orderID = x.id,
                FullName = x.Reader.Fullname,
                BookName = x.Book.Name,
                x.Debtbook
            }).ToList();
        }
        private void gridviewrefres1()
        {
            //Latest

            string datenw = DateTime.Now.ToString("yyy/MM/dd");
            DateTime datenow = DateTime.Parse(datenw);
            DateTime dateTime = DateTime.Parse(DateTime.Now.AddDays(+1).ToString("yyy/MM/dd"));
            dataGridView1.DataSource = db.Orderrs.Where(x => x.EndDate < datenow && x.returned == false).Select(x => new
            {
                x.EndDate,
                orderID = x.id,
                FullName = x.Reader.Fullname,
                BookName = x.Book.Name,
                x.Debtbook
            }).ToList();
        }

        private void Tracking_Load(object sender, EventArgs e)
        {
            gridviewrefres3();
            gridviewrefres2();
            gridviewrefres1();

          int k=  db.Orderrs.Where(x => x.returned == false).Count();
          //  MessageBox.Show(k.ToString(), "warning", MessageBoxButtons.OK);
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         int orderid = int.Parse(dataGridView3.Rows[e.RowIndex].Cells["OrderID"].Value.ToString());
            Orderr order = db.Orderrs.FirstOrDefault(x => x.id == orderid);

            int readerid = int.Parse(order.ReaderId.ToString());

            int orderscount = db.Orderrs.Where(x => x.ReaderId == readerid && x.returned==false).Count();
            label2.Text = orderscount.ToString();
            

            


        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderid = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["OrderID"].Value.ToString());
            Orderr order = db.Orderrs.FirstOrDefault(x => x.id == orderid);

            int readerid = int.Parse(order.ReaderId.ToString());

            int orderscount = db.Orderrs.Where(x => x.ReaderId == readerid && x.returned == false).Count();
            label2.Text = orderscount.ToString();


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value.ToString());
            Orderr order = db.Orderrs.FirstOrDefault(x => x.id == orderid);

            int readerid = int.Parse(order.ReaderId.ToString());

            int orderscount = db.Orderrs.Where(x => x.ReaderId == readerid && x.returned == false).Count();
            label2.Text = orderscount.ToString();
        }
    }
}
