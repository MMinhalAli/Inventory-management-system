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
    public partial class UpdateItem : Form
    {
        public UpdateItem()
        {
            InitializeComponent();
            ApplicationManager.registerForm("UpdateItemForm",this);
        }

        private void ItemNameTxtbox_Click(object sender, EventArgs e)
        {
            if (ItemName.Text == "ItemName") ItemName.Text = null;
            setTextBoxValueOnClickAndKeyPress(Cost,CompanyID);
        }

        private void CostTxtbox_Click(object sender, EventArgs e)
        {
            if (Cost.Text == "Cost") Cost.Text = null;
            setTextBoxValueOnClickAndKeyPress(ItemName, CompanyID);
        }

        private void CompanyIDTxtbox_Click(object sender, EventArgs e)
        {
            if (CompanyID.Text == "CompanyID") CompanyID.Text = null;
            setTextBoxValueOnClickAndKeyPress(ItemName, Cost);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //if ((ItemName.Text != "" && ItemName.Text != "ItemName")) ApplicationManager.updateItem("ItemName",ItemName.Text,comboBox1.SelectedItem.ToString());
            //if ((Cost.Text != "" && Cost.Text != "Cost")) ApplicationManager.updateItem("Cost",Cost.Text,comboBox1.SelectedItem.ToString());
            //if ((CompanyID.Text != "" && CompanyID.Text != "CompanyID")) ApplicationManager.updateItem("CompanyID",CompanyID.Text,comboBox1.SelectedItem.ToString());

            ApplicationManager.updateItem(ItemName,Cost,CompanyID,comboBox1.SelectedItem.ToString());
            ApplicationManager.showStock(ApplicationManager.getDataGridViewFromInventoryStoreForm());
        }

        private void setTextBoxValueOnClickAndKeyPress(TextBox txtBox1,TextBox txtBox2)
        {
            if (txtBox1.Text == "") txtBox1.Text = txtBox1.Name;
            if (txtBox2.Text == "") txtBox2.Text = txtBox2.Name;
        }

        private void UpdateItem_Load(object sender, EventArgs e)
        {
            ApplicationManager.getItemIDs(comboBox1);
        }

        private void UpdateItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideUpdateItemForm();
        }
    }
}
