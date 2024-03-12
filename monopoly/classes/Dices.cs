using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly.classes
{
    public class Dices()
    {
        public Dice dice_1 = new();
        public Dice dice_2 = new();

        public int result = 0;

        public int Roll() {
            result += dice_1.Roll();
            result += dice_2.Roll();
            return result; 
        }

        public bool Is_double() {  
            return dice_1.value == dice_2.value;
        }
    }
}
