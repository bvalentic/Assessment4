using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDroneClass
{
    abstract class Drone
    {
        private int totalFlyTime; //in feet
        private int totalDistance; //in minutes

        public int TotalFlyTime
        {
            get { return totalFlyTime; }
            set { totalFlyTime = value; }
        }

        public int TotalDistance
        {
            get { return totalDistance; }
            set { totalDistance = value; }
        }

        public Drone(int totalFlyTime, int totalDistance)
        {
            TotalFlyTime = totalFlyTime;
            TotalDistance = totalDistance;
        }

        public Drone()
        {//default constructor
            TotalFlyTime = 0;
            TotalDistance = 0;
        }

        public virtual double FlightSpeed(int totalFlyTime, int totalDistance)
        {//because both inputs are int, I converted them to doubles and returned that value
            double flyTime = (double)totalFlyTime;
            double distance = (double)totalDistance;
            return (distance / flyTime); //in feet/minute
        }
    }
}
