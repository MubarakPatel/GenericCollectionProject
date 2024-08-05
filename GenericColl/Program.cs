// See https://aka.ms/new-console-template for more information
using GenericColl.Generic;
using GenericColl.GenericNonGeneric;
using GenericColl.NonGeneric;

Console.WriteLine("Hello, World!");

//GENERIC COLLECTIONS

//List
ListObject listObject = new ListObject();  
listObject.DisplayPrimeNumbers();
listObject.DisplayStudents();


//Dictionary
DictionaryObject dictionaryObject = new DictionaryObject();
dictionaryObject.DisplayStudents();


//GENERIC AND NON-GENERIC COLLECTIONS
//Sortedlist
SortedListObject sortedList = new SortedListObject();
sortedList.DisplaySortedList();

//Queue
QueueObject queueObject = new QueueObject();
queueObject.DisplayQueue();


//Stack
StackObject stackObject = new StackObject();
stackObject.DisplayStackObject();


//NON-GENERIC COLLECTIONS
//ArrayList
ArrayListObject arrayListObject = new ArrayListObject();
arrayListObject.DisplayArrayList();


//HashTable
HashTableObject hashTableObject = new HashTableObject();
hashTableObject.DisplayHashTable();


