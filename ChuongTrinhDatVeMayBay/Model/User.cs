using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinhDatVeMayBay.Model
{
    public class User
    {
        public string CustomerID {  get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
        public User() {
            this.userName = "User Application";
        }
        public User(string customerID, string userName, string password)
        {
            CustomerID = customerID;
            this.userName = userName;
            Password = password;
        }

    }
}
