namespace ISDS309Group4GroceryStoreProject
{
    partial class Tab_Home
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
            tabMeat = new Button();
            shopingCart = new Button();
            tabProduce = new Button();
            tabDairy = new Button();
            tabDrinks = new Button();
            tabSnacks = new Button();
            tabBakery = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // tabMeat
            // 
            tabMeat.AutoSize = true;
            tabMeat.Cursor = Cursors.Hand;
            tabMeat.Location = new Point(24, 119);
            tabMeat.MaximumSize = new Size(175, 45);
            tabMeat.Name = "tabMeat";
            tabMeat.Size = new Size(125, 25);
            tabMeat.TabIndex = 2;
            tabMeat.Text = "Meat";
            tabMeat.UseVisualStyleBackColor = true;
            tabMeat.Click += tabMeat_Click;
            // 
            // shopingCart
            // 
            shopingCart.BackgroundImage = Properties.Resources.shopping_cart;
            shopingCart.BackgroundImageLayout = ImageLayout.Stretch;
            shopingCart.Cursor = Cursors.Hand;
            shopingCart.Location = new Point(1092, 9);
            shopingCart.Name = "shopingCart";
            shopingCart.Size = new Size(88, 75);
            shopingCart.TabIndex = 8;
            shopingCart.UseVisualStyleBackColor = true;
            shopingCart.Click += shopingCart_Click;
            // 
            // tabProduce
            // 
            tabProduce.AutoSize = true;
            tabProduce.Cursor = Cursors.Hand;
            tabProduce.Location = new Point(224, 119);
            tabProduce.Name = "tabProduce";
            tabProduce.Size = new Size(125, 25);
            tabProduce.TabIndex = 3;
            tabProduce.Text = "Produce";
            tabProduce.UseVisualStyleBackColor = true;
            tabProduce.Click += tabProduce_Click;
            // 
            // tabDairy
            // 
            tabDairy.AutoSize = true;
            tabDairy.Cursor = Cursors.Hand;
            tabDairy.Location = new Point(424, 119);
            tabDairy.Name = "tabDairy";
            tabDairy.Size = new Size(125, 25);
            tabDairy.TabIndex = 4;
            tabDairy.Text = "Dairy";
            tabDairy.UseVisualStyleBackColor = true;
            tabDairy.Click += tabDairy_Click;
            // 
            // tabDrinks
            // 
            tabDrinks.AutoSize = true;
            tabDrinks.Cursor = Cursors.Hand;
            tabDrinks.Location = new Point(1046, 119);
            tabDrinks.Name = "tabDrinks";
            tabDrinks.Size = new Size(125, 25);
            tabDrinks.TabIndex = 7;
            tabDrinks.Text = "Drinks";
            tabDrinks.UseVisualStyleBackColor = true;
            tabDrinks.Click += tabDrinks_Click;
            // 
            // tabSnacks
            // 
            tabSnacks.AutoSize = true;
            tabSnacks.Cursor = Cursors.Hand;
            tabSnacks.Location = new Point(849, 119);
            tabSnacks.Name = "tabSnacks";
            tabSnacks.Size = new Size(125, 25);
            tabSnacks.TabIndex = 6;
            tabSnacks.Text = "Snacks and Candy";
            tabSnacks.UseVisualStyleBackColor = true;
            tabSnacks.Click += tabSnacks_Click;
            // 
            // tabBakery
            // 
            tabBakery.AutoSize = true;
            tabBakery.Cursor = Cursors.Hand;
            tabBakery.Location = new Point(644, 119);
            tabBakery.Name = "tabBakery";
            tabBakery.Size = new Size(125, 25);
            tabBakery.TabIndex = 5;
            tabBakery.Text = "Bakery";
            tabBakery.UseVisualStyleBackColor = true;
            tabBakery.Click += tabBakery_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.BackgroundImage = Properties.Resources.blackmesagrocerylogo;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(24, 2);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(272, 100);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Tab_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.homepage;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1192, 653);
            Controls.Add(button1);
            Controls.Add(tabDrinks);
            Controls.Add(tabSnacks);
            Controls.Add(tabBakery);
            Controls.Add(tabDairy);
            Controls.Add(tabProduce);
            Controls.Add(shopingCart);
            Controls.Add(tabMeat);
            DoubleBuffered = true;
            MaximumSize = new Size(1208, 692);
            MinimumSize = new Size(1208, 692);
            Name = "Tab_Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            FormClosed += Tab_Home_FormClosed;
            Load += Tab_Home_Load;
            Resize += Tab_Home_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tabMeat;
        private Button shopingCart;
        private Button tabProduce;
        private Button tabDairy;
        private Button tabDrinks;
        private Button tabSnacks;
        private Button tabBakery;
        private Button button1;
    }
}