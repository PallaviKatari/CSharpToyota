using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    /// <summary>
    /// Inheritance - acquiring the properties and behaviors of the base class into the derived class
    /// Types of Inheritance:
    /// Single Inheritance - one base class and one derived class
    /// Multilevel Inheritance - one base class and multiple derived classes
    /// Multiple Inheritance - not supported in C# through classes (supported through interfaces)
    /// Hierarchical Inheritance - one base class and multiple derived classes
    /// Hybrid Inheritance - combination of two or more types of inheritance
    /// </summary>
    internal class Inheritance
    {
        static void Main(string[] args)
        {
            Son son = new Son();
            son.Display();
            son.ShowAccount();
            son.DisplaySon();
            GrandSon grandSon = new GrandSon();
            grandSon.Display();
            grandSon.ShowAccount();
            grandSon.DisplaySon();
            grandSon.DisplayGrandSon();
            GrandSon1 grandSon1 = new GrandSon1();
            grandSon1.Display();
            grandSon1.ShowAccount();
            grandSon1.DisplaySon();
            grandSon1.DisplayGrandSon1();

        }
    }
    // Single Inheritance Example
    // Multilevel Inheritance Example
    internal class Father
    {
        public int AccountNumber = 123456;
        public void Display()
        {
            Console.WriteLine("Father's Property");
        }
        public void ShowAccount() { Console.WriteLine("Father's Show Method" + AccountNumber); }
    }
    internal class Son : Father //Single Inheritance
    {
        public void DisplaySon()
        {
            Console.WriteLine("Son's Property");
        }
    }
    internal class GrandSon : Son //Multilevel Inheritance
    {
        public void DisplayGrandSon()
        {
            Console.WriteLine("GrandSon's Property");
        }
    }
    internal class GrandSon1 : Son //Hierarchical Inheritance
    {
        public void DisplayGrandSon1()
        {
            Console.WriteLine("GrandSon1's Property");
        }
    }
}
