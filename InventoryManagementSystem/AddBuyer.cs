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
    public partial class AddBuyer : Form
    {
        public AddBuyer()
        {
            InitializeComponent();
            ApplicationManager.registerForm("AddBuyerForm", this);
        }

        private void BuyerID_Click(object sender, EventArgs e)
        {
            if (BuyerID.Text == "BuyerID") BuyerID.Text = null;
            setTextBoxValueONClickAndKeyPress(BuyerName);
        }

        private void BuyerName_Click(object sender, EventArgs e)
        {
            if (BuyerName.Text == "BuyerName") BuyerName.Text = null ;
            setTextBoxValueONClickAndKeyPress(BuyerID);
        }

        private void setTextBoxValueONClickAndKeyPress(TextBox txtBox1)
        {
            if (txtBox1.Text == "") txtBox1.Text = txtBox1.Name;
        }

        private void AddBuyer_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideAddBuyerForm();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            if(Retailer.Checked)
                ApplicationManager.addBuyer(BuyerID.Text,BuyerName.Text,Retailer.Text);
            if(WholeSaller.Checked)
                ApplicationManager.addBuyer(BuyerID.Text, BuyerName.Text, WholeSaller.Text);
            BuyerID.Text = BuyerID.Name;
            BuyerName.Text = BuyerName.Name;
            Retailer.Checked = false;
            WholeSaller.Checked = false;
        }
    }
}
