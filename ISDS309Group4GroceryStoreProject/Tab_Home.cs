using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISDS309Group4GroceryStoreProject
{
    public partial class Tab_Home : Form
    {
        public Tab_Home()
        {
            InitializeComponent();
        }


        private void Tab_Home_Load(object sender, EventArgs e)
        {
           
            
        }

        private void tabMeat_Click(object sender, EventArgs e)
        {//When clicked...
            //Exit curent tab to then,
            this.Hide();

            Tab_Meat tabMeat = new Tab_Meat();
            //.Show = open new tab, (can alt tab to others)
            //.ShowDialog = open new tab but you can't eddit others while its open

            //Go to new selected tab
            tabMeat.ShowDialog();
        }

        private void tabProduce_Click(object sender, EventArgs e)
        {//When clicked....
            this.Hide();
            Tab_Produce tabProduce = new Tab_Produce();
            tabProduce.ShowDialog();
        }

        private void tabBakery_Click(object sender, EventArgs e)
        {//You get the idea...
            this.Hide();
            Tab_Bakery tabBake = new Tab_Bakery();
            tabBake.ShowDialog();
        }

        private void tabSnacks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tab_Snacks tabSnack = new Tab_Snacks();
            tabSnack.ShowDialog();
        }
        private void tabDrinks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tab_Drinks tabDrinks = new Tab_Drinks();
            tabDrinks.ShowDialog();
        }

        private void tabDairy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tab_Dairy tabDairy = new Tab_Dairy();
            tabDairy.ShowDialog();
        }
        private void Tab_Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            //When you hit the X on the top right to close the form:
            Application.Exit();
            //For some reason, it leaves the application open unless,
            //you close it from Form1 (login tab)

        }


        private void Tab_Home_Resize(object sender, EventArgs e)
        {

        }

        private void shopingCart_Click(object sender, EventArgs e)
        {
            //Exit curent tab
            this.Hide();
            //Then open new tab
            tab_ShopingCart tab_Shoping = new tab_ShopingCart();
            //.Show = open new tab, (can alt tab to others)
            //.ShowDialog = open new tab but you can't eddit others while its open
            tab_Shoping.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tab_Home tab_Home = new Tab_Home();
            tab_Home.ShowDialog();
            this.Close();
        }

        //Shopping Cart Section
        public class InShoppingCart
        {
            public string[] addToShopCart = new string[3];
            public int quantity = 1, totalQuantity = 0;
        }
        public class Paths
        {
            public string pathToStore = Path.Combine("ProjectData", "UserInfo", "Curent User Purchase.txt");
            public string pathRead = Path.Combine("ProjectData", "Inventory.txt");
        }
        private void addToCartTest_Click(object sender, EventArgs e)
        {
            string recordIn, item = "Chip Pack (Variety),12.50,0";
            char DELIM = ',';
            
            Paths paths = new Paths();
            InShoppingCart inShoppingCart = new InShoppingCart();

            //Read inventory to scan/store item info
            FileStream inFile = new FileStream(paths.pathRead,
                FileMode.Open, FileAccess.Read);
            //Open stream reader to read the file ^
            StreamReader reader = new StreamReader(inFile);
            //Start at the top of the file
            inFile.Seek(0, SeekOrigin.Begin);
            //read 1 line of the file
            recordIn = reader.ReadLine();
            //keep reading until file is done
            while (recordIn != null)
            {
                //record info when match is found
                if (recordIn == item)//replace this part for each button
                {
                    string[] fields = recordIn.Split(DELIM);
                    inShoppingCart.addToShopCart[0] = fields[0];
                    inShoppingCart.addToShopCart[1] = fields[1];
                    inShoppingCart.addToShopCart[2] = Convert.ToString(inShoppingCart.quantity);
                }
                recordIn = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();
            inShoppingCart.quantity = 1;          

                //now record everything on the Curent User Purchase file
                FileStream outFile = new FileStream(paths.pathToStore,
                FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
                // Write all items added to the cart
                writer.WriteLine("{0},{1},{2}",
                    inShoppingCart.addToShopCart[0],
                    inShoppingCart.addToShopCart[1],
                    inShoppingCart.addToShopCart[2]);

            writer.Close();
            outFile.Close();
        }

        private void btnSodaVar_Click(object sender, EventArgs e)
        {
            string recordIn, item = "Soda Variety Pack,7.50,0";
            char DELIM = ',';

            Paths paths = new Paths();
            InShoppingCart inShoppingCart = new InShoppingCart();

            //Read inventory to scan/store item info
            FileStream inFile = new FileStream(paths.pathRead,
                FileMode.Open, FileAccess.Read);
            //Open stream reader to read the file ^
            StreamReader reader = new StreamReader(inFile);
            //Start at the top of the file
            inFile.Seek(0, SeekOrigin.Begin);
            //read 1 line of the file
            recordIn = reader.ReadLine();
            //keep reading until file is done
            while (recordIn != null)
            {
                //record info when match is found
                if (recordIn == item)//replace this part for each button
                {
                    string[] fields = recordIn.Split(DELIM);
                    inShoppingCart.addToShopCart[0] = fields[0];
                    inShoppingCart.addToShopCart[1] = fields[1];
                    inShoppingCart.addToShopCart[2] = Convert.ToString(inShoppingCart.quantity);
                }
                recordIn = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();
            inShoppingCart.quantity = 1;

            //now record everything on the Curent User Purchase file
            FileStream outFile = new FileStream(paths.pathToStore,
            FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            // Write all items added to the cart
            writer.WriteLine("{0},{1},{2}",
                inShoppingCart.addToShopCart[0],
                inShoppingCart.addToShopCart[1],
                inShoppingCart.addToShopCart[2]);

            writer.Close();
            outFile.Close();
        }

        private void btnCarrots_Click(object sender, EventArgs e)
        {
            string recordIn, item = "Carrots,1.50,0";
            char DELIM = ',';

            Paths paths = new Paths();
            InShoppingCart inShoppingCart = new InShoppingCart();

            //Read inventory to scan/store item info
            FileStream inFile = new FileStream(paths.pathRead,
                FileMode.Open, FileAccess.Read);
            //Open stream reader to read the file ^
            StreamReader reader = new StreamReader(inFile);
            //Start at the top of the file
            inFile.Seek(0, SeekOrigin.Begin);
            //read 1 line of the file
            recordIn = reader.ReadLine();
            //keep reading until file is done
            while (recordIn != null)
            {
                //record info when match is found
                if (recordIn == item)//replace this part for each button
                {
                    string[] fields = recordIn.Split(DELIM);
                    inShoppingCart.addToShopCart[0] = fields[0];
                    inShoppingCart.addToShopCart[1] = fields[1];
                    inShoppingCart.addToShopCart[2] = Convert.ToString(inShoppingCart.quantity);
                }
                recordIn = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();
            inShoppingCart.quantity = 1;

            //now record everything on the Curent User Purchase file
            FileStream outFile = new FileStream(paths.pathToStore,
            FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            // Write all items added to the cart
            writer.WriteLine("{0},{1},{2}",
                inShoppingCart.addToShopCart[0],
                inShoppingCart.addToShopCart[1],
                inShoppingCart.addToShopCart[2]);

            writer.Close();
            outFile.Close();
        }

        private void btnCandyVar_Click(object sender, EventArgs e)
        {
            string recordIn, item = "Candy Variety Pack,15.00,0";
            char DELIM = ',';

            Paths paths = new Paths();
            InShoppingCart inShoppingCart = new InShoppingCart();

            //Read inventory to scan/store item info
            FileStream inFile = new FileStream(paths.pathRead,
                FileMode.Open, FileAccess.Read);
            //Open stream reader to read the file ^
            StreamReader reader = new StreamReader(inFile);
            //Start at the top of the file
            inFile.Seek(0, SeekOrigin.Begin);
            //read 1 line of the file
            recordIn = reader.ReadLine();
            //keep reading until file is done
            while (recordIn != null)
            {
                //record info when match is found
                if (recordIn == item)//replace this part for each button
                {
                    string[] fields = recordIn.Split(DELIM);
                    inShoppingCart.addToShopCart[0] = fields[0];
                    inShoppingCart.addToShopCart[1] = fields[1];
                    inShoppingCart.addToShopCart[2] = Convert.ToString(inShoppingCart.quantity);
                }
                recordIn = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();
            inShoppingCart.quantity = 1;

            //now record everything on the Curent User Purchase file
            FileStream outFile = new FileStream(paths.pathToStore,
            FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            // Write all items added to the cart
            writer.WriteLine("{0},{1},{2}",
                inShoppingCart.addToShopCart[0],
                inShoppingCart.addToShopCart[1],
                inShoppingCart.addToShopCart[2]);

            writer.Close();
            outFile.Close();
        }

        private void btnMilkG_Click(object sender, EventArgs e)
        {
            string recordIn, item = "Milk Galon,3.50,0";
            char DELIM = ',';

            Paths paths = new Paths();
            InShoppingCart inShoppingCart = new InShoppingCart();

            //Read inventory to scan/store item info
            FileStream inFile = new FileStream(paths.pathRead,
                FileMode.Open, FileAccess.Read);
            //Open stream reader to read the file ^
            StreamReader reader = new StreamReader(inFile);
            //Start at the top of the file
            inFile.Seek(0, SeekOrigin.Begin);
            //read 1 line of the file
            recordIn = reader.ReadLine();
            //keep reading until file is done
            while (recordIn != null)
            {
                //record info when match is found
                if (recordIn == item)//replace this part for each button
                {
                    string[] fields = recordIn.Split(DELIM);
                    inShoppingCart.addToShopCart[0] = fields[0];
                    inShoppingCart.addToShopCart[1] = fields[1];
                    inShoppingCart.addToShopCart[2] = Convert.ToString(inShoppingCart.quantity);
                }
                recordIn = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();
            inShoppingCart.quantity = 1;

            //now record everything on the Curent User Purchase file
            FileStream outFile = new FileStream(paths.pathToStore,
            FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            // Write all items added to the cart
            writer.WriteLine("{0},{1},{2}",
                inShoppingCart.addToShopCart[0],
                inShoppingCart.addToShopCart[1],
                inShoppingCart.addToShopCart[2]);

            writer.Close();
            outFile.Close();
        }
        private void btnWhiskey_Click(object sender, EventArgs e)
        {
            string recordIn, item = "Whiskey,14.00,0";
            char DELIM = ',';

            Paths paths = new Paths();
            InShoppingCart inShoppingCart = new InShoppingCart();

            //Read inventory to scan/store item info
            FileStream inFile = new FileStream(paths.pathRead,
                FileMode.Open, FileAccess.Read);
            //Open stream reader to read the file ^
            StreamReader reader = new StreamReader(inFile);
            //Start at the top of the file
            inFile.Seek(0, SeekOrigin.Begin);
            //read 1 line of the file
            recordIn = reader.ReadLine();
            //keep reading until file is done
            while (recordIn != null)
            {
                //record info when match is found
                if (recordIn == item)//replace this part for each button
                {
                    string[] fields = recordIn.Split(DELIM);
                    inShoppingCart.addToShopCart[0] = fields[0];
                    inShoppingCart.addToShopCart[1] = fields[1];
                    inShoppingCart.addToShopCart[2] = Convert.ToString(inShoppingCart.quantity);
                }
                recordIn = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();
            inShoppingCart.quantity = 1;

            //now record everything on the Curent User Purchase file
            FileStream outFile = new FileStream(paths.pathToStore,
            FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            // Write all items added to the cart
            writer.WriteLine("{0},{1},{2}",
                inShoppingCart.addToShopCart[0],
                inShoppingCart.addToShopCart[1],
                inShoppingCart.addToShopCart[2]);

            writer.Close();
            outFile.Close();
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            string recordIn, item = "Coffee,5.50,0";
            char DELIM = ',';

            Paths paths = new Paths();
            InShoppingCart inShoppingCart = new InShoppingCart();

            //Read inventory to scan/store item info
            FileStream inFile = new FileStream(paths.pathRead,
                FileMode.Open, FileAccess.Read);
            //Open stream reader to read the file ^
            StreamReader reader = new StreamReader(inFile);
            //Start at the top of the file
            inFile.Seek(0, SeekOrigin.Begin);
            //read 1 line of the file
            recordIn = reader.ReadLine();
            //keep reading until file is done
            while (recordIn != null)
            {
                //record info when match is found
                if (recordIn == item)//replace this part for each button
                {
                    string[] fields = recordIn.Split(DELIM);
                    inShoppingCart.addToShopCart[0] = fields[0];
                    inShoppingCart.addToShopCart[1] = fields[1];
                    inShoppingCart.addToShopCart[2] = Convert.ToString(inShoppingCart.quantity);
                }
                recordIn = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();
            inShoppingCart.quantity = 1;

            //now record everything on the Curent User Purchase file
            FileStream outFile = new FileStream(paths.pathToStore,
            FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            // Write all items added to the cart
            writer.WriteLine("{0},{1},{2}",
                inShoppingCart.addToShopCart[0],
                inShoppingCart.addToShopCart[1],
                inShoppingCart.addToShopCart[2]);

            writer.Close();
            outFile.Close();
        }

        private void btnBeefTri_Click(object sender, EventArgs e)
        {//This is what I pasted (jaime)
    string recordIn, item = "Tri-Tip Stealk,20.00,0";
    char DELIM = ',';

    Paths paths = new Paths();
    InShoppingCart inShoppingCart = new InShoppingCart();

    //Read inventory to scan/store item info
    FileStream inFile = new FileStream(paths.pathRead,
        FileMode.Open, FileAccess.Read);
    //Open stream reader to read the file ^
    StreamReader reader = new StreamReader(inFile);
    //Start at the top of the file
    inFile.Seek(0, SeekOrigin.Begin);
    //read 1 line of the file
    recordIn = reader.ReadLine();
    //keep reading until file is done
    while (recordIn != null)
    {
        //record info when match is found
        if (recordIn == item)//replace this part for each button
        {
            string[] fields = recordIn.Split(DELIM);
            inShoppingCart.addToShopCart[0] = fields[0];
            inShoppingCart.addToShopCart[1] = fields[1];
            inShoppingCart.addToShopCart[2] = Convert.ToString(inShoppingCart.quantity);
        }
        recordIn = reader.ReadLine();
    }
    reader.Close();
    inFile.Close();
    inShoppingCart.quantity = 1;

    //now record everything on the Curent User Purchase file
    FileStream outFile = new FileStream(paths.pathToStore,
    FileMode.Append, FileAccess.Write);
    StreamWriter writer = new StreamWriter(outFile);
    // Write all items added to the cart
    writer.WriteLine("{0},{1},{2}",
        inShoppingCart.addToShopCart[0],
        inShoppingCart.addToShopCart[1],
        inShoppingCart.addToShopCart[2]);

    writer.Close();
    outFile.Close();
}//End of Jaime's section
        private void amountToCartTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Make sure only numbers can be entered
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Stop the character from being entered
            }
        }
    }
}
