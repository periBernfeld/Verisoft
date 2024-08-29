using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class CorporateCustomer : ICustomer
    {
        private string companyName;

        private List<Vehicle> rentedVehicles = new List<Vehicle>();
        public CorporateCustomer(string companyName)
        {
            this.companyName = companyName;
        }
        public string getName()
        {
           return companyName;
        }


        public double rentVehicle(Vehicle vehicle, int days)
        {
            double price = vehicle.calculateRentalCost(days) * 0.95;
            rentedVehicles.Add(vehicle);
            return price;
        }


        public List<Vehicle> getRentedVehicles()
        {
            return rentedVehicles;
        }
    }
}
