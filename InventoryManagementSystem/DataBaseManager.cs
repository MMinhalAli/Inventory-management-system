using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace InventoryManagementSystem
{
    class DataBaseManager
    {
        private static string connString = "Data Source=DESKTOP-S7J53V9;Initial Catalog=InventoryManagement;Integrated Security=True";

        public static List<Dictionary<String, String>> runSelectQuery(string query)
        {
            List<Dictionary<String, String>> data = new List< Dictionary < String, String>> ();
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Dictionary<String, String> row = new Dictionary<string, string>();
                    for (int i = 0; i < sdr.FieldCount; ++i)
                    {
                        row.Add(sdr.GetName(i), sdr.GetString(i));
                    }
                    data.Add(row);
               }
            }
            conn.Close();
            return data;
        }

        public static int runInsertAndUpdateAndDeleteQuery(string query)
        {
            int rowsAffected = 0;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                rowsAffected=cmd.ExecuteNonQuery();
            }
            conn.Close();
            return rowsAffected;
        }
        
    }
}
