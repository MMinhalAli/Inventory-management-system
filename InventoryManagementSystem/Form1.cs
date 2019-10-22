using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ApplicationManager.registerForm("SignInForm", this);
        }

        private void UserNameTxtbox_Click(object sender, EventArgs e)
        {
            setTextBoxValueONClickAndKeyPress(UserName,Password);

        }

        private void PasswordTxtbox_Click(object sender, EventArgs e)
        {
            setTextBoxValueONClickAndKeyPress(Password, UserName);
            setSysPassCharValOnTxtBoxClick(Password, true);
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            ApplicationManager.performSignIn(UserName.Text, Password.Text);
        }

        private void setTextBoxValueONClickAndKeyPress(TextBox tBox1,TextBox tBox2)
        {
            if (tBox1.Text == tBox1.Name)
                tBox1.Text = null;
            if (tBox2.Text == "")
            {
                tBox2.Text = tBox2.Name; setSysPassCharValOnTxtBoxClick(Password, false);
            }
        }

        private void setSysPassCharValOnTxtBoxClick(TextBox txtBox,bool value)
        {
            txtBox.UseSystemPasswordChar = value;
        }


        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            setTextBoxValueONClickAndKeyPress(Password, UserName);
            setSysPassCharValOnTxtBoxClick(Password, true);
        }
    }
}
