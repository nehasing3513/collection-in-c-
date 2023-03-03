using System;
using System.Collections;
namespace Demo
{
    class StackDemo
    {
        public void StackMethod()
        {
            Stack stk = new Stack();
            stk.Push(100);
            stk.Push(200);
            stk.Push(300);
            stk.Push(400);
            stk.Push(500);
            stk.Push(600);
            DisplayingStack(stk);
            System.Console.WriteLine("The number elements of a stack: {0}", stk.Count);
            System.Console.WriteLine("Checking whether 400 is there in the stack or not: {0}", stk.Contains(400));
            System.Console.WriteLine("Displaying the top element:{0}", stk.Peek());
            System.Console.WriteLine("Removing the element from the top of the stack: {0}", stk.Pop());
            System.Console.WriteLine("Displaying stack after popingnthe top element: -");
            DisplayingStack(stk);
            stk.Push(null);
            DisplayingStack(stk);
        }
        public void DisplayingStack(Stack stk)
        {
            System.Console.WriteLine("Displaying the elements of stack :- ");
            foreach (var item in stk)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}