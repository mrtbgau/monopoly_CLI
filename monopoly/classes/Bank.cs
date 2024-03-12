using monopoly.classes.config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly.classes
{
    public class Bank()
    {
        public int cash = Config.CASH;
        public int houses = Config.HOUSES;
        public int hotels = Config.HOTELS;

        public bool Cashout(int amount)
        {
            if(amount > cash || amount <= 0) return false;

            cash -= amount;

            return true;
        }

        public bool Cashin(int amount)
        {
            if ((amount + cash) > 20580) return false;

            cash += amount;

            return true;
        }

        public bool GiveHouse() {
            if(houses <= 0) return false;

            houses--;

            return true;
        }

        public bool TakeHouse()
        {
            if (houses >= Config.HOUSES) return false;

            houses--;

            return true;
        }

        public bool GiveHotel()
        {
            if (hotels <= 0) return false;

            hotels--;

            return true;
        }

        public bool TakeHotel()
        {
            if (houses >= Config.HOTELS) return false;

            houses--;

            return true;
        }
    }
}
