namespace Admin
{
    partial class AdminControl
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private TabPage tabUserManagement, tabTourCategories, tabAnalytics, tabReviewModeration;
        private TabControl adminTabControl;

        private DataGridView dgvUsers, dgvOperators;
        private Button btnApproveUser, btnRejectUser;

        private DataGridView dgvCategories;
        private TextBox txtNewCategory;
        private Button btnAddCategory, btnDeleteCategory;

        private DataGridView dgvAnalytics;

        private DataGridView dgvReviews;
        private Button btnDeleteReview;

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
        private void InitializeComponent()
        {
            this.adminTabControl = new TabControl();
            this.tabUserManagement = new TabPage("User Management");
            this.tabTourCategories = new TabPage("Tour Categories");
            this.tabAnalytics = new TabPage("Analytics");
            this.tabReviewModeration = new TabPage("Review Moderation");

            this.adminTabControl.Dock = DockStyle.Fill;
            this.adminTabControl.Controls.Add(this.tabUserManagement);
            this.adminTabControl.Controls.Add(this.tabTourCategories);
            this.adminTabControl.Controls.Add(this.tabAnalytics);
            this.adminTabControl.Controls.Add(this.tabReviewModeration);
            this.Controls.Add(this.adminTabControl);

            // User Management
            this.dgvUsers = new DataGridView { Location = new Point(10, 10), Width = 400, Height = 200 };
            this.dgvOperators = new DataGridView { Location = new Point(10, 220), Width = 400, Height = 200 };
            this.btnApproveUser = new Button { Text = "Approve", Location = new Point(420, 50), Size = new Size(100,30) };
            this.btnRejectUser = new Button { Text = "Reject", Location = new Point(420, 100), Size = new Size(100, 30) };
            this.btnApproveUser.Click += new EventHandler(this.btnApproveUser_Click);
            this.btnRejectUser.Click += new EventHandler(this.btnRejectUser_Click);

            this.tabUserManagement.Controls.AddRange(new Control[] {
                dgvUsers, dgvOperators, btnApproveUser, btnRejectUser
            });

            // Tour Categories
            this.dgvCategories = new DataGridView { Location = new Point(10, 10), Width = 300, Height = 200 };
            this.txtNewCategory = new TextBox { Location = new Point(320, 10), Width = 200 };
            this.btnAddCategory = new Button { Text = "Add", Location = new Point(320, 50), Size = new Size(100, 30) };
            this.btnDeleteCategory = new Button { Text = "Delete", Location = new Point(320, 90), Size = new Size(100, 30) };
            this.btnAddCategory.Click += new EventHandler(this.btnAddCategory_Click);
            this.btnDeleteCategory.Click += new EventHandler(this.btnDeleteCategory_Click);

            this.tabTourCategories.Controls.AddRange(new Control[] {
                dgvCategories, txtNewCategory, btnAddCategory, btnDeleteCategory
            });

            // Analytics
            this.dgvAnalytics = new DataGridView { Dock = DockStyle.Fill };
            this.tabAnalytics.Controls.Add(this.dgvAnalytics);

            // Review Moderation
            this.dgvReviews = new DataGridView { Dock = DockStyle.Top, Height = 300 };
            this.btnDeleteReview = new Button { Text = "Delete Selected Review", Dock = DockStyle.Bottom, Size = new Size(100,80) };
            this.btnDeleteReview.Click += new EventHandler(this.btnDeleteReview_Click);
            this.tabReviewModeration.Controls.AddRange(new Control[] {
                dgvReviews, btnDeleteReview
            });
        }
            #endregion
        }
}
