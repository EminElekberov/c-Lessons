using System;
using System.Collections.Generic;
using System.Text;

namespace video11_task_
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public  Genre Genre;
    }
    public enum Genre
    {
        Detective,
        Drama,
        ScienceFiction
    }
}
