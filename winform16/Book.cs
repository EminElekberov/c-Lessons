using System;
using System.Collections.Generic;
using System.Text;

namespace winform16
{
    class Book
    {
        private string _bookName;
        public string BookbName
        {
            get
            {
                return _bookName;
            }
            set
            {
                if (value.Trim().Length>=2)
                {
                    _bookName = value;
                }
                else
                {
                    throw new ArgumentException("book name can not be less 2 chars");
                }
            }
        }
        public int ISBNumber { get; set; }
        public byte BookPrice { get; set; }
        public int GenreId { get; set; }
        public string Genre { get; set; }
        public override string ToString()
        {
            return $"{BookbName} {ISBNumber} {BookPrice} {Genre}";
        }
    }
}
