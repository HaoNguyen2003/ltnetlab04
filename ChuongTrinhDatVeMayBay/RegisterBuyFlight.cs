using ChuongTrinhDatVeMayBay.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhDatVeMayBay
{
    public partial class RegisterBuyFlight : Form
    {
        Login loginParent;
        User userLogin;
        Customer customerLogin;

        public RegisterBuyFlight()
        {
            InitializeComponent();
            loginParent = Login.fromLogin;
            foreach(Flight obj in this.loginParent.listFlight){
                this.listBoxFlight.Items.Add(obj.FlightID+"*"+obj.start+"-"+obj.end +":"+obj.TimeDepart.ToString()+"-"+obj.TimeArrival.ToString());
            }
                
            
        }
        public void getLoginUser(User user)
        {
            this.userLogin = user;
            customerLogin=this.loginParent.listCustomer.Find(x=>(x.CustomerID==this.userLogin.CustomerID));
            this.labelCustomerID.Text = "Customer ID: "+customerLogin.CustomerID;
            this.labelCustomerName.Text= "Customer Name: "+customerLogin.CustomerName;
            foreach(CourseRegisterFlight obj in this.loginParent.listCourseRegisterFlight)
            {
                if (obj.CustomerID == this.userLogin.CustomerID)
                {
                    foreach (Flight objf in obj.flights)
                    {
                        this.dataGridView1.Rows.Add(objf.FlightID, objf.FlightType, objf.TimeDepart, objf.TimeArrival, objf.start, objf.end);
                    }
                }
                return;
            }
        }

      
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            foreach(object select in this.listBoxFlight.SelectedItems)
            {
                string id = (select.ToString()).Split('*')[0];
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    // Kiểm tra dòng không phải là dòng trống
                    if (!row.IsNewRow)
                    {
                        // Lấy giá trị từ ô đầu tiên của dòng và thêm vào List
                        string firstColumnValue = row.Cells[0].Value.ToString();
                        if (id.Equals(firstColumnValue))
                        {
                            MessageBox.Show("Each customer can only buy one flight ticket ID: You already have a flight Ticket ID: " + id+ " in the cart", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                foreach (CourseRegisterFlight obj in this.loginParent.listCourseRegisterFlight)
                {
                        if (obj.CustomerID == this.userLogin.CustomerID)
                        {
                            Flight objf = this.loginParent.listFlight.Find(x => x.FlightID.Equals(id));
                            obj.flights.Add(objf);
                            this.dataGridView1.Rows.Add(objf.FlightID, objf.FlightType, objf.TimeDepart, objf.TimeArrival, objf.start, objf.end);
                        }
                }
            }
        }

        private void Click_Logout(object sender, EventArgs e)
        {
            this.Hide();
            this.loginParent.resetLogin = true;
            this.loginParent.Show();
        }
        public string getTicket()
        {
            string kq="";
            foreach (CourseRegisterFlight obj in this.loginParent.listCourseRegisterFlight)
            {
                if (obj.CustomerID == this.userLogin.CustomerID)
                {
                    foreach (var flight in obj.flights)
                    {
                        kq += flight.ToString();
                    }
                }
            }
            return kq;

        }
        private void Click_Confirm(object sender, EventArgs e)
        {
            MessageBox.Show(getTicket(), "Ticket of Customer: "+customerLogin.CustomerName,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
