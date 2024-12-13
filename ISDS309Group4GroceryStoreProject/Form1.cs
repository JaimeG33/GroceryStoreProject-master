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


            //if username = admin and password = staffmesa2024, go to admin page
            if (username == "admin" && password == "staffmesa2024")

            {
                this.Hide();
                Tab_Admin tabAdmin = new Tab_Admin();
                tabAdmin.ShowDialog();

            }
            else
            //if username = john and password = john2024, go to grocery homepage
            if (username == "john" && password == "john2024")

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
                // displays error if both are not met
                label3.Show();
                label3.Text = "Invalid username and/or password";
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(!Directory.Exists("ProjectData"))
{
    InventoryInfo inventoryInfo = new InventoryInfo();
    string dataFolder = "ProjectData", inv = "", DELIM = ",";
    int row = 0, invListLength = inventoryInfo.invList.GetLength(0);
    //int consoleWidth = Console.WindowWidth, spacesToPad = (consoleWidth - line.Length) / 2;


    //Make the folder
    Directory.CreateDirectory(dataFolder);
    //Make file in that folder
    inv = Path.Combine(dataFolder, "Inventory.txt");
    //Open the file stream (in Create mode) with access to Write in it
    FileStream outFile = new FileStream(inv,
        FileMode.Create, //replace .Create with .Append to keep old file info
        FileAccess.Write);
    //Open stream writer to write on the file ^
    StreamWriter writer = new StreamWriter(outFile);

    writer.WriteLine("This is a list of all the inventory available: ");

    while (row < invListLength)
    {
        //Write each collumn of data for the row onto the file
        writer.Write(inventoryInfo.invList[row,0] + DELIM);
        writer.Write(inventoryInfo.invList[row,1] + DELIM);
        writer.WriteLine(inventoryInfo.invList[row,2]);
        //then move onto the next row
        ++row;
    }             
    writer.Close();
    outFile.Close();

                string path = "";


                //Create Admin Folder
            path = Path.Combine(dataFolder, "AdminFiles");
            Directory.CreateDirectory(path);

                //Add File to it
            inv = Path.Combine(path, "TransactionsHistory.txt");
            outFile = new FileStream(inv,
                    FileMode.Create, 
                    FileAccess.Write);
            //Transaction History will mostly be edited in other tabs
            writer = new StreamWriter(outFile);

            writer.WriteLine("This is a list of all the users, their login info, and their transaction history: \n"
                            + "--------------------------------------------------------------------------------");

            writer.Close();
            outFile.Close();


            //Create Users folder
            path = Path.Combine(dataFolder, "UserInfo");
            Directory.CreateDirectory(path);
            //in case we pursue the optional creating accounts


}
        }

         class InventoryInfo
 {

     public string[,] invList =
     {
         {"Ground Beef", "3.00", "Health"},
         {"Ribs", "12.50", "NoDiscount"}, 
         {"Chicken Breast", "3.00", "Health"}, 
         {"Salmon", "2.50", "Health"}, 
         {"Bass", "3.25", "NoDiscount"}, 
         {"Tuna", "2.50", "Health"}, 
         {"Tri-Tip Stealk", "20.00", "NoDiscount"}, 
         {"Pork", "2.75", "NoDiscount"}, 

         {"12 Eggs", "3.25", "Health"}, 
         {"Carrots", "1.50", "Health"}, 
         {"Brocoli", "1.25", "Health"}, 
         {"Lettuce", "1.25", "Health"}, 
         {"Cabbage", "1.50", "Health"}, 
         {"Kale", "2.00", "Health"}, 
         {"Green Apple", "0.75", "Health"}, 
         {"Red Apple", "0.75", "Health"}, 
         {"Yellow Apple", "0.75", "Health"}, 
         {"Bell Pepper", "1.25", "NoDiscount"}, 
         {"Pear", "1.00", "Health"}, 
         {"Bannana", "1.00", "Health"}, 
         {"Orange", "1.25", "Health"}, 

         {"Milk Galon", "3.50", "Health"}, 
         {"Milk Half-Gallon", "2.00", "Health"}, 
         {"Cheese (Chedar)", "1.50", "NoDiscount"}, 
         {"Cheese (Mozzarella)", "1.25", "NoDiscount"}, 
         {"Yogurt", "0.75", "Health"}, 
         {"Butter", "1.50", "NoDiscount"}, 
         {"Whipped Cream", "1.00", "NoDiscount"}, 

         {"White Bread", "2.75", "NoDiscount"}, 
         {"Wheat Bread", "2.50", "Health"}, 
         {"Flour", "1.50", "NoDiscount"}, 
         {"12 Cookies", "4.75", "NoDiscount"}, 
         {"Pumpkin Pie", "6.50", "NoDiscount"}, 
         {"Apple Pie", "6.50", "NoDiscount"}, 
         {"Chocolate Cake", "15.00", "NoDiscount"}, 
         {"Birthday Cake", "16.50", "NoDiscount"}, 

         {"Large Lays Chips", "4.50", "NoDiscount"}, 
         {"Large Takis", "4.75", "NoDiscount"}, 
         {"Chip Pack (Variety)", "12.50", "NoDiscount"}, 
         {"Chocolate Bar", "1.50", "NoDiscount"}, 
         {"Loli Pop Packets", "5.00", "NoDiscount"}, 
         {"Ramen", "0.50", "NoDiscount"}, 
         {"Candy Variety Pack", "15.00", "NoDiscount"}, 

         {"12oz Coke", "3.00", "NoDiscount"}, 
         {"12oz Sprite", "3.00", "NoDiscount"}, 
         {"24 Pack Coke", "8.00", "NoDiscount"}, 
         {"24 Pack Sprite", "8.00", "NoDiscount"}, 
         {"Soda Variety Pack", "7.50", "NoDiscount"}, 
         {"12 Pack Beer", "10.00", "NoDiscount"}, 
         {"Whiskey", "14.00", "NoDiscount"}, 
         {"Champagne", "16.00", "NoDiscount"}, 
         {"24 Pack Waters", "5.00", "Health"}, 
     };


 }

        private void Tab_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }




    }
}
