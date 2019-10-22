namespace InventoryManagementSystem
{
    partial class UpdateBuyer
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BuyerName = new System.Windows.Forms.TextBox();
            this.Retailer = new System.Windows.Forms.RadioButton();
            this.WholeSaller = new System.Windows.Forms.RadioButton();
            this.Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "BuyerID\'s";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(190, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // BuyerName
            // 
            this.BuyerName.Location = new System.Drawing.Point(190, 105);
            this.BuyerName.Name = "BuyerName";
            this.BuyerName.Size = new System.Drawing.Size(178, 20);
            this.BuyerName.TabIndex = 1;
            this.BuyerName.Text = "BuyerName";
            this.BuyerName.Click += new System.EventHandler(this.BuyerName_Click);
            // 
            // Retailer
            // 
            this.Retailer.AutoSize = true;
            this.Retailer.Location = new System.Drawing.Point(190, 186);
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
            this.WholeSaller.Location = new System.Drawing.Point(283, 186);
            this.WholeSaller.Name = "WholeSaller";
            this.WholeSaller.Size = new System.Drawing.Size(82, 17);
            this.WholeSaller.TabIndex = 3;
            this.WholeSaller.TabStop = true;
            this.WholeSaller.Text = "WholeSaller";
            this.WholeSaller.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(245, 241);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 4;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // UpdateBuyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 288);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.WholeSaller);
            this.Controls.Add(this.Retailer);
            this.Controls.Add(this.BuyerName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "UpdateBuyer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateBuyer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateBuyer_FormClosing);
            this.Load += new System.EventHandler(this.UpdateBuyer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox BuyerName;
        private System.Windows.Forms.RadioButton Retailer;
        private System.Windows.Forms.RadioButton WholeSaller;
        private System.Windows.Forms.Button Update;
    }
}