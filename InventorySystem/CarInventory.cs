using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class CarInventory : Form
    {
        public CarInventory()
        {
            InitializeComponent();

        }
        SqlConnection con = DBConnection.GetConnection();
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieves the values from the UserTbl table for the specified ID
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT CarID,CarName,CarBrand,CarModel,CarColor,CarPrice,CarYear,CarStatus,CarImage FROM CarsTbl WHERE CarID=@ID", con);
                int IDZ = Convert.ToInt32(nameIdTB.Text);
                cmd.Parameters.AddWithValue("@ID", IDZ);
                //cmd.Parameters.AddWithValue("@CN", nameIdTB.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    carIdTB.Text = reader["CarID"].ToString();
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
                    carPic.Image = image;
                    reader.Close();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Info!");
                con.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu men = new MainMenu();
            men.Show();
        }
    }
}
