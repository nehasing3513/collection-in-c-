using System;
using System.Collections;
namespace Demo
{
    class DemohashTable
    {
        public void hashtableMethod()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Name", "John");
            ht.Add("EmployeeId", "258963147");
            ht.Add("Designation", "Manager");
            ht.Add("Location", "Kolkata");

            foreach (var keyval in ht.Keys) //printing keys value
            {
                System.Console.WriteLine(keyval);
            }
            foreach (var val in ht.Values)
            {
                System.Console.WriteLine(val); //printing values for a key 
            }
            foreach (var item in ht.Keys) //printing keys and values together 
            {
                System.Console.WriteLine("{0} : {1}", item, ht[item]);
            }
            System.Console.WriteLine(ht.Count);
            ht.Remove("Designation");
            foreach (var item in ht.Keys) //printing keys and values together
            {
                System.Console.WriteLine("{0} : {1}", item, ht[item]);
            }
            System.Console.WriteLine(ht.ContainsKey("Name"));
            System.Console.WriteLine(ht.ContainsValue("kolkata"));
            System.Console.WriteLine(ht.GetHashCode());//Equals method in hashtable
        }
    }
}