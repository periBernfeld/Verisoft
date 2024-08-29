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

        public Truck(string licensePlate, string make, string model,double  rentalPrice, int capacity) : base(licensePlate, make, model,rentalPrice)
        {
             this.capacity = capacity;
        }

        public override double calculateRentalCost(int days)
        {
            return days * (getRentalPrice() + capacity);

        }
    }
}
