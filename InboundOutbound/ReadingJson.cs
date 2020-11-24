using System;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace InboundOutbound
{
    

    class ReadingJson
    {
        //taskkill /im InboundOutbound.exe /f     
        private string _Airport;

        public void VerwerkingGegevens(string Airport, string[] AirportData)
        {
            WebClient client = new WebClient();
            string json = client.DownloadString("http://cluster.data.vatsim.net/vatsim-data.json");
            var JData = JsonConvert.DeserializeObject<GeneratingJson>(json);
            _Airport = Airport;
            //calculating bounds (only for northeastern part of the world)
            double Number = 0.05;
            string LatitudeString = AirportData[1] + "," + AirportData[2];
            string LongitudeString = AirportData[3] + "," + AirportData[4];

            double LatitudeAirp = Convert.ToDouble(LatitudeString);
            double LongitudeAirp = Convert.ToDouble(LongitudeString);

            double NorthBound = LatitudeAirp + Number;
            double SouthBound = LatitudeAirp - Number;
            double EastBound = LongitudeAirp + Number;
            double WestBound = LongitudeAirp - Number;

            
            List<string> Departures = new List<string>();
            List<string> Arrivals = new List<string>();

            CalculateTimeDistance ctd = new CalculateTimeDistance();


            //loading in flights that spawned in and filled
            foreach (var Connected in JData.Clients)
            {
                double Latitude = Connected.Latitude;
                double Longitude = Connected.Longitude;

                if (Connected.Departure?.Equals(Airport) == true)
                {
                    //if the aircraft is 3000ft or higher and is out of the range of the airport, the flight gets filtered out
                    if ((Convert.ToInt32(Connected.CurrentAltitude) < 3000) && ((Latitude <= NorthBound) && (Latitude >= SouthBound) && (Longitude <= EastBound) && (Longitude >= WestBound)))
                    {
                        //following data: Callsign, Depa airport, estimated depa time, altitude, speed, dest airport, estimated arrival time, aircaft type
                        string EnrouteTimeZ = Connected.EnrouteTimeHrs + Connected.EnrouteTimeMin;
                        
                        int ArrivalTime = Convert.ToInt32(Connected.DepaTimePlanned) + Convert.ToInt32(EnrouteTimeZ);

                        Departures.Add(Connected.Callsign + ", " + Connected.AircraftType + ", " + Connected.Departure + ", " + Connected.DepaTimePlanned + ", " + Connected.CurrentAltitude + ", " +
                            Connected.Groundspeed + ", " + Connected.Destination);                        

                        
                   }
                }
                else if (Connected.Destination?.Equals(Airport) == true)
                {
                    //following data: Callsign, Depa airport, estimated depa time, altitude, speed, distance, dest airport, estimated arrival time, calculated arrival time, aircraft type
                    string EnrouteTimeZ = Connected.EnrouteTimeHrs + Connected.EnrouteTimeMin;
                    int ArrivalTime = Convert.ToInt32(Connected.DepaTimePlanned) + Convert.ToInt32(EnrouteTimeZ);

                    List<double> Coordinates = new List<double>();
                    Coordinates.Add(Latitude);
                    Coordinates.Add(Longitude);
                    Coordinates.Add(LatitudeAirp);
                    Coordinates.Add(LongitudeAirp);

                    Queue<double> Radian = ctd.CalculateRadian(Coordinates);
                    double Distance = ctd.CalculateDistance(Radian);
                    decimal CalculatedTime = new decimal();
                    if(Connected.Groundspeed > 50)
                    {
                        CalculatedTime = ctd.CalculateActualTime(Connected.Groundspeed, Convert.ToDecimal(Distance));
                    }
                    else
                    {
                        CalculatedTime = ArrivalTime;
                    }


                    Arrivals.Add(Connected.Callsign + ", " + Connected.AircraftType + "," + Connected.Departure + ", " + Connected.DepaTimePlanned + ", " + Connected.CurrentAltitude + ", " +
                            Connected.Groundspeed + "," + Distance + ", " + Connected.Destination + ", " + Convert.ToString(ArrivalTime) + "," + CalculatedTime );


                }                
            }

            //TO DO: loading in atc online list for selected airport


            //sending data to table
            

            DateTime ZuluTime = Convert.ToDateTime(JData.General.UpdateTime);


            Display dpl = new Display(Departures, Arrivals, ZuluTime);
            dpl.Show();                  
       
        }        
    }
}
