using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace InventoryManagementSystem
{
    public partial class AddItems : Form
    {
        public AddItems()
        {
            InitializeComponent();
            ApplicationManager.registerForm("AddItemsForm", this);
        }

        private void ItemIDTxtbox_Click(object sender, EventArgs e)
        {
            if(ItemID.Text=="ItemID") ItemID.Text = null;
            setTextBoxValueONClickAndKeyPress(ItemName,Cost,Quantity,RetailerProfitPrice,WholeSallerProfitPrice);
        }

        private void ItemNameTxtbox_Click(object sender, EventArgs e)
        {
            if (ItemName.Text == "ItemName") ItemName.Text = null;
            setTextBoxValueONClickAndKeyPress(ItemID, Cost, Quantity, RetailerProfitPrice, WholeSallerProfitPrice);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ApplicationManager.addItem(ItemID.Text, ItemName.Text, Cost.Text, CompanyID.Text, DateTime.Now.ToString());
            ApplicationManager.updateStock(ItemID.Text,Quantity.Text);
            ApplicationManager.setItemPriceManagement(ItemID.Text,RetailerProfitPrice.Text,WholeSallerProfitPrice.Text);
            ApplicationManager.showStock(ApplicationManager.getDataGridViewFromInventoryStoreForm());
            ItemID.Text = "ItemID";
            ItemName.Text = "ItemName";
            Cost.Text = "Cost";
            CompanyID.Text = "CompanyID";
            Quantity.Text = "Quantity";
            RetailerProfitPrice.Text = "RetailerProfitPrice";
            WholeSallerProfitPrice.Text = "WholeSallerProfitPrice";
        }

        private void QuantityBtn_Click(object sender, EventArgs e)
        {
            if (Quantity.Text == "Quantity") Quantity.Text = null;
            setTextBoxValueONClickAndKeyPress(ItemName, Cost, ItemID, RetailerProfitPrice, WholeSallerProfitPrice);
        }

        private void RetailerProfitPriceTxtbox_Click(object sender, EventArgs e)
        {
            if (RetailerProfitPrice.Text == "RetailerProfitPrice") RetailerProfitPrice.Text = null;
            setTextBoxValueONClickAndKeyPress(ItemName, Cost,  Quantity, ItemID, WholeSallerProfitPrice);
        }

        private void WholeSallerProfitPriceTxtbox_Click(object sender, EventArgs e)
        {
            if (WholeSallerProfitPrice.Text == "WholeSallerProfitPrice") WholeSallerProfitPrice.Text = null;
            setTextBoxValueONClickAndKeyPress(ItemName, Cost,  Quantity, RetailerProfitPrice, ItemID);
        }

        private void setTextBoxValueONClickAndKeyPress(TextBox txtBox1, TextBox txtBox2, TextBox txtBox3, TextBox txtBox4, TextBox txtBox5)
        {
            if (txtBox1.Text == "") txtBox1.Text = txtBox1.Name;
            if (txtBox2.Text == "") txtBox2.Text = txtBox2.Name;
            if (txtBox3.Text == "") txtBox3.Text = txtBox3.Name;
            if (txtBox4.Text == "") txtBox4.Text = txtBox4.Name;
            if (txtBox5.Text == "") txtBox5.Text = txtBox5.Name;
        }

        private void CostTxtbox_Click(object sender, EventArgs e)
        {
            if (Cost.Text == "Cost") Cost.Text = null;
            setTextBoxValueONClickAndKeyPress(ItemName, ItemID, Quantity, RetailerProfitPrice, WholeSallerProfitPrice);
        }

        private void AddItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideAddItemForm();
        }

        private void AddItems_Load(object sender, EventArgs e)
        {
            CompanyID.Items.Clear();
            ApplicationManager.getCompanyID(CompanyID);
        }
    }
}
