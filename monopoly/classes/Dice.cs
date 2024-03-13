using monopoly.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly.classes
{
    public class Dice() : IDice
    {
        public int NbFaces { get; } = 6;
        public int Value { get; set; }

        public int Roll()
        {
            Random rnd = new();
            Value = rnd.Next(1, NbFaces + 1);
            return Value;
        }
    }
}
