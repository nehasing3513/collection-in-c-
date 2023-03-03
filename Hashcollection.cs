using System;
using System.Collections;
namespace Demo
{
    class Hashcollection
    {
        public void implementingHashTable()
        {
            Hashtable person = new Hashtable();
            person.Add("EmployeeId", 101);
            person.Add("EmployeeName","John");
            person.Add("Job","Manager");
            person.Add("Location","Kolkata");
            person.Add("Salary", null);

            // foreach(var key in person.Keys)
            //   System.Console.WriteLine(key);

            // foreach(var val in person.Values)
            //    System.Console.WriteLine(val);

            foreach(var kv in person.Keys)
               System.Console.WriteLine(kv + ":"+ person[kv]);
        }
        
    }
}