using System;

namespace taskRepeat
{
    public class Group
    {
        public String Name { get; set; }
        public int Id { get; set; }
        public Group(string nm)
        {
            Name = nm;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
