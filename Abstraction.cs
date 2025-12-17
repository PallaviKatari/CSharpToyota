using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    /// <summary>
    /// Abstraction - Hiding the implementation details and showing only the functionality to the user
    /// Methods,Interfaces,Abstract Classes - to achieve abstraction in C#
    /// Abstract Classes - abstract keyword - cannot be instantiated - can have abstract and non-abstract methods
    /// Abstract class - base class for other classes
    /// Abstarct Methods - no method body - must be implemented in derived class    
    /// Abstract class can have constructors,destructors,fields,properties,methods(events,indexers)
    /// Abstract class - partial abstraction - 0 to 100%
    /// Partial secured - abstract class
    /// </summary>
    internal abstract class Abstraction //Base Class - 2 properties
    {
        // Abstract Method
        // Method signature only
        // partial abstraction
        public abstract void Show();//data hiding
        // Non-Abstract Method
        public void Display() // data not hidden
        {
            Console.WriteLine("Non-Abstract Method in Abstract Class");
        }
        public abstract void ElectricityBill();
        public void PayBill(int units)
        {
            int bill = 0;
            if(units > 85)
            {
                bill = units * 10;
                Console.WriteLine("Total Bill Amount: $" + bill);
            }
            else
            {
                bill= units * 5;
                Console.WriteLine("Total Bill Amount: $" + bill);
            }
            Console.WriteLine("Paying Electricity Bill");
        }
    }
    //Inhertitance - derived class from base class
    //What is Inheritance - acquiring the properties and behaviors of the base class into the derived class
    internal class DerivedAbstraction : Abstraction //Derived Class 
    {
        // Implementing the abstract method
        //MethodOverriding - run-time polymorphism
        public override void Show()
        {
            Console.WriteLine("Abstract Method Implemented in Derived Class - Property in Electronic City");
        }
        public override void ElectricityBill()
        {
            Console.WriteLine("Electricity Bill for Electronic City Property: $100");
        }
    }
    internal class DerivedAbstraction1 : Abstraction
    {
        public override void Show()
        {
            Console.WriteLine("Abstract Method Implemented in Derived Class 1 - Property in Jainagar");
        }
        public override void ElectricityBill()
        {
            Console.WriteLine("Electricity Bill for Jainagar Property: $80");
        }
    }
    internal class MethodOverriding
    {
        static void Main(string[] args)
        {
            //You cannot create an instance of an abstract class
            //Abstraction abstraction = new Abstraction();
            DerivedAbstraction derived = new DerivedAbstraction();
            derived.Show(); // Abstract Method Call
            derived.Display(); // Non-Abstract Method Call
            derived.ElectricityBill();
            derived.PayBill(100);
            DerivedAbstraction1 derived1 = new DerivedAbstraction1();
            derived1.Show();
            derived1.Display();
            derived1.ElectricityBill();
            derived1.PayBill(80);
        }
    }
}
