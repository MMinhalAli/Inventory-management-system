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
    public partial class UpdateCompany : Form
    {
        public UpdateCompany()
        {
            InitializeComponent();
            ApplicationManager.registerForm("UpdateCompanyForm", this);
        }

        private void CompanyNameTxtbox_Click(object sender, EventArgs e)
        {
            if(CompanyName.Text== "CompanyName") CompanyName.Text = null;
        }

        private void UpdateCompany_Load(object sender, EventArgs e)
        {
            ApplicationManager.getCompanyID(comboBox1);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            ApplicationManager.updateCompanyName(comboBox1.SelectedItem.ToString(),CompanyName.Text);
            CompanyName.Text = CompanyName.Name;
        }

        private void UpdateCompany_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideUpdateCompanyForm();
        }
    }
}
