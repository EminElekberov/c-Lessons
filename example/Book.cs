using System;
using System.Collections.Generic;
using System.Text;

namespace example
{
   public  class Book
    {
        public string Name { get; set; }
        public string Author{ get; set; }
        public int Page { get; set; }
        public Genre genre;
    }
   public enum Genre
    {
        Detective,
        Dram,
        Roman
    }
}
