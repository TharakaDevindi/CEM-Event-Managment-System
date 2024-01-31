namespace CEM_Event_Managment_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCEM = new System.Windows.Forms.Label();
            this.gradientPanel1 = new CEM_Event_Managment_System.GradientPanel();
            this.btnBookEvent = new System.Windows.Forms.Button();
            this.btnViewVenu = new System.Windows.Forms.Button();
            this.btnManageEvent = new System.Windows.Forms.Button();
            this.btnUserRegistration = new System.Windows.Forms.Button();
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.btnManageCustomer = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel2 = new CEM_Event_Managment_System.GradientPanel();
            this.crbtnEvent = new CEM_Event_Managment_System.CircularButton();
            this.crbtnNews = new CEM_Event_Managment_System.CircularButton();
            this.crbtnContactUs = new CEM_Event_Managment_System.CircularButton();
            this.crbtnAboutUs = new CEM_Event_Managment_System.CircularButton();
            this.crbtnHome = new CEM_Event_Managment_System.CircularButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 67);
            this.panel1.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Location = new System.Drawing.Point(768, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(25, 23);
            this.btnHome.TabIndex = 2;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Stencil Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(152, 19);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(569, 25);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "WELCOME TO COLOMBO EVENT MANAGEMENT SYSTEM...";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logo.Location = new System.Drawing.Point(8, 7);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(82, 50);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblCEM);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 42);
            this.panel2.TabIndex = 3;
            // 
            // lblCEM
            // 
            this.lblCEM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCEM.AutoSize = true;
            this.lblCEM.Font = new System.Drawing.Font("Stencil Std", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEM.ForeColor = System.Drawing.Color.White;
            this.lblCEM.Location = new System.Drawing.Point(110, 11);
            this.lblCEM.Name = "lblCEM";
            this.lblCEM.Size = new System.Drawing.Size(573, 20);
            this.lblCEM.TabIndex = 0;
            this.lblCEM.Text = "Colombo Event Management - We create, We Design, We Develop";
            this.lblCEM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gradientPanel1.ColorLeft = System.Drawing.Color.White;
            this.gradientPanel1.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gradientPanel1.Controls.Add(this.btnBookEvent);
            this.gradientPanel1.Controls.Add(this.btnViewVenu);
            this.gradientPanel1.Controls.Add(this.btnManageEvent);
            this.gradientPanel1.Controls.Add(this.btnUserRegistration);
            this.gradientPanel1.Controls.Add(this.btnUserProfile);
            this.gradientPanel1.Controls.Add(this.btnManageCustomer);
            this.gradientPanel1.Controls.Add(this.pictureBox2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.gradientPanel2);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.Location = new System.Drawing.Point(0, 67);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(800, 341);
            this.gradientPanel1.TabIndex = 4;
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.GradientPanel1_Paint);
            // 
            // btnBookEvent
            // 
            this.btnBookEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBookEvent.BackColor = System.Drawing.Color.White;
            this.btnBookEvent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBookEvent.BackgroundImage")));
            this.btnBookEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBookEvent.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookEvent.Location = new System.Drawing.Point(479, 165);
            this.btnBookEvent.Name = "btnBookEvent";
            this.btnBookEvent.Size = new System.Drawing.Size(216, 93);
            this.btnBookEvent.TabIndex = 8;
            this.btnBookEvent.Text = "Book Event";
            this.btnBookEvent.UseVisualStyleBackColor = false;
            this.btnBookEvent.Click += new System.EventHandler(this.BtnBookEvent_Click);
            // 
            // btnViewVenu
            // 
            this.btnViewVenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewVenu.BackColor = System.Drawing.Color.White;
            this.btnViewVenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewVenu.BackgroundImage")));
            this.btnViewVenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewVenu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewVenu.Location = new System.Drawing.Point(209, 165);
            this.btnViewVenu.Name = "btnViewVenu";
            this.btnViewVenu.Size = new System.Drawing.Size(216, 93);
            this.btnViewVenu.TabIndex = 7;
            this.btnViewVenu.Text = "View Venu";
            this.btnViewVenu.UseVisualStyleBackColor = false;
            this.btnViewVenu.Click += new System.EventHandler(this.BtnViewVenu_Click);
            // 
            // btnManageEvent
            // 
            this.btnManageEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageEvent.BackColor = System.Drawing.Color.White;
            this.btnManageEvent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageEvent.BackgroundImage")));
            this.btnManageEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageEvent.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEvent.Location = new System.Drawing.Point(-63, 165);
            this.btnManageEvent.Name = "btnManageEvent";
            this.btnManageEvent.Size = new System.Drawing.Size(216, 93);
            this.btnManageEvent.TabIndex = 6;
            this.btnManageEvent.Text = "Manage Event Details";
            this.btnManageEvent.UseVisualStyleBackColor = false;
            this.btnManageEvent.Click += new System.EventHandler(this.BtnManageEvent_Click);
            // 
            // btnUserRegistration
            // 
            this.btnUserRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserRegistration.BackColor = System.Drawing.Color.White;
            this.btnUserRegistration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserRegistration.BackgroundImage")));
            this.btnUserRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserRegistration.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserRegistration.Location = new System.Drawing.Point(479, 10);
            this.btnUserRegistration.Name = "btnUserRegistration";
            this.btnUserRegistration.Size = new System.Drawing.Size(216, 93);
            this.btnUserRegistration.TabIndex = 5;
            this.btnUserRegistration.Text = "User Registration";
            this.btnUserRegistration.UseVisualStyleBackColor = false;
            this.btnUserRegistration.Click += new System.EventHandler(this.BtnUserRegistration_Click);
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserProfile.BackColor = System.Drawing.Color.White;
            this.btnUserProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserProfile.BackgroundImage")));
            this.btnUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserProfile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserProfile.Location = new System.Drawing.Point(209, 12);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(216, 93);
            this.btnUserProfile.TabIndex = 4;
            this.btnUserProfile.Text = "User Profile";
            this.btnUserProfile.UseVisualStyleBackColor = false;
            this.btnUserProfile.Click += new System.EventHandler(this.BtnUserProfile_Click);
            // 
            // btnManageCustomer
            // 
            this.btnManageCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageCustomer.BackColor = System.Drawing.Color.White;
            this.btnManageCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageCustomer.BackgroundImage")));
            this.btnManageCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageCustomer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCustomer.Location = new System.Drawing.Point(-61, 12);
            this.btnManageCustomer.Name = "btnManageCustomer";
            this.btnManageCustomer.Size = new System.Drawing.Size(216, 93);
            this.btnManageCustomer.TabIndex = 3;
            this.btnManageCustomer.Text = "Manage Customer Details";
            this.btnManageCustomer.UseVisualStyleBackColor = false;
            this.btnManageCustomer.Click += new System.EventHandler(this.BtnManageCustomer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(209, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(584, 274);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main Menu";
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gradientPanel2.ColorLeft = System.Drawing.Color.White;
            this.gradientPanel2.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gradientPanel2.Controls.Add(this.crbtnEvent);
            this.gradientPanel2.Controls.Add(this.crbtnNews);
            this.gradientPanel2.Controls.Add(this.crbtnContactUs);
            this.gradientPanel2.Controls.Add(this.crbtnAboutUs);
            this.gradientPanel2.Controls.Add(this.crbtnHome);
            this.gradientPanel2.Controls.Add(this.pictureBox1);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(203, 337);
            this.gradientPanel2.TabIndex = 0;
            this.gradientPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.GradientPanel2_Paint);
            // 
            // crbtnEvent
            // 
            this.crbtnEvent.BackColor = System.Drawing.Color.Coral;
            this.crbtnEvent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crbtnEvent.Location = new System.Drawing.Point(20, 294);
            this.crbtnEvent.Name = "crbtnEvent";
            this.crbtnEvent.Size = new System.Drawing.Size(149, 47);
            this.crbtnEvent.TabIndex = 5;
            this.crbtnEvent.Text = "Event";
            this.crbtnEvent.UseVisualStyleBackColor = false;
            this.crbtnEvent.Click += new System.EventHandler(this.CrbtnEvent_Click);
            // 
            // crbtnNews
            // 
            this.crbtnNews.BackColor = System.Drawing.Color.Coral;
            this.crbtnNews.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crbtnNews.Location = new System.Drawing.Point(20, 225);
            this.crbtnNews.Name = "crbtnNews";
            this.crbtnNews.Size = new System.Drawing.Size(149, 47);
            this.crbtnNews.TabIndex = 4;
            this.crbtnNews.Text = "News";
            this.crbtnNews.UseVisualStyleBackColor = false;
            this.crbtnNews.Click += new System.EventHandler(this.CrbtnNews_Click);
            // 
            // crbtnContactUs
            // 
            this.crbtnContactUs.BackColor = System.Drawing.Color.Coral;
            this.crbtnContactUs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crbtnContactUs.Location = new System.Drawing.Point(20, 160);
            this.crbtnContactUs.Name = "crbtnContactUs";
            this.crbtnContactUs.Size = new System.Drawing.Size(149, 47);
            this.crbtnContactUs.TabIndex = 3;
            this.crbtnContactUs.Text = "Contact Us";
            this.crbtnContactUs.UseVisualStyleBackColor = false;
            this.crbtnContactUs.Click += new System.EventHandler(this.CrbtnContactUs_Click);
            // 
            // crbtnAboutUs
            // 
            this.crbtnAboutUs.BackColor = System.Drawing.Color.Coral;
            this.crbtnAboutUs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crbtnAboutUs.Location = new System.Drawing.Point(20, 89);
            this.crbtnAboutUs.Name = "crbtnAboutUs";
            this.crbtnAboutUs.Size = new System.Drawing.Size(149, 47);
            this.crbtnAboutUs.TabIndex = 2;
            this.crbtnAboutUs.Text = "About Us";
            this.crbtnAboutUs.UseVisualStyleBackColor = false;
            this.crbtnAboutUs.Click += new System.EventHandler(this.CrbtnAboutUs_Click);
            // 
            // crbtnHome
            // 
            this.crbtnHome.BackColor = System.Drawing.Color.Coral;
            this.crbtnHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crbtnHome.Location = new System.Drawing.Point(20, 20);
            this.crbtnHome.Name = "crbtnHome";
            this.crbtnHome.Size = new System.Drawing.Size(149, 47);
            this.crbtnHome.TabIndex = 1;
            this.crbtnHome.Text = "Login";
            this.crbtnHome.UseVisualStyleBackColor = false;
            this.crbtnHome.Click += new System.EventHandler(this.CrbtnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 180);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCEM;
        private GradientPanel gradientPanel1;
        private GradientPanel gradientPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularButton crbtnNews;
        private CircularButton crbtnContactUs;
        private CircularButton crbtnAboutUs;
        private CircularButton crbtnHome;
        private CircularButton crbtnEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBookEvent;
        private System.Windows.Forms.Button btnViewVenu;
        private System.Windows.Forms.Button btnManageEvent;
        private System.Windows.Forms.Button btnUserRegistration;
        private System.Windows.Forms.Button btnUserProfile;
        private System.Windows.Forms.Button btnManageCustomer;
        private System.Windows.Forms.Timer timer1;
    }
}