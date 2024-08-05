using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericColl.GenericNonGeneric
{
    public class StackObject
    {
        public void DisplayStackObject()
        {
            Console.WriteLine("\n*****Stack*****");
            //Stack
            //Stack allows null (for reference types) and duplicate values.
            //Stack is a LIFO (Last in First Out) collection.

            //Push(T) Inserts an item at the top of the stack.
            //Peek()  Returns the top item from the stack.
            //Pop()   Removes and returns items from the top of the stack.

            Stack<string> mystack = new Stack<string>();
            mystack.Push("John");  //Inserts an item at the top of the stack.
            mystack.Push("Doe");

            foreach (var item in mystack)
                Console.WriteLine(item + ",");

            Console.WriteLine(mystack.Peek()); //Returns the top item from the stack.

            Console.WriteLine("Before Pop");
            Console.WriteLine(mystack.Pop()); //Removes and returns items from the top of the stack.

            Console.WriteLine("After Pop");
            foreach (var item in mystack)
                Console.WriteLine(item + ",");

        }
    }
}
