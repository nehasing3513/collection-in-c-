using System;
using System.Collections.Generic;
namespace Demo{
    class Dictionarydemo
     {
        public void dictionaryMethod1()
         {
            Dictionary<string,string> dic = new Dictionary<string, string>();
            dic.Add("Name","John");
            dic.Add("EmployeeID","123852967");
            dic.Add("Designation","Manager");
            dic.Add("Location","Kolkata");
            
            foreach (var item in dic)
             {
                 System.Console.WriteLine("{0}, {1}", item.Key, item.Value);
             }
         }
     }
 }
