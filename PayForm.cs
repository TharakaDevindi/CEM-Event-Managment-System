using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace CEM_Event_Managment_System
{
    public partial class PayForm : Form
    {
        SqlConnection sqlCon;

        public PayForm()
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
                    "Pay Event Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            SignInForm objSignInForm = new SignInForm();
            this.Hide();
            objSignInForm.Show();
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

        private void PayForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;

            try
            {

                SqlCommand cmd = new SqlCommand
                    ("Select distinct BookingId from tbl_EventDetail", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds, "tbl_EventDetail");

                cmbBookingId.DataSource = ds;
                cmbBookingId.DisplayMember = "tbl_EventDetail.BookingId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex, "Pay Form",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LinklblPrevious_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BookEventForm objSignInForm = new BookEventForm();
            this.Hide();
            objSignInForm.Show();
        }

        private void CmbBookingId_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCardNo.Text) || string.IsNullOrEmpty(txtCVVNo.Text)
                || string.IsNullOrEmpty(txtNameOfCard.Text) || string.IsNullOrEmpty(txttExpiration.Text))
            {
                MessageBox.Show("Please enter all details", "Pay Form",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {   
             MessageBox.Show("Paying Successfuly Added.. Event Reserved", "Customer Form", MessageBoxButtons.OK, MessageBoxIcon.Information);  
            }
        }

        private void LinklblMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm objMenuForm = new MainForm();
            this.Hide();
            objMenuForm.Show();
        }
    }
}
