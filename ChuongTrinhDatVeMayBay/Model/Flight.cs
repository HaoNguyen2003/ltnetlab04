using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinhDatVeMayBay.Model
{
    public enum flighttype
    {
        VietnamAirlines,
        VietJetAir,
        BambooAirways,
        VietnamAirServicesCompany,
        PacificAirlines,
    }
    public class Flight
    {
        public string FlightID {  get; set; }
        public DateTime TimeDepart {  get; set; }
        public DateTime TimeArrival {  get; set; }
        public flighttype FlightType {  get; set; }
        public string start {  get; set; }
        public string end { get; set; }
        public Flight() {
            this.FlightID = "Application";
        }
        public Flight(string flightID, DateTime timeDepart, DateTime timeArrival, flighttype flightType, string start, string end)
        {
            FlightID = flightID;
            TimeDepart = timeDepart;
            TimeArrival = timeArrival;
            FlightType = flightType;
            this.start = start;
            this.end = end;
        }
        public override string ToString()
        {
            return "\nFlightID: " + FlightID + ", TimeDepart: " + TimeDepart.ToString("yyyy-MM-dd HH:mm:ss")
            + ", TimeArrival: " + TimeArrival.ToString("yyyy-MM-dd HH:mm:ss") + ", FlightType: " + FlightType
            + ", Start: " + start + ", End: " + end + "\n"
            + "----------------------------------------------------------------------------------------------------------------------------------------------------------------";
        }
    }
}
