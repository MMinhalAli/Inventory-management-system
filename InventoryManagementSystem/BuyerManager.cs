using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class BuyerManager
    {
        public bool addBuyer(string buyerID,string buyerName,string buyerType)
        {
            int row;
            if ((buyerID == "" || buyerID == "BuyerID") && (buyerName == "" || buyerName == "BuyerName") && (buyerType=="" || buyerType=="BuyerType"))
                row = 0;
            else
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Insert into Buyer values('" + buyerID + "','" + buyerName + "','"+buyerType+"','" + UserManager.getMerchandID() + "')");
            return row == 1 ? true : false;
        }

        public List<Dictionary<String, String>> getBuyerID()
        {
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select BuyerID from Buyer");
            return result;
        }

        public bool updateBuyer(string buyerID,string colName,string data)
        {
            int row;
            if ((buyerID == "" || buyerID == "BuyerID") && ((colName =="BuyerName")||( colName=="Retailer" )||((colName== "WholeSaller"))) && (data==""))
                row = 0;
            else
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update Buyer Set "+colName+"='"+data+"',MerchandiserID='"+UserManager.getMerchandID()+"' where BuyerID='"+buyerID+"'");
            return row == 1 ? true : false;
        }

        public bool deleteBuyer(string buyerID)
        {
            int row;
            if ((buyerID == "" || buyerID == "BuyerID"))
                row = 0;
            else
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Delete From Buyer where BuyerID='"+buyerID+"'");
            return row == 1 ? true : false;
        }
    }
}
