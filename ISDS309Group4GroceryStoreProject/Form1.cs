namespace ISDS309Group4GroceryStoreProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            label3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            username = textBox1.Text;
            password = textBox2.Text;

            if (username == "admin" && password == "staffmesa2024")

            {
                this.Hide();
                Tab_Admin tabAdmin = new Tab_Admin();
                tabAdmin.ShowDialog();

            }
            else
            if (username == "John" && password == "john2024")

            {
                //Exit curent tab
                this.Hide();
                //Then open new tab
                Tab_Home tabMeat = new Tab_Home();
                //.Show = open new tab, (can alt tab to others)
                //.ShowDialog = open new tab but you can't eddit others while its open
                tabMeat.ShowDialog();
            }
            else

            {
                label3.Show();
                label3.Text = "Invalid username and/or password";
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Tab_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }




    }
}
