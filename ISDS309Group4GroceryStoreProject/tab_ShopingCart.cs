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
    public partial class tab_ShopingCart : Form
    {
        public tab_ShopingCart()
        {
            InitializeComponent();
        }

        private void tab_ShopingCart_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tab_Home tab_Home = new Tab_Home();
            tab_Home.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tab_ShopingCartFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
