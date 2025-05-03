namespace tour_traveler
{
    partial class TourOperatorControl
    {
        private TabPage tabCreateTrip, tabManageTrips, tabBookings;

        private TextBox txtTripTitle, txtDestination, txtDescription;
        private DateTimePicker dtpStartDate, dtpEndDate;
        private NumericUpDown numPrice;
        private Button btnCreateTrip;

        private DataGridView dgvTrips;
        private Button btnEditTrip, btnDeleteTrip;

        private DataGridView dgvTripBookings;
        private TabControl tabControl;

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
        /// private TabControl tabControl;


        private void InitializeComponent()
        {
            this.tabControl = new TabControl();
            this.tabCreateTrip = new TabPage();
            this.tabManageTrips = new TabPage();
            this.tabBookings = new TabPage();

            this.txtTripTitle = new TextBox();
            this.txtDestination = new TextBox();
            this.txtDescription = new TextBox();
            this.dtpStartDate = new DateTimePicker();
            this.dtpEndDate = new DateTimePicker();
            this.numPrice = new NumericUpDown();
            this.btnCreateTrip = new Button();

            this.dgvTrips = new DataGridView();
            this.btnEditTrip = new Button();
            this.btnDeleteTrip = new Button();

            this.dgvTripBookings = new DataGridView();

            this.tabControl.Dock = DockStyle.Fill;
            this.tabControl.Controls.Add(this.tabCreateTrip);
            this.tabControl.Controls.Add(this.tabManageTrips);
            this.tabControl.Controls.Add(this.tabBookings);
            this.Controls.Add(this.tabControl);

            //Trip tab
            this.tabCreateTrip.Text = "Create Trip";
            int spacing = 40;
            Label[] labels = new Label[6];
            string[] labelNames = { "Trip Title", "Destination", "Start Date", "End Date", "Description", "Price" };
            Control[] inputs = { txtTripTitle, txtDestination, dtpStartDate, dtpEndDate, txtDescription, numPrice };

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Text = labelNames[i];
                labels[i].Location = new Point(20, 20 + i * spacing);
                labels[i].Width = 100;

                inputs[i].Location = new Point(130, 20 + i * spacing);
                inputs[i].Width = 250;

                this.tabCreateTrip.Controls.Add(labels[i]);
                this.tabCreateTrip.Controls.Add(inputs[i]);
            }

            this.btnCreateTrip.Location = new Point(130, 20 + 6 * spacing);
            this.btnCreateTrip.Size = new Size(100, 30);
            this.btnCreateTrip.Text = "Create Trip";
            this.btnCreateTrip.Click += new EventHandler(this.btnCreateTrip_Click);
            this.tabCreateTrip.Controls.Add(this.btnCreateTrip);

            //Manage trips tab
            this.tabManageTrips.Text = "Manage Trips";
            this.dgvTrips.Dock = DockStyle.Top;
            this.dgvTrips.Height = 250;

            this.btnEditTrip.Text = "Edit Selected";
            this.btnEditTrip.Location = new Point(20, 270);
            this.btnEditTrip.Size = new Size(100, 30);
            this.btnEditTrip.Click += new EventHandler(this.btnEditTrip_Click);

            this.btnDeleteTrip.Text = "Delete Selected";
            this.btnDeleteTrip.Location = new Point(140, 270);
            this.btnDeleteTrip.Size = new Size(100, 30);
            this.btnDeleteTrip.Click += new EventHandler(this.btnDeleteTrip_Click);

            this.tabManageTrips.Controls.Add(this.dgvTrips);
            this.tabManageTrips.Controls.Add(this.btnEditTrip);
            this.tabManageTrips.Controls.Add(this.btnDeleteTrip);

            //Bookings Tab
            this.tabBookings.Text = "Bookings";
            this.dgvTripBookings.Dock = DockStyle.Fill;
            this.tabBookings.Controls.Add(this.dgvTripBookings);

        }

        #endregion
    }
}
