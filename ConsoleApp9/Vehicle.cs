using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public abstract class Vehicle
    {
        private string licensePlate;
        private string make;
        private string model;
        protected double rentalPrice { get; set; }


        public string GetLicensePlate() { return licensePlate; }
        public string GetMake() { return make; }
        public string getModel() { return model; }
        public double getRentalPrice() { return rentalPrice; }

        public abstract double calculateRentalCost(int days);
    }
}
