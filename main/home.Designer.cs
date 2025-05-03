namespace Home
{
    partial class Home
    {
        private System.ComponentModel.IContainer components = null;
        private TabPage tabHome;
        private PictureBox pictureBoxHome;
        private TabControl tabControl;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new TabControl();
            this.tabHome = new TabPage("Home");
            this.pictureBoxHome = new PictureBox();

            // PictureBox setup
            this.pictureBoxHome.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBoxHome.Dock = DockStyle.Fill;

            try
            {
                this.pictureBoxHome.Image = Image.FromFile(@"C:\Users\delll\OneDrive\Desktop\db_fp\ui\Home\Home\homepage.png");
            }
            catch
            {
                MessageBox.Show("Image file not found. Please check the path.");
            }

            // Assemble tab
            this.tabHome.Controls.Add(this.pictureBoxHome);
            this.tabControl.Controls.Add(this.tabHome);

            // TabControl setup
            this.tabControl.Dock = DockStyle.Fill;
            this.Controls.Add(this.tabControl);
        }
    }
}
