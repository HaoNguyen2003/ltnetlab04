using ChuongTrinhDatVeMayBay.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhDatVeMayBay
{
    public partial class Login : Form
    {
        public static Login fromLogin;
        public List<Customer> listCustomer = new List<Customer>();
        public List<Flight>listFlight = new List<Flight>();
        public List<User> listUser = new List<User>();
        public List<CourseRegisterFlight>listCourseRegisterFlight=new List<CourseRegisterFlight>();
        public string startupPath;
        public bool resetLogin;
        public Login()
        {

            fromLogin = this;
            InitializeComponent();
            //trả về đường dẫnđên thư mục của ứng dụng đang làm viêc=Directory.GetCurrentDirectory()=debug;
            //trả về thư mục cha của thư mục=Directory.GetParent(); cha của debug là bin;
            //FullName lấy toàn bộ đường dẫn đó;
            startupPath = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            //thêm đối tượng cho list Customer
            listCustomer.Add(new Customer("ST001","NguyenVanA",DateTime.ParseExact("08/10/2003","dd/MM/yyyy",null),"123456789","Vietnam",Image.FromFile(startupPath+"\\Images\\Doraemon.jpg")));
            User userAdmin = new User("ST001","Admin","1234");
            listUser.Add(userAdmin);
            listFlight.Add(new Flight("F01",DateTime.Now.AddHours(3),DateTime.Now.AddHours(6),flighttype.VietJetAir,"TP.HCM","Hà Nội"));
            listFlight.Add(new Flight("F02", DateTime.Now.AddHours(5), DateTime.Now.AddHours(6), flighttype.VietnamAirlines,"TP.HCM","Đà Nẵng"));
            listFlight.Add(new Flight("F03", DateTime.Now.AddDays(3), DateTime.Now.AddDays(6), flighttype.BambooAirways,"Hà Nội","Japan"));
            listFlight.Add(new Flight("F04", DateTime.Now.AddHours(9), DateTime.Now.AddHours(12), flighttype.VietnamAirServicesCompany,"Đà Nẵng","Đà Lạt"));
            listFlight.Add(new Flight("F05", DateTime.Now.AddMinutes(30), DateTime.Now.AddMinutes(120), flighttype.PacificAirlines,"Côn Đảo","TP.HCM"));
            listFlight.Add(new Flight("F06", DateTime.Now.AddHours(5), DateTime.Now.AddHours(6), flighttype.VietnamAirlines, "TP.HCM", "Hà Nội"));
            resetLogin = true;
            List<Flight> list = new List<Flight>();
            list.Add(new Flight("F01", DateTime.Now.AddHours(3), DateTime.Now.AddHours(6), flighttype.VietJetAir, "TP.HCM", "Hà Nội"));
            list.Add(new Flight("F02", DateTime.Now.AddHours(5), DateTime.Now.AddHours(6), flighttype.VietnamAirlines, "TP.HCM", "Đà Nẵng"));
            list.Add(new Flight("F03", DateTime.Now.AddDays(3), DateTime.Now.AddDays(6), flighttype.BambooAirways, "Hà Nội", "Japan"));
            listCourseRegisterFlight.Add(new CourseRegisterFlight(userAdmin.CustomerID,list));
           
        }


        private void clickChuyenRegisterFrom(object sender, EventArgs e)
        {
            RegistrationForm f=new RegistrationForm();
            this.Hide();
            f.Show();
        }

        private void btn_LoginClick(object sender, EventArgs e)
        {
            if (this.textBoxUser.Text.Length == 0)
            {
                MessageBox.Show("Please Enter User Name","Input Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if (this.textPassWord.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Pass Word", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            User user = listUser.Find(x =>((x.userName.Equals(this.textBoxUser.Text)&&(x.Password.Equals(this.textPassWord.Text)))));
            if(user == null)
            {
                MessageBox.Show("User Name and PassWord is Wrong\n Please reinput or Register Account","User not Found",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.textBoxUser.Text = "";
                this.textPassWord.Text = "";
                this.textBoxUser.Focus();
            }
            else {
                RegisterBuyFlight obj = new RegisterBuyFlight();

                obj.getLoginUser(user);
                this.Hide();
                obj.Show();
            }
        }

        private void Cancel_click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            if(this.resetLogin==true)
            {
                this.textBoxUser.Text = "";
                this.textPassWord.Text = "";
            }
        }
    }
}
