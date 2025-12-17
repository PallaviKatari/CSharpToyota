using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    /// <summary>
    /// Pure Abstraction - Interfaces
    /// Interfaces - 100% abstraction - data hiding - secured
    /// Interfaces can have methods,properties,events,indexers
    /// Interface naming convention - IProperty,IEmployee
    /// </summary>
    internal interface IProperty
    {
        void ShowPropertyDetails();
        int PropertyID { get; set; }
    }
    internal interface IEmployee
    {
        void ShowEmployeeDetails();
        int EmployeeID { get; set; }
    }
    interface ICustomer
    {
        void ShowCustomerDetails();
        int CustomerID { get; set; }
    }
    // We can implement multiple interfaces in a class
    internal class RealEstate : IProperty, IEmployee, ICustomer
    {
        public int PropertyID { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public void ShowPropertyDetails()
        {
            Console.WriteLine("Property ID: " + PropertyID);
        }
        public void ShowEmployeeDetails()
        {
            Console.WriteLine("Employee ID: " + EmployeeID);
        }
        public void ShowCustomerDetails()
        {
            Console.WriteLine("Customer ID: " + CustomerID);
        }
    }
    internal class Interfaces
    {
        static void Main(string[] args)
        {
            RealEstate realEstate = new RealEstate();
            realEstate.PropertyID = 101;
            realEstate.EmployeeID = 201;
            realEstate.CustomerID = 301;
            realEstate.ShowPropertyDetails();
            realEstate.ShowEmployeeDetails();
            realEstate.ShowCustomerDetails();
        }
    }
}
