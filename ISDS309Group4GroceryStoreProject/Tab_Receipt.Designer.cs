namespace ISDS309Group4GroceryStoreProject
{
    partial class Tab_Receipt
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
            lblReceipt = new Label();
            SuspendLayout();
            // 
            // lblReceipt
            // 
            lblReceipt.AutoSize = true;
            lblReceipt.Location = new Point(547, 51);
            lblReceipt.Name = "lblReceipt";
            lblReceipt.Size = new Size(38, 15);
            lblReceipt.TabIndex = 0;
            lblReceipt.Text = "label1";
            lblReceipt.Click += lblReceipt_Click;
            // 
            // Tab_Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 653);
            Controls.Add(lblReceipt);
            MaximumSize = new Size(1208, 692);
            MinimumSize = new Size(1208, 692);
            Name = "Tab_Receipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receipt";
            FormClosed += Tab_Receipt_FormClosed;
            Load += Tab_Receipt_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReceipt;
    }
}