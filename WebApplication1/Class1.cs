using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace WebApplication1
{
    public static class Class1
    {
        private static int i = 0;
        //defining login table - only 2 entries
        private static Dictionary<string, string> login = new Dictionary<string, string>() { { "alice", "al123" }, { "bob", "bo123" } };
        //defining database - cols: item, price, alice_count, bob_count
        private static Dictionary<string, int[]> Database = new Dictionary<string, int[]>() { { "onion", new int[4] { 5,25, 0, 0 } }, { "banana", new int[4] { 4,35, 0, 0 } }, { "potato", new int[4] { 6,20, 0, 0 } } };
        
        // method to check login 
        public static bool checkLogin(string user, string pass)
        {
           if(login.ContainsKey(user))
            {
                if(login[user]==pass)
                {
                    return true;
                }
            }
            return false;
        }

        //method to insert count values
        public static void Insertval(string user,int count_it1, int count_it2, int count_it3)
        {
            int[] count = new int[3] { count_it1, count_it2, count_it3 };
            int countcol = (user == "alice") ? 2 : 3;
            int i = 0;
            //Database[user] = new int[] { count_it1, count_it2, count_it3 };
            foreach(KeyValuePair<string,int[]> item in Database)
            {
                item.Value[countcol] += count[i];
                item.Value[0] -= count[i];
                i++;
            }
        
        }

        //method to return database - for invoice generation
         public static Dictionary<string,int[]> InvoiceGen(string user)
        {
            Dictionary<string, int[]> Invoice = new Dictionary<string, int[]>();
            int countcol = (user == "alice") ? 2 : 3;
            foreach(KeyValuePair<string, int[]> kvpair in Database)
            {
                Invoice.Add(kvpair.Key, new int[3] { kvpair.Value[1], kvpair.Value[countcol], kvpair.Value[1] * kvpair.Value[countcol] });

            }
            return Invoice;
        }

        // method to return inventory of item - to check max items to be ordered
        public static int Inventory_return(string item)
        {
            return Database[item][0];
        }
    }
}