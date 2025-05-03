namespace Hotel_Service_Provider
{
    partial class HotelControl
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControlProvider;
        private TabPage tabServiceIntegration, tabServiceListing, tabBookingManagement, tabPerformanceReports;

        private DataGridView dgvServiceRequests;
        private Button btnAcceptRequest, btnRejectRequest;

        private DataGridView dgvServiceList;
        private Button btnAddService, btnDeleteService;

        private DataGridView dgvBookings;
        private Button btnConfirmBooking, btnUpdateAvailability;

        private DataGridView dgvPerformance;
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
            this.tabControlProvider = new TabControl();
            this.tabServiceIntegration = new TabPage("Service Requests");
            this.tabServiceListing = new TabPage("My Services");
            this.tabBookingManagement = new TabPage("Bookings");
            this.tabPerformanceReports = new TabPage("Performance");

            this.tabControlProvider.Dock = DockStyle.Fill;
            this.tabControlProvider.Controls.Add(this.tabServiceIntegration);
            this.tabControlProvider.Controls.Add(this.tabServiceListing);
            this.tabControlProvider.Controls.Add(this.tabBookingManagement);
            this.tabControlProvider.Controls.Add(this.tabPerformanceReports);
            this.Controls.Add(this.tabControlProvider);

            // Service Requests Tab
            dgvServiceRequests = new DataGridView { Dock = DockStyle.Top, Height = 250 };
            btnAcceptRequest = new Button { Text = "Accept", Location = new Point(10, 260), Size = new Size(100, 30) };
            btnRejectRequest = new Button { Text = "Reject", Location = new Point(100, 260), Size = new Size(100, 30) };
            btnAcceptRequest.Click += new EventHandler(this.btnAcceptRequest_Click);
            btnRejectRequest.Click += new EventHandler(this.btnRejectRequest_Click);

            tabServiceIntegration.Controls.AddRange(new Control[] {
                dgvServiceRequests, btnAcceptRequest, btnRejectRequest
            });

            // My Services Tab
            dgvServiceList = new DataGridView { Dock = DockStyle.Top, Height = 250 };
            btnAddService = new Button { Text = "Add New", Location = new Point(10, 260), Size = new Size(100, 30) };
            btnDeleteService = new Button { Text = "Delete Selected", Location = new Point(120, 260), Size = new Size(100, 30) };
            btnAddService.Click += new EventHandler(this.btnAddService_Click);
            btnDeleteService.Click += new EventHandler(this.btnDeleteService_Click);

            tabServiceListing.Controls.AddRange(new Control[] {
                dgvServiceList, btnAddService, btnDeleteService
            });

            // Booking Management Tab
            dgvBookings = new DataGridView { Dock = DockStyle.Top, Height = 250 };
            btnConfirmBooking = new Button { Text = "Confirm Booking", Location = new Point(10, 260), Size = new Size(100, 30) };
            btnUpdateAvailability = new Button { Text = "Update Availability", Location = new Point(150, 260), Size = new Size(100, 30) };
            btnConfirmBooking.Click += new EventHandler(this.btnConfirmBooking_Click);
            btnUpdateAvailability.Click += new EventHandler(this.btnUpdateAvailability_Click);

            tabBookingManagement.Controls.AddRange(new Control[] {
                dgvBookings, btnConfirmBooking, btnUpdateAvailability
            });

            // Performance Reports Tab
            dgvPerformance = new DataGridView { Dock = DockStyle.Fill };
            tabPerformanceReports.Controls.Add(dgvPerformance);
        }

        #endregion
    }
}
