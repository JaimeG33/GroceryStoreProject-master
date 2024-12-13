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
    public partial class Tab_Admin : Form
    {
        public Tab_Admin()
        {
            InitializeComponent();
        }

        private void Tab_Admin_Load(object sender, EventArgs e)
        {

        }

        private void Tab_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            //When you hit the X on the top right to close the form:
            Application.Exit();
            //For some reason, it leaves the application open unless,
            //you close it from Form1 (login tab)

        }



    }
}
