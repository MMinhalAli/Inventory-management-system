using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    class ItemManager
    {
    
        public bool addItem(string itemID, string itemName, string cost, string companyID, string itemRegistrationTime)
        {
            int row;
            if ((itemID == "" || itemID == "ItemID") && (itemName == "" || itemName == "ItemName") && (cost == "" || cost == "Cost") && (companyID == "" || companyID == "CompanyID"))
                row = 0;
            else
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Insert into Item values('" + itemID + "','" + itemName + "','" + cost + "','" + companyID + "','" + itemRegistrationTime + "','" + UserManager.getMerchandID() + "')");
            return row == 1 ? true : false;
        }

        public bool updateItem(TextBox txtBox1, TextBox txtBox2, TextBox txtBox3, string itemID)
        {
            int row=0;
            if (txtBox1.Text!="" && txtBox1.Text!=txtBox1.Name)
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update Item Set "+txtBox1.Name+"='"+txtBox1.Text+"',ItemRegistrationTime='" + DateTime.Now + "',MerchandiserID='" + UserManager.getMerchandID() + "' where ItemID='" + itemID + "'");
            if(txtBox2.Text!="" && txtBox2.Text!=txtBox2.Name)
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update Item Set " + txtBox2.Name + "='" + txtBox2.Text + "',ItemRegistrationTime='" + DateTime.Now + "',MerchandiserID='" + UserManager.getMerchandID() + "' where ItemID='" + itemID + "'");
            if (txtBox3.Text != "" && txtBox3.Text != txtBox3.Name)
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update Item Set " + txtBox3.Name + "='" + txtBox3.Text + "',ItemRegistrationTime='" + DateTime.Now + "',MerchandiserID='" + UserManager.getMerchandID() + "' where ItemID='" + itemID + "'");
            return row==1 ? true : false;
        }

        public bool deleteItem(string itemID)
        {
            int row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Delete from Item where ItemID='"+itemID+"'");
            return row == 1 ? true : false;
        }

        public List<Dictionary<String, String>> getItemIDs()
        {
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select ItemID from Item");
            return result;
        }

        public bool setItemPriceManagement(string itemID,string retailerProfitPrice,string wholeSallerProfitPrice)
        {
            int row;
            if ((itemID == "" || itemID == "ItemID") && (retailerProfitPrice == "" || retailerProfitPrice == "RetailerProfitPrice") && (wholeSallerProfitPrice == "" || wholeSallerProfitPrice == "WholeSallerProfitPrice"))
                row = 0;
            else
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Insert into ItemPriceManagementTable values('" + itemID + "','"+retailerProfitPrice+"','"+wholeSallerProfitPrice+"')");
            return row == 1 ? true : false;
        }

        public bool deleteItemFromItemPriceManagement(string itemID)
        {
            int row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Delete from ItemPriceManagementTable where ItemID='" + itemID + "'");
            return row == 1 ? true : false;
        }
    }
}
