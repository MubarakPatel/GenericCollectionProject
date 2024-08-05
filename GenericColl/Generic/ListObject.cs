using GenericColl.Generic.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericColl.Generic
{
    public class ListObject
    {
        public void DisplayPrimeNumbers()
        {
            Console.WriteLine("\n*****List*****");
            //List
            //List is a collection of objects.
            //List is a generic type.
            //List allows duplicate elements.
            //List is an ordered collection.
            //List can be accessed using an index.
            //List can be iterated using foreach loop.
            //List can be sorted.
            List<int> primenumber = new List<int>();
            primenumber.Add(2);
            primenumber.Add(3);

            //display the prime numbers
            foreach (int i in primenumber)
            {
                Console.WriteLine(i);
            }
        }

        public void DisplayStudents()
        {
            //List with Dto
            List<Students> students = new List<Students>();
            students.Add(new Students { Id = 1, Name = "John" });
            students.Add(new Students { Id = 2, Name = "Doe" });

            foreach (Students student in students)
            {
                Console.WriteLine("Id: " + student.Id + " Name: " + student.Name);
            }
        }
    }
}

