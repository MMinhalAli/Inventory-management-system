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
    public partial class UpdateBuyer : Form
    {
        public UpdateBuyer()
        {
            InitializeComponent();
            ApplicationManager.registerForm("updateBuyerForm", this);
        }

        private void UpdateBuyer_Load(object sender, EventArgs e)
        {
            ApplicationManager.getBuyerID(comboBox1);
        }

        private void UpdateBuyer_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideUpdateBuyerForm();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (BuyerName.Text != "" && BuyerName.Text != BuyerName.Name) ApplicationManager.updateBuyer(BuyerName.Name,BuyerName.Text,comboBox1.SelectedItem.ToString());
            if (Retailer.Checked) ApplicationManager.updateBuyer("BuyerType", Retailer.Text, comboBox1.SelectedItem.ToString());
            if(WholeSaller.Checked) ApplicationManager.updateBuyer("BuyerType", WholeSaller.Text, comboBox1.SelectedItem.ToString());
            comboBox1.Items.Remove(comboBox1.SelectedItem.ToString());
            ApplicationManager.getBuyerID(comboBox1);
            BuyerName.Text = BuyerName.Name;
            Retailer.Checked = false;
            WholeSaller.Checked = false;
        }

        private void BuyerName_Click(object sender, EventArgs e)
        {
            if (BuyerName.Text == BuyerName.Name) BuyerName.Text = null;
        }
    }
}
