using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class RegularCustomer : ICustomer
    {

        private string name;
        private List<Vehicle> rentedVehicles=new List<Vehicle>();

        public RegularCustomer(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
        public double rentVehicle(Vehicle vehicle, int days)
        {
            
            rentedVehicles.Add(vehicle);

            return  vehicle.calculateRentalCost(days);


        }
        public List<Vehicle> getRentedVehicles()
        {
            return rentedVehicles;
        }
        
    }
}
