using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericColl.GenericNonGeneric
{
    public class SortedListObject
    {
        public void DisplaySortedList()
        {

            Console.WriteLine("\n*****SortedList*****");
            //SortedList

            //Sorted List Support both Generic and Non-Generic Collections
            //SortedList of int keys, string values 
            SortedList<int, string> sortedList = new SortedList<int, string>();
                sortedList.Add(1, "John");
                sortedList.Add(2, "Doe");
                sortedList.Add(3, null);

            //display the sorted list
            foreach (KeyValuePair<int, string> student in sortedList)
            {
                Console.WriteLine("Id: " + student.Key + " Name: " + student.Value);
            }

            //The following will throw exceptions
            //numberNames.Add("Three", 3); //Compile-time error: key must be int type
            //numberNames.Add(1, "One"); //Run-time exception: duplicate key
            //numberNames.Add(null, "Five");//Run-time exception: key cannot be null

            Console.WriteLine(sortedList[1]); //output: Doe

        }
    }
}
