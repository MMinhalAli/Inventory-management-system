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
    public partial class AddCompany : Form
    {
        public AddCompany()
        {
            InitializeComponent();
            ApplicationManager.registerForm("AddCompanyForm",this);
        }

        private void CompanyIDTxtbox_Click(object sender, EventArgs e)
        {
            if (CompanyID.Text == "CompanyID") CompanyID.Text = null;
            setTextBoxValueOnClickAndKeyPress(CompanyName);
        }

        private void CompanyNameTxtbox_Click(object sender, EventArgs e)
        {
            if (CompanyName.Text == "CompanyName") CompanyName.Text = null;
            setTextBoxValueOnClickAndKeyPress(CompanyID);
        }

        private void setTextBoxValueOnClickAndKeyPress(TextBox txtBox1)
        {
            if (txtBox1.Text == "") txtBox1.Text = txtBox1.Name;
        }

        private void ADDBtn_Click(object sender, EventArgs e)
        {
            ApplicationManager.addCompany(CompanyID.Text, CompanyName.Text);
            CompanyID.Text = CompanyID.Name;
            CompanyName.Text = CompanyName.Name;
        }

        private void AddCompany_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideAddCompanyForm();
        }
    }
}
