using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    class ApplicationManager
    {
        private static Dictionary<String,Form> listOfRegisteredForms = new Dictionary<string, Form>();
        private static UserManager am=new UserManager();
        private static ItemManager im = new ItemManager();
        private static ProviderManager pm = new ProviderManager();
        private static StockManager s = new StockManager();
        private static InventoryStore iS = new InventoryStore();
        private static BuyerManager bm = new BuyerManager();
        public static void registerForm(string formName,Form f)
        {
            listOfRegisteredForms.Add(formName, f);
        }

        public static Form startApplication()
        {
             Form addCompanyForm = new AddCompany();
             Form addItemForm = new AddItems();
             Form updateItemForm = new UpdateItem();
             Form deleteItemForm = new DeleteItem();
             Form updateCompanyForm = new UpdateCompany();
             Form deleteCompanyForm = new DeleteCompanyForm();
             Form addBuyerForm = new AddBuyer();
             Form updateBuyerForm = new UpdateBuyer();
             Form deleteBuyerForm = new DeleteBuyerForm();
             Form signInForm = new Form1();
            return signInForm;
        }

        public static void performSignIn(string userName,string password)
        {
            if (!am.performSignIn(userName, password))
            { MessageBox.Show("Wrong username/password"); }
            else
            {
                hideForm("SignInForm");
                showForm("InventoryStoreForm");
            }
        }

        public static void showAddItemForm()
        {
            showForm("AddItemsForm");
        }

        public static void showUpdateCompanyForm()
        {
            showForm("UpdateCompanyForm");
        }

        public static void hideUpdateCompanyForm()
        {
            hideForm("UpdateCompanyForm");
        }

        public static void showDeleteCompanyForm()
        {
            showForm("DeleteCompanyForm");
        }

        public static void hideDeleteCompanyForm()
        {
            hideForm("DeleteCompanyForm");
        }

        public static void hideAddItemForm()
        {
            hideForm("AddItemsForm");
        }

        public static void showInventoryStoreForm()
        {
            hideForm("AddItemsForm");
        }

        public static void showDeleteItemForm()
        {
            showForm("DeleteItemForm");
        }

        public static void hideDeleteItemForm()
        {
            hideForm("DeleteItemForm");
        }

        public static void showAddCompanyForm()
        {
            showForm("AddCompanyForm");
        }

        public static void showAddBuyerForm()
        {
            showForm("AddBuyerForm");
        }

        public static void hideAddBuyerForm()
        {
            hideForm("AddBuyerForm");
        }

        public static void showUpdateBuyerForm()
        {
            showForm("updateBuyerForm");
        }

        public static void hideUpdateBuyerForm()
        {
            hideForm("updateBuyerForm");
        }

        public static void showDeleteBuyerForm()
        {
            showForm("deleteBuyerForm");
        }

        public static void hideDeleteBuyerForm()
        {
            hideForm("deleteBuyerForm");
        }

        public static void  addItem(string itemID, string itemName, string cost, string companyID, string itemRegistrationTime)
        {
            if(!im.addItem(itemID, itemName, cost, companyID, itemRegistrationTime)) MessageBox.Show("YOUR ADDING ITEM REQUEST IS FAILED");
            else MessageBox.Show("ITEM HAS BEEN SUCCESSFULLY ADDED");
        }

        public static void addCompany(string companyID,string companyName)
        {
            if (!pm.addCompany(companyID, companyName)) MessageBox.Show("YOUR ADDING COMPANY REQUEST IS FAILED");
            else MessageBox.Show("COMPANY HAS BEEN SUCCESSFULLY ADDED");
        }

        public static void updateStock(string itemId,string quantity)
        {
            if (!s.addItemIntoStock(itemId,quantity)) MessageBox.Show("YOUR UPDATE STOCK REQUEST IS FAILED");
            else MessageBox.Show("YOUR STOCK IS SUCCESSFULLY UPDATED");
        }

        public static void showStock(DataGridView pDataGridView)
        {
            pDataGridView.Rows.Clear();
            pDataGridView.Refresh();
            List<Dictionary<String, String>> data = s.availableStock();
            string tempItemId = "";
            string tempItemName = "";
            string tempItemPrice = "";
            string tempCompanyId = "";
            string tempQuantity = "";
            foreach (Dictionary<String, String> valueMap in data)
            {
                valueMap.TryGetValue("ItemID", out tempItemId);
                valueMap.TryGetValue("ItemName", out tempItemName);
                valueMap.TryGetValue("Cost", out tempItemPrice);
                valueMap.TryGetValue("CompanyID", out tempCompanyId);
                valueMap.TryGetValue("Quantity", out tempQuantity);
                string[] tempRow = { tempItemId, tempItemName, tempItemPrice, tempCompanyId, tempQuantity };
                pDataGridView.Rows.Add(tempRow);
            }
        }

        public static void updateItem(TextBox txtBox1, TextBox txtBox2, TextBox txtBox3,string itemID)
        {
            if (!im.updateItem(txtBox1,txtBox2,txtBox3,itemID)) MessageBox.Show("YOUR UPDATE ITEM REQUEST IS FAILED");
            else MessageBox.Show("ITEM HAS BEEN SUCCESSFULLY UPDATED");
        }

        public static void updateBuyer(string colName, string data, string buyerID)
        {
            if (!bm.updateBuyer(buyerID,colName,data)) MessageBox.Show("YOUR UPDATE BUYER REQUEST IS FAILED");
            else MessageBox.Show("BUYER HAS BEEN SUCCESSFULLY UPDATED");
        }

        public static void deleteItem(string itemID)
        {
            if (!im.deleteItem(itemID)) MessageBox.Show("YOUR DELETE ITEM REQUEST IS FAILED");
            else MessageBox.Show("ITEM HAS BEEN SUCCESSFULLY DELETED");

            if(!s.deleteItemFromStock(itemID)) MessageBox.Show("YOUR DELETE ITEM FROM STOCK REQUEST IS FAILED");
            else MessageBox.Show("ITEM HAS BEEN SUCCESSFULLY DELETED FROM STOCK");

           if(!im.deleteItemFromItemPriceManagement(itemID)) MessageBox.Show("YOUR DELETE ITEM FROM ITEMPRICEMANAGEMENT REQUEST IS FAILED");
           else MessageBox.Show("ITEM HAS BEEN SUCCESSFULLY DELETED FROM ITEMPRICEMANAGEMENT");
        }

        public static void deleteBuyer(string buyerID)
        {
            if (!bm.deleteBuyer(buyerID)) MessageBox.Show("YOUR DELETE BUYER REQUEST IS FAILED");
            else MessageBox.Show("BUYER HAS BEEN SUCCESSFULLY DELETED");
        }

        public static void setItemPriceManagement(string itemID,string retialerProfitPrice,string wholeSallerProfitPrice)
        {
            if (!im.setItemPriceManagement(itemID, retialerProfitPrice, wholeSallerProfitPrice)) MessageBox.Show("YOUR ADD ITEM FROM ITEMPRICEMANAGEMENT REQUEST IS FAILED");
            else MessageBox.Show("ITEM HAS BEEN SUCCESSFULLY ADDED INTO ITEMPRICEMANAGEMENT");
        }

        private static void hideForm(string value)
        {
            Form formName;
            listOfRegisteredForms.TryGetValue(value, out formName);
            formName.Hide();
        }

        private static void showForm( string value)
        {
            Form formName=null;
            listOfRegisteredForms.TryGetValue(value, out formName);
            formName.Show();
        }

        public static void getItemIDs(ComboBox c)
        {
            List<Dictionary<String, String>> result = im.getItemIDs();
            string itemID;
            foreach (Dictionary<String, String> valueMap in result)
            {
                valueMap.TryGetValue("ItemID", out itemID);
                c.Items.Add(itemID);
            }
        }

        public static void hideAddCompanyForm()
        {
            hideForm("AddCompanyForm");
        }

        public static void showUpdateItemForm()
        {
            showForm("UpdateItemForm");
        }

        public static void hideUpdateItemForm()
        {
            hideForm("UpdateItemForm");
        }

        public static DataGridView getDataGridViewFromInventoryStoreForm()
        {
            return iS.getDataGridView();
        }

        public static void getCompanyID(ComboBox c)
        {
            List < Dictionary<String, String> > data= pm.getCompanyID();
            string CompanyID;
            foreach (Dictionary<String, String> valueMap in data)
            {
                valueMap.TryGetValue("CompanyID", out CompanyID);
                c.Items.Add(CompanyID);
            }
        }

        public static void getBuyerID(ComboBox c)
        {
            List<Dictionary<String, String>> data = bm.getBuyerID();
            string buyerID;
            foreach (Dictionary<String, String> valueMap in data)
            {
                valueMap.TryGetValue("BuyerID", out buyerID);
                c.Items.Add(buyerID);
            }
        }

        public static void updateCompanyName(string companyID,string companyName)
        {
            if (!pm.updateCompanyName(companyID, companyName)) MessageBox.Show("YOUR UPDATE COMPANYNAME REQUEST IS FAILED");
            else MessageBox.Show("COMPANYNAME HAS BEEN SUCCESSFULLY UPDATED");
        }

        public static void removeCompany(string companyID)
        {
            if (!pm.removeCompany(companyID)) MessageBox.Show("YOUR DELETE COMPANY REQUEST IS FAILED");
            else MessageBox.Show("COMPANY HAS BEEN SUCCESSFULLY DELETED");
        }

        public static void addBuyer(string buyerID,string buyerName,string buyerType)
        {
            if (!bm.addBuyer(buyerID, buyerName, buyerType)) MessageBox.Show("YOUR ADD BUYER REQUEST IS FAILED");
            else MessageBox.Show("BUYER HAS BEEN SUCCESSFULLY ADDED");
        }
    }
}
