using System;
using System.Collections.Generic;
using System.Text;

namespace example
{
    public class Library : Ilibrary
    {
        public List<Book> books { get; set; }
        public Library()
        {
            books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            bool exist = false;
            foreach (var item in books)
            {
                if (item.Name.Trim().ToLower() == book.Name.Trim().ToLower())
                {
                    exist = true;
                }
            }
            if (!exist)
            {
                books.Add(book);
            }
        }

        public void DeleteBook(string name)
        {
            string bname = name.Trim().ToLower();
            foreach (var item in books)
            {
                if (item.Name.Trim().ToLower().Equals(bname))
                {
                    books.Remove(item);
                    Console.WriteLine("silindi");
                }
            }
            //string bookName = name.Trim().ToLower();
            //Book delBook = books.Find(n => n.Name.Trim().ToLower().Equals(bookName));
            //if (delBook != null)
            //{
            //    books.Remove(delBook);
            //    Console.WriteLine("silindi");
            //}
            //else
            //{
            //    Console.WriteLine("bele bir kitab tapilmadi");
            //}
        }

        public List<Book> Search(string name, Genre genre)
        {
            string bName = name.Trim().ToLower();
            List<Book> search = books.FindAll(m => m.Name.Trim().ToLower().Equals(bName) && m.genre.Equals(genre));
            return search;
        }
        public void AllList()
        {
            foreach (var item in books)
            {
                Console.WriteLine(item.Name);
            }
        }
        public void ShowBook(string bookName)
        {
            string Book = bookName.Trim().ToLower();

            foreach (var item in books)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
