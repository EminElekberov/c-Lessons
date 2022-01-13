using System;
using System.Collections.Generic;
using System.Text;

namespace example
{
    public interface Ilibrary
    {
        public List<Book> books { get; set; }
        public void AddBook(Book book);
        public List<Book> Search(string name, Genre genre);
        public void DeleteBook(string name);
        public void ShowBook(string bookName);
    }
}
