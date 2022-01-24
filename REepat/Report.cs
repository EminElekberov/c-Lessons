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
    public partial class Report : Form
    {
        private readonly LibraryMSEntities db;
        public Report()
        {
            InitializeComponent();
            db = new LibraryMSEntities();
                }

        private void gridviewrefresh()
        {
            dataGridView1.DataSource = db.Orderrs.Where(x => x.returned == false).
                Select(x => new
                {
                    OrderNum = x.id,
                    ReaderName = x.Reader.Fullname,
                    BookName = x.Book.Name,
                    x.StartDate,
                    x.EndDate,
                    BookPrice =  x.Debtbook
                }).ToList();
        }
        private void Report_Load(object sender, EventArgs e)
        {
            gridviewrefresh();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            DateTime strdt = dateTimeStart.Value;
            DateTime enddt = dateTimeEnd.Value;

            dataGridView1.DataSource = db.Orderrs.Where(x =>x.StartDate>strdt && x.StartDate<enddt  && x.returned == false).
                Select(x => new
                {
                    OrderNum = x.id,
                    ReaderName = x.Reader.Fullname,
                    BookName = x.Book.Name,
                    x.StartDate,
                    x.EndDate,
                    BookPrice = x.Debtbook
                }).ToList();
        }
    }
}
