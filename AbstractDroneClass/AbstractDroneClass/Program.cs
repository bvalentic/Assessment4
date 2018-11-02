using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDroneClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /* SOLID principles in action:
             *  Single Responsibility - the method FlightSpeed only does one thing: calculate speed as (distance/time)
             *  Open/Closed - abstract parent class allows the subclass to get added functionality without any changes to the parent class
             *  Liskov Substitution - a QuadrotorDrone object could be used in place of a Drone object without any other changes to the code 
             *      (the fact that Drone is abstract notwithstanding)
             *  Interface Segregation - code is split into multiple small parts, only one of which (the QuadrotorDrone class [and Main I guess])
             *      the user actually interacts with; there isn't an interface used here, but if it were, it would also be used this way
             *  Dependency Inversion - objects depend on the abstraction of Drone in order to function, 
             *      instead of a direct interaction between two concrete objects
             */

            var test = new QuadrotorDrone(3, 120);
            double speedTest = test.FlightSpeed(test.TotalFlyTime, test.TotalDistance);
            Console.WriteLine($"The speed of test 1 was {speedTest} ft/min.");

            var test2 = new QuadrotorDrone();
            double speedTest2 = test2.FlightSpeed(test2.TotalFlyTime, test2.TotalDistance);
            Console.WriteLine($"The speed of test 2 was {speedTest2} ft/min.");

            Console.ReadKey();
        }
    }
}
