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
    public partial class InventoryStore : Form
    {
        public InventoryStore()
        {
            InitializeComponent();
            ApplicationManager.registerForm("InventoryStoreForm", this);
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            ApplicationManager.showAddItemForm();
        }

        private void AvaliableStockBtn_Click(object sender, EventArgs e)
        {
            ApplicationManager.showStock(dataGridView1);
        }

        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {
            ApplicationManager.showDeleteItemForm();
        }

        private void UpdateItemBtn_Click(object sender, EventArgs e)
        {
            ApplicationManager.showUpdateItemForm();
        }

        public  DataGridView getDataGridView()
        {
            return dataGridView1;
        }

        private void AddCompanyBtn_Click(object sender, EventArgs e)
        {
            ApplicationManager.showAddCompanyForm();
        }

        private void UpdateCompany_Click(object sender, EventArgs e)
        {
            ApplicationManager.showUpdateCompanyForm();
        }

        private void DeleteCompany_Click(object sender, EventArgs e)
        {
            ApplicationManager.showDeleteCompanyForm();
        }

        private void AddBuyer_Click(object sender, EventArgs e)
        {
            ApplicationManager.showAddBuyerForm();
        }

        private void UpdateBuyer_Click(object sender, EventArgs e)
        {
            ApplicationManager.showUpdateBuyerForm();
        }

        private void DeleteBuyer_Click(object sender, EventArgs e)
        {
            ApplicationManager.showDeleteBuyerForm();
        }
    }
}
