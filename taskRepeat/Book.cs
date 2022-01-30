using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskRepeat
{
    public class Book
    {
        public string Name { get; set; }
        public int IsbnNumber { get; set; }
        public byte BookPrice { get; set; }
        public int GenreId { get; set; }
        public string Genre { get; set; }
        public override string ToString()
        {
            return $"{ Name} {IsbnNumber } { BookPrice} { Genre}";
        }
    }
}
