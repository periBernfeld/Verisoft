using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public interface ICustomer
    {

        public string getName();

        //מחשב השכרת רכב למספר נתון של ימים
        public double rentVehicle(Vehicle vehicle, int days);

        public List<Vehicle>  getRentedVehicles();
    }
}
