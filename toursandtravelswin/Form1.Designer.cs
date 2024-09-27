namespace toursandtravelswin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCustomerName = new TextBox();
            label1 = new Label();
            txtNoOfDays = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            label3 = new Label();
            radioButtonYes = new RadioButton();
            radioButton2 = new RadioButton();
            lblPackageDetails = new Label();
            txtPerDayCost = new TextBox();
            label4 = new Label();
            txtDestination = new TextBox();
            label5 = new Label();
            txtExtraDays = new TextBox();
            label6 = new Label();
            radioButtonBookHotel = new RadioButton();
            lblUpdatedPackageDetails = new Label();
            radioButtonBookFlight = new RadioButton();
            label7 = new Label();
            txtRoomCost = new TextBox();
            txtRoomType = new TextBox();
            txtHotelName = new TextBox();
            txtFlightName = new TextBox();
            txtFlightCost = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(89, 67);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(100, 23);
            txtCustomerName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 70);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // txtNoOfDays
            // 
            txtNoOfDays.Location = new Point(89, 109);
            txtNoOfDays.Name = "txtNoOfDays";
            txtNoOfDays.Size = new Size(100, 23);
            txtNoOfDays.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 112);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 3;
            label2.Text = "No. Of Days";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ghar", "Goa", "Manali", "Pune" });
            comboBox1.Location = new Point(2, 600);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "MakeMyTrip", "AkbarTravels" });
            listBox1.Location = new Point(446, 74);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(131, 19);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(446, 117);
            label3.Name = "label3";
            label3.Size = new Size(181, 15);
            label3.TabIndex = 6;
            label3.Text = "Do you want  a customized plan?";
            // 
            // radioButtonYes
            // 
            radioButtonYes.AutoSize = true;
            radioButtonYes.Location = new Point(446, 158);
            radioButtonYes.Name = "radioButtonYes";
            radioButtonYes.Size = new Size(42, 19);
            radioButtonYes.TabIndex = 7;
            radioButtonYes.TabStop = true;
            radioButtonYes.Text = "Yes";
            radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(536, 158);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(41, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "No";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // lblPackageDetails
            // 
            lblPackageDetails.AutoSize = true;
            lblPackageDetails.Location = new Point(49, 388);
            lblPackageDetails.Name = "lblPackageDetails";
            lblPackageDetails.Size = new Size(88, 15);
            lblPackageDetails.TabIndex = 9;
            lblPackageDetails.Text = "Package details";
            // 
            // txtPerDayCost
            // 
            txtPerDayCost.Location = new Point(294, 112);
            txtPerDayCost.Name = "txtPerDayCost";
            txtPerDayCost.Size = new Size(70, 23);
            txtPerDayCost.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.System;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(250, 117);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 11;
            label4.Text = "Per day";
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(294, 70);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(100, 23);
            txtDestination.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 74);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 13;
            label5.Text = "Destination";
            // 
            // txtExtraDays
            // 
            txtExtraDays.Location = new Point(446, 220);
            txtExtraDays.Name = "txtExtraDays";
            txtExtraDays.Size = new Size(120, 23);
            txtExtraDays.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 9);
            label6.Name = "label6";
            label6.Size = new Size(118, 15);
            label6.TabIndex = 15;
            label6.Text = "Do you want a hotel?";
            // 
            // radioButtonBookHotel
            // 
            radioButtonBookHotel.AutoSize = true;
            radioButtonBookHotel.Location = new Point(59, 40);
            radioButtonBookHotel.Name = "radioButtonBookHotel";
            radioButtonBookHotel.Size = new Size(42, 19);
            radioButtonBookHotel.TabIndex = 16;
            radioButtonBookHotel.TabStop = true;
            radioButtonBookHotel.Text = "Yes";
            radioButtonBookHotel.UseVisualStyleBackColor = true;
            // 
            // lblUpdatedPackageDetails
            // 
            lblUpdatedPackageDetails.AutoSize = true;
            lblUpdatedPackageDetails.Location = new Point(50, 458);
            lblUpdatedPackageDetails.Name = "lblUpdatedPackageDetails";
            lblUpdatedPackageDetails.Size = new Size(87, 15);
            lblUpdatedPackageDetails.TabIndex = 17;
            lblUpdatedPackageDetails.Text = "Updates details";
            // 
            // radioButtonBookFlight
            // 
            radioButtonBookFlight.AutoSize = true;
            radioButtonBookFlight.Location = new Point(40, 42);
            radioButtonBookFlight.Name = "radioButtonBookFlight";
            radioButtonBookFlight.Size = new Size(42, 19);
            radioButtonBookFlight.TabIndex = 18;
            radioButtonBookFlight.TabStop = true;
            radioButtonBookFlight.Text = "Yes";
            radioButtonBookFlight.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 11);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 19;
            label7.Text = "Do you want a flight?";
            // 
            // txtRoomCost
            // 
            txtRoomCost.Location = new Point(405, 40);
            txtRoomCost.Name = "txtRoomCost";
            txtRoomCost.Size = new Size(100, 23);
            txtRoomCost.TabIndex = 20;
            txtRoomCost.Text = "Room cost";
            // 
            // txtRoomType
            // 
            txtRoomType.Location = new Point(268, 40);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.Size = new Size(100, 23);
            txtRoomType.TabIndex = 21;
            txtRoomType.Text = "Room type";
            // 
            // txtHotelName
            // 
            txtHotelName.Location = new Point(132, 40);
            txtHotelName.Name = "txtHotelName";
            txtHotelName.Size = new Size(100, 23);
            txtHotelName.TabIndex = 22;
            txtHotelName.Text = "Hotel Name";
            // 
            // txtFlightName
            // 
            txtFlightName.Location = new Point(249, 38);
            txtFlightName.Name = "txtFlightName";
            txtFlightName.Size = new Size(100, 23);
            txtFlightName.TabIndex = 23;
            // 
            // txtFlightCost
            // 
            txtFlightCost.Location = new Point(443, 35);
            txtFlightCost.Name = "txtFlightCost";
            txtFlightCost.Size = new Size(100, 23);
            txtFlightCost.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 25;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(375, 41);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 26;
            label9.Text = "Flight cost";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(143, 38);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 27;
            label10.Text = "Flight name";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(radioButtonBookHotel);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtHotelName);
            panel1.Controls.Add(txtRoomType);
            panel1.Controls.Add(txtRoomCost);
            panel1.Location = new Point(375, 266);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 137);
            panel1.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtFlightCost);
            panel2.Controls.Add(txtFlightName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(radioButtonBookFlight);
            panel2.Location = new Point(19, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(575, 63);
            panel2.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 626);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(lblUpdatedPackageDetails);
            Controls.Add(txtExtraDays);
            Controls.Add(label5);
            Controls.Add(txtDestination);
            Controls.Add(label4);
            Controls.Add(txtPerDayCost);
            Controls.Add(lblPackageDetails);
            Controls.Add(radioButton2);
            Controls.Add(radioButtonYes);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(txtNoOfDays);
            Controls.Add(label1);
            Controls.Add(txtCustomerName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerName;
        private Label label1;
        private TextBox txtNoOfDays;
        private Label label2;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Label label3;
        private RadioButton radioButtonYes;
        private RadioButton radioButton2;
        private Label lblPackageDetails;
        private TextBox txtPerDayCost;
        private Label label4;
        private TextBox txtDestination;
        private Label label5;
        private TextBox txtExtraDays;
        private Label label6;
        private RadioButton radioButtonBookHotel;
        private Label lblUpdatedPackageDetails;
        private RadioButton radioButtonBookFlight;
        private Label label7;
        private TextBox txtRoomCost;
        private TextBox txtRoomType;
        private TextBox txtHotelName;
        private TextBox txtFlightName;
        private TextBox txtFlightCost;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel1;
        private Panel panel2;
    }
}
