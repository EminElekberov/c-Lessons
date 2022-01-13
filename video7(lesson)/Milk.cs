using System;
using System.Collections.Generic;
using System.Text;

namespace video7_lesson_
{
    class Milk:Product
    {
        public double Volume { get; set; }
        public double FatRate { get; set; }
        public Milk(string nm) : base(nm) { }
    }
}
