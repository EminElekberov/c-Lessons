using System;
using System.Collections.Generic;
using System.Text;

namespace winform16
{
    class Genre
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public static int id = 0;
        public Genre()
        {
            Id = ++id;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
