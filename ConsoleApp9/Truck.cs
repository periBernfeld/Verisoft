using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Truck:Vehicle
    {
        private int capacity;

        public override double calculateRentalCost(int days)
        {
            return days * getRentalPrice() + capacity;

        }
    }
}
