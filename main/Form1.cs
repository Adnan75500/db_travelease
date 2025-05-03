using main;
using System;
using System.Windows.Forms;
using Hotel_Service_Provider;
using Admin;
using tour_traveler;
using WinFormsApp1;

namespace main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var homeControl = new Home.Home();
            homeControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(homeControl);
        }

        private void SidebarButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            UserControl controlToLoad = null;


            if (sender == homebutton)
                controlToLoad = new Home.Home();
            else if (sender == btnAdmin)
                controlToLoad = new Admin.AdminControl();
            else if (sender == btnHotel)
                controlToLoad = new Hotel_Service_Provider.HotelControl();
            else if (sender == btnTour)
                controlToLoad = new TourOperatorControl();
            else if (sender == btnTraveler)
                controlToLoad = new TravelerControl();

            if (controlToLoad != null)
            {
                controlToLoad.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(controlToLoad);
            }
        }
    }
}
