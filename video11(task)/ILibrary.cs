using System;
using System.Collections.Generic;
using System.Text;

namespace video11_task_
{
    interface ILibrary
    {
        public List<Book> Books { get; set; }
        public void Add(Book book);
        public void ShowInfo(string bookName);
        public List<Book> Search(string serachName);
        public List<Book> Filtername(string author, Genre genre);
        public void Remove(string book);
    }
}
