using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InboundOutbound
{
    class CalculateTimeDistance
    {
        public void CalculatePlannedTime()
        {

        }
        public Queue<double> CalculateRadian(List<double> Coordinates)
        {
            Queue<double> RadianList = new Queue<double>();
            double Radian = new double();

            foreach(double coordinate in Coordinates)
            {
                Radian = (coordinate / 180) * Math.PI;
                RadianList.Enqueue(Radian);
            }

            return RadianList;
        }

        public double CalculateDistance(Queue<double> Radian)
        { //distance between 2 points: cos(c) = cos(l_2 - l_1) * cos(b_2) * cos(b_1) + sin(b_2) * sin(b_1)  // x = c * r_a         // l = longitude and b is latitude
            double DistanceCalc = 0;
            double Distance = 0;
            double Latitude = Radian.Dequeue();
            double Longitude = Radian.Dequeue();
            double AirportLatitude = Radian.Dequeue();
            double AirportLongitude = Radian.Dequeue();


            DistanceCalc = Math.Round(Math.Cos(Longitude - AirportLongitude) * Math.Cos(Latitude) * Math.Cos(AirportLatitude) + Math.Sin(Latitude) * Math.Sin(AirportLatitude), 5);
            Distance = Math.Round(Math.Acos(DistanceCalc)  * 3440.06479 ,3); //radius earth            

            return Distance;
        }

        

        public decimal CalculateActualTime(decimal Speed, decimal Distance)
        {
            decimal ActualTime = Distance / Speed;

            return ActualTime;
        }


    }
}
