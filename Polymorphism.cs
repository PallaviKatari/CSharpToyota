using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    /// <summary>
    /// Polymorphism - many forms
    /// Method Overloading - Compile-time Polymorphism - Static Polymorphism
    /// Method Overriding - Run-time Polymorphism - Dynamic Polymorphism
    /// </summary>
    internal class Polymorphism
    {
        //Garbage Collection is a default feature in C#
        //No need to free the memory explicitly
        //Automatic memory management
        static void Main(string[] args)
        {
            Polymorphism poly1 = new Polymorphism(); //Default Constructor
            Polymorphism poly2 = new Polymorphism(10); //Constructor with one integer parameter
            Polymorphism poly3 = new Polymorphism(10, 20); //Constructor with two integer parameters
            Polymorphism poly4 = new Polymorphism(12.34); //Constructor with double parameter
        }
        // Constructor Overloading - same class name with different signatures
        //Default Constructor
        public Polymorphism()
        {
            //Constructor
        }
        //Constructor with one integer parameter
        public Polymorphism(int a)
        {
            Console.WriteLine("Polymorphism Example");
        }
        //Constructor with two integer parameters
        public Polymorphism(int a, int b)
        {
            Console.WriteLine("Constructor with two parameters");
        }
        //Constructor with double parameter
        public Polymorphism(double a)
        {
            Console.WriteLine("Constructor with double parameter");
        }
        //Destructor
        //No access specifier,no parameters,no return type
        //Only one destructor is allowed per class
        ~Polymorphism()
        {
            //Destructor - cleanup code
        }

        // Method Overloading - same method name with different signatures
        // signature - number of parameters,datatype of parameters,sequence of parameters
        public void Add(int a, int b)
        {
            Console.WriteLine("Sum of two integers: " + (a + b));
        }
        public void Add(double a, double b)
        {
            Console.WriteLine("Sum of two doubles: " + (a + b));
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine("Sum of three integers: " + (a + b + c));
        }
        public void Add(double a, int b)
        {
            Console.WriteLine("Sum of double and integer: " + (a + b));
        }
        public void Add(int a, double b)
        {
            Console.WriteLine("Sum of integer and double: " + (a + b));
        }

    }
}
