using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CEM_Event_Managment_System
{
    public partial class MainForm : Form
    {
        SqlConnection sqlCon;
        public MainForm()
        {
            InitializeComponent();
         
            try
            {
                DBConnection obj = new DBConnection();
                sqlCon = obj.getConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting" + ex,
                    "Main Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        String Username;
        public MainForm(String s)
        {
            InitializeComponent();

            Username = s;
        }

        private void GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            int four = rand.Next(0, 255);
            lblCEM.ForeColor = Color.FromArgb(one, two, three, four);
            lblWelcome.ForeColor = Color.FromArgb(one, two, three, four);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;

            if(Username == "customer")
            {
                btnManageCustomer.Hide();
                btnManageEvent.Hide();
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            SignInForm objSignInForm = new SignInForm();
            this.Hide();
            objSignInForm.Show();
        }

        private void CrbtnHome_Click(object sender, EventArgs e)
        {
            SignInForm objSignInForm = new SignInForm();
            this.Hide();
            objSignInForm.Show();
        }

        private void CrbtnAboutUs_Click(object sender, EventArgs e)
        {
            AboutUsForm objAboutUsForm = new AboutUsForm();
            this.Hide();
            objAboutUsForm.Show();
        }

        private void CrbtnContactUs_Click(object sender, EventArgs e)
        {
            ContactForm objContactForm = new ContactForm();
            this.Hide();
            objContactForm.Show();
        }

        private void CrbtnNews_Click(object sender, EventArgs e)
        {
            NewsForm objNewsForm = new NewsForm();
            this.Hide();
            objNewsForm.Show();
        }

        private void CrbtnEvent_Click(object sender, EventArgs e)
        {
            EventForm objEventForm = new EventForm();
            this.Hide();
            objEventForm.Show();
        }

        private void BtnManageCustomer_Click(object sender, EventArgs e)
        {


            ManageCustomerProfileForm objManageCustomerForm = new ManageCustomerProfileForm();
            this.Hide();
            objManageCustomerForm.Show();

        }

        private void BtnUserProfile_Click(object sender, EventArgs e)
        {
            CustomerProfile objCustomerProForm = new CustomerProfile();
            this.Hide();
            objCustomerProForm.Show();
        }

        private void BtnUserRegistration_Click(object sender, EventArgs e)
        {
            CustomerRegistration objRegistrationForm = new CustomerRegistration();
            this.Hide();
            objRegistrationForm.Show();
        }

        private void BtnManageEvent_Click(object sender, EventArgs e)
        {
            ManageEventDetailsForm objEventDeForm = new ManageEventDetailsForm();
            this.Hide();
            objEventDeForm.Show();
        }

        private void BtnViewVenu_Click(object sender, EventArgs e)
        {
            ViewVenuForm objViewVenuForm = new ViewVenuForm();
            this.Hide();
            objViewVenuForm.Show();
        }

        private void BtnBookEvent_Click(object sender, EventArgs e)
        {
            BookEventForm objBookEventForm = new BookEventForm();
            this.Hide();
            objBookEventForm.Show();
        }
    }
}
