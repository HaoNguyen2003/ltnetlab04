using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinhDatVeMayBay.Model
{

    public class Customer
    {
        public string CustomerID {  get; set; }
        public string CustomerName {  get; set; }
        public DateTime Birthday {  get; set; }
        public string PassPortNbr {  get; set; }
        public string Nationality {  get; set; }
        public Image Avatar {  get; set; }
        public Customer() {
            this.CustomerID = "Customer Application";
        }
        public Customer(string customerID, string customerName, DateTime birthday, string passPortNbr, string nationality, Image avatar)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            Birthday = birthday;
            PassPortNbr = passPortNbr;
            Nationality = nationality;
            Avatar = avatar;
        }

    }
}
