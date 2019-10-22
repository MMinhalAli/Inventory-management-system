namespace InventoryManagementSystem
{
    partial class InventoryStore
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.AvaliableStock = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteItem = new System.Windows.Forms.Button();
            this.UpdateItem = new System.Windows.Forms.Button();
            this.AddCompany = new System.Windows.Forms.Button();
            this.UpdateCompany = new System.Windows.Forms.Button();
            this.DeleteCompany = new System.Windows.Forms.Button();
            this.AddBuyer = new System.Windows.Forms.Button();
            this.UpdateBuyer = new System.Windows.Forms.Button();
            this.DeleteBuyer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Welcome to new form";
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(170, 95);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemBtn.TabIndex = 1;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItem_Click);
            // 
            // AvaliableStock
            // 
            this.AvaliableStock.Location = new System.Drawing.Point(63, 95);
            this.AvaliableStock.Name = "AvaliableStock";
            this.AvaliableStock.Size = new System.Drawing.Size(92, 23);
            this.AvaliableStock.TabIndex = 2;
            this.AvaliableStock.Text = "Avaliable Stock";
            this.AvaliableStock.UseVisualStyleBackColor = true;
            this.AvaliableStock.Click += new System.EventHandler(this.AvaliableStockBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.ItemID,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(63, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(846, 242);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ItemID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ItemName";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ItemPrice";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "CompanyID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // DeleteItem
            // 
            this.DeleteItem.Location = new System.Drawing.Point(261, 95);
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(75, 23);
            this.DeleteItem.TabIndex = 4;
            this.DeleteItem.Text = "Delete Item";
            this.DeleteItem.UseVisualStyleBackColor = true;
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItemBtn_Click);
            // 
            // UpdateItem
            // 
            this.UpdateItem.Location = new System.Drawing.Point(352, 95);
            this.UpdateItem.Name = "UpdateItem";
            this.UpdateItem.Size = new System.Drawing.Size(75, 23);
            this.UpdateItem.TabIndex = 5;
            this.UpdateItem.Text = "Update Item";
            this.UpdateItem.UseVisualStyleBackColor = true;
            this.UpdateItem.Click += new System.EventHandler(this.UpdateItemBtn_Click);
            // 
            // AddCompany
            // 
            this.AddCompany.Location = new System.Drawing.Point(442, 95);
            this.AddCompany.Name = "AddCompany";
            this.AddCompany.Size = new System.Drawing.Size(99, 23);
            this.AddCompany.TabIndex = 6;
            this.AddCompany.Text = "Add Company";
            this.AddCompany.UseVisualStyleBackColor = true;
            this.AddCompany.Click += new System.EventHandler(this.AddCompanyBtn_Click);
            // 
            // UpdateCompany
            // 
            this.UpdateCompany.Location = new System.Drawing.Point(556, 95);
            this.UpdateCompany.Name = "UpdateCompany";
            this.UpdateCompany.Size = new System.Drawing.Size(99, 23);
            this.UpdateCompany.TabIndex = 7;
            this.UpdateCompany.Text = "Update Company";
            this.UpdateCompany.UseVisualStyleBackColor = true;
            this.UpdateCompany.Click += new System.EventHandler(this.UpdateCompany_Click);
            // 
            // DeleteCompany
            // 
            this.DeleteCompany.Location = new System.Drawing.Point(670, 95);
            this.DeleteCompany.Name = "DeleteCompany";
            this.DeleteCompany.Size = new System.Drawing.Size(99, 23);
            this.DeleteCompany.TabIndex = 8;
            this.DeleteCompany.Text = "Delete Company";
            this.DeleteCompany.UseVisualStyleBackColor = true;
            this.DeleteCompany.Click += new System.EventHandler(this.DeleteCompany_Click);
            // 
            // AddBuyer
            // 
            this.AddBuyer.Location = new System.Drawing.Point(784, 95);
            this.AddBuyer.Name = "AddBuyer";
            this.AddBuyer.Size = new System.Drawing.Size(99, 23);
            this.AddBuyer.TabIndex = 9;
            this.AddBuyer.Text = "Add Buyer";
            this.AddBuyer.UseVisualStyleBackColor = true;
            this.AddBuyer.Click += new System.EventHandler(this.AddBuyer_Click);
            // 
            // UpdateBuyer
            // 
            this.UpdateBuyer.Location = new System.Drawing.Point(63, 124);
            this.UpdateBuyer.Name = "UpdateBuyer";
            this.UpdateBuyer.Size = new System.Drawing.Size(99, 23);
            this.UpdateBuyer.TabIndex = 10;
            this.UpdateBuyer.Text = "Update Buyer";
            this.UpdateBuyer.UseVisualStyleBackColor = true;
            this.UpdateBuyer.Click += new System.EventHandler(this.UpdateBuyer_Click);
            // 
            // DeleteBuyer
            // 
            this.DeleteBuyer.Location = new System.Drawing.Point(170, 124);
            this.DeleteBuyer.Name = "DeleteBuyer";
            this.DeleteBuyer.Size = new System.Drawing.Size(99, 23);
            this.DeleteBuyer.TabIndex = 11;
            this.DeleteBuyer.Text = "Delete Buyer";
            this.DeleteBuyer.UseVisualStyleBackColor = true;
            this.DeleteBuyer.Click += new System.EventHandler(this.DeleteBuyer_Click);
            // 
            // InventoryStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 426);
            this.Controls.Add(this.DeleteBuyer);
            this.Controls.Add(this.UpdateBuyer);
            this.Controls.Add(this.AddBuyer);
            this.Controls.Add(this.DeleteCompany);
            this.Controls.Add(this.UpdateCompany);
            this.Controls.Add(this.AddCompany);
            this.Controls.Add(this.UpdateItem);
            this.Controls.Add(this.DeleteItem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AvaliableStock);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "InventoryStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryStore";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button AvaliableStock;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button DeleteItem;
        private System.Windows.Forms.Button UpdateItem;
        private System.Windows.Forms.Button AddCompany;
        private System.Windows.Forms.Button UpdateCompany;
        private System.Windows.Forms.Button DeleteCompany;
        private System.Windows.Forms.Button AddBuyer;
        private System.Windows.Forms.Button UpdateBuyer;
        private System.Windows.Forms.Button DeleteBuyer;
    }
}