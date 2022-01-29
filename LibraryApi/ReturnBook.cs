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
    public partial class ReturnBook : Form
    {
        private readonly LibraryEntities3 _db;

        public ReturnBook()
        {
            InitializeComponent();
            _db = new LibraryEntities3();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DataSource = _db.Readers.Select(x => new Cb_genre
            {
               Id=x.Id, 
               Name=x.Fullanme
            }).ToArray();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem!=null)
            {
                int id = ((Cb_genre)comboBox1.SelectedItem).Id;
                dataGridView1.DataSource = _db.Orders.Where(x => x.ReaderID == id).Select(x => new
                {
                    UserId = x.Reader.Id,
                    BookName = x.Book.Name,
                    Startdate = x.Startdate,
                    EndDate = x.EndDate,
                    Price = x.DebtBook
                }).ToList();
            }
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["UserId"].Value.ToString());
            MessageBox.Show(id.ToString());
            Model.Order order = _db.Orders.FirstOrDefault(x => x.ReaderID == id);
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = ((DateTime)order.EndDate);
            numericUpDown1.Value = decimal.Parse(order.DebtBook.ToString());
            comboBox1.SelectedIndex = comboBox1.FindString(order.Book.Name);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            double price = double.Parse(numericUpDown1.Value.ToString());
            DateTime toDay = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;
            TimeSpan sp = toDay - endDate;
            int days = sp.Days;
            if (toDay > endDate)
            {
                double otherMany = (price * 0.3) * days;
                label3.Text = "Bu kitab " + days.ToString() + " gecikib ve elave odenis " + otherMany.ToString();
            }
            else
            {
                MessageBox.Show("Kitab Ugurla qaytardi", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numericUpDown1.Value = 0;
                dateTimePicker1.Value = DateTime.Now;
            }
        }
    }
}
