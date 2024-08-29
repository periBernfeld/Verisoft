using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace ConsoleApp9
{
    public class VehicleRental
    {

        //רשימת  רכבים שכורים
         private static List<Vehicle> rentalVehiclesList = new List<Vehicle>();

        //רשימה של הרכבים
        private static List<Vehicle> vehiclesList = new List<Vehicle>();

        static void Main(string[] args)
        {
            Car mazda = new Car("456767", "mazde", "b501",200, "5 places");
            Car skoda = new Car("225511", "skoda", "v567",400, "7 places");
            Car toyota = new Car("45575", "toyota", "f555",100, "2 places");
            vehiclesList.Add(mazda);
            vehiclesList.Add(toyota);
            vehiclesList.Add(skoda);

            Truck truck1 = new Truck("655444", "gg", "r555",300, 300);
            Truck truck2 = new Truck("656545", "ffd", "e333",500, 900);
            Truck truck3 = new Truck("324666", "gg", "s508",800, 1000);

            vehiclesList.Add(truck1);
            vehiclesList.Add(truck2);
            vehiclesList.Add(truck3);

            RegularCustomer customerAvi = new RegularCustomer("Avi");
            RegularCustomer customerBenni = new RegularCustomer("Benni");
            RegularCustomer customerDavid = new RegularCustomer("David");

            CorporateCustomer companyOND = new CorporateCustomer("OND");
            CorporateCustomer companyAEO = new CorporateCustomer("AEO");

             double price = Rental(mazda, customerAvi, 5);


            Console.WriteLine(  "רשימת הרכבים");
            PrintVehicles(vehiclesList);
            Console.WriteLine("רשימת הרכבים השכורים");
            PrintVehicles(rentalVehiclesList);




        }
        //השכרת רכב ללקוח
        public static double Rental(Vehicle vehicle,ICustomer customer,int days)
        {
            //בדיקה האם הרכב פנוי
            if (rentalVehiclesList.Contains(vehicle))
            {
                Console.WriteLine(vehicle.getMake()+" is not free.");

                return 0;
            }
            rentalVehiclesList.Add(vehicle);
            double price=customer.rentVehicle(vehicle,days);
            Console.WriteLine( vehicle is Car ? "הרכב הושכר בהצלחה" : "המשאית הושכרה בהצלחה");

            return price;
            
        }

        //הדפסת הרכבים ומיחריהם
        public static void PrintVehicles(List<Vehicle> vehicles)
        {
            foreach (var vehicle in vehicles)       
            {
                ///"mazda model 222 cost " + 
                string toPrint = vehicle.getMake() + " model " + vehicle.getModel() + " cost " + vehicle.getRentalPrice()+  "for a day";
                Console.WriteLine(toPrint);
            }
        }

        [Fact]
        public void TestRentalVehicles()
        {
            //  הכנת הנתונים לבדיקה
            RegularCustomer customerAvi = new RegularCustomer("Avi");
            RegularCustomer customerBenni = new RegularCustomer("Benni");
            RegularCustomer customerDavid = new RegularCustomer("David");

            CorporateCustomer companyOND = new CorporateCustomer("OND");
            CorporateCustomer companyAEO = new CorporateCustomer("AEO");

            Car mazda = new Car("456767", "mazde", "b501", 200, "5 places");


            // Act - קריאת הפונקציה שאותה נבדוק
            double price  = Rental(mazda,customerAvi,5);

            // Assert - בדיקה שהפונקציה מחזירה את התוצאה הנכונה
            Assert.Equal(1000, price);
        }
    }
}
