namespace WinFormsApp1
{
    partial class TravelerControl
    {
        private System.ComponentModel.IContainer components = null;

        //Controls
        private TabControl tabControl;
        private TabPage tabSearchTrips, tabMyBookings, tabProfile;
        private TextBox txtSearch, txtFirstName, txtLastName, txtEmail, txtPhone, txtPreferences;
        private ComboBox cmbCategory;
        private Button btnSearch, btnSaveProfile;
        private DataGridView dgvTrips, dgvBookings;

        private void InitializeComponent()
        {
            this.tabControl = new TabControl();
            this.tabSearchTrips = new TabPage();
            this.tabMyBookings = new TabPage();
            this.tabProfile = new TabPage();

            this.txtSearch = new TextBox();
            this.cmbCategory = new ComboBox();
            this.btnSearch = new Button();
            this.dgvTrips = new DataGridView();

            this.dgvBookings = new DataGridView();

            this.txtFirstName = new TextBox();
            this.txtLastName = new TextBox();
            this.txtEmail = new TextBox();
            this.txtPhone = new TextBox();
            this.txtPreferences = new TextBox();
            this.btnSaveProfile = new Button();

            this.tabControl.Controls.Add(this.tabSearchTrips);
            this.tabControl.Controls.Add(this.tabMyBookings);
            this.tabControl.Controls.Add(this.tabProfile);
            this.tabControl.Dock = DockStyle.Fill;
            this.Controls.Add(this.tabControl);

            //Search Tab
            this.tabSearchTrips.Text = "Search Trips";
            this.txtSearch.Location = new Point(20, 20);
            this.cmbCategory.Location = new Point(230, 20);
            this.btnSearch.Location = new Point(390, 18);
            this.btnSearch.Size = new Size(100, 30);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
            this.dgvTrips.Location = new Point(20, 60);
            this.dgvTrips.Size = new Size(740, 300);
            this.tabSearchTrips.Controls.AddRange(new Control[] { txtSearch, cmbCategory, btnSearch, dgvTrips });

            //Bookings Tab
            this.tabMyBookings.Text = "My Bookings";
            this.dgvBookings.Dock = DockStyle.Fill;
            this.tabMyBookings.Controls.Add(this.dgvBookings);

            //Profile Tab
            this.tabProfile.Text = "Profile";
            int spacing = 40;
            string[] labels = { "First Name", "Last Name", "Email", "Phone", "Preferences" };
            TextBox[] textBoxes = { txtFirstName, txtLastName, txtEmail, txtPhone, txtPreferences };
            for (int i = 0; i < labels.Length; i++)
            {
                Label lbl = new Label();
                lbl.Text = labels[i];
                lbl.Location = new Point(20, 20 + i * spacing);
                lbl.Width = 100;

                textBoxes[i].Location = new Point(130, 20 + i * spacing);
                textBoxes[i].Width = 250;

                this.tabProfile.Controls.Add(lbl);
                this.tabProfile.Controls.Add(textBoxes[i]);
            }
            this.btnSaveProfile.Location = new Point(130, 20 + labels.Length * spacing);
            this.btnSaveProfile.Size = new Size(100, 30);
            this.btnSaveProfile.Text = "Save";
            this.btnSaveProfile.Click += new EventHandler(this.btnSaveProfile_Click);
            this.tabProfile.Controls.Add(this.btnSaveProfile);

        }
    }
}
