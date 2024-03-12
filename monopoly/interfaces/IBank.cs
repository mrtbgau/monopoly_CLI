using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly.interfaces
{
    public interface IBank
    {
        public bool Cashout(int amount);
        public bool Cashin(int amount);
        public bool GiveHouse();
        public bool TakeHouse();
        public bool GiveHotel();
        public bool TakeHotel();
    }
}
