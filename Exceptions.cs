using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    /// <summary>
    /// Errors - Developer(Syntax,Logical,Compile-time), Runtime(Exception Handling)
    /// Exception Handling - try(doubtful codes),catch(error message),finally(optional)close the DB connection
    /// throw, multiple catch, Custom Exception Class
    /// EXCEPTION CLASS - BASE CLASS
    /// PRE-DEFINED-Exception class,SystemException class
    /// USER-DEFINED/CUSTOM-Exception/ApplicationException class
    /// </summary>
    internal class Exceptions1
    {
        float result = 0; //to hold the result of division
        //instance method
        public void DivideByZero(float a, float b) // 1.3,0
        {
            try
            {
                result = a / b; // 1.3/0
                if (float.IsInfinity(result)) //true
                {
                    Console.WriteLine("Cannot Divide by 0");
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Source);
            }
            //finally
            //{
            //    Console.WriteLine("I am a finally block");
            //}
        }
        public void DivideByZero1(int a, int b) // 1,0
        {
            try
            {
                result = a / b; // 1/0
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Source);
            }
            //finally
            //{
            //    Console.WriteLine("I am a finally block");
            //}
        }
        public void MultipleCatch()
        {
            int[] numbers1 = { 1, 2, 3, 4, 5 };//1-D array
            int[] numbers2 = { 1, 0, 3 };//1-D array
            for (int i = 0; i < numbers1.Length; i++) //0,1,2,3,4
            {
                try
                {
                    //numbers1[0] / numbers2[0] -> 1/1 = 1
                    //numbers1[1] / numbers2[1] -> 2/0 = DivideByZeroException
                    //numbers1[2] / numbers2[2] -> 3/3 = 1
                    //numbers1[3] / numbers2[3] -> IndexOutOfRangeException
                    //numbers1[4] / numbers2[4] -> IndexOutOfRangeException
                    Console.WriteLine(numbers1[i] / numbers2[i]);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (IndexOutOfRangeException e1)
                {
                    Console.WriteLine(e1.Message);
                }
            }
        }
    }

    public class Exceptions2
    {
        static void Main(string[] args)
        {
            Exceptions1 ex = new Exceptions1();
            //ex.DivideByZero(1.30f, 0);
            //ex.DivideByZero1(1, 0);
            //ex.DivideByZero(1.30f, 0);
            ex.MultipleCatch();
            Console.ReadLine();

        }
    }
}
