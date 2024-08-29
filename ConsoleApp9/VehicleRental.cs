using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace ConsoleApp9
{
    public class VehicleRental
    {

        //Car rental list
        private static List<Vehicle> rentalVehiclesList = new List<Vehicle>();

        //Car list
        private static List<Vehicle> vehiclesList = new List<Vehicle>();

        static void Main(string[] args)
        {
            Car mazda = new Car("456767", "mazde", "b501",200, "5 places");
            Car skoda = new Car("225511", "skoda", "v567",400, "7 places");
            Car toyota = new Car("45575", "toyota", "f555",100, "2 places");
            vehiclesList.Add(mazda);
            vehiclesList.Add(toyota);
            vehiclesList.Add(skoda);

            Truck refrigeratedTruck = new Truck("655444", "skoda", "r555",300, 300);
            Truck transportTruck = new Truck("656545", "ford", "e333",500, 900);
            Truck garbageTruck = new Truck("324666", "gg", "isuzu",800, 1000);

            vehiclesList.Add(refrigeratedTruck);
            vehiclesList.Add(transportTruck);
            vehiclesList.Add(garbageTruck);

            RegularCustomer customerAvi = new RegularCustomer("Avi");
            RegularCustomer customerBenni = new RegularCustomer("Benni");
            RegularCustomer customerDavid = new RegularCustomer("David");

            CorporateCustomer companyOND = new CorporateCustomer("OND");
            CorporateCustomer companyAEO = new CorporateCustomer("AEO");

             double price = Rental(mazda, customerAvi, 5);


            Console.WriteLine(  "List of cars");
            PrintVehicles(vehiclesList);
            Console.WriteLine("List of cars hired out");
            PrintVehicles(rentalVehiclesList);




        }
        //Car rental to the customer
        public static double Rental(Vehicle vehicle,ICustomer customer,int days)
        {
            //Check if the car is free
            if (rentalVehiclesList.Contains(vehicle))
            {
                Console.WriteLine(vehicle.getMake()+" is not free.");

                return 0;
            }
            rentalVehiclesList.Add(vehicle);
            double price=customer.rentVehicle(vehicle,days);
            Console.WriteLine( vehicle is Car ? "The car hire was completed succesfully" : "The truck was succesfully rented");

            return price;
            
        }

        //print vehichle and their prices
        public static void PrintVehicles(List<Vehicle> vehicles)
        {
            foreach (var vehicle in vehicles)       
            {
                string toPrint = vehicle.getMake() + " model " + vehicle.getModel() + " cost " + vehicle.getRentalPrice()+  "for a day";
                Console.WriteLine(toPrint);
            }
        }

        [Fact]
        public void TestRentalVehicles()
        {
            //  Prepare your data for review
            RegularCustomer customerAvi = new RegularCustomer("Avi");
            RegularCustomer customerBenni = new RegularCustomer("Benni");
            RegularCustomer customerDavid = new RegularCustomer("David");

            CorporateCustomer companyOND = new CorporateCustomer("OND");
            CorporateCustomer companyAEO = new CorporateCustomer("AEO");
            CorporateCustomer companyERF = new CorporateCustomer("ERF");


            Car mazda = new Car("456767", "mazde", "b501", 200, "5 places");


            // Act - Read the function we will test
            double price  = Rental(mazda,customerAvi,5);

            // Assert - Make sure that the function returns the correct result
            Assert.Equal(1000, price);
        }
    }
}
