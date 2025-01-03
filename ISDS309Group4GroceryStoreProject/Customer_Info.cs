using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISDS309Group4GroceryStoreProject
{
    public partial class Customer_Info : Form
    {
        public Customer_Info()
        {
            InitializeComponent();
            CalculateTotalPurchase();
        }
        //Check if each info section is valid
        public bool allInfoGood = false;
        public bool ccnCheck = false;
        public bool phoneNumberCheck = false;
        public bool secNrCheck = false;
        public string cardType = "";

        public string[] writeCustomerInfo = new string[7];



        public class Paths
        {
            public string pathToStore = Path.Combine("ProjectData", "UserInfo", "Curent User Purchase.txt");
            public string pathRead = Path.Combine("ProjectData", "Inventory.txt");
        }

        private void CalculateTotalPurchase()
        {
            string filePath = Path.Combine("ProjectData", "UserInfo", "Curent User Purchase.txt");

            if (File.Exists(filePath))
            {
                double total = 0.0;

                try
                {
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');

                        // Ensure the line contains at least two parts and trims any whitespace
                        if (parts.Length >= 2 && double.TryParse(parts[1].Trim(), out double price))
                        {
                            total += price;
                        }
                    }

                    // Update label9 with the total cost
                    label9.Text = $"Total: ${total:F2}";
                }
                catch (Exception ex)
                {
                    label9.Text = $"Error calculating total: {ex.Message}";
                }
            }
            else
            {
                label9.Text = "Purchase file not found.";
            }
        }
        private void Customer_Info_Load(object sender, EventArgs e)
        {

        }

        private void phoneNumber_TextChanged(object sender, EventArgs e)
        {
            int lenPN = phoneNumber.Text.Length;

            if (lenPN == 9 || lenPN == 10)
            {
                phoneNumberCheck = true;
                writeCustomerInfo[1] = phoneNumber.Text;
            }

        }
        private void phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Make sure only numbers can be entered
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Stop the character from being entered
            }
        }
        private void checkValidPhoneNum_Click(object sender, EventArgs e)
        {

        }
        private void email_TextChanged(object sender, EventArgs e)
        {
            writeCustomerInfo[2] = email.Text;
        }

        private void cardNumber_TextChanged(object sender, EventArgs e)
        {
            int lenCCN = cardNumber.Text.Length;

            // Determine if card number is at a valid length
            if (lenCCN == 16 || lenCCN == 15)
            {
                ccnCheck = true;
                writeCustomerInfo[4] = cardNumber.Text.Substring(cardNumber.Text.Length - 4);
            }

            // Determine what type of card is being used

            if (lenCCN == 15 && cardNumber.Text.Substring(0, 1) == "3")
            {
                cardType = "AMEX";
                writeCustomerInfo[3] = cardType + ":";
            }
            else if (lenCCN == 16)
            {
                if (cardNumber.Text.Substring(0, 1) == "4")
                {
                    cardType = "VISA";
                    writeCustomerInfo[3] = cardType + ":";
                }
                else if (cardNumber.Text.Substring(0, 1) == "5")
                {
                    cardType = "MASTER CARD";
                    writeCustomerInfo[3] = cardType + ":";
                }
                else if (cardNumber.Text.Substring(0, 1) == "6")
                {
                    cardType = "DISCOVER";
                    writeCustomerInfo[3] = cardType + ":";
                }
                else
                {
                    ccnCheck = false;
                }
            }
            else ccnCheck = false;

        }
        private void cardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Make sure only numbers can be entered
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Stop the character from being entered
            }
        }

        private void cardExpDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void cardSecurityCode_TextChanged(object sender, EventArgs e)
        {

            int lenSecNum = cardSecurityCode.Text.Length;

            if (lenSecNum == 3)
            {
                secNrCheck = true;
            }
        }
        private void cardSecurityCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Make sure only numbers can be entered
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Stop the character from being entered
            }
        }
        private void checkValidCardNum_Click(object sender, EventArgs e)
        {

        }

        private void checkValidExD8_Click(object sender, EventArgs e)
        {

        }

        private void checkValidSecCode_Click(object sender, EventArgs e)
        {
        }

        private void backToCart_Click(object sender, EventArgs e)
        {
            //Exit curent tab
            this.Hide();
            //Then open new tab
            tab_ShopingCart tab_Shoping = new tab_ShopingCart();
            //.Show = open new tab, (can alt tab to others)
            //.ShowDialog = open new tab but you can't eddit others while its open
            tab_Shoping.ShowDialog();
        }

        private void placeOrder_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (!ccnCheck)
            {
                checkValidCardNum.Text = "This is not a valid card number";
            }
            if (!phoneNumberCheck)
            {
                checkValidPhoneNum.Text = "This is not a valid phone number";
            }
            if (!secNrCheck)
            {
                checkValidSecCode.Text = "This is not a valid security number";
            }

            if (ccnCheck && phoneNumberCheck && secNrCheck)
            {
                allInfoGood = true;
            }

            if (allInfoGood)
            {
                // Set user name
                string user = "john"; // Replace with dynamic user retrieval if needed

                // Prepare file path
                string filePath = Path.Combine("ProjectData", "UserInfo", $"{user}.txt");

                // Ensure directory exists
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));

                // Get current date and time for creation timestamp
                string creationTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // Write only the specified values in a CSV format
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    string line = $"{writeCustomerInfo[1]},{writeCustomerInfo[2]},{cardType},{new string('X', cardNumber.Text.Length - 4)}{writeCustomerInfo[4]},{creationTime}";
                    writer.WriteLine(line);
                }


                this.Hide();
                Tab_Receipt tab_receipt = new Tab_Receipt();
                tab_receipt.ShowDialog();
            }
        }

        private void Customer_Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }
    }
}
