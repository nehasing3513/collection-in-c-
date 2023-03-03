using System;
using System.Collections;

namespace Demo
{
    class MyArrayList
    {
        public void implementingArrayList()
        {
            ArrayList a = new ArrayList();
            a.Add(100);
            a.Add("hello");
            a.Add(200);
            a.Add(300);
            a.Add(400);
            a.Add(500);

            System.Console.WriteLine(string.Join(" ",a.ToArray())); //printing value without using loop.
            // foreach(var i in a)   //printing ArrayListElements.
            //   System.Console.WriteLine(i);

            a.Insert(3,250);//Inserting element at 3rd index
           
            a.RemoveAt(3);//Removing element from 3rd index.
            a.Remove("hello");//Removing a element.

            foreach(var i in a)   //printing ArrayListElements.
              System.Console.WriteLine(i);

        }
    }
}
