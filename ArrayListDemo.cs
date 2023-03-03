using System;
using System.Collections;
namespace Demo
{
    class A
    {
        public void Method1()
        {
            System.Console.WriteLine("Enter the number of elements you want to insert: ");
            int n = Convert.ToInt32(Console.ReadLine());
            ArrayList al = new ArrayList(n);
            System.Console.WriteLine("Enter your ArrayList element: ");
            for (int i = 0; i < n; i++)
            {
                int ele = Convert.ToInt32(Console.ReadLine());
                al.Add(ele);
            }
            Displayelements(al);
        }
        public void Method2()
        {
            ArrayList myal = new ArrayList();
            System.Console.WriteLine("\nNow start. : ");
            System.Console.WriteLine("If you want to exit, then please do enter any negative value");
            System.Console.WriteLine("\nNow start entering your Array elements: ");
            while (true)
            {
                int ele = Convert.ToInt32(Console.ReadLine());
                if (ele < 0)
                    break;
                myal.Add(ele);
            }
            Displayelements(myal);
        }
        public void Displayelements(ArrayList a)
        {
            System.Console.WriteLine("Displaying the ArrayList elements: ");
            foreach (var item in a)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}