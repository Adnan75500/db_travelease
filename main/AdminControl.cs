namespace Admin
{
    public partial class AdminControl : UserControl
    {
        public AdminControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        private void btnApproveUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User approved!");
        }

        private void btnRejectUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User rejected!");
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Category added!");
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Category deleted!");
        }

        private void btnDeleteReview_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Review deleted!");
        }

    }
}
