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
            string filePath = "ProjectData/UserInfo/Curent User Purchase.txt"; // Relative path

            // Set up the ListView for Details view
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            // Clear existing items and columns
            listView1.Columns.Clear();
            listView1.Items.Clear();

            // Define the columns without headers
            listView1.Columns.Add("", 200);  // Empty header for the first column
            listView1.Columns.Add("", 100);  // Empty header for the second column
            listView1.Columns.Add("", 150);  // Empty header for the third column

            if (File.Exists(filePath)) // Check if the file exists
            {
                // Open the file with StreamReader
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split the line into parts
                        string[] parts = line.Split(',');

                        if (parts.Length == 3) // Process lines with exactly 3 parts
                        {
                            ListViewItem item = new ListViewItem(parts[0].Trim()); // Add Name of Item
                            item.SubItems.Add(parts[1].Trim()); // Add Price
                            item.SubItems.Add(parts[2].Trim()); // Add Quantity
                            listView1.Items.Add(item); // Add the item to the ListView
                        }
                    }
                } // StreamReader is automatically closed here
            }
            else
            {
                // If the file does not exist, show a single error message
                listView1.Items.Add(new ListViewItem("File not found."));
            }
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
