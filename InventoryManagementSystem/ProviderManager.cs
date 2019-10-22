using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class ProviderManager
    {
        public bool addCompany(string companyID,string companyName)
        {
            int row;
            if ((companyID == "" || companyID == "companyID") && (companyName == "" || companyName == "CompanyName"))
                row = 0;
            else
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Insert into Provider values('"+companyID+"','"+companyName+"','"+UserManager.getMerchandID()+"')");
            return row == 1 ? true : false;
        }

        public List<Dictionary<String, String>> getCompanyID()
        {
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select CompanyID from Provider");
            return result;
        }

        public bool updateCompanyName(string companyID,string companyName)
        {
            int row;
            if ((companyID == "" || companyID == "CompanyID") && (companyName == "" || companyName == "CompanyName"))
                row = 0;
            else
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update Provider Set CompanyName='"+companyName+"',MerchandiserID='"+UserManager.getMerchandID()+"' where CompanyID='"+companyID+"'");
            return row == 1 ? true : false;
        }

        public bool removeCompany(string companyID)
        {
            int row;
            if ((companyID == "" || companyID == "CompanyID"))
                row = 0;
            else
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Delete From Provider where CompanyID='"+companyID+"'");
            return row == 1 ? true : false;
        }
    }
}
