namespace InventoryManagementSystem
{
    partial class AddBuyer
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
            this.ADD = new System.Windows.Forms.Button();
            this.BuyerID = new System.Windows.Forms.TextBox();
            this.BuyerName = new System.Windows.Forms.TextBox();
            this.Retailer = new System.Windows.Forms.RadioButton();
            this.WholeSaller = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(157, 215);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(75, 23);
            this.ADD.TabIndex = 4;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // BuyerID
            // 
            this.BuyerID.Location = new System.Drawing.Point(133, 52);
            this.BuyerID.Name = "BuyerID";
            this.BuyerID.Size = new System.Drawing.Size(149, 20);
            this.BuyerID.TabIndex = 0;
            this.BuyerID.Text = "BuyerID";
            this.BuyerID.Click += new System.EventHandler(this.BuyerID_Click);
            // 
            // BuyerName
            // 
            this.BuyerName.Location = new System.Drawing.Point(133, 103);
            this.BuyerName.Name = "BuyerName";
            this.BuyerName.Size = new System.Drawing.Size(149, 20);
            this.BuyerName.TabIndex = 1;
            this.BuyerName.Text = "BuyerName";
            this.BuyerName.Click += new System.EventHandler(this.BuyerName_Click);
            // 
            // Retailer
            // 
            this.Retailer.AutoSize = true;
            this.Retailer.Location = new System.Drawing.Point(80, 164);
            this.Retailer.Name = "Retailer";
            this.Retailer.Size = new System.Drawing.Size(61, 17);
            this.Retailer.TabIndex = 2;
            this.Retailer.TabStop = true;
            this.Retailer.Text = "Retailer";
            this.Retailer.UseVisualStyleBackColor = true;
            // 
            // WholeSaller
            // 
            this.WholeSaller.AutoSize = true;
            this.WholeSaller.Location = new System.Drawing.Point(244, 164);
            this.WholeSaller.Name = "WholeSaller";
            this.WholeSaller.Size = new System.Drawing.Size(82, 17);
            this.WholeSaller.TabIndex = 3;
            this.WholeSaller.TabStop = true;
            this.WholeSaller.Text = "WholeSaller";
            this.WholeSaller.UseVisualStyleBackColor = true;
            // 
            // AddBuyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 265);
            this.Controls.Add(this.WholeSaller);
            this.Controls.Add(this.Retailer);
            this.Controls.Add(this.BuyerName);
            this.Controls.Add(this.BuyerID);
            this.Controls.Add(this.ADD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddBuyer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBuyer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddBuyer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.TextBox BuyerID;
        private System.Windows.Forms.TextBox BuyerName;
        private System.Windows.Forms.RadioButton Retailer;
        private System.Windows.Forms.RadioButton WholeSaller;
    }
}