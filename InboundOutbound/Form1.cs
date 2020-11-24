using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace InboundOutbound
{
    public partial class InboundsOutboundsList : Form
    {
        public InboundsOutboundsList()
        {
            InitializeComponent();
        }       

        private void button1_Click(object sender, EventArgs e)
        {            
            if (textBoxAirport.TextLength == 4)
            {
                string Airport = textBoxAirport.Text;
                
                string AirportData;
                string[] ArrayAirportData = new string[5];

                using (StreamReader file = new StreamReader(GetCurrentApplicationPath() + "AirportData.txt"))
                {
                    while ((AirportData = file.ReadLine()) != null)
                    {
                        ArrayAirportData = AirportData.Split(',');
                        var A = ArrayAirportData[0];
                        if (A.Equals(Airport, StringComparison.InvariantCultureIgnoreCase)== true)
                        {
                            ReadingJson read = new ReadingJson();
                            read.VerwerkingGegevens(Airport, ArrayAirportData);
                            break;
                        }
                    }
                }
                this.Close();

            }
            else
            {                
                string error = "No Valid Airport";
                textBoxAirport.Text = error ;
            }
        }

        private static string GetCurrentApplicationPath()
        {
            // geef applicatiepad weer bij uitvoering
            string CurrentDirectory = Path.GetDirectoryName(
                   System.Reflection.Assembly.GetExecutingAssembly().Location);
            string AdaptedPath = CurrentDirectory.Replace(@"bin\Debug", "");
            return AdaptedPath;
        }

        private void InboundsOutboundsList_Load(object sender, EventArgs e)
        {

        }
    }
}
