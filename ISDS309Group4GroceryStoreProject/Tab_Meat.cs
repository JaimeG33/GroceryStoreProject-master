using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ISDS309Group4GroceryStoreProject.Tab_Home;

namespace ISDS309Group4GroceryStoreProject
{
    public partial class Tab_Meat : Form
    {
        public Tab_Meat()
        {
            InitializeComponent();
        }

        private void Tab_Meat_Load(object sender, EventArgs e)
        {

        }

        private void tabMeat_Click(object sender, EventArgs e)
        {

        }

        private void tabProduce_Click(object sender, EventArgs e)
        {//When clicked....
            this.Hide();
            Tab_Produce tabProduce = new Tab_Produce();
            tabProduce.ShowDialog();
        }

        private void tabDairy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tab_Dairy tabDairy = new Tab_Dairy();
            tabDairy.ShowDialog();
        }

        private void tabBakery_Click(object sender, EventArgs e)
        {
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

        private void shopingCart_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tab_Home tab_Home = new Tab_Home();
            tab_Home.ShowDialog();
        }

        private void shopingCart_Click_1(object sender, EventArgs e)
        {
            //Exit curent tab
            this.Hide();
            //Then open new tab
            tab_ShopingCart tab_Shoping = new tab_ShopingCart();
            //.Show = open new tab, (can alt tab to others)
            //.ShowDialog = open new tab but you can't eddit others while its open
            tab_Shoping.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSteak_Click(object sender, EventArgs e)
        {
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
        }

        private void btnChicken_Click(object sender, EventArgs e)
        {
            string recordIn, item = "Chicken Breast,3.00,0";
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

        private void btnGBeef_Click(object sender, EventArgs e)
        {
            string recordIn, item = "Ground Beef,3.00,0";
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

        private void btnPork_Click(object sender, EventArgs e)
        {
            string recordIn, item = "Pork,2.75,0";
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

        private void btnRibs_Click(object sender, EventArgs e)
        {
            string recordIn, item = "Ribs,12.50,0";
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

        private void btnSalmon_Click(object sender, EventArgs e)
        {
            string recordIn, item = "Salmon,2.50,0";
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
        private void Tab_Meat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



    }
}
