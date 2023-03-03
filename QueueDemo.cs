using System;

using System.Collections;
namespace Demo
{
    class QueueDemo
    {
        public void queueMethod()
        {
            Queue myq = new Queue();
            myq.Enqueue(100);
            myq.Enqueue(200);
            myq.Enqueue(300);
            myq.Enqueue(400);
            myq.Enqueue(500);
            Traverse(myq);
            int deletedele = Convert.ToInt32(myq.Dequeue()); //as object cannot be converted to int.  
            System.Console.WriteLine("Element deleted from the queue: {0} ", deletedele);
            System.Console.WriteLine("Check whether the element is present in a queue or not: {0}", myq.Contains(300));
            System.Console.WriteLine("Check whether the element is present in a queue or not: {0}", myq.Contains(330));
            System.Console.WriteLine("Elements at the begining of the queue: {0}", myq.Peek());
            Traverse(myq);
        }
        public void Traverse(Queue q)
        {
            System.Console.WriteLine("Elements in the queue are: ");
            foreach (var item in q)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}