using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class UserManager
    {
        private static string MerchandiserID;
        public bool performSignIn(string userName,string password)
        {
            MerchandiserID = userName;
            string pass;
            List<Dictionary<String, String>> result=DataBaseManager.runSelectQuery("Select Password from SignInInfo where UserName='"+userName+"'");
            result.ElementAt(0).TryGetValue("Password",out pass);
            return password == pass ? true : false;
        }

        public static string getMerchandID()
        { return MerchandiserID; }
    }
}
