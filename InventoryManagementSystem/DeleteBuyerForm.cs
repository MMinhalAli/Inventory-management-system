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
    public partial class DeleteBuyerForm : Form
    {
        public DeleteBuyerForm()
        {
            InitializeComponent();
            ApplicationManager.registerForm("deleteBuyerForm",this);
        }

        private void DeleteBuyerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideDeleteBuyerForm();
        }

        private void DeleteBuyerForm_Load(object sender, EventArgs e)
        {
            ApplicationManager.getBuyerID(comboBox1);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            ApplicationManager.deleteBuyer(comboBox1.SelectedItem.ToString());
            comboBox1.Items.Remove(comboBox1.SelectedItem.ToString());
            ApplicationManager.getBuyerID(comboBox1);
        }
    }
}
