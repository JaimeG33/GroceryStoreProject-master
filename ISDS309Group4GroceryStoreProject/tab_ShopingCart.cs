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
using static ISDS309Group4GroceryStoreProject.tab_ShopingCart;

namespace ISDS309Group4GroceryStoreProject
{
    public partial class tab_ShopingCart : Form
    {
        public tab_ShopingCart()
        {
            InitializeComponent();
        }

        private void tab_ShopingCart_Load(object sender, EventArgs e)
        {
            LoadCartItems();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tab_Home tab_Home = new Tab_Home();
            tab_Home.Show();
        }



        private void tab_ShopingCartFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void tab_ShopingCart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        public class Paths
        {
            public string pathToStore = Path.Combine("ProjectData", "UserInfo", "Curent User Purchase.txt");
            public string pathRead = Path.Combine("ProjectData", "Inventory.txt");
        }
        private void LoadCartItems()
        {
            char DELIM = ',';
            string recordIn;
            string[,] item;
            string[] selectedItem = new string[3];
            int count = 0, length;
            Paths paths = new Paths();

            //Read inventory to scan/store item info
            FileStream inFile = new FileStream(paths.pathToStore,
                FileMode.Open, FileAccess.Read);
            //Open stream reader to read the file ^
            StreamReader reader = new StreamReader(inFile);
            //Start at the top of the file
            inFile.Seek(0, SeekOrigin.Begin);
            //read 1 line of the file
            recordIn = reader.ReadLine();
            //Read the file once to set the length of the array
            while ((recordIn = reader.ReadLine()) != null)
            {
                count++;
            }
            length = count;
            item = new string[length, 3];

            //read again to input all the items
            inFile.Seek(0, SeekOrigin.Begin);
            count = 0;
            recordIn = reader.ReadLine();
            while ((recordIn = reader.ReadLine()) != null)
            {
                selectedItem = recordIn.Split(DELIM);
                item[count, 0] = selectedItem[0];//name
                item[count, 1] = selectedItem[1];//Price
                item[count, 2] = selectedItem[2];//Qunty
                count++;
            }
            count = 0;

            while (count < length)
            {
                listOfItemsInCart.Items.Add(item[count, 0]);
                listOfPricesinCart.Items.Add(Convert.ToDouble(item[count, 1]));
                listOfQuantInCart.Items.Add(Convert.ToInt32(item[count, 2]));
                ++count;
            }
            reader.Close();
            inFile.Close();
        }
        private void listOfItemsInCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listOfPricesinCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listOfQuantInCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //junk
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearCart_Click(object sender, EventArgs e)
        {
            string pathToStore = Path.Combine("ProjectData", "UserInfo", "Curent User Purchase.txt");
            string recordIn = "";
            int count = 0, length = 0;
            FileStream outFile = new FileStream(pathToStore,
                FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            writer.WriteLine("Name of Item, Price in $, Quantity in Cart");

            writer.Close();
            outFile.Close();
        }

        private void toCheckout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Info customerInfo = new Customer_Info();
            customerInfo.Show();
        }
    }
}
