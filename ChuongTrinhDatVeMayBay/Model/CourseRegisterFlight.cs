using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinhDatVeMayBay.Model
{
    public class CourseRegisterFlight
    {
        public string CustomerID {  get; set; }
        public List<Flight> flights = new List<Flight>();
        public CourseRegisterFlight()
        {
            this.CustomerID = "Customer Application";
            flights = new List<Flight>();
        }
        public CourseRegisterFlight(string customerID)
        {
            CustomerID = customerID;
            this.flights = new List<Flight>();
        }
        public CourseRegisterFlight(string customerID,List<Flight>flights)
        {
            CustomerID = customerID;
            this.flights = flights;
        }
        public void addFlightByID(Flight fl)
        {
            this.flights.Add(fl);
        }
        public string returnallFlight()
        {
            return this.flights.ToString();
        }
    }
}
