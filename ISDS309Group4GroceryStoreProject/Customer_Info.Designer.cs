namespace ISDS309Group4GroceryStoreProject
{
    partial class Customer_Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            phoneNumber = new TextBox();
            email = new TextBox();
            cardNumber = new TextBox();
            cardExpDate = new TextBox();
            cardSecurityCode = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            checkValidCardNum = new Label();
            checkValidExD8 = new Label();
            checkValidSecCode = new Label();
            backToCart = new Button();
            placeOrder = new Button();
            checkValidPhoneNum = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // phoneNumber
            // 
            phoneNumber.Location = new Point(530, 183);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(144, 23);
            phoneNumber.TabIndex = 1;
            phoneNumber.TextChanged += phoneNumber_TextChanged;
            phoneNumber.KeyPress += phoneNumber_KeyPress;
            // 
            // email
            // 
            email.Location = new Point(530, 212);
            email.Name = "email";
            email.Size = new Size(144, 23);
            email.TabIndex = 2;
            email.TextChanged += email_TextChanged;
            // 
            // cardNumber
            // 
            cardNumber.Location = new Point(530, 312);
            cardNumber.Name = "cardNumber";
            cardNumber.Size = new Size(144, 23);
            cardNumber.TabIndex = 3;
            cardNumber.TextChanged += cardNumber_TextChanged;
            cardNumber.KeyPress += cardNumber_KeyPress;
            // 
            // cardExpDate
            // 
            cardExpDate.Location = new Point(530, 341);
            cardExpDate.Name = "cardExpDate";
            cardExpDate.Size = new Size(144, 23);
            cardExpDate.TabIndex = 4;
            cardExpDate.TextChanged += cardExpDate_TextChanged;
            // 
            // cardSecurityCode
            // 
            cardSecurityCode.Location = new Point(530, 370);
            cardSecurityCode.Name = "cardSecurityCode";
            cardSecurityCode.Size = new Size(144, 23);
            cardSecurityCode.TabIndex = 5;
            cardSecurityCode.TextChanged += cardSecurityCode_TextChanged;
            cardSecurityCode.KeyPress += cardSecurityCode_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(529, 157);
            label1.Name = "label1";
            label1.Size = new Size(165, 21);
            label1.TabIndex = 5;
            label1.Text = "Contact Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(530, 288);
            label2.Name = "label2";
            label2.Size = new Size(142, 21);
            label2.TabIndex = 6;
            label2.Text = "Payment Method";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(433, 186);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 7;
            label3.Text = "Phone Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(485, 215);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 8;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(442, 315);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 9;
            label5.Text = "Card Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(433, 344);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 10;
            label6.Text = "Expiration Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(442, 373);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 11;
            label7.Text = "Security Code:";
            // 
            // checkValidCardNum
            // 
            checkValidCardNum.AutoSize = true;
            checkValidCardNum.Location = new Point(680, 315);
            checkValidCardNum.Name = "checkValidCardNum";
            checkValidCardNum.Size = new Size(0, 15);
            checkValidCardNum.TabIndex = 12;
            checkValidCardNum.Click += checkValidCardNum_Click;
            // 
            // checkValidExD8
            // 
            checkValidExD8.AutoSize = true;
            checkValidExD8.Location = new Point(680, 344);
            checkValidExD8.Name = "checkValidExD8";
            checkValidExD8.Size = new Size(0, 15);
            checkValidExD8.TabIndex = 13;
            checkValidExD8.Click += checkValidExD8_Click;
            // 
            // checkValidSecCode
            // 
            checkValidSecCode.AutoSize = true;
            checkValidSecCode.Location = new Point(680, 373);
            checkValidSecCode.Name = "checkValidSecCode";
            checkValidSecCode.Size = new Size(0, 15);
            checkValidSecCode.TabIndex = 14;
            checkValidSecCode.Click += checkValidSecCode_Click;
            // 
            // backToCart
            // 
            backToCart.BackColor = Color.DarkOrange;
            backToCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backToCart.Location = new Point(28, 22);
            backToCart.Name = "backToCart";
            backToCart.Size = new Size(94, 51);
            backToCart.TabIndex = 7;
            backToCart.Text = "Back to Cart";
            backToCart.UseVisualStyleBackColor = false;
            backToCart.Click += backToCart_Click;
            // 
            // placeOrder
            // 
            placeOrder.BackColor = Color.YellowGreen;
            placeOrder.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            placeOrder.ForeColor = SystemColors.ControlText;
            placeOrder.Location = new Point(786, 356);
            placeOrder.Name = "placeOrder";
            placeOrder.Size = new Size(144, 40);
            placeOrder.TabIndex = 6;
            placeOrder.Text = "PAY ORDER";
            placeOrder.UseVisualStyleBackColor = false;
            placeOrder.Click += placeOrder_Click;
            // 
            // checkValidPhoneNum
            // 
            checkValidPhoneNum.AutoSize = true;
            checkValidPhoneNum.Location = new Point(681, 186);
            checkValidPhoneNum.Name = "checkValidPhoneNum";
            checkValidPhoneNum.Size = new Size(0, 15);
            checkValidPhoneNum.TabIndex = 17;
            checkValidPhoneNum.Click += checkValidPhoneNum_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.blackmesagrocerylogo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(464, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 102);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(786, 288);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 19;
            label8.Text = "Subtotal: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(849, 288);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 20;
            label9.Click += label9_Click;
            // 
            // Customer_Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 607);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(checkValidPhoneNum);
            Controls.Add(placeOrder);
            Controls.Add(backToCart);
            Controls.Add(checkValidSecCode);
            Controls.Add(checkValidExD8);
            Controls.Add(checkValidCardNum);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cardSecurityCode);
            Controls.Add(cardExpDate);
            Controls.Add(cardNumber);
            Controls.Add(email);
            Controls.Add(phoneNumber);
            MaximumSize = new Size(1208, 646);
            MinimumSize = new Size(1208, 646);
            Name = "Customer_Info";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Information";
            FormClosed += Customer_Info_FormClosed;
            Load += Customer_Info_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox phoneNumber;
        private TextBox email;
        private TextBox cardNumber;
        private TextBox cardExpDate;
        private TextBox cardSecurityCode;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label checkValidCardNum;
        private Label checkValidExD8;
        private Label checkValidSecCode;
        private Button backToCart;
        private Button placeOrder;
        private Label checkValidPhoneNum;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label9;
    }
}