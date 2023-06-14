namespace InventorySystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aduser = "admin";
            string adpass = "admin";

            if (usertb.Text == aduser || passtb.Text == adpass)
            {
                this.Hide();
                MainMenu menu = new MainMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Wrong Credentials!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}