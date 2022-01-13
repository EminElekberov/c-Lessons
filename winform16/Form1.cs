using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform16
{
    public partial class Form1 : Form
    {
        private List<Book> _book;
        private List<Genre> _genre;
        public Form1()
        {
            InitializeComponent();
            _book = new List<Book>();
            _genre = new List<Genre>
            {
                new Genre{Name="Dedectice"},
                new Genre{Name="Roman"},
                new Genre{Name="LOve"}
            };
        }
        private void Form1_Load(object sender,EventArgs e)
        {
            //burdaki kodlar islemir
            
        }
        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Bname = txt_name.Text.Trim();
            int BNumber = Convert.ToInt32(txt_number.Text.Trim());
            byte BPrice = Convert.ToByte (txt_price.Text.Trim());
            Book book = null;
            try
            {
                 book = new Book
                {
                    BookbName = Bname,
                    ISBNumber = BNumber,
                    BookPrice = BPrice
                };
            }
            catch (Exception)
            {
                MessageBox.Show("please fill values  for book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Genre selectgenre = cmb_genre.SelectedItem as Genre;
            if (selectgenre==null)
            {
                MessageBox.Show("please select genre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            book.GenreId = selectgenre.Id;
            book.Genre = selectgenre.Name;
            _book.Add(book);
            ListBook();
            Clearinput();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cmb_genre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_genre.Items.AddRange(_genre.ToArray());
            cmb_filter.Items.AddRange(_genre.ToArray());
            cmb_filter.Items.Insert(0, "All");
        }
        private void Clearinput()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = " ";
                }
            }
        }
        private void ListBook()
        {
            lbl_book.Items.Clear();
            lbl_book.Items.AddRange(_book.ToArray());
        }

        private void cmb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Genre selectedgenre = cmb_filter.SelectedItem as Genre;
            if (selectedgenre==null)
            {
                ListBook();
            }
            else
            {
                lbl_book.Items.Clear();
                foreach (var book in _book)
                {
                    if (selectedgenre.Id==book.GenreId)
                    {
                        lbl_book.Items.Add(book);
                    }
                }
            }
        }
    }
}
