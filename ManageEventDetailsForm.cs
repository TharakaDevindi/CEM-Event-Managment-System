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
    public partial class ManageEventDetailsForm : Form
    {
        SqlConnection sqlCon;
        Double Venue, NoOfGuest, FoodFor, FoodType, Lighting, Flower, Seating, Total;

        private void CmbFoodFor_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cmbFoodFor.SelectedItem.ToString() != "")
                {
                    SqlCommand cmd = new SqlCommand("Select * from tbl_CostFoodFor where FoodFor = '" + cmbFoodFor.SelectedItem.ToString() + "'", sqlCon);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtCostFoodFor.Text = dr["Cost"].ToString();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex,
                    "Book Event Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbFoodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbFoodType.SelectedItem.ToString() != "")
                {
                    SqlCommand cmd = new SqlCommand("Select * from tbl_CostFoodType where FoodType = '" + cmbFoodType.SelectedItem.ToString() + "'", sqlCon);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtCostFoodType.Text = dr["Cost"].ToString();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex,
                    "Book Event Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbLighting_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbLighting.SelectedItem.ToString() != "")
                {
                    SqlCommand cmd = new SqlCommand("Select * from tbl_CostType where Type = '" + cmbLighting.SelectedItem.ToString() + "'", sqlCon);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtCostLighting.Text = dr["Cost"].ToString();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex,
                    "Book Event Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbFlower_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbFlower.SelectedItem.ToString() != "")
                {
                    SqlCommand cmd = new SqlCommand("Select * from tbl_CostType where Type = '" + cmbFlower.SelectedItem.ToString() + "'", sqlCon);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtCostFlower.Text = dr["Cost"].ToString();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex,
                    "Book Event Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbSeating_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSeating.SelectedItem.ToString() != "")
                {
                    SqlCommand cmd = new SqlCommand("Select * from tbl_CostSeating where Seating = '" + cmbSeating.SelectedItem.ToString() + "'", sqlCon);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtCostSeating.Text = dr["Cost"].ToString();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex,
                    "Book Event Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Date from tbl_EventDetail where Date = '" + txtDate.Text + "'", sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Date Already Reserved !", "Book Event Form", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("insert into tbl_EventDetail (BookingId,EventType,EventPlace,NoOfGuest,Date,Food,FoodType,Lighting,Flower,Seating,Total) values('" + txtBookId.Text + "','" + cmbVenuType.SelectedItem.ToString() + "','" + cmbVenue.SelectedItem.ToString()
                        + "','" + cmbNoOfGuest.SelectedItem.ToString() + "','" + txtDate.Text + "','" + cmbFoodFor.SelectedItem.ToString() + "','" + cmbFoodType.SelectedItem.ToString() + "','" + cmbLighting.SelectedItem.ToString() + "','" + cmbFlower.SelectedItem.ToString() + "','" + cmbSeating.SelectedItem.ToString() + "','" + txtTot.Text + "')", sqlCon);
                    int NoRows = cmd.ExecuteNonQuery();
                    if (NoRows > 0)
                    {
                        MessageBox.Show("Event Insert Succcessfully", "Book Event Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Event fail Added !", "Book Event Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error  " + ex);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtBookId.Text = "";
            txtCost.Text = "";
            txtCostFlower.Text = "";
            txtCostFoodFor.Text = "";
            txtCostFoodType.Text = "";
            txtCostLighting.Text = "";
            txtCostNoOfGuest.Text = "";
            txtCostSeating.Text = "";
            txtDate.Text = "";
            txtTot.Text = "";
            

        }

        private void DgvEventDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvEventDetails.Rows[e.RowIndex];

                txtBookId.Text = row.Cells["BookingId"].Value.ToString();
              
                txtDate.Text = row.Cells["Date"].Value.ToString();
                txtTot.Text = row.Cells["Total"].Value.ToString();

            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from tbl_EventDetail", sqlCon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEventDetails.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex,
                    "Manage Event Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            
                try
                {

                    SqlCommand cmd = new SqlCommand("Delete tbl_EventDetail where BookingId ='" + txtBookId.Text + "'", sqlCon);
                    int NoRows = cmd.ExecuteNonQuery();
                    if (NoRows > 0)
                    {
                        MessageBox.Show("Event Delete Succcessfully", "Book Event Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Event fali to Delete  !", "Book Event Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error  " + ex);
                }
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Update tbl_EventDetail set BookingId='"+txtBookId.Text+"',EventType='"+cmbVenuType.SelectedItem.ToString()+"'," +
                    " EventPlace='"+cmbVenue.SelectedItem.ToString()+"' , NoOfGuest='"+cmbNoOfGuest.SelectedItem.ToString()+"' , Date='"+txtDate.Text+"' " +
                    ",Food='"+cmbFoodFor.SelectedItem.ToString()+ "', FoodType='"+cmbFoodType.SelectedItem.ToString()+"'," +
                    " Lighting='"+cmbLighting.SelectedItem.ToString()+ "',Flower='" +cmbFlower.SelectedItem.ToString() + "',Seating='" + cmbSeating.SelectedItem.ToString()
                    + "',Total='" + txtTot.Text + "'" +
                    " where BookingId='" + txtBookId.Text + "'", sqlCon);
             
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Updated",
                    "Manage Customer Profile Form",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex,
                    "Manage Event Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnBackToMenu_Click(object sender, EventArgs e)
        {
            MainForm objMenuForm = new MainForm();
            this.Hide();
            objMenuForm.Show();
        }

        private void CmbNoOfGuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbNoOfGuest.SelectedItem.ToString() != "")
                {
                    SqlCommand cmd = new SqlCommand("Select * from tbl_CostNoOfGuest where NoOfGuest = '" + cmbNoOfGuest.SelectedItem.ToString() + "'", sqlCon);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtCostNoOfGuest.Text = dr["Cost"].ToString();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex,
                    "Book Event Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbVenue.SelectedItem.ToString() != "")
                {
                    SqlCommand cmd = new SqlCommand("Select * from tbl_CostVenue where Venue = '" + cmbVenue.SelectedItem.ToString() + "'", sqlCon);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtCost.Text = dr["Cost"].ToString();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex,
                    "Book Event Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ManageEventDetailsForm()
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
                    "Book Event Form",
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

        private void ManageEventDetailsForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
            cmbVenue.Text = "---SELECT VENUE---";
            cmbVenuType.Text = "-- - SELECT VENU TYPE-- - ";
            cmbFlower.Text = "---SELECT TYPE---";
            cmbLighting.Text = "---SELECT TYPE---";
            cmbSeating.Text = "---SELECT TYPE---";
            cmbNoOfGuest.Text = "---SELECT NUMBER---";
            cmbFoodFor.Text = "---SELECT TYPE---";
            cmbFoodType.Text = "---SELECT TYPE---";

            try
            {
                SqlCommand cmd = new SqlCommand("Select BookingId from tbl_EventDetail", sqlCon);
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
                        txtBookId.Text = "E00" + CTR;
                    }
                    else if (CTR >= 9 && CTR < 99)
                    {
                        CTR = CTR + 1;
                        txtBookId.Text = "E0" + CTR;
                    }
                    else if (CTR >= 99)
                    {
                        CTR = CTR + 1;
                        txtBookId.Text = "E" + CTR;
                    }
                }
                else
                {
                    txtBookId.Text = "E001";
                }

                dr.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error connecting " + e1, "Book Event Form ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            SignInForm objSignInForm = new SignInForm();
            this.Hide();
            objSignInForm.Show();
        }

        private void BtnCal_Click(object sender, EventArgs e)
        {
            Venue = Convert.ToDouble(txtCost.Text);
            NoOfGuest = Convert.ToDouble(txtCostNoOfGuest.Text);
            FoodFor = Convert.ToDouble(txtCostFoodFor.Text);
            FoodType = Convert.ToDouble(txtCostFoodType.Text);
            Lighting = Convert.ToDouble(txtCostLighting.Text);
            Flower = Convert.ToDouble(txtCostFlower.Text);
            Seating = Convert.ToDouble(txtCostSeating.Text);

            Total = Venue + (FoodFor * NoOfGuest) + FoodType + Lighting + Flower + Seating;
            txtTot.Text = Total.ToString();
        }
    }
}
