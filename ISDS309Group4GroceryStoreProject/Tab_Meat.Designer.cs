namespace ISDS309Group4GroceryStoreProject
{
    partial class Tab_Meat
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
            tabDrinks = new Button();
            tabSnacks = new Button();
            tabBakery = new Button();
            tabDairy = new Button();
            tabProduce = new Button();
            tabMeat = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            shopingCart = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabDrinks
            // 
            tabDrinks.Cursor = Cursors.Hand;
            tabDrinks.Location = new Point(1040, 121);
            tabDrinks.Name = "tabDrinks";
            tabDrinks.Size = new Size(125, 25);
            tabDrinks.TabIndex = 7;
            tabDrinks.Text = "Drinks";
            tabDrinks.UseVisualStyleBackColor = true;
            tabDrinks.Click += tabDrinks_Click;
            // 
            // tabSnacks
            // 
            tabSnacks.Cursor = Cursors.Hand;
            tabSnacks.Location = new Point(838, 121);
            tabSnacks.Name = "tabSnacks";
            tabSnacks.Size = new Size(125, 25);
            tabSnacks.TabIndex = 6;
            tabSnacks.Text = "Snacks and Candy";
            tabSnacks.UseVisualStyleBackColor = true;
            tabSnacks.Click += tabSnacks_Click;
            // 
            // tabBakery
            // 
            tabBakery.Cursor = Cursors.Hand;
            tabBakery.Location = new Point(638, 121);
            tabBakery.Name = "tabBakery";
            tabBakery.Size = new Size(125, 25);
            tabBakery.TabIndex = 5;
            tabBakery.Text = "Bakery";
            tabBakery.UseVisualStyleBackColor = true;
            tabBakery.Click += tabBakery_Click;
            // 
            // tabDairy
            // 
            tabDairy.Cursor = Cursors.Hand;
            tabDairy.Location = new Point(426, 121);
            tabDairy.Name = "tabDairy";
            tabDairy.Size = new Size(125, 25);
            tabDairy.TabIndex = 4;
            tabDairy.Text = "Dairy";
            tabDairy.UseVisualStyleBackColor = true;
            tabDairy.Click += tabDairy_Click;
            // 
            // tabProduce
            // 
            tabProduce.Cursor = Cursors.Hand;
            tabProduce.Location = new Point(229, 121);
            tabProduce.Name = "tabProduce";
            tabProduce.Size = new Size(125, 25);
            tabProduce.TabIndex = 3;
            tabProduce.Text = "Produce";
            tabProduce.UseVisualStyleBackColor = true;
            tabProduce.Click += tabProduce_Click;
            // 
            // tabMeat
            // 
            tabMeat.Cursor = Cursors.Hand;
            tabMeat.Location = new Point(24, 121);
            tabMeat.Name = "tabMeat";
            tabMeat.Size = new Size(125, 25);
            tabMeat.TabIndex = 2;
            tabMeat.Text = "Meat";
            tabMeat.UseVisualStyleBackColor = true;
            tabMeat.Click += tabMeat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.blankpage;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1196, 656);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.BackgroundImage = Properties.Resources.blackmesagrocerylogo;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(24, 4);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(280, 99);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // shopingCart
            // 
            shopingCart.BackgroundImage = Properties.Resources.shopping_cart;
            shopingCart.BackgroundImageLayout = ImageLayout.Stretch;
            shopingCart.Cursor = Cursors.Hand;
            shopingCart.Location = new Point(1092, 12);
            shopingCart.Name = "shopingCart";
            shopingCart.Size = new Size(88, 75);
            shopingCart.TabIndex = 8;
            shopingCart.UseVisualStyleBackColor = true;
            shopingCart.Click += shopingCart_Click_1;
            // 
            // Tab_Meat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1192, 653);
            Controls.Add(shopingCart);
            Controls.Add(button1);
            Controls.Add(tabDrinks);
            Controls.Add(tabSnacks);
            Controls.Add(tabBakery);
            Controls.Add(tabDairy);
            Controls.Add(tabProduce);
            Controls.Add(tabMeat);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(1208, 692);
            MinimumSize = new Size(1208, 692);
            Name = "Tab_Meat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Meat";
            FormClosed += Tab_Meat_FormClosed;
            Load += Tab_Meat_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button tabDrinks;
        private Button tabSnacks;
        private Button tabBakery;
        private Button tabDairy;
        private Button tabProduce;
        private Button tabMeat;
        private PictureBox pictureBox1;
        private Button button1;
        private Button shopingCart;
    }
}