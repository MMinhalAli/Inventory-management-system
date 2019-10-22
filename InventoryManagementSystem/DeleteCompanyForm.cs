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
    public partial class DeleteCompanyForm : Form
    {
        public DeleteCompanyForm()
        {
            InitializeComponent();
            ApplicationManager.registerForm("DeleteCompanyForm", this);
        }

        private void DeleteCompanyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideDeleteCompanyForm();
        }

        private void DeleteCompanyForm_Load(object sender, EventArgs e)
        {
            ApplicationManager.getCompanyID(comboBox1);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            ApplicationManager.removeCompany(comboBox1.SelectedItem.ToString());
            comboBox1.Items.Clear();
            ApplicationManager.getCompanyID(comboBox1);
        }
    }
}
