using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace GenericColl.NonGeneric
{
    public class HashTableObject
    {

        public void DisplayHashTable()
        {
            Console.WriteLine("\n*****HashTable*****");
            //HashTable
            //HashTable is a collection of key/value pairs.
            //HashTable is a non-generic collection.
            //HashTable is thread safe for use by multiple reader threads and a single writing thread.
            //HashTable is slower than Dictionary.

            Hashtable myhashtable = new Hashtable();
            myhashtable.Add("001", "John");
            myhashtable.Add("002", "Doe");

            //display the hashtable
            foreach (var item in myhashtable.Keys)
            {
                Console.WriteLine(item + " : " + myhashtable[item]);
            }
        }

    }
}
