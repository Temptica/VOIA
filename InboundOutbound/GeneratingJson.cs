using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace InboundOutbound
{
    class GeneratingJson
    {
        public GeneralInfo General { get; set; }
        public List<Client> Clients { get; set; }
        public List<Server> Servers { get; set; }
        public List<Client> Prefiles { get; set; }

        public class GeneralInfo
        {            
            [JsonProperty("update_timestamp")]
            public string UpdateTime { get; set; }
        }

        public class Client
        {
            [JsonProperty("callsign")]
            public string Callsign { get; set; }
            [JsonProperty("latitude")]
            public double Latitude { get; set; }
            [JsonProperty("longitude")]
            public double Longitude { get; set; }
            [JsonProperty("altitude")]
            public int CurrentAltitude { get; set; }
            [JsonProperty("groundspeed")]
            public int Groundspeed { get; set; }
            [JsonProperty("planned_aircraft")]
            public string AircraftType { get; set; }
            [JsonProperty("planned_depairport")]
            public string Departure { get; set; }
            [JsonProperty("planned_destairport")]
            public string Destination { get; set; }
            [JsonProperty("planned_deptime")]
            public string DepaTimePlanned { get; set; }
            [JsonProperty("planned_hrsenroute")]
            public string EnrouteTimeHrs { get; set; }
            [JsonProperty("planned_minenroute")]
            public string EnrouteTimeMin { get; set; }

        }

        public class Server
        {
            public string Ident { get; set; }
            public string IP { get; set; }
            public string Location { get; set; }
            public string Name { get; set; }
            public int Allowed { get; set; }

        }        
    }
}


    
