namespace InventorySystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            string mdf = @"C:\Users\Public\Desktop\DealershipDB.mdf";

            if (File.Exists(mdf))
            {

            }
            else
            {
                string expPath = Path.Combine(Application.StartupPath, "DealershipDB.mdf");
                string targetPath = @"C:\Users\Public\Desktop\ExpenseDB.mdf";
                string log = Path.Combine(Application.StartupPath, "DealershipDB_log.ldf");
                string logpath = @"C:\Users\Public\Desktop\DealershipDB_log.ldf";
                File.Copy(expPath, targetPath, true);
                File.Copy(log, logpath, true);
            }
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