namespace InventoryManagementSystem
{
    partial class Form1
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
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(55, 88);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(159, 20);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "UserName";
            this.UserName.Click += new System.EventHandler(this.UserNameTxtbox_Click);
           
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(55, 134);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(159, 20);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.PasswordTxtbox_Click);
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
            // 
            // SignInBtn
            // 
            this.SignInBtn.Location = new System.Drawing.Point(96, 207);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(75, 23);
            this.SignInBtn.TabIndex = 3;
            this.SignInBtn.Text = "SignIn";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 302);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button SignInBtn;
    }
}

