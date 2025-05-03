using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TravelerControl : UserControl
    {
        public TravelerControl()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search clicked!");
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profile saved!");
        }
    }
}
