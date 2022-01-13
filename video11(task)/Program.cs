using System;

namespace video11_task_
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book
            {
                Name="Global programing errors",
                Genre=Genre.Detective,
                PageCount=6000,
                Author="Will"
            };
            Book book2 = new Book
            {
                Name = "JS",
                Genre = Genre.Drama,
                PageCount = 2000,
                Author = "XXX"
            };
            Book book3 = new Book
            {
                Name = "Python",
                Genre = Genre.Drama,
                PageCount = 2000,
                Author = "XXX"
            };
            Library library = new Library();
            library.Add(book1);
            library.Add(book2);
            library.Add(book3);
            //Console.WriteLine(library.Books.Count);
            //foreach (var item in library.Filtername("XXX",Genre.Drama))
            //{
            //    Console.WriteLine(item.Name+" "+item.Author+" "+item.Genre.ToString());
            //}
            //Console.WriteLine("-----------");
            library.ShowInfo("Python");
        }
    }
}
