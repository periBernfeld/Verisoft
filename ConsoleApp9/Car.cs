using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Car : Vehicle
    {
        private string type;


        public Car(string licensePlate, string make, string model, double rentalPrice,string type ) : base(licensePlate, make, model,rentalPrice)
        {
          this.type=type;
        }
        public override double calculateRentalCost(int days)
        {
            return days * getRentalPrice();
        }
    }
}
