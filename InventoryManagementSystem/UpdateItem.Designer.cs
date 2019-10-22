namespace InventoryManagementSystem
{
    partial class UpdateItem
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Update = new System.Windows.Forms.Button();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.TextBox();
            this.CompanyID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(175, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(216, 238);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 4;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ItemName
            // 
            this.ItemName.Location = new System.Drawing.Point(175, 94);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(150, 20);
            this.ItemName.TabIndex = 1;
            this.ItemName.Text = "ItemName";
            this.ItemName.Click += new System.EventHandler(this.ItemNameTxtbox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ItemID\'s";
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(175, 142);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(150, 20);
            this.Cost.TabIndex = 2;
            this.Cost.Text = "Cost";
            this.Cost.Click += new System.EventHandler(this.CostTxtbox_Click);
            // 
            // CompanyID
            // 
            this.CompanyID.Location = new System.Drawing.Point(175, 193);
            this.CompanyID.Name = "CompanyID";
            this.CompanyID.Size = new System.Drawing.Size(150, 20);
            this.CompanyID.TabIndex = 3;
            this.CompanyID.Text = "CompanyID";
            this.CompanyID.Click += new System.EventHandler(this.CompanyIDTxtbox_Click);
            // 
            // UpdateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 292);
            this.Controls.Add(this.CompanyID);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "UpdateItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateItem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateItem_FormClosing);
            this.Load += new System.EventHandler(this.UpdateItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.TextBox CompanyID;
    }
}