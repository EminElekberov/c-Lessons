using System.Collections.Generic;

namespace example
{
    public class Brutforce
    {
        public ICollection<char> Alphabet { get; set; }

        private ICollection<string> _calculate(int lenght)
        {
            if (lenght <= 1) return Alphabet.Select(a => a + "").ToList();
            ICollection<string> sub = _calculate(lenght - 1);
            return (from alpha in Alphabet from prior in sub select alpha + prior).ToList();
        }

        public ICollection<string> Calculate(int lenght)
        {
            return Alphabet == null ? null : _calculate(lenght);
        }
    }
}