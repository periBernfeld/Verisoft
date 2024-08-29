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

        protected Vehicle(string licensePlate, string make, string model, double rentalPrice)
        {
            this.licensePlate = licensePlate;
            this.make = make;
            this.model = model;
            this.rentalPrice = rentalPrice;
        }

     
        public string getLicensePlate() { return licensePlate; }
        public string getMake() { return make; }
        public string getModel() { return model; }
        public double getRentalPrice() { return rentalPrice; }

        public abstract double calculateRentalCost(int days);
    }
}
