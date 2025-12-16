using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    /// <summary>
    /// Basics of CSharp
    /// </summary>
    internal class Basics
    {
        /// <summary>
        /// ctor tab - create a constructor
        /// Special methods - same name as the class name,no return type, initialised automatically
        /// Datatypes - Value type and Reference type
        /// Value Type - int, float, double , bool -> Stack - actual data
        /// Reference Type - class,interface,delegates,array,string  -> Heap - reference(stack) -> actual data(Heap)
        /// </summary>
        
        public Basics()
        {
            Console.WriteLine("Constructor Called");
        }

        /// <summary>
        /// Instance Method
        /// </summary>
        public void Display()
        {
            int a = 10;
            float b = 12.36f;// .1234567
            double c = 12.36;// .12345678901234
            bool d = false;
            Console.WriteLine("Value of the int datatype is:" + a); // + concatenation
            Console.WriteLine("Value of the float datatype is: {0},Value of the double datatype is: {1}", b,c); // Composite formatting
            Console.WriteLine($"Value of the double datatype is: {c}"); // String interpolation
            Console.WriteLine("\\\\Koenig\\\\CSharp.txt"); // \\Basics\\Program "\\Koenig\\CSharp.txt"
            Console.WriteLine(@"\\Koenig\\CSharp.txt"); // @ verbatim string literal
        }
        /// <summary>
        /// Static Method
        /// static and non-static variables
        /// </summary>
        public static void EmployeeDetails()
        {
            //Apart from string all are value types which must be converted while getting input from the console
            int empId;
            string empName;
            Console.WriteLine("Enter the employee ID");
            //cin>> empId;
            empId = Convert.ToInt32(Console.ReadLine()); //100
            Console.WriteLine("Enter the employee name");
            empName = Console.ReadLine(); //John
            Console.WriteLine($"{empName}'s employee ID is {empId}");
        }

        static void Main(string[] args)
        {
            Basics basics = new Basics(); // default constructor - Basics()
            basics.Display();
            EmployeeDetails();
            Basics1 basics1 = new Basics1();
            basics1.Display1();
            Basics1.Display2();
            Console.ReadLine();
        }
    }

    internal class Basics1
    {
        public void Display1()
        {
            Console.WriteLine("Display1 Instance Method");
        }
        public static void Display2()
        {
            Console.WriteLine("Display2 Static Method");
        }
    }
}
