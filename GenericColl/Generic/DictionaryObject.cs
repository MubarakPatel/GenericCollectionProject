using GenericColl.Generic.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericColl.Generic
{
    public class DictionaryObject
    {
        public void DisplayStudents()
        {
            Console.WriteLine("\n*****Dictionary*****");    
            //Dictionary
            //Dictionary is a collection of key/value pairs.
            //Dictionary is a generic collection.
            //Dictionary is faster than HashTable.
            //Dictionary is not thread safe for use by multiple reader threads and a single writing thread.
            //Dictionary<TKey, TValue> where TKey is the type of the key and TValue is the type of the value.
            

            Dictionary<int, string> mystudents = new Dictionary<int, string>();
            mystudents.Add(1, "John");
            mystudents.Add(2, "Doe");

            //The following throws run-time exception: key already added.
            //mystudents.Add(2, "Doe");


            //display the students
            foreach (KeyValuePair<int, string> student in mystudents)
            {
                Console.WriteLine("Id: " + student.Key + " Name: " + student.Value);
            }

            FindStudents(mystudents);
            TryGetValueStudents(mystudents); 
        }

        public void FindStudents(Dictionary<int, string> mystudents)
        {
            //use ContainsKey() to check for an unknown key
            if (mystudents.ContainsKey(2))
            {
                Console.WriteLine(mystudents[2]);
            }
        }


        public  void TryGetValueStudents(Dictionary<int, string> mystudents)
        {
            //use TryGetValue() to check for an unknown key
            string value = "";
            if (mystudents.TryGetValue(3, out value))
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Key not found");
            }
        }
       
        
        

    }
}
