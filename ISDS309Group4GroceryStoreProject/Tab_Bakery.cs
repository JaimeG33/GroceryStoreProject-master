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
    public partial class Tab_Bakery : Form
    {
        public Tab_Bakery()
        {
            InitializeComponent();
        }

        private void Tab_Bakery_Load(object sender, EventArgs e)
        {

        }

        private void tabMeat_Click(object sender, EventArgs e)
        {//When clicked...
            //Exit curent tab to then,
            this.Hide();

            Tab_Meat tabMeat = new Tab_Meat();
            //.Show = open new tab, (can alt tab to others)
            //.ShowDialog = open new tab but you can't edit others while its open

            //Go to new selected tab
            tabMeat.ShowDialog();
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

        private void Tab_Bakery_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tab_Home tab_Home = new Tab_Home();
            tab_Home.ShowDialog();
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
    }
}
