using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    internal class Arrays
    {
        //static methods - can be called without creating the object of the class
        //1-D Array - Either single row or single column
        public static void OneDimArray()
        {
            //int[] arrayName = new int[10];
            int[] array1 = new int[2] { 1, 2 };
            int[] array2 = new int[] { 11, 2, 31, 14, 25 };
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            //Accessing the elements of the array
            //Special loop to access the elements of the array - foreach loop
            foreach (int i in array1) //1,2 - 2 looping will take place
            {
                Console.WriteLine(i); // prints 1 and 2
            }
            foreach (int i in array2)
            {
                Console.WriteLine(i); // prints 11,2,31,14,25
            }
            //Array class methods and properties
            //System.Linq; Language Integrated Query
            Console.WriteLine(array2.Length);//5
            Console.WriteLine(array2.Max());//31
            Console.WriteLine(array2.Min());//2
            Console.WriteLine(array2.Sum());
            Console.WriteLine(array2.Average());
            Console.WriteLine(array2.Count());//5
            Array.Sort(array2); //ordering the elements in ascending order
            Array.Reverse(array2); //ordering the elements in descending order
            foreach (int i in array2)
            {
                Console.WriteLine(i);
            }

        }

        public static void LoopingExample()
        {
            //for loop - entry
            // initialization, condition, increment/decrement
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"For Loop Iteration: {i}");//0,1,2,3,4
            }
            //while loop - entry
            int j = 0; //initialization
            while (j < 5) //condition
            {
                Console.WriteLine($"While Loop Iteration: {j}"); // 0,1,2,3,4
                // j=1
                j++; // j++ - post increment - assigns and then inc , ++j - pre increment - inc and then assigns
            }
            //do-while loop - exit 
            int k = 10;//initialization
            do
            {
                Console.WriteLine($"Do-While Loop Iteration: {k}");
                k++;//increment
            } while (k < 5);//condition
        }

        public static void TwoDimArray()
        {
            int[,] numbers = new int[,]
            {
                { 1, 2 },
                { 2, 3 },
                { 3, 4 }
            };
            // Control Statements
            // Looping and Conditional
            // Looping - Iteration - Entry (while,for) ,Exit (do-while)
            // Conditional - simple if, if-else, else if, nested if , switch-case

            for (int i = 0; i < 3; i++) // rows
            {
                for (int j = 0; j < 2; j++) // columns
                {
                    Console.Write(numbers[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }

        }
        /// <summary>
        /// Array of Arrays
        /// </summary>
        public static void JaggedArray()
        {
            //Jagged Array Declaration which accepts different sizes of arrays of 1-D arrays
            int[][] arrays = new int[][]
            {
                //         0,1,2
                new int[6]{1,2,3,4,5,6},// 0th index
                new int[2]{4,5}, // 1st index
                new int[5]{5,6,7,8,9} // 2nd index
            };
            //Represents the number of arrays present in the jagged array
            for (int i = 0; i < arrays.Length; i++) // Length = 3 i=0 0<3,i=1 i<3,i=2 2<3
            {
                //Represents the number of elements present in each array
                for (int j = 0; j < arrays[i].Length; j++) // arrays[0].Length = 3,arrays[1].Length=2,arrays[2].Length=3
                {
                    Console.Write($"{arrays[i][j]}");// arrays[0][0] = 1, arrays[0][1] = 2,arrays[0][2] = 3
                    //arrays[1][0] = 4, arrays[1][1] = 5
                    //arrays[2][0] = 5, arrays[2][1] = 6,arrays[2][2] = 7
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //OneDimArray();
            //Console.WriteLine("************************");
            //LoopingExample();
            //Console.WriteLine("************************");
            //TwoDimArray();
            //Console.WriteLine("************************");
            JaggedArray();
            //Console.ReadLine();

        }
    }
}
