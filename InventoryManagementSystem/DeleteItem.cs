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
    public partial class DeleteItem : Form
    {
        public DeleteItem()
        {
            InitializeComponent();
            ApplicationManager.registerForm("DeleteItemForm", this);
        }

        private void DeleteItem_Load(object sender, EventArgs e)
        {
            ApplicationManager.getItemIDs(comboBox1);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ApplicationManager.deleteItem(comboBox1.SelectedItem.ToString());
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            ApplicationManager.showStock(ApplicationManager.getDataGridViewFromInventoryStoreForm());
            ApplicationManager.getItemIDs(comboBox1);
        }

        private void DeleteItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideDeleteItemForm();
        }
    }
}
