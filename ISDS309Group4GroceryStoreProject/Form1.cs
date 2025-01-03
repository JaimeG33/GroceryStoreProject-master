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

    writer.WriteLine("This is a list of all the inventory available: \n" +
        "Item, Price, Quantity in Cart");

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

                path = Path.Combine(path, "Curent User Purchase.txt");
                outFile = new FileStream(path, 
                    FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(outFile);
                writer.WriteLine("Name of Item, Price in $, Quantity in Cart");
                writer.Close() ;
                outFile.Close();


}
        }

         class InventoryInfo
 {

     public string[,] invList =
     {
         {"Ground Beef", "3.00", "0"},//0 Meat Section
         {"Ribs", "12.50", "0"}, 
         {"Chicken Breast", "3.00", "0"}, 
         {"Salmon", "2.50", "0"}, 
         {"Bass", "3.25", "0"}, 
         {"Tuna", "2.50", "0"}, 
         {"Tri-Tip Steak", "20.00", "0"}, 
         {"Pork", "2.75", "0"}, //7

         {"12 Eggs", "3.25", "0"}, //8 Produce Section
         {"Carrots", "1.50", "0"}, 
         {"Brocoli", "1.25", "0"}, 
         {"Lettuce", "1.25", "0"}, 
         {"Cabbage", "1.50", "0"}, 
         {"Kale", "2.00", "0"}, 
         {"Green Apple", "0.75", "0"}, 
         {"Red Apple", "0.75", "0"}, 
         {"Yellow Apple", "0.75", "0"}, 
         {"Bell Pepper", "1.25", "0"}, 
         {"Pear", "1.00", "0"}, 
         {"Bannana", "1.00", "0"}, 
         {"Orange", "1.25", "0"}, //20

         {"Milk Galon", "3.50", "0"}, //21 Dairy Section
         {"Milk Half-Gallon", "2.00", "0"}, 
         {"Cheese (Chedar)", "1.50", "0"}, 
         {"Cheese (Mozzarella)", "1.25", "0"}, 
         {"Yogurt", "0.75", "0"}, 
         {"Butter", "1.50", "0"}, 
         {"Whipped Cream", "1.00", "0"}, //27

         {"White Bread", "2.75", "0"}, //28 Bakery Section
         {"Wheat Bread", "2.50", "0"}, 
         {"Flour", "1.50", "0"}, 
         {"12 Cookies", "4.75", "0"}, 
         {"Pumpkin Pie", "6.50", "0"}, 
         {"Apple Pie", "6.50", "0"}, 
         {"Chocolate Cake", "15.00", "0"}, 
         {"Birthday Cake", "16.50", "0"}, //35

         {"Large Lays Chips", "4.50", "0"}, //36 Snacks Section
         {"Large Takis", "4.75", "0"}, 
         {"Chip Pack (Variety)", "12.50", "0"}, //38
         {"Chocolate Bar", "1.50", "0"}, 
         {"Loli Pop Packets", "5.00", "0"}, 
         {"Ramen", "0.50", "0"}, 
         {"Candy Variety Pack", "15.00", "0"}, //42

         {"12oz Coke", "3.00", "0"}, //43 Drinks Section
         {"12oz Sprite", "3.00", "0"}, 
         {"24 Pack Coke", "8.00", "0"}, 
         {"24 Pack Sprite", "8.00", "0"}, 
         {"Soda Variety Pack", "7.50", "0"}, 
         {"12 Pack Beer", "10.00", "0"}, 
         {"Whiskey", "14.00", "0"}, 
         {"Champagne", "16.00", "0"}, 
         {"24 Pack Waters", "5.00", "0"}, //51
     };
 }


        private void Tab_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }




    }
}
