using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericColl.NonGeneric
{
    public class ArrayListObject
    {
        public void DisplayArrayList()
        {
            //An ArrayList can be used to add unknown data where you don't know the **types** and the **size** of the data.
            //ArrayList is a non-generic collection.
            //ArrayList is a resizable array.
            //ArrayList can store multiple data types.
            //ArrayList can store null and duplicate values.

            Console.WriteLine("\n*****ArrayList*****");
            //ArrayList

            ArrayList myarraylist = new ArrayList();
            myarraylist.Add(1);
            myarraylist.Add("John");
            myarraylist.Add(true);
            myarraylist.Add(1);
            myarraylist.Add(null);
            myarraylist.Add(4.15);

            foreach (var item in myarraylist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Before Removing");
            //myarraylist.Remove(null); //Removes first occurance of null
            //myarraylist.RemoveAt(4); //Removes element at index 4
            myarraylist.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)

            Console.WriteLine("After Removing");
            foreach (var item in myarraylist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
