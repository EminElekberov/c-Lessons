using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video26.View
{
    public class Cb_Types
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name; 
        }
    }
}
