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
    public partial class ViewVenuForm : Form
    {
        SqlConnection sqlCon;
        public ViewVenuForm()
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
                    "View Venu Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        String Username;
        public ViewVenuForm (String s)
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

        private void ViewVenuForm_Load(object sender, EventArgs e)
        {
            if (Username == "customer")
            {
                btnDelete.Hide();
                BtnInsert.Hide();
                btnSave.Hide();
                btnUpdate.Hide();
                btnUploadImage.Hide();
            }

            timer1.Start();
            timer1.Enabled = true;

            

            this.cmbPic.Items.Clear();
            string[] imgs = Directory.GetFiles(@"C:\Users\THARAKA DEVINDI\Documents\Visual Studio 2019\C#\CEM_Event_Managment_System\CEM_Event_Managment_System\VenueImages\");
            foreach(string file in imgs)
            {
                cmbPic.Text = "---SELECT IMAGES---";
                cmbPic.Items.Add(file);
            }
            cmbVenue.Text = "---SELECT VENUE---";
            cmbVenuType.Text = "-- - SELECT VENU TYPE-- - ";
            try
            {
                SqlCommand cmd = new SqlCommand("Select VenuId from tbl_VenueInfo", sqlCon);
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
                        txtVenuId.Text = "V00" + CTR;
                    }
                    else if (CTR >= 9 && CTR < 99)
                    {
                        CTR = CTR + 1;
                        txtVenuId.Text = "V0" + CTR;
                    }
                    else if (CTR >= 99)
                    {
                        CTR = CTR + 1;
                        txtVenuId.Text = "V" + CTR;
                    }
                }
                else
                {
                    txtVenuId.Text = "V001";
                }

                dr.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error connecting " + e1, "View Venu Form ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            SignInForm objSignInForm = new SignInForm();
            this.Hide();
            objSignInForm.Show();
        }

        private void BtnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp)|*.jpg;*.jpeg;*.gif;*.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtUploadPath.Text = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            File.Copy(txtUploadPath.Text, Path.Combine(@"C:\Users\THARAKA DEVINDI\Documents\Visual Studio 2019\C#\CEM_Event_Managment_System\CEM_Event_Managment_System\VenueImages\", Path.GetFileName(txtUploadPath.Text)), true);
            label5.Text = "Image file saved successfully";
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            byte[] Image = null;
            FileStream stream = new FileStream(txtUploadPath.Text, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            Image = brs.ReadBytes((int)stream.Length);

            SqlCommand cmd = new SqlCommand("Insert into tbl_VenueInfo(VenuType,Venue,Cost,Image,VenuId) values ('" + cmbVenuType.SelectedItem.ToString() + "','" + cmbVenue.SelectedItem.ToString() + "','" + txtCost.Text + "',@Image,'" + txtVenuId.Text + "')", sqlCon);
            cmd.Parameters.Add(new SqlParameter("@Image", Image));
            cmd.ExecuteNonQuery();

            MessageBox.Show("Successfully Saved",
                "View Venu Form",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CmbVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbVenue.SelectedItem.ToString() != "")
                {
                    SqlCommand cmd = new SqlCommand("Select * from tbl_VenueInfo where Venue = '" + cmbVenue.SelectedItem.ToString() + "'", sqlCon);
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
                    "View Venu Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbPic_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = cmbPic.SelectedItem.ToString();
            pictureBox1.Image = new Bitmap(s);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtCost.Text = "";
            txtVenuId.Text = "";
            txtUploadPath.Text = "";
            cmbVenue.Text = "---SELECT VENUE---";
            cmbVenuType.Text = "-- - SELECT VENU TYPE-- - ";
            cmbPic.Text = "---SELECT IMAGES---";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] Image = null;
                FileStream stream = new FileStream(txtUploadPath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                Image = brs.ReadBytes((int)stream.Length);

                SqlCommand cmd = new SqlCommand("Update tbl_VenueInfo set VenuType='" + cmbVenuType.SelectedItem.ToString() + "'," +
                    " Venue='" + cmbVenue.SelectedItem.ToString() + "' , Cost='" + txtCost.Text + "' , Image=@Image " +
                    ",VenuId='" +txtVenuId.Text + "' where VenuId='" + txtVenuId.Text + "'", sqlCon);
                cmd.Parameters.Add(new SqlParameter("@Image", Image));
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

    

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Delete tbl_VenueInfo where VenuId ='" + txtVenuId.Text + "'", sqlCon);
                int NoRows = cmd.ExecuteNonQuery();
                if (NoRows > 0)
                {
                    MessageBox.Show("Venu Delete Succcessfully", "View venu Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fail to Delete!", "View venu Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            MainForm objMenuForm = new MainForm();
            this.Hide();
            objMenuForm.Show();
        }
    }
}
