namespace ISDS309Group4GroceryStoreProject
{
    partial class Tab_Snacks
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
            tabDrinks.Location = new Point(1028, 116);
            tabDrinks.Margin = new Padding(3, 4, 3, 4);
            tabDrinks.Name = "tabDrinks";
            tabDrinks.Size = new Size(143, 33);
            tabDrinks.TabIndex = 7;
            tabDrinks.Text = "Drinks";
            tabDrinks.UseVisualStyleBackColor = true;
            tabDrinks.Click += tabDrinks_Click;
            // 
            // tabSnacks
            // 
            tabSnacks.Cursor = Cursors.Hand;
            tabSnacks.Location = new Point(844, 116);
            tabSnacks.Margin = new Padding(3, 4, 3, 4);
            tabSnacks.Name = "tabSnacks";
            tabSnacks.Size = new Size(143, 33);
            tabSnacks.TabIndex = 6;
            tabSnacks.Text = "Snacks and Candy";
            tabSnacks.UseVisualStyleBackColor = true;
            tabSnacks.Click += tabSnacks_Click;
            // 
            // tabBakery
            // 
            tabBakery.Cursor = Cursors.Hand;
            tabBakery.Location = new Point(647, 116);
            tabBakery.Margin = new Padding(3, 4, 3, 4);
            tabBakery.Name = "tabBakery";
            tabBakery.Size = new Size(143, 33);
            tabBakery.TabIndex = 5;
            tabBakery.Text = "Bakery";
            tabBakery.UseVisualStyleBackColor = true;
            tabBakery.Click += tabBakery_Click;
            // 
            // tabDairy
            // 
            tabDairy.Cursor = Cursors.Hand;
            tabDairy.Location = new Point(439, 116);
            tabDairy.Margin = new Padding(3, 4, 3, 4);
            tabDairy.Name = "tabDairy";
            tabDairy.Size = new Size(143, 33);
            tabDairy.TabIndex = 4;
            tabDairy.Text = "Dairy";
            tabDairy.UseVisualStyleBackColor = true;
            tabDairy.Click += tabDairy_Click;
            // 
            // tabProduce
            // 
            tabProduce.Cursor = Cursors.Hand;
            tabProduce.Location = new Point(237, 116);
            tabProduce.Margin = new Padding(3, 4, 3, 4);
            tabProduce.Name = "tabProduce";
            tabProduce.Size = new Size(143, 33);
            tabProduce.TabIndex = 3;
            tabProduce.Text = "Produce";
            tabProduce.UseVisualStyleBackColor = true;
            tabProduce.Click += tabProduce_Click;
            // 
            // tabMeat
            // 
            tabMeat.Cursor = Cursors.Hand;
            tabMeat.Location = new Point(29, 116);
            tabMeat.Margin = new Padding(3, 4, 3, 4);
            tabMeat.Name = "tabMeat";
            tabMeat.Size = new Size(143, 33);
            tabMeat.TabIndex = 2;
            tabMeat.Text = "Meat";
            tabMeat.UseVisualStyleBackColor = true;
            tabMeat.Click += tabMeat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.blankpage;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1198, 648);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.BackgroundImage = Properties.Resources.blackmesagrocerylogo;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(29, 3);
            button1.Name = "button1";
            button1.Size = new Size(265, 103);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // shopingCart
            // 
            shopingCart.BackgroundImage = Properties.Resources.shopping_cart;
            shopingCart.BackgroundImageLayout = ImageLayout.Stretch;
            shopingCart.Cursor = Cursors.Hand;
            shopingCart.Location = new Point(1086, 5);
            shopingCart.Margin = new Padding(3, 4, 3, 4);
            shopingCart.Name = "shopingCart";
            shopingCart.Size = new Size(100, 100);
            shopingCart.TabIndex = 8;
            shopingCart.UseVisualStyleBackColor = true;
            shopingCart.Click += shopingCart_Click;
            // 
            // Tab_Snacks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 645);
            Controls.Add(shopingCart);
            Controls.Add(button1);
            Controls.Add(tabDrinks);
            Controls.Add(tabSnacks);
            Controls.Add(tabBakery);
            Controls.Add(tabDairy);
            Controls.Add(tabProduce);
            Controls.Add(tabMeat);
            Controls.Add(pictureBox1);
            Cursor = Cursors.IBeam;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1208, 692);
            MinimumSize = new Size(1208, 692);
            Name = "Tab_Snacks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Snacks";
            FormClosed += Tab_Snacks_FormClosed;
            Load += Tab_Snacks_Load;
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