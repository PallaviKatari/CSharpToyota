using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    internal class SimpleProgram
    {
        //Classes
        //objects
        static void Main(string[] args)
        {
            //instance/object is created using new keyword
            SimpleProgram simpleProgram = new SimpleProgram(); //object creation

            simpleProgram.SampleMethod(); //instance method call

            StaticMethod(); //static method call

            //30
            int result = simpleProgram.Add(10, 20); //method with parameters and return type
            Console.WriteLine("Addition Result: " + result);

            StaticExample.BasicsMethod();
            StaticExample staticExample = new StaticExample();
            staticExample.BasicsMethod1();

            ConstructorExample constructorExample = new ConstructorExample();
            constructorExample.DisplayName();

        }

        //access specifier returntype MethodName(parameters)
        //instance method
        public void SampleMethod()
        {
            Console.WriteLine("This is a sample method in SimpleProgram class.");
        }

        //static method
        public static void StaticMethod()
        {
            Console.WriteLine("This is a static method in SimpleProgram class.");
        }

        public int Add(int x, int y) // 10,20
        {
            return x + y; // 30
        }
    }

    internal class StaticExample
    {
        public static void BasicsMethod()
        {
            Console.WriteLine("Basics1 class static method called.");
        }

        public void BasicsMethod1()
        {
            Console.WriteLine("Basics1 class instance method called.");
        }
    }

    internal class ConstructorExample
    {
        //constructor
        //special method - same name as class name
        //no return type
        //automatically invoked when an object is created

        public string name;
        public ConstructorExample()
        {
            name= "Default Name";
            Console.WriteLine("Constructor called.");
        }

        public void DisplayName()
        {
            Console.WriteLine("Name: " + name);
        }   
    }
}

