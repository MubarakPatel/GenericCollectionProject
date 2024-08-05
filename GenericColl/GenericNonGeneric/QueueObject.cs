using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericColl.GenericNonGeneric
{
    public class QueueObject
    {
        public void DisplayQueue()
        {
            Console.WriteLine("\n*****Queue*****");
            //Queue
            //Queue is a collection of objects.
            //Queue is a generic type.
            //Queue allows duplicate elements.
            //Queue is a FIFO (First in First Out) collection.
            //Queue can be iterated using foreach loop.
            

            Queue<string> myqueue = new Queue<string>();
            myqueue.Enqueue("John");
            myqueue.Enqueue("Doe");

            //Before Remvoing the Queue
            foreach(var item in myqueue)
            {
                Console.WriteLine(item);
            }

            //Peek()	Returns an first item from the queue without removing it.
            Console.WriteLine(myqueue.Peek()); //prints H

            //Dequeue = Returns an item from the beginning of the queue and removes it from the queue.
            myqueue.Dequeue(); //removes John from the queue
            
            //After Removing the Queue
            foreach (var item in myqueue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
