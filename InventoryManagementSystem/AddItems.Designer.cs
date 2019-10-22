namespace InventoryManagementSystem
{
    partial class AddItems
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
            //base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemID = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.RetailerProfitPrice = new System.Windows.Forms.TextBox();
            this.WholeSallerProfitPrice = new System.Windows.Forms.TextBox();
            this.CompanyID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ItemID
            // 
            this.ItemID.Location = new System.Drawing.Point(148, 34);
            this.ItemID.Name = "ItemID";
            this.ItemID.Size = new System.Drawing.Size(155, 20);
            this.ItemID.TabIndex = 0;
            this.ItemID.Text = "ItemID";
            this.ItemID.Click += new System.EventHandler(this.ItemIDTxtbox_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(179, 315);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ItemName
            // 
            this.ItemName.Location = new System.Drawing.Point(148, 72);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(155, 20);
            this.ItemName.TabIndex = 1;
            this.ItemName.Text = "ItemName";
            this.ItemName.Click += new System.EventHandler(this.ItemNameTxtbox_Click);
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(148, 112);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(155, 20);
            this.Cost.TabIndex = 2;
            this.Cost.Text = "Cost";
            this.Cost.Click += new System.EventHandler(this.CostTxtbox_Click);
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(148, 189);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(155, 20);
            this.Quantity.TabIndex = 4;
            this.Quantity.Text = "Quantity";
            this.Quantity.Click += new System.EventHandler(this.QuantityBtn_Click);
            // 
            // RetailerProfitPrice
            // 
            this.RetailerProfitPrice.Location = new System.Drawing.Point(148, 227);
            this.RetailerProfitPrice.Name = "RetailerProfitPrice";
            this.RetailerProfitPrice.Size = new System.Drawing.Size(155, 20);
            this.RetailerProfitPrice.TabIndex = 5;
            this.RetailerProfitPrice.Text = "RetailerProfitPrice";
            this.RetailerProfitPrice.Click += new System.EventHandler(this.RetailerProfitPriceTxtbox_Click);
            // 
            // WholeSallerProfitPrice
            // 
            this.WholeSallerProfitPrice.Location = new System.Drawing.Point(147, 267);
            this.WholeSallerProfitPrice.Name = "WholeSallerProfitPrice";
            this.WholeSallerProfitPrice.Size = new System.Drawing.Size(155, 20);
            this.WholeSallerProfitPrice.TabIndex = 6;
            this.WholeSallerProfitPrice.Text = "WholeSallerProfitPrice";
            this.WholeSallerProfitPrice.Click += new System.EventHandler(this.WholeSallerProfitPriceTxtbox_Click);
            // 
            // CompanyID
            // 
            this.CompanyID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompanyID.FormattingEnabled = true;
            this.CompanyID.Location = new System.Drawing.Point(147, 152);
            this.CompanyID.Name = "CompanyID";
            this.CompanyID.Size = new System.Drawing.Size(156, 21);
            this.CompanyID.TabIndex = 3;
            // 
            // AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 362);
            this.Controls.Add(this.CompanyID);
            this.Controls.Add(this.WholeSallerProfitPrice);
            this.Controls.Add(this.RetailerProfitPrice);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ItemID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItems";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddItems_FormClosing);
            this.Load += new System.EventHandler(this.AddItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ItemID;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox RetailerProfitPrice;
        private System.Windows.Forms.TextBox WholeSallerProfitPrice;
        private System.Windows.Forms.ComboBox CompanyID;
    }
}