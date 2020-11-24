using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace InboundOutbound
{
    public partial class Display : Form
    {
        public Display(List<string> Departures, List<string> Arrivals, DateTime ZuluTime)
        {
            InitializeComponent();
            FormClosed += Display_FormClosed;
            DepartureList(Departures, Arrivals, ZuluTime);
        }

        private void Display_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void DepartureList(List<string> Departures, List<string> Arrivals, DateTime ZuluTime)
        {

            //labelArrivalList.Text = "Test";

            listDepartures.View = View.Details;
            listViewArrivals.View = View.Details;

            //data to display: Callsign, Depa airport, estimated depa time, altitude, speed, dest airport, estimated arrival time
            listDepartures.Columns.Add("Callsign");
            listDepartures.Columns.Add("Type");
            listDepartures.Columns.Add("Departure");
            listDepartures.Columns.Add("ETD");
            listDepartures.Columns.Add("Height");
            listDepartures.Columns.Add("Groundspeed");
            listDepartures.Columns.Add("Destination");
            
            //following data: Callsign, Depa airport, estimated depa time, altitude, speed, distance, dest airport, calculated arrival time, aircraft type
            listViewArrivals.Columns.Add("Callsign");
            listViewArrivals.Columns.Add("Type");
            listViewArrivals.Columns.Add("Departure");
            listViewArrivals.Columns.Add("ETD");
            listViewArrivals.Columns.Add("Height");
            listViewArrivals.Columns.Add("Groundspeed");
            listViewArrivals.Columns.Add("Distance");
            listViewArrivals.Columns.Add("ETA");
            listViewArrivals.Columns.Add("Destination");


            labelZuluTime.Text = Convert.ToString(ZuluTime);

            string[] AircraftDepa = new string[6];
            string[] AircraftArra = new string[9];

            foreach (string departure in Departures)
            {
                AircraftDepa = departure.Split(',');
                
                
                listDepartures.Items.Add(new ListViewItem(new[] { AircraftDepa[0], AircraftDepa[1], AircraftDepa[2], AircraftDepa[3], AircraftDepa[4], AircraftDepa[5], AircraftDepa[6]}));
            }
            foreach (string arrival in Arrivals)
            {
                AircraftArra = arrival.Split(',');
                
                listViewArrivals.Items.Add(new ListViewItem(new[] { AircraftArra[0], AircraftArra[1], AircraftArra[2], AircraftArra[3], AircraftArra[4], AircraftArra[5], AircraftArra[6], AircraftArra[7], AircraftArra[8] }));                
            }            
        }

        private void ButtonRefrech_Click(object sender, EventArgs e)
        {
            
        }

        private void Display_Load(object sender, EventArgs e)
        {

        }

        private void labelDepartures_Click(object sender, EventArgs e)
        {

        }
    }
}
