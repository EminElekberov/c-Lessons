using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskRepeat
{
    public partial class Form1 : Form
    {
        public List<Genre> genre;
        public List<Book> books;
        public Form1()
        {
            books = new List<Book>();
            genre = new List<Genre>
            {
                new Genre{name="Roman"},
                new Genre{name="Felsefe"},

            };
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //burdaki kodlar islemir

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text.Trim().ToLower();
            int Isbn = Convert.ToInt32(txt_number.Text.Trim().ToLower());
            byte price = byte.Parse(txt_price.Text.Trim());
            Book book = new Book
            {
                Name = name,
                IsbnNumber = Isbn,
                BookPrice=price
            };
            Genre selectedGenere = cmb_genre.SelectedItem as Genre;
            if (selectedGenere==null)
            {
                MessageBox.Show("please select genre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            book.GenreId = selectedGenere.Id;
            book.Genre = selectedGenere.name;
            books.Add(book);
            ListBook();
        }
        public void ListBook()
        {
            lbl_book.Items.Clear();
            lbl_book.Items.AddRange(books.ToArray());
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cmb_genre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_filter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_filter.Items.Add("all");
            cmb_genre.Items.AddRange(genre.ToArray());
            cmb_filter.Items.AddRange(genre.ToArray());
        }


        private void cmb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Genre selected = cmb_filter.SelectedItem as Genre;
            if (selected==null)
            {
                ListBook();
            }
            lbl_book.Items.Clear();
            foreach (var item in books)
            {
                if (item.Genre==selected.ToString())
                {
                    lbl_book.Items.Add(item);
                }
            }
        }

        private void cmb_genre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
