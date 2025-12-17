using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    /// <summary>
    /// public,private,internal,[protected, internal protected]-inheritance(child class)
    /// OOPS - Class,Object,Abstraction,Encapsulation,Inheritance,Polymorphism
    /// </summary>
    public class AccessSpecifiers
    {
        private int _count = 0;
        /// <summary>
        /// prop - double tab
        /// Properties - to provide access to the private members of a class
        /// get; set;
        /// </summary>
        public int Count
        {
            get//read
            {
                return _count;//10
            }
            set//write,assign
            {
                _count = value;//10
            }

        }
        // Constructor
        public AccessSpecifiers()
        {
            Console.WriteLine(_count);//0
        }
        public void Display()
        {
            Console.WriteLine("Access Specifiers Example" + _count);
        }

    }
    internal class Encapsulation
    {
        static void Main(string[] args)
        {
            AccessSpecifiers accessSpecifiers = new AccessSpecifiers();
            //accessSpecifiers._count = 10; // not accessible due to private access modifier
            accessSpecifiers.Count = 10;
            accessSpecifiers.Display();
            Console.WriteLine(accessSpecifiers.Count);
            Console.ReadLine();

        }
    }
}
