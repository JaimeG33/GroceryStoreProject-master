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
    public partial class Tab_Drinks : Form
    {
        public Tab_Drinks()
        {
            InitializeComponent();
        }

        private void Tab_Drinks_Load(object sender, EventArgs e)
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

        }

        private void Tab_Drinks_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
