using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int userChoice)
        {
            switch  (userChoice)
            {
                case 4:
                    return new Car();
                case 3:
                    return new Slingshot();
                case 2:
                    return new Motorcycle();
                default:
                    Console.WriteLine("Invalid number of wheels, default build:");
                    return new Car();
            }
        }
    }
}
