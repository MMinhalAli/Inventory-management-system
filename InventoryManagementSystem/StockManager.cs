using System;
using System.Collections.Generic;

namespace InventoryManagementSystem
{
    class StockManager
    {
       
        public bool addItemIntoStock(string itemID,string quantity)
        {
            int row;
            if ((itemID == "" || itemID == "ItemID") && (quantity == "" || quantity == "Quantity"))
                row = 0;
            else
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Insert into Stock values('" + itemID + "','" + quantity + "')");
            return row == 1 ? true : false;
        }

        public List<Dictionary<String, String>> availableStock()
        {
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select Item.ItemID,Item.ItemName,Item.Cost,Item.CompanyID,Stock.Quantity from Item Inner Join Stock ON  Item.ItemID=Stock.ItemID");
            return result;
        }

        public bool deleteItemFromStock(string itemID)
        {
            int row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Delete from Stock where ItemID='" + itemID + "'");
            return row == 1 ? true : false;
        }
    }
}
