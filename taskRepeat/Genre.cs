using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskRepeat
{
    public class Genre
    {
        public string name { get; set; }
        public int Id { get; set; }
        public static int id = 0;

        public Genre()
        {
            Id = ++id;
        }
        public override string ToString()
        {
            return $"{ name}";
        }
    }
}
