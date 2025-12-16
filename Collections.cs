using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    /// <summary>
    /// C and C++ - STL - Standard Template Library
    /// Stack - LIFO - Last In First Out - Push,Pop,Peek
    /// Queue - FIFO - First In First Out - Enqueue,Dequeue,Peek
    /// List - Dynamic array - LinkedList - Doubly linked list
    /// Collections - Dynamic memory allocation - Stack,Queue,List
    /// using System.Collections.Generic;
    /// using System.Collections;
    /// using System.Collections.Concurrent;
    /// Arrays - Static memory - int[] num={1,2,3,4,5};
    /// </summary>
    internal class Collections
    {
        /// <summary>
        /// ArrayList
        /// </summary>
        public static void ArrayList()
        {
            //ArrayList - Non-Generic Collection
            //Can hold multiple data types
            //int, string, float, double, object
            ArrayList arr = new ArrayList();
            arr.Add(null);//0 - null value
            arr.Add(100);//1 - int
            arr.Add("John");//2 - string
            arr.Add(36000.00);//3 - double
            arr.Add(10.56f);//4 - float
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }
            arr.Remove("John");//removing an item
            arr.Insert(1, "Welcome");//inserting an item at index 1
            arr.RemoveAt(2);

            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }

        }
        //Generic Collections
        //What are generics - to create a class,method,interface with a placeholder for the data type
        public static void List()
        {
            //List Collection - Generic Collection - what type of data it is going to hold
            //List<int> - to hold int data types only
            //<>- Angle brackets - Generic type parameter
            List<int> list = new List<int>();
            list.Add(100);
            list.Add(200);
            //list.Add(10.89); //Error - cannot convert double to int
            foreach (var a in list)
            {
                Console.WriteLine(a);
            }
        }
        //sorted list - generic collection
        //key-value pairs
        public static void sortedList()
        {
            SortedList<int, string> keyValuePairs = new SortedList<int, string>();
            keyValuePairs.Add(1, "Harita");
            keyValuePairs.Add(2, "Yamini");
            keyValuePairs.Add(3, "Vignesh");
            //keyValuePairs.Add(1, "Sivabharath");//error - key already exists
            foreach (var a in keyValuePairs)
            {
                Console.WriteLine(a);
            }

        }
        //stack - generic collection
        //Stack<T> - Push,Pop,Peek
        public static void Stack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            foreach (var a in stack)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine(stack.Peek());//3
            stack.Pop();//delete 3
            Console.WriteLine(stack.Peek());//2
            foreach (var a in stack)
            {
                Console.WriteLine(a);
            }

        }
        //Dictionary - generic collection
        public static void Dictionary()
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "Arun");
            keyValuePairs.Add(2, "Srikanth");
            keyValuePairs.Add(3, "Hemanth");
            keyValuePairs.Add(4, "Darshan");
            foreach (var a in keyValuePairs)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine($"Is this key present in a Dictionary:{keyValuePairs[2]}");
        }

        //Hashtable - Non-Generic Collection
        //HashTable - key-value pairs
        public static void hashtable()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "John");
            ht.Add(2, 100);
            ht.Add(3, 36.54);
            ICollection collection = ht.Keys;
            foreach (var a in collection)
            {
                Console.WriteLine(a);
            }
            ICollection values = ht.Values;
            foreach (var a in values)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine($"Is this key present in a hashtable:{ht[3]}");

        }
      
        static void Main(string[] args)
        {
            //ArrayList();
            //List();
            //sortedList();
            //Stack();
            //Dictionary();
            hashtable();
            Console.ReadLine();

        }

    }
}
