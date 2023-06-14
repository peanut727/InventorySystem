using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class CarList : Form
    {
        SqlConnection con = DBConnection.GetConnection();
        public CarList()
        {
            InitializeComponent();
            showCarList();
        }

        private void showCarList()
        {
            con.Open();
            string query = "select * from CarsTbl";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(SDA);
            var ds = new DataSet();
            SDA.Fill(ds);
            carDGV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void clear()
        {
            carNameTB.Text = "";
            carBrandTB.Text = "";
            carModelTB.Text = "";
            carColorTB.Text = "";
            carPriceTB.Text = "";
            carYearTB.Text = "";
            carIdTB.Text = "";
            carPicB.Image = null;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (carIdTB.Text == "" || carNameTB.Text == "" || carModelTB.Text == "" || carColorTB.Text == "" || carPriceTB.Text == "" || carBrandTB.Text == "" || carYearTB.Text == "" || carPicB.Image == null)
            {
                MessageBox.Show("Missing Informations!");
            }
            else
            {
                // Convert the Bitmap object to a byte array
                byte[] imageData;
                using (MemoryStream stream = new MemoryStream())
                {
                    carPicB.Image.Save(stream, ImageFormat.Png);
                    imageData = stream.ToArray();
                }
                // Inserts the values from the textbox above to CarsTbl
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into CarsTbl (CarID,CarName,CarBrand,CarModel,CarColor,CarPrice,CarYear,CarStatus,CarImage) values(@CID,@CN,@CB,@CM,@CC,@CP,@CY,@CS,@CI)", con);
                cmd.Parameters.AddWithValue("@CID", carIdTB.Text);
                cmd.Parameters.AddWithValue("@CN", carNameTB.Text);
                cmd.Parameters.AddWithValue("@CB", carBrandTB.Text);
                cmd.Parameters.AddWithValue("@CM", carModelTB.Text);
                cmd.Parameters.AddWithValue("@CC", carColorTB.Text);
                cmd.Parameters.AddWithValue("@CP", carPriceTB.Text);
                cmd.Parameters.AddWithValue("@CY", carYearTB.Text);
                cmd.Parameters.AddWithValue("@CS", carStatusTB.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@CI", imageData);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Car Information added successfully!");
                con.Close();
                showCarList();
                clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM CarsTbl WHERE CarID = @CID", con);
            cmd.Parameters.AddWithValue("@CID", CIDTB.Text);
            int rowsDeleted = cmd.ExecuteNonQuery();
            if (rowsDeleted > 0)
            {
                MessageBox.Show("Car information deleted successfully!");
                con.Close();
                showCarList();
                CIDTB.Text = "";
            }
            else
            {
                MessageBox.Show("Car ID not found");
                con.Close();
                CIDTB.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Select Item Image ";
            OFD.Filter = " Image File (*.png;*.jpg;*.jpeg;) | *.png;*.jpg;*.jpeg";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                carPicB.Image = new Bitmap(OFD.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int carprice = Convert.ToInt32(carPriceTB.Text);
            int cID = Convert.ToInt32(ciDeditTB.Text);


            if (ciDeditTB.Text == "")
            {
                MessageBox.Show("Missing ID!");
            }
            else
            {
                // Convert the Bitmap object to a byte array
                byte[] imageData;
                using (MemoryStream stream = new MemoryStream())
                {
                    carPicB.Image.Save(stream, ImageFormat.Png);
                    imageData = stream.ToArray();
                }
                // Updates the values on CarsTbl
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CarsTbl SET CarName=@CN, CarBrand=@CB, CarModel=@CM, CarColor=@CC, CarPrice=@CP, CarYear=@CY, CarStatus=@CS, CarImage=@CI WHERE CarID=@EID", con);
                cmd.Parameters.AddWithValue("@EID", cID);
                cmd.Parameters.AddWithValue("@CN", carNameTB.Text);
                cmd.Parameters.AddWithValue("@CB", carBrandTB.Text);
                cmd.Parameters.AddWithValue("@CM", carModelTB.Text);
                cmd.Parameters.AddWithValue("@CC", carColorTB.Text);
                cmd.Parameters.AddWithValue("@CP", carPriceTB.Text);
                cmd.Parameters.AddWithValue("@CY", carYearTB.Text);
                cmd.Parameters.AddWithValue("@CS", carStatusTB.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@CI", imageData);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Car info updated successfully!");
                con.Close();
                showCarList();
                clear();

            }
        }

        private void ciDeditTB_TextChanged(object sender, EventArgs e)
        {
            // Retrieves the values from the UserTbl table for the specified ID
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT CarID,CarName,CarBrand,CarModel,CarColor,CarPrice,CarYear,CarStatus,CarImage FROM CarsTbl WHERE CarID=@ID", con);
                int IDZ = Convert.ToInt32(ciDeditTB.Text);
                cmd.Parameters.AddWithValue("@ID", IDZ);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    carNameTB.Text = reader["CarName"].ToString();
                    carBrandTB.Text = reader["CarBrand"].ToString();
                    carYearTB.Text = reader["CarYear"].ToString();
                    carModelTB.Text = reader["CarModel"].ToString();
                    carColorTB.Text = reader["CarColor"].ToString();
                    carPriceTB.Text = reader["CarPrice"].ToString();
                    carStatusTB.Text = reader["CarStatus"].ToString();
                    // Get the image data from the reader
                    byte[] imageData = (byte[])reader["CarImage"];

                    // Create a MemoryStream object from the image data
                    MemoryStream ms = new MemoryStream(imageData);

                    // Create an Image object from the MemoryStream
                    Image image = Image.FromStream(ms);

                    // Assign the Image object to the PictureBox control
                    carPicB.Image = image;
                    reader.Close();
                    con.Close();
                    showCarList();
                }
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }
    }
}
