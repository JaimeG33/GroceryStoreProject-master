using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ISDS309Group4GroceryStoreProject
{
    public partial class Tab_Receipt : Form
    {
        public Tab_Receipt()
        {
            InitializeComponent();

            // Ensure GenerateAndDisplayReceipt runs when the form is loaded
            this.Load += Tab_Receipt_Load;
        }

        private void lblReceipt_Click(object sender, EventArgs e)
        {
            // Optional: Leave this empty if no click event is needed
        }

        private void Tab_Receipt_Load(object sender, EventArgs e)
        {
            // Generate and display the receipt as soon as the form loads
            GenerateAndDisplayReceipt();
        }

        public class Paths
        {
            public string purchaseFilePath = Path.Combine("ProjectData", "UserInfo", "Curent User Purchase.txt");
            public string userFilePath = Path.Combine("ProjectData", "UserInfo", "john.txt"); // Static user file
        }

        private void GenerateAndDisplayReceipt()
        {
            Paths paths = new Paths();

            if (File.Exists(paths.purchaseFilePath) && File.Exists(paths.userFilePath))
            {
                // Read purchase and user data
                string[] purchaseLines = File.ReadAllLines(paths.purchaseFilePath);
                string userData = File.ReadAllText(paths.userFilePath);

                // Build and display the receipt
                lblReceipt.Text = GenerateReceipt(purchaseLines, userData);

                // Refresh the label to ensure updates are visible
                lblReceipt.Refresh();
            }
            else
            {
                lblReceipt.Text = "Error: Required files not found!";
                lblReceipt.Refresh();
            }
        }

        private string GenerateReceipt(string[] lines, string userData)
        {
            // Extract user data
            string[] userDetails = userData.Split(',');
            string phoneNumber = userDetails[0].Trim();
            string email = userDetails[1].Trim();
            string cardType = userDetails[2].Trim();
            string cardMasked = userDetails[3].Trim();
            string purchaseDate = userDetails[4].Trim();

            System.Text.StringBuilder receiptBuilder = new System.Text.StringBuilder();

            // Header with user data
            receiptBuilder.AppendLine("******* Black Mesa Grocery *******");
            receiptBuilder.AppendLine("       THANK YOU FOR SHOPPING     ");
            receiptBuilder.AppendLine("----------------------------------");
            receiptBuilder.AppendLine($"Date: {purchaseDate}");
            receiptBuilder.AppendLine($"Phone: {phoneNumber}");
            receiptBuilder.AppendLine($"Email: {email}");
            receiptBuilder.AppendLine($"Payment: {cardType} ({cardMasked})");
            receiptBuilder.AppendLine("----------------------------------");

            double total = 0;

            // Use a dictionary to remove duplicates and sum quantities
            var itemSummary = new Dictionary<string, (double price, int quantity)>();

            // Start loop at 1 to skip the header line
            for (int i = 1; i < lines.Length; i++)
            {
                string[] details = lines[i].Split(',');

                // Ensure each line has exactly 3 parts
                if (details.Length == 3)
                {
                    string itemName = details[0].Trim();
                    if (!double.TryParse(details[1].Trim(), out double price))
                        continue;

                    if (!int.TryParse(details[2].Trim(), out int quantity))
                        continue;

                    // Add or update the item in the dictionary
                    if (itemSummary.ContainsKey(itemName))
                    {
                        var existing = itemSummary[itemName];
                        itemSummary[itemName] = (existing.price, existing.quantity + quantity);
                    }
                    else
                    {
                        itemSummary[itemName] = (price, quantity);
                    }
                }
            }

            // Format the receipt
            int receiptWidth = 38; // Total width of the receipt for alignment
            foreach (var item in itemSummary)
            {
                string itemName = item.Key;
                double price = item.Value.price;
                int quantity = item.Value.quantity;
                double itemTotal = price * quantity;
                total += itemTotal;

                // Format the item line: align price and quantity to the right
                string itemLine = $"{itemName} x{quantity}";
                string priceLine = $"{price.ToString("0.00")}";
                receiptBuilder.AppendLine(itemLine.PadRight(receiptWidth - priceLine.Length) + priceLine);
            }

            // Add total and footer
            string totalLine = $"TOTAL:";
            string totalAmount = total.ToString("0.00");
            receiptBuilder.AppendLine("----------------------------------");
            receiptBuilder.AppendLine(totalLine.PadRight(receiptWidth - totalAmount.Length) + totalAmount);
            receiptBuilder.AppendLine("**********************************");
            receiptBuilder.AppendLine("       Visit Black Mesa Again!     ");
            receiptBuilder.AppendLine("**********************************");

            return receiptBuilder.ToString();
        }

        private void Tab_Receipt_Load_1(object sender, EventArgs e)
        {

        }

        private void Tab_Receipt_FormClosed(object sender, FormClosedEventArgs e)
        {
            //When you hit the X on the top right to close the form:
            Application.Exit();
            //For some reason, it leaves the application open unless,
            //you close it from Form1 (login tab)
        }
    }
}