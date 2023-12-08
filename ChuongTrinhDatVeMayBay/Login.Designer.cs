namespace ChuongTrinhDatVeMayBay
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBoxLonginInformation = new System.Windows.Forms.GroupBox();
            this.linklabelRegisterAccount = new System.Windows.Forms.LinkLabel();
            this.textPassWord = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.LabelPassWord = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxLoginInformation = new System.Windows.Forms.PictureBox();
            this.groupBoxLonginInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLonginInformation
            // 
            this.groupBoxLonginInformation.Controls.Add(this.linklabelRegisterAccount);
            this.groupBoxLonginInformation.Controls.Add(this.buttonCancel);
            this.groupBoxLonginInformation.Controls.Add(this.buttonLogin);
            this.groupBoxLonginInformation.Controls.Add(this.textPassWord);
            this.groupBoxLonginInformation.Controls.Add(this.textBoxUser);
            this.groupBoxLonginInformation.Controls.Add(this.LabelPassWord);
            this.groupBoxLonginInformation.Controls.Add(this.labelUser);
            this.groupBoxLonginInformation.Controls.Add(this.pictureBoxLoginInformation);
            this.groupBoxLonginInformation.Location = new System.Drawing.Point(12, 25);
            this.groupBoxLonginInformation.Name = "groupBoxLonginInformation";
            this.groupBoxLonginInformation.Size = new System.Drawing.Size(776, 393);
            this.groupBoxLonginInformation.TabIndex = 0;
            this.groupBoxLonginInformation.TabStop = false;
            this.groupBoxLonginInformation.Text = "Login Information";
            // 
            // linklabelRegisterAccount
            // 
            this.linklabelRegisterAccount.AutoSize = true;
            this.linklabelRegisterAccount.Location = new System.Drawing.Point(74, 341);
            this.linklabelRegisterAccount.Name = "linklabelRegisterAccount";
            this.linklabelRegisterAccount.Size = new System.Drawing.Size(132, 20);
            this.linklabelRegisterAccount.TabIndex = 7;
            this.linklabelRegisterAccount.TabStop = true;
            this.linklabelRegisterAccount.Text = "Register Account";
            this.linklabelRegisterAccount.Click += new System.EventHandler(this.clickChuyenRegisterFrom);
            // 
            // textPassWord
            // 
            this.textPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassWord.Location = new System.Drawing.Point(392, 190);
            this.textPassWord.Name = "textPassWord";
            this.textPassWord.Size = new System.Drawing.Size(297, 35);
            this.textPassWord.TabIndex = 4;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(392, 86);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(297, 35);
            this.textBoxUser.TabIndex = 3;
            // 
            // LabelPassWord
            // 
            this.LabelPassWord.AutoSize = true;
            this.LabelPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassWord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelPassWord.Location = new System.Drawing.Point(398, 148);
            this.LabelPassWord.Name = "LabelPassWord";
            this.LabelPassWord.Size = new System.Drawing.Size(136, 29);
            this.LabelPassWord.TabIndex = 2;
            this.LabelPassWord.Text = "Pass Word:";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUser.Location = new System.Drawing.Point(387, 36);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(147, 29);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = " User Name:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Image = global::ChuongTrinhDatVeMayBay.Properties.Resources.Cancel;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(547, 260);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(142, 61);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.Cancel_click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogin.Image = global::ChuongTrinhDatVeMayBay.Properties.Resources.Login;
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.Location = new System.Drawing.Point(391, 260);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(142, 61);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "&Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.btn_LoginClick);
            // 
            // pictureBoxLoginInformation
            // 
            this.pictureBoxLoginInformation.Image = global::ChuongTrinhDatVeMayBay.Properties.Resources.login_ico;
            this.pictureBoxLoginInformation.InitialImage = null;
            this.pictureBoxLoginInformation.Location = new System.Drawing.Point(19, 36);
            this.pictureBoxLoginInformation.Name = "pictureBoxLoginInformation";
            this.pictureBoxLoginInformation.Size = new System.Drawing.Size(247, 302);
            this.pictureBoxLoginInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoginInformation.TabIndex = 0;
            this.pictureBoxLoginInformation.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxLonginInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login Form";
            this.VisibleChanged += new System.EventHandler(this.Login_VisibleChanged);
            this.groupBoxLonginInformation.ResumeLayout(false);
            this.groupBoxLonginInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLonginInformation;
        private System.Windows.Forms.PictureBox pictureBoxLoginInformation;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label LabelPassWord;
        private System.Windows.Forms.TextBox textPassWord;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.LinkLabel linklabelRegisterAccount;
    }
}

