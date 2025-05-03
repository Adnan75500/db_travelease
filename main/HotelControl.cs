namespace Hotel_Service_Provider
{
    public partial class HotelControl : UserControl
    {
        public HotelControl()
        {
            InitializeComponent();
        }
        private void btnAcceptRequest_Click(object sender, EventArgs e)
        {
            if (dgvServiceRequests.CurrentRow != null)
            {
                int requestId = Convert.ToInt32(dgvServiceRequests.CurrentRow.Cells["RequestID"].Value);
                // TODO: Update DB to set request status = 'Accepted'
                MessageBox.Show($"Service request {requestId} accepted.");
            }
        }

        private void btnRejectRequest_Click(object sender, EventArgs e)
        {
            if (dgvServiceRequests.CurrentRow != null)
            {
                int requestId = Convert.ToInt32(dgvServiceRequests.CurrentRow.Cells["RequestID"].Value);
                // TODO
                MessageBox.Show($"Service request {requestId} rejected.");
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            // TODO: Open a form or popup to add a new service
            MessageBox.Show("Add service functionality coming soon!");
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (dgvServiceList.CurrentRow != null)
            {
                int serviceId = Convert.ToInt32(dgvServiceList.CurrentRow.Cells["ServiceID"].Value);
                //TODO
                MessageBox.Show($"Service ID {serviceId} deleted.");
            }
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookings.CurrentRow != null)
            {
                int bookingId = Convert.ToInt32(dgvBookings.CurrentRow.Cells["BookingID"].Value);
                //TODO
                MessageBox.Show($"Booking {bookingId} confirmed.");
            }
        }

        private void btnUpdateAvailability_Click(object sender, EventArgs e)
        {
            //TODO
            MessageBox.Show("Availability updated.");
        }

    }
}
