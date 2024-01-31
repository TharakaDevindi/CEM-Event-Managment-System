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
    public partial class ManageCustomerProfileForm : Form
    {
        SqlConnection sqlCon;
        public ManageCustomerProfileForm()
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
                    "Manage Customer Profile Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        String Username;
        public ManageCustomerProfileForm(String s)
        {
            InitializeComponent();
            Username = s;
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

        private void ManageCustomerProfileForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;

            if (Username == "manager")
            {
                btnInsertProfile.Hide();
               
            }

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
                MessageBox.Show("Error connecting " + e1, "Manage Customer Profile Form ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvCustomerDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCustomerDetails.Rows[e.RowIndex];

                txtUId.Text = row.Cells["UserId"].Value.ToString();
                txtFirstName.Text = row.Cells["FirstNane"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtContact.Text = row.Cells["ContactNo"].Value.ToString();
                txtEmail.Text = row.Cells["EmailAddress"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            SignInForm objSignInForm = new SignInForm();
            this.Hide();
            objSignInForm.Show();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Update tbl_UserRegistration set UserId=@Userid,FirstNane=@FirstNane, LastName=@LastName , Address=@Address , ContactNo=@ContactNo ,EmailAddress=@EmailAddress, Username=@Username, Password=@Password where UserId = @UserId", sqlCon);
                cmd.Parameters.AddWithValue("@UserId", (txtUId.Text));
                cmd.Parameters.AddWithValue("@FirstNane", (txtFirstName.Text));
                cmd.Parameters.AddWithValue("@LastName", (txtLastName.Text));
                cmd.Parameters.AddWithValue("@Address", (txtAddress.Text));
                cmd.Parameters.AddWithValue("@ContactNo", (txtContact.Text));
                cmd.Parameters.AddWithValue("@EmailAddress", (txtEmail.Text));
                cmd.Parameters.AddWithValue("@Username", (txtUsername.Text));
                cmd.Parameters.AddWithValue("@Password", (txtPassword.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Updated",
                    "Manage Customer Profile Form",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex,
                    "Manage Customer Profile Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void TxtSearchId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchId.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("Select * from tbl_UserRegistration where UserId = @UserId", sqlCon);
                    cmd.Parameters.AddWithValue("@UserId", (txtSearchId.Text));
                    SqlDataReader da = cmd.ExecuteReader();
                    while (da.Read())
                    {
                        txtUId.Text = da.GetValue(0).ToString();
                        txtFirstName.Text = da.GetValue(1).ToString();
                        txtLastName.Text = da.GetValue(2).ToString();
                        txtAddress.Text = da.GetValue(3).ToString();
                        txtContact.Text = da.GetValue(4).ToString();
                        txtEmail.Text = da.GetValue(5).ToString();
                        txtUsername.Text = da.GetValue(6).ToString();
                        txtPassword.Text = da.GetValue(7).ToString();

                    }
                    da.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex,
                    "Manage Customer Profile Form",
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
            txtUId.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Delete tbl_UserRegistration where UserId = @UserId", sqlCon);
                cmd.Parameters.AddWithValue("@UserId", (txtSearchId.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Deleted",
                    "Manage Customer Profile Form",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex,
                    "Manage Customer Profile Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from tbl_UserRegistration", sqlCon);
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCustomerDetails.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex,
                    "Manage Customer Profile Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnInsertProfile_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into tbl_UserRegistration values (@UserId,@FirstNane,@LastName,@Address,@ContactNo,@EmailAddress,@Username,@Password)", sqlCon);
                cmd.Parameters.AddWithValue("@UserId", (txtUId.Text));
                cmd.Parameters.AddWithValue("@FirstNane", (txtFirstName.Text));
                cmd.Parameters.AddWithValue("@LastName", (txtLastName.Text));
                cmd.Parameters.AddWithValue("@Address", (txtAddress.Text));
                cmd.Parameters.AddWithValue("@ContactNo", (txtContact.Text));
                cmd.Parameters.AddWithValue("@EmailAddress", (txtEmail.Text));
                cmd.Parameters.AddWithValue("@Username", (txtUsername.Text));
                cmd.Parameters.AddWithValue("@Password", (txtPassword.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Saved",
                    "Manage Customer Profile Form",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex,
                    "Manage Customer Profile Form",
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
