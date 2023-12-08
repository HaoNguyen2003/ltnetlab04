namespace ChuongTrinhDatVeMayBay
{
    partial class RegisterBuyFlight
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
            this.listBoxFlight = new System.Windows.Forms.ListBox();
            this.listFlight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnFlightID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFlightType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTgStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTgEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiaDiemXuatPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiadiemToiNoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFlight
            // 
            this.listBoxFlight.FormattingEnabled = true;
            this.listBoxFlight.ItemHeight = 20;
            this.listBoxFlight.Location = new System.Drawing.Point(86, 78);
            this.listBoxFlight.Name = "listBoxFlight";
            this.listBoxFlight.Size = new System.Drawing.Size(933, 104);
            this.listBoxFlight.TabIndex = 0;
            // 
            // listFlight
            // 
            this.listFlight.AutoSize = true;
            this.listFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFlight.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.listFlight.Location = new System.Drawing.Point(81, 49);
            this.listFlight.Name = "listFlight";
            this.listFlight.Size = new System.Drawing.Size(261, 26);
            this.listFlight.TabIndex = 2;
            this.listFlight.Text = "Danh sách Chuyến Bay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(81, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh Sách Chuyến Bay Đã Đăng Kí";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogout.Image = global::ChuongTrinhDatVeMayBay.Properties.Resources.Log_Out_Icon_;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(870, 397);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(149, 50);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "&Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.Click_Logout);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConfirm.Image = global::ChuongTrinhDatVeMayBay.Properties.Resources.Confirm;
            this.buttonConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfirm.Location = new System.Drawing.Point(677, 397);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(149, 50);
            this.buttonConfirm.TabIndex = 5;
            this.buttonConfirm.Text = "&Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.Click_Confirm);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Image = global::ChuongTrinhDatVeMayBay.Properties.Resources.Add;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(86, 397);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(149, 50);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFlightID,
            this.ColumnFlightType,
            this.ColumnTgStart,
            this.ColumnTgEnd,
            this.ColumnDiaDiemXuatPhat,
            this.ColumnDiadiemToiNoi});
            this.dataGridView1.Location = new System.Drawing.Point(86, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(933, 177);
            this.dataGridView1.TabIndex = 7;
            // 
            // ColumnFlightID
            // 
            this.ColumnFlightID.HeaderText = "Mã Chuyến Bay";
            this.ColumnFlightID.MinimumWidth = 8;
            this.ColumnFlightID.Name = "ColumnFlightID";
            this.ColumnFlightID.Width = 150;
            // 
            // ColumnFlightType
            // 
            this.ColumnFlightType.HeaderText = "Hãng";
            this.ColumnFlightType.MinimumWidth = 8;
            this.ColumnFlightType.Name = "ColumnFlightType";
            this.ColumnFlightType.Width = 150;
            // 
            // ColumnTgStart
            // 
            this.ColumnTgStart.HeaderText = "Khởi Hành";
            this.ColumnTgStart.MinimumWidth = 8;
            this.ColumnTgStart.Name = "ColumnTgStart";
            this.ColumnTgStart.Width = 150;
            // 
            // ColumnTgEnd
            // 
            this.ColumnTgEnd.HeaderText = "Kết Thúc";
            this.ColumnTgEnd.MinimumWidth = 8;
            this.ColumnTgEnd.Name = "ColumnTgEnd";
            this.ColumnTgEnd.Width = 150;
            // 
            // ColumnDiaDiemXuatPhat
            // 
            this.ColumnDiaDiemXuatPhat.HeaderText = "Xuất Phát";
            this.ColumnDiaDiemXuatPhat.MinimumWidth = 8;
            this.ColumnDiaDiemXuatPhat.Name = "ColumnDiaDiemXuatPhat";
            this.ColumnDiaDiemXuatPhat.Width = 150;
            // 
            // ColumnDiadiemToiNoi
            // 
            this.ColumnDiadiemToiNoi.HeaderText = "Tới Nơi";
            this.ColumnDiadiemToiNoi.MinimumWidth = 8;
            this.ColumnDiadiemToiNoi.Name = "ColumnDiadiemToiNoi";
            this.ColumnDiadiemToiNoi.Width = 150;
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerID.Location = new System.Drawing.Point(82, 9);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(115, 20);
            this.labelCustomerID.TabIndex = 8;
            this.labelCustomerID.Text = "Customer ID:";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.Location = new System.Drawing.Point(82, 29);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(142, 20);
            this.labelCustomerName.TabIndex = 9;
            this.labelCustomerName.Text = "Customer Name:";
            // 
            // RegisterBuyFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 450);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.labelCustomerID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listFlight);
            this.Controls.Add(this.listBoxFlight);
            this.Name = "RegisterBuyFlight";
            this.Text = "RegisterBuyFlight";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFlight;
        private System.Windows.Forms.Label listFlight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFlightID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFlightType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTgStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTgEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiaDiemXuatPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiadiemToiNoi;
    }
}