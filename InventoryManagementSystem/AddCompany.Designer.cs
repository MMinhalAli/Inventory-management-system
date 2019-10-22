namespace InventoryManagementSystem
{
    partial class AddCompany
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
            this.CompanyID = new System.Windows.Forms.TextBox();
            this.CompanyName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(197, 226);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(75, 23);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADDBtn_Click);
            // 
            // CompanyID
            // 
            this.CompanyID.Location = new System.Drawing.Point(154, 91);
            this.CompanyID.Name = "CompanyID";
            this.CompanyID.Size = new System.Drawing.Size(167, 20);
            this.CompanyID.TabIndex = 1;
            this.CompanyID.Text = "CompanyID";
            this.CompanyID.Click += new System.EventHandler(this.CompanyIDTxtbox_Click);
            // 
            // CompanyName
            // 
            this.CompanyName.Location = new System.Drawing.Point(154, 159);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(167, 20);
            this.CompanyName.TabIndex = 2;
            this.CompanyName.Text = "CompanyName";
            this.CompanyName.Click += new System.EventHandler(this.CompanyNameTxtbox_Click);
            // 
            // AddCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 295);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.CompanyID);
            this.Controls.Add(this.ADD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCompany";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCompany_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.TextBox CompanyID;
        private System.Windows.Forms.TextBox CompanyName;
    }
}