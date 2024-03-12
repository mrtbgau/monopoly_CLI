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
        public readonly int faces = 6;
        public int value;

        public int Roll()
        {
            Random rnd = new();
            value = rnd.Next(1, faces + 1);
            return value;
        }
    }
}
