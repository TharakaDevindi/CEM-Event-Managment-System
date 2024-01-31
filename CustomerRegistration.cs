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
    public partial class CustomerRegistration : Form
    {
        SqlConnection sqlCon;
        public CustomerRegistration()
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
                    "Registration Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;

            try
            {
                SqlCommand cmd = new SqlCommand("Select UserId from tbl_UserRegistration", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();
                String UserId = "";
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        UserId = dr[0].ToString();
                    }
                    string UserIdString = UserId.Substring(1); //001
                    int CTR = Int32.Parse(UserIdString);   //1

                    if (CTR >= 1 && CTR < 9)
                    {
                        CTR = CTR + 1;
                        txtUId.Text = "C00" + CTR;
                    }
                    else if (CTR >= 9 && CTR < 99)
                    {
                        CTR = CTR + 1;
                        txtUId.Text = "C0" + CTR;
                    }
                    else if (CTR >= 99)
                    {
                        CTR = CTR + 1;
                        txtUId.Text = "C" + CTR;
                    }
                }
                else
                {
                    txtUId.Text = "C001";
                }

                dr.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error connecting " + e1, "User Registration ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill mandatory fields...", "User Registration", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (txtContact.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtFirstName.Text == ""
                || txtLastName.Text == "")
            {
                MessageBox.Show("Please fill all fields..." , "User Registration", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password do not match !!", "User Registration", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("UserAdd", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FirstNane", txtFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContactNo", txtContact.Text.Trim());
                    cmd.Parameters.AddWithValue("@EmailAddress", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@UserId", txtUId.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is Successfull");
                    Clear();
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Error record added !!" + e1, "User Registration", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }          
            }
    }

        void Clear()
        {
            txtAddress.Text = txtConfirmPassword.Text = txtContact.Text = txtEmail.Text = txtFirstName.Text = txtLastName.Text = txtPassword.Text = txtUsername.Text = txtUId.Text = "";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SignInForm objSignInForm = new SignInForm();
            this.Hide();
            objSignInForm.Show();
        }

        
    }
}
