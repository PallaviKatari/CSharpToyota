using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    internal class Conditional
    {
        static void Main(string[] args)
        {
            //IfExample();
            //IfElseExample();
            //IfElseIfExample();
            //NestedIfExample();
            //SwitchExample();
            GreaterExample();

        }
        //Simple if statement
        //eligible to vote
        public static void IfExample()
        {
            int age = 25;
            if (age >= 18)
            {
                Console.WriteLine("Eligible to Vote");
            }
        }
        //if-else statement
        //even or odd
        public static void IfElseExample()
        {
            int number = 16;
            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is Even");
            }
            else
            {
                Console.WriteLine(number + " is Odd");
            }
        }
        //if-else if-else statement
        //grading system
        public static void IfElseIfExample()
        {
            int marks = 64;
            if (marks >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (marks >= 75)
            {
                Console.WriteLine("Grade B");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Grade D");
            }
        }
        //nested if statement
        // positive even or odd
        public static void NestedIfExample()
        {
            int num;
            Console.WriteLine("Enter a Number:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num + " is a Positive Even Number");
                }
                else
                {
                    Console.WriteLine(num + " is a Positive Odd Number");
                }
            }
            else
            {
                Console.WriteLine(num + " is not a Positive Number");
            }
        }
        //switch-case statement
        //day of the week
        public static void SwitchExample()
        {
            Console.WriteLine("Enter Day Number (1-7):"); //4
            int day = Convert.ToInt32(Console.ReadLine()); //4
            string dayName;
            switch (day) //4
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid Day";
                    break;
            }
            Console.WriteLine("Day: " + dayName);
        }
        //Ternary Operator - Conditional Operator
        // greater of two numbers
        public static void GreaterExample()
        {
            int a = 100;
            int b = 20;
            int max = (a > b) ? a : b; // Conditional Operator
            Console.WriteLine("Max Value: " + max);
        }
    }
}
