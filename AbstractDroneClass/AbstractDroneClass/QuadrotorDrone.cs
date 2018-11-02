using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDroneClass
{
    class QuadrotorDrone : Drone
    {
        public QuadrotorDrone(int totalFlyTime, int totalDistance) : base(totalFlyTime, totalDistance)
        {

        }

        public QuadrotorDrone() : base()
        {

        }

        public override double FlightSpeed(int totalFlyTime, int totalDistance)
        {//added 1 to both input arguments and returns a slightly different flight speed
            //I wasn't sure if the instance variables were supposed to be changed
            //only in the method or outside as well; I ended up 
            totalFlyTime++;
            totalDistance++;
            double flyTime = (double)totalFlyTime;
            double distance = (double)totalDistance;
            return (distance/flyTime); //in ft/m
        }
    }
}
