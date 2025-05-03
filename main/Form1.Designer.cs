using System;
using System.Drawing;
using System.Windows.Forms;


namespace main
{
    public partial class Form1 : Form
    {
        private Panel sidebar;
        private Panel mainPanel;
        private Button btnAdmin, btnHotel, btnTour, btnTraveler, homebutton;

        private void InitializeComponent()
        {
            this.Text = "TravelEase Control Panel";
            this.Size = new Size(1000, 700);

            sidebar = new Panel
            {
                Dock = DockStyle.Left,
                Width = 150,
                BackColor = Color.LightGray
            };

            mainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle 
            };

            homebutton = new Button { Text = "Home", Width = 130, Height = 40, Top = 20, Left = 10 };
            btnAdmin = new Button { Text = "Admin", Width = 130, Height = 40, Top = 70, Left = 10 };
            btnHotel = new Button { Text = "Hotel", Width = 130, Height = 40, Top = 120, Left = 10 };
            btnTour = new Button { Text = "Tour", Width = 130, Height = 40, Top = 170, Left = 10 };
            btnTraveler = new Button { Text = "Traveler", Width = 130, Height = 40, Top = 220, Left = 10 };

            homebutton.Click += SidebarButton_Click;
            btnAdmin.Click += SidebarButton_Click;
            btnHotel.Click += SidebarButton_Click;
            btnTour.Click += SidebarButton_Click;
            btnTraveler.Click += SidebarButton_Click;

            sidebar.Controls.AddRange(new Control[] { homebutton, btnAdmin, btnHotel, btnTour, btnTraveler });

            this.Controls.Add(mainPanel);
            this.Controls.Add(sidebar);
        }
    }
}