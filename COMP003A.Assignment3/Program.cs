/* Author: Anastasia Clements
 * Course: COMP-003A
 *Purpose: Assignment 3 (Making a Statement) */
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What is your grade (from 0 to 100)?");
            double numericGrade = Convert.ToDouble(Console.ReadLine());
            if (numericGrade>=0 || numericGrade<=100)
                {
                if (numericGrade>=90){ Console.WriteLine("You have an A!");}
                else if (numericGrade>=80){Console.WriteLine("You have a B!");}
                else if (numericGrade>=70){Console.WriteLine("You have a C!");}
                else if (numericGrade>=60){Console.WriteLine("You have a D");}
                else{{ Console.WriteLine("You have an F ;-;"); }}
                }
            else{ Console.WriteLine("Invalid Input :(");}
            Console.WriteLine("----------------------------------------------------------------");

            Console.WriteLine("Give me a number and I'll give you a day!");
            int numericDay = Convert.ToInt32(Console.ReadLine()) % 7;
            switch (numericDay)
            {
                case 0: Console.WriteLine("It's Monday!"); break;
                case 1: Console.WriteLine("It's Tuesday!"); break;
                case 2: Console.WriteLine("It's Wednesday!"); break;
                case 3: Console.WriteLine("It's Thursday!"); break;
                case 4: Console.WriteLine("It's Friday!"); break;
                case 5: Console.WriteLine("It's Saturday!"); break;
                case 6: Console.WriteLine("It's Sunday!"); break;
                default: Console.WriteLine("Thats not a number!"); break;
            }
        }
    }
}