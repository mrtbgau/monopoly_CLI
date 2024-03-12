using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly.interfaces
{
    public interface IBank
    {
        public bool GiveMoney(int amount);
        public bool TakeMoney(int amount);
    }
}
