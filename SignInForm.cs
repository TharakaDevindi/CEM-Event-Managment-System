using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace CEM_Event_Managment_System
{
    public partial class SignInForm : Form
    {
        SqlConnection sqlCon;
        public SignInForm()
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
                    "Login Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 9)
            {
                imageNumber = 1;
            }
            sliderpic.ImageLocation = string.Format(@"images\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

   

        private void Sliderpic_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            int four = rand.Next(0, 255);
            lblCEM.ForeColor = Color.FromArgb(one, two, three, four);
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            timer2.Start();
            timer2.Enabled = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnHome_MouseHover(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.LightPink;
        }

        private void BtnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Transparent;
        }

        private void BtnAboutUs_MouseHover(object sender, EventArgs e)
        {
            btnAboutUs.BackColor = Color.LightPink;
        }

        private void BtnAboutUs_MouseLeave(object sender, EventArgs e)
        {
            btnAboutUs.BackColor = Color.Transparent;
        }

        private void BtnContactUs_MouseHover(object sender, EventArgs e)
        {
            btnContactUs.BackColor = Color.LightPink;
        }

        private void BtnContactUs_MouseLeave(object sender, EventArgs e)
        {
            btnContactUs.BackColor = Color.Transparent;
        }

        private void BtnNews_MouseHover(object sender, EventArgs e)
        {
            btnNews.BackColor = Color.LightPink;
        }

        private void BtnNews_MouseLeave(object sender, EventArgs e)
        {
            btnNews.BackColor = Color.Transparent;
        }

        private void BtnEvent_MouseHover(object sender, EventArgs e)
        {
            btnEvent.BackColor = Color.LightPink;
        }

        private void BtnEvent_MouseLeave(object sender, EventArgs e)
        {
            btnEvent.BackColor = Color.Transparent;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Login where Username ='" + txtUsername.Text.Trim() + "'and Password = '" + txtPassword.Text.Trim() + "'", sqlCon);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    if (txtUsername.Text == "admin" && txtPassword.Text == "123")
                    {
                        MainForm objmainForm = new MainForm (txtUsername.Text);
                        this.Hide();
                        objmainForm.Show();
                    }
                    else if (txtUsername.Text == "manager" && txtPassword.Text == "123")
                    {
                        MainForm objmainForm = new MainForm(txtUsername.Text);
                        this.Hide();
                        objmainForm.Show();
                    }
                    else if (txtUsername.Text == "customer" && txtPassword.Text == "123") {
                        MainForm objmainForm = new MainForm(txtUsername.Text);
                        this.Hide();
                        objmainForm.Show();
                    }
                }
                else if (this.txtUsername.Text == "")
                {
                    MessageBox.Show("Please Enter Username...", "Login Form", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else if (this.txtPassword.Text == "")
                {
                    MessageBox.Show("Please Enter Password...", "Login Form", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else 
                {
                    MessageBox.Show("Incorrect Username or Password", "Login Form", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error connecting " + e1, "Student Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAboutUs_Click(object sender, EventArgs e)
        {
            AboutUsForm objAboutUsForm = new AboutUsForm();
            this.Hide();
            objAboutUsForm.Show();
        }

        private void BtnContactUs_Click(object sender, EventArgs e)
        {
            ContactForm objContactForm = new ContactForm();
            this.Hide();
            objContactForm.Show();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
           SignInForm objSignInForm = new SignInForm();
            this.Hide();
            objSignInForm.Show();
        }

        private void BtnNews_Click(object sender, EventArgs e)
        {
            NewsForm objNewsForm = new NewsForm();
            this.Hide();
            objNewsForm.Show();
        }

        private void BtnEvent_Click(object sender, EventArgs e)
        {
            EventForm objEventForm = new EventForm();
            this.Hide();
            objEventForm.Show();
        }

        private void LinklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerRegistration objRegisterForm = new CustomerRegistration();
            this.Hide();
            objRegisterForm.Show();
        }

        private void GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
