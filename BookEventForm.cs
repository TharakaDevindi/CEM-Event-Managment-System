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
    public partial class BookEventForm : Form
    {
        SqlConnection sqlCon;

        Double Venue, NoOfGuest, FoodFor, FoodType, Lighting, Flower, Seating, Total;

        public BookEventForm()
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

        private void BookEventForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
            this.cmbPic.Items.Clear();
            string[] imgs = Directory.GetFiles(@"C:\Users\THARAKA DEVINDI\Documents\Visual Studio 2019\C#\CEM_Event_Managment_System\CEM_Event_Managment_System\VenueImages\");
            foreach (string file in imgs)
            {
                cmbPic.Text = "---SELECT IMAGES---";
                cmbPic.Items.Add(file);
            }
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

        private void BtnHome_Click(object sender, EventArgs e)
        {
            SignInForm objSignInForm = new SignInForm();
            this.Hide();
            objSignInForm.Show();
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

        private void CmbPic_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = cmbPic.SelectedItem.ToString();
            pictureBox1.Image = new Bitmap(s);
        }

        private void CmbVenuType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Date from tbl_EventDetail where Date = '" + txtDate.Text + "'", sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Date Already Reserved !","Book Event Form", MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
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
                        MessageBox.Show("Event Scheduled..Pay to Reserved", "Book Event Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Event fail Scheduled !", "Book Event Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error  " + ex);
                }
            }
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            PayForm objSignInForm = new PayForm();
            this.Hide();
            objSignInForm.Show();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
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
                        txtCostGuest.Text = dr["Cost"].ToString();

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

        private void BtnCal_Click(object sender, EventArgs e)
        {
            Venue = Convert.ToDouble(txtCost.Text);
            NoOfGuest = Convert.ToDouble(txtCostGuest.Text);
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
