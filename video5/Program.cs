using System;
using System.Collections;
using System.Collections.Generic;

namespace video5
{
    class Program
    {
        static void Main(string[] args)
        {
            BOOK book1 = new BOOK("Book1", "Author2", 155);
            BOOK book2 = new BOOK("book2", "author2", 160);
            BOOK book3 = new BOOK("Book3", "author3", 190);
            Library library = new Library();
            library.BOOKs = new List<BOOK> { book1, book2, book3 };
            library.FindAllBookByName("book1");
            foreach (var item in library.FindAllBookByName("Book1"))
            {
                Console.WriteLine(item.name);
            }
        }
    }
    public class BOOK
    {
        public string code;
        public string name;
        public string authorName;
        public int pageCount;
        public int id;
        public BOOK(string name, string authorName, int pageCount)
        {
            this.name = name;
            this.authorName = authorName;
            this.pageCount = pageCount;
            code = name.Substring(0, 2) + ++id;
        }
    }

    public class Library
    {
        public List<BOOK> BOOKs = new List<BOOK>();
        public List<BOOK> FindAllBookByName(string name)
        {
            List<BOOK> allBook = new List<BOOK>();
            foreach (var item in BOOKs)
            {
                if (item.name == name)
                {
                    allBook.Add(item);
                }
            }
            return allBook;
        }
        public List<BOOK> RemoveBookByName(string name)
        {
            foreach (var item in BOOKs)
            {
                if (item.name == name)
                {
                    BOOKs.Remove(item);
                }
            }
            return BOOKs;

        }
        public List<BOOK> SearchAllBookByName(string name, string authorName, int pageCount)
        {
            List<BOOK> searchBook = new List<BOOK>();
            foreach (var item in BOOKs)
            {
                if (item.name==name || item.authorName==authorName || item.pageCount==pageCount)
                {
                    searchBook.Add(item);
                }
            }
            return searchBook;
        }

        public List<BOOK> FindAllBooksByPageCount(int min,int max)
        {
            List<BOOK> newBookList = new List<BOOK>();
            foreach (var item in BOOKs)
            {
                if (item.pageCount>min && item.pageCount<max)
                {
                    newBookList.Add(item);
                }
            }
            return newBookList;
        }
        public List<BOOK> RemoveByNo(string no)
        {
            foreach (var item in BOOKs)
            {
                if (item.code==no)
                {
                    BOOKs.Remove(item);
                }
            }
            return BOOKs;
        }
    }
}
