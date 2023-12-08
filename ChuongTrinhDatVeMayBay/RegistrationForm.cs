using ChuongTrinhDatVeMayBay.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhDatVeMayBay
{
    public partial class RegistrationForm : Form
    {
        string startUpPath;
        string AvatarPath;
        Login LoginParen;
        public RegistrationForm()
        {
            InitializeComponent();
            startUpPath = Login.fromLogin.startupPath;
            this.LoginParen = Login.fromLogin;
            List<string> countries = new List<string> {
    "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia",
    "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin",
    "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi",
    "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia",
    "Comoros", "Congo", "Costa Rica", "Cote d'Ivoire", "Croatia", "Cuba", "Cyprus", "Czechia", "Denmark", "Djibouti",
    "Dominica", "Dominican Republic", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia",
    "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece",
    "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India",
    "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya",
    "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho",
    "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali",
    "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia",
    "Montenegro", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand",
    "Nicaragua", "Niger", "Nigeria", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea",
    "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis",
    "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia",
    "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia",
    "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan",
    "Tajikistan", "Tanzania", "Thailand", "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey",
    "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay",
    "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe"
};
            this.comboBoxNationalty.DataSource = countries;

    }
        private void Click_browse(object sender, EventArgs e)
        {
            this.openFileDialog1.Title = "Find To Image";
            this.openFileDialog1.Filter = "JPG file|*.jpg";
            this.openFileDialog1.InitialDirectory= startUpPath;
            if(this.openFileDialog1.ShowDialog()== DialogResult.OK) {
                this.AvatarPath = this.openFileDialog1.FileName;
                this.pictureBoxAvatar.BackgroundImage = Image.FromFile(AvatarPath);
                this.startUpPath = Path.GetDirectoryName(AvatarPath);
                this.pictureBoxAvatar.SizeMode=PictureBoxSizeMode.StretchImage;
            }
        }

        private void Click_buttonClose(object sender, EventArgs e)
        {
            this.Close();
            this.LoginParen.Show();
        }

        private void Click_buttonRemove(object sender, EventArgs e)
        {
            this.pictureBoxAvatar.BackgroundImage = Properties.Resources.NewMember;
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Click_ButtonCreate(object sender, EventArgs e)
        {
            if(this.textBoxCustomerID.Text.Trim().Length == 0) {
                MessageBox.Show("Please Input CustomerID","error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if (this.textBoxCustomerName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Input Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (this.textBoxPassPort.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Input Passport", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (this.textBoxUserName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Input User Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (this.textBoxPassWord.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Input PassWord", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (this.textBoxRePass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Input RePassWord", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!this.textBoxPassWord.Text.Equals(this.textBoxRePass.Text))
            {
                MessageBox.Show("Please Input RePassWord and PassWord not similar", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            User user = new User();
            Customer customer = new Customer();
            user.userName= this.textBoxUserName.Text;
            user.Password= this.textBoxPassWord.Text;
            user.CustomerID= this.textBoxCustomerID.Text;
            customer.CustomerName= this.textBoxCustomerName.Text;
            customer.CustomerID = this.textBoxCustomerID.Text;
            customer.Birthday=dateTimeBirthday.Value;
            customer.PassPortNbr = this.textBoxPassPort.Text;
            customer.Nationality = this.comboBoxNationalty.Text;
            customer.Avatar = this.pictureBoxAvatar.BackgroundImage;
            this.LoginParen.listUser.Add(user);
            this.LoginParen.listCustomer.Add(customer);
            MessageBox.Show("New Account is Create", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void Click_clear(object sender, EventArgs e)
        {
            this.textBoxCustomerID.Text = "";
            this.textBoxCustomerName.Text = "";
            this.textBoxPassPort.Text = "";
            this.textBoxPassWord.Text = "";
            this.textBoxRePass.Text = "";
            this.textBoxUserName.Text = "";
            this.dateTimeBirthday.Value = DateTime.Now;
            this.comboBoxNationalty.SelectedIndex = 0;
            this.pictureBoxAvatar.BackgroundImage = Properties.Resources.NewMember;
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            this.textBoxCustomerID.Focus();
        }
    }
}
