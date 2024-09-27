using toursandtravels;

namespace toursandtravelswin

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TravelCompany travelCompany = null;
            if (listBox1.SelectedIndex == 0) // Akbar Travels
            {
                travelCompany = new AkbarTravels();
            }
            else if (listBox1.SelectedIndex == 1) // MakeMyTrip
            {
                travelCompany = new MakeMyTrip();
            }

            if (travelCompany != null)
            {
                double perDayCost = double.Parse(txtPerDayCost.Text);
                travelCompany.SetCustomerName(txtCustomerName.Text);
                travelCompany.SetNoOfDays(int.Parse(txtNoOfDays.Text));
                travelCompany.SetDestination(txtDestination.Text);

                travelCompany.CalculateCost(perDayCost);

                lblPackageDetails.Text = $"Destination: {travelCompany.Destination}, No. of Days: {travelCompany.NoOfDays}, Total Cost: {travelCompany.GetTotalAmount()}";

                if (radioButtonYes.Checked)
                {
                    int extraDays = int.Parse(txtExtraDays.Text);
                    bool hotel = false;
                    bool flight = false;

                    if (listBox1.SelectedIndex == 1) // MakeMyTrip
                    {
                        panel1.Visible = true;
                        panel2.Visible = true;
                        if (radioButtonBookHotel.Checked)
                        {
                            ((MakeMyTrip)travelCompany).BookHotel(txtHotelName.Text, txtRoomType.Text, double.Parse(txtRoomCost.Text));
                            hotel = true;

                        }
                        if (radioButtonBookFlight.Checked)
                        {
                            ((MakeMyTrip)travelCompany).BookFlight(txtFlightName.Text, double.Parse(txtFlightCost.Text));
                            flight = true;
                        }
                    }

                    travelCompany.CustomizePackage(extraDays, hotel, flight);
                }

             
                lblUpdatedPackageDetails.Text = $"Updated Destination: {travelCompany.Destination}, No. of Days: {travelCompany.NoOfDays}, Total Cost: {travelCompany.GetTotalAmount()}";

                
                
            }
        }

        
    }
}
