using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class customer : Form
    {
        SqlConnection con = DBConnection.GetConnection();
        public customer()
        {
            InitializeComponent();
            ShowCustomer();
        }

        private void ShowCustomer()
        {
            con.Open();
            string query = "select * from CustomerTbl";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(SDA);
            var ds = new DataSet();
            SDA.Fill(ds);
            carDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Clear()
        {
            idTB.Text = "";
            nameTB.Text = "";
            phoneTB.Text = "";
            addressTB.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idTB.Text == "" || nameTB.Text == "" || phoneTB.Text == "" || addressTB.Text == "" || ageTB.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                // create the values from the textbox above to CustomerTbl
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomerTbl (CId,CName,CPhone,CAddress,CAge,CDOB) values(@CID,@CN,@CP,@CA,@CAGE,@CDOB)", con);
                cmd.Parameters.AddWithValue("@CID", idTB.Text);
                cmd.Parameters.AddWithValue("@CN", nameTB.Text);
                cmd.Parameters.AddWithValue("@CP", phoneTB.Text);
                cmd.Parameters.AddWithValue("@CA", addressTB.Text);
                cmd.Parameters.AddWithValue("CAGE", ageTB.Text);
                cmd.Parameters.AddWithValue("@CDOB", cDOB.Value.Date);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User added successfully!");
                con.Close();
                ShowCustomer();
                Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ciDeditTB.Text == "")
            {
                MessageBox.Show("Missing ID!");
            }
            else
            {
                // Updates the values on CustomerTbl
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CustomerTbl SET CName=@CN, CPhone=@CP, CAddress=@CA, CAge=@CAG, CDOB=@CDOB WHERE CId=@CID", con);
                cmd.Parameters.AddWithValue("@CID", ciDeditTB.Text);
                cmd.Parameters.AddWithValue("@CN", nameTB.Text);
                cmd.Parameters.AddWithValue("@CP", phoneTB.Text);
                cmd.Parameters.AddWithValue("@CA", addressTB.Text);
                cmd.Parameters.AddWithValue("@CAG", ageTB.Text);
                cmd.Parameters.AddWithValue("CDOB", cDOB.Value.Date);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer information updated successfully!");
                con.Close();
                ShowCustomer();
                ciDeditTB.Text = "";
                Clear();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Delete values from CustomerTbl based on the CId
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM CustomerTbl WHERE CId = @CID", con);
            cmd.Parameters.AddWithValue("@CID", delID.Text);
            int rowsDeleted = cmd.ExecuteNonQuery();
            if (rowsDeleted > 0)
            {
                MessageBox.Show("Customer information deleted successfully!");
                con.Close();
                ShowCustomer();
                delID.Text = "";
            }
            else
            {
                MessageBox.Show("Customer ID not found!");
                con.Close();
                delID.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }

        private void ciDeditTB_TextChanged(object sender, EventArgs e)
        {
            // Retrieves the values from the UserTbl table for the specified ID
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT CId,CName,CPhone,CAddress,CAge,CDOB FROM CustomerTbl WHERE CId=@ID", con);
                int IDZ = Convert.ToInt32(ciDeditTB.Text);
                cmd.Parameters.AddWithValue("@ID", IDZ);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nameTB.Text = reader["CName"].ToString();
                    phoneTB.Text = reader["CPhone"].ToString();
                    addressTB.Text = reader["CAddress"].ToString();
                    ageTB.Text = reader["CAge"].ToString();
                    cDOB.Value = Convert.ToDateTime(reader["CDOB"]);

                    reader.Close();
                    con.Close();
                    ShowCustomer();
                }
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }

        private void delID_TextChanged(object sender, EventArgs e)
        {
            // Retrieves the values from the UserTbl table for the specified ID
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT CId,CName,CPhone,CAddress,CAge,CDOB FROM CustomerTbl WHERE CId=@ID", con);
                int IDZ = Convert.ToInt32(delID.Text);
                cmd.Parameters.AddWithValue("@ID", IDZ);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nameTB.Text = reader["CName"].ToString();
                    phoneTB.Text = reader["CPhone"].ToString();
                    addressTB.Text = reader["CAddress"].ToString();
                    ageTB.Text = reader["CAge"].ToString();
                    cDOB.Value = Convert.ToDateTime(reader["CDOB"]);

                    reader.Close();
                    con.Close();
                    ShowCustomer();
                }
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }
    }
}
