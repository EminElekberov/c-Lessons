using System;
using System.Collections.Generic;
using System.Text;

namespace video11_task_
{
    class Library : ILibrary
    {
        public List<Book> Books { get; set; }
        public Library()
        {
            this.Books = new List<Book>();
        }
        public void Add(Book book)
        {
            bool existName = false;
            foreach (var item in Books)
            {
                if (item.Name.Trim().ToLower() == book.Name.Trim().ToLower())
                {
                    existName = true;
                }
            }
            if (!existName)
            {
                Books.Add(book);
            }
            else
            {
                throw new sameBookAlreadyAddedException("this book exist");
            }
        }
        public List<Book> Filtername(string author, Genre genre)
        {
            string nonCapital = author.Trim().ToLower();
            List<Book> find = Books.FindAll(b => b.Author.Trim().ToLower().Equals(nonCapital) &&
            b.Genre.Equals(genre));
            return find;
        }

        public void Remove(string book)
        {
            string removeBook = book.Trim().ToLower();
            Book remove = Books.Find(r => r.Name.Trim().ToLower().Contains(removeBook));
            if (remove != null)
            {
                Books.Remove(remove);
                Console.WriteLine("silindi");
            }
            else
            {
                throw new BookNorFoundException("book doesn't found");
            }
        }

        public List<Book> Search(string serachName)
        {
            string nonCapital = serachName.Trim().ToLower();
            List<Book> searched = Books.FindAll(x => x.Author.Trim().ToLower().Contains(nonCapital)
            || x.Name.Trim().ToLower().Contains(nonCapital));
            return searched;
        }

        public void ShowInfo(string bookName)
        {
            Book info = Books.Find(n => n.Name.Trim().ToLower() == bookName.Trim().ToLower());
            if (info != null)
            {
                Console.WriteLine($"name {info.Name} \n Author{info.Author} \n " +
                    $"pagecount {info.PageCount}");
            }
            else
            {
                throw new BookNorFoundException("this book is not found");
            }
        }
    }
}
