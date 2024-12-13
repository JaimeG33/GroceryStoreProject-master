﻿namespace ISDS309Group4GroceryStoreProject
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
            SuspendLayout();
            // 
            // tabMeat
            // 
            tabMeat.AutoSize = true;
            tabMeat.Location = new Point(33, 115);
            tabMeat.Margin = new Padding(3, 4, 3, 4);
            tabMeat.MaximumSize = new Size(200, 60);
            tabMeat.Name = "tabMeat";
            tabMeat.Size = new Size(143, 33);
            tabMeat.TabIndex = 0;
            tabMeat.Text = "Meat";
            tabMeat.UseVisualStyleBackColor = true;
            tabMeat.Click += tabMeat_Click;
            // 
            // shopingCart
            // 
            shopingCart.Location = new Point(1067, 6);
            shopingCart.Margin = new Padding(3, 4, 3, 4);
            shopingCart.Name = "shopingCart";
            shopingCart.Size = new Size(122, 92);
            shopingCart.TabIndex = 1;
            shopingCart.Text = "Shopping Cart";
            shopingCart.UseVisualStyleBackColor = true;
            // 
            // tabProduce
            // 
            tabProduce.AutoSize = true;
            tabProduce.Location = new Point(242, 115);
            tabProduce.Margin = new Padding(3, 4, 3, 4);
            tabProduce.Name = "tabProduce";
            tabProduce.Size = new Size(143, 33);
            tabProduce.TabIndex = 2;
            tabProduce.Text = "Produce";
            tabProduce.UseVisualStyleBackColor = true;
            tabProduce.Click += tabProduce_Click;
            // 
            // tabDairy
            // 
            tabDairy.AutoSize = true;
            tabDairy.Location = new Point(435, 115);
            tabDairy.Margin = new Padding(3, 4, 3, 4);
            tabDairy.Name = "tabDairy";
            tabDairy.Size = new Size(143, 33);
            tabDairy.TabIndex = 3;
            tabDairy.Text = "Dairy";
            tabDairy.UseVisualStyleBackColor = true;
            tabDairy.Click += tabDairy_Click;
            // 
            // tabDrinks
            // 
            tabDrinks.AutoSize = true;
            tabDrinks.Location = new Point(1035, 115);
            tabDrinks.Margin = new Padding(3, 4, 3, 4);
            tabDrinks.Name = "tabDrinks";
            tabDrinks.Size = new Size(143, 33);
            tabDrinks.TabIndex = 6;
            tabDrinks.Text = "Drinks";
            tabDrinks.UseVisualStyleBackColor = true;
            tabDrinks.Click += tabDrinks_Click;
            // 
            // tabSnacks
            // 
            tabSnacks.AutoSize = true;
            tabSnacks.Location = new Point(849, 115);
            tabSnacks.Margin = new Padding(3, 4, 3, 4);
            tabSnacks.Name = "tabSnacks";
            tabSnacks.Size = new Size(143, 33);
            tabSnacks.TabIndex = 5;
            tabSnacks.Text = "Snacks and Candy";
            tabSnacks.UseVisualStyleBackColor = true;
            tabSnacks.Click += tabSnacks_Click;
            // 
            // tabBakery
            // 
            tabBakery.AutoSize = true;
            tabBakery.Location = new Point(650, 115);
            tabBakery.Margin = new Padding(3, 4, 3, 4);
            tabBakery.Name = "tabBakery";
            tabBakery.Size = new Size(143, 33);
            tabBakery.TabIndex = 4;
            tabBakery.Text = "Bakery";
            tabBakery.UseVisualStyleBackColor = true;
            tabBakery.Click += tabBakery_Click;
            // 
            // Tab_Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.homepage;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1190, 645);
            Controls.Add(tabDrinks);
            Controls.Add(tabSnacks);
            Controls.Add(tabBakery);
            Controls.Add(tabDairy);
            Controls.Add(tabProduce);
            Controls.Add(shopingCart);
            Controls.Add(tabMeat);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 4, 3, 4);
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
    }
}