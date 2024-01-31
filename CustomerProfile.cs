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
    public partial class CustomerProfile : Form
    {
        SqlConnection sqlCon;
        public CustomerProfile()
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
                    "Customer Profile Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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

        private void CustomerProfile_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            SignInForm objSignInForm = new SignInForm();
            this.Hide();
            objSignInForm.Show();
        }

        private void TxtSearchId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchId.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("Select FirstNane,LastName,Address,ContactNo,EmailAddress from tbl_UserRegistration where Username = @Username", sqlCon);
                    cmd.Parameters.AddWithValue("@Username", (txtSearchId.Text));
                    SqlDataReader da = cmd.ExecuteReader();
                    while (da.Read())
                    {
                        txtFirstName.Text = da.GetValue(0).ToString();
                        txtLastName.Text = da.GetValue(1).ToString();
                        txtAddress.Text = da.GetValue(2).ToString();
                        txtContact.Text = da.GetValue(3).ToString();
                        txtEmail.Text = da.GetValue(4).ToString();

                    }
                    da.Close();
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex,
                    "Customer Profile Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtSearchId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                
                 SqlCommand cmd = new SqlCommand("Update tbl_UserRegistration set FirstNane=@FirstNane, LastName=@LastName , Address=@Address , ContactNo=@ContactNo ,EmailAddress=@EmailAddress where Username = @Username", sqlCon);
                    cmd.Parameters.AddWithValue("@Username", (txtSearchId.Text));
                    cmd.Parameters.AddWithValue("@FirstNane", (txtFirstName.Text));
                    cmd.Parameters.AddWithValue("@LastName", (txtLastName.Text));
                    cmd.Parameters.AddWithValue("@Address", (txtAddress.Text));
                    cmd.Parameters.AddWithValue("@ContactNo", (txtContact.Text));
                    cmd.Parameters.AddWithValue("@EmailAddress", (txtEmail.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Updated" ,
                    "Customer Profile Form",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex,
                    "Customer Profile Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Delete tbl_UserRegistration where Username = @Username", sqlCon);
                cmd.Parameters.AddWithValue("@Username", (txtSearchId.Text));
               
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Deleted",
                    "Customer Profile Form",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex,
                    "Customer Profile Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("Select FirstNane,LastName,Address,ContactNo,EmailAddress,Username,Password from tbl_UserRegistration where Username = @Username", sqlCon);
                cmd.Parameters.AddWithValue("@Username", (txtSearchId.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCustomerDetails.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex,
                    "Customer Profile Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainForm objMenuForm = new MainForm();
            this.Hide();
            objMenuForm.Show();
        }
    }
}
