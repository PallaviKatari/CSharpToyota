using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System - namespaces - like the header files in C,C++ - class libraries

namespace CSharpPrograms // - collection of classes
{
    /// <summary>
    /// class name - Program
    /// class keyword
    /// internal - access modifier
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// summaries are in xml format - documentation comments - data about the program
        /// Entry point of the program
        /// Functions - Methods
        /// void - need no return any thing back to the caller method - Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //WriteLine - method of Console class - prints the output to the console
            Console.WriteLine("Hello World!"); // print Hello World to the console
            Console.ReadLine(); // wait for user input before closing the console window       
        }
    }
}
