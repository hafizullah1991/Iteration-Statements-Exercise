using System;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace IterationStatements
{
    public class Program
    
       
    
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintMethod() {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void writing()

        {
            for (int i = 3; i < 1000; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool EqualIntegers(int number1, int number2)
        {
            if (number1 == number2)
            {
                Console.WriteLine($"{number1} is equal to {number2}");
                return true;
            }
            else
            {
                Console.WriteLine($"{number1} is not equal to {number2}");
                return false;
            }
        }

        public static void CheckNumbers()
           
            // The follwoing Method is checking if the numbers are Even Or Odd:
        {
            Console.WriteLine("Enter your Number: ");
            double Num = double.Parse(Console.ReadLine());

            if (Num % 2 == 0)
            {
                Console.WriteLine($"\t{Num} is Even");
            }
            else
            {
                Console.WriteLine($"\t{Num} is Odd");
            }

        }
        //Write a method to check whether a given number is positive or negative

        public static void CheckInteger()
        {
            Console.WriteLine("Enter your Number: ");
            double User = double.Parse(Console.ReadLine());
            {
                if (User > 0)
                {
                    Console.WriteLine($"{User} is Positive");
                }
                else
                {
                    Console.WriteLine($"{User} is Negative");
                }
        }
}
        
        //Write a method to read the age of a candidate and determine whether they can vote.

        public static void Vote( )

        {
            Console.WriteLine("How old are you: ");
            int VoteAge = int.Parse(Console.ReadLine());
            if(VoteAge >18)
            {
                Console.WriteLine("You are eligible for vote");
            }
            else
            {
                Console.WriteLine("You are not eligible for vote.");
            }
        }

        //Hint: Use Parse or the safer TryParse() for an extra challenge


        //Heatin Up Section:

        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void RangeNum()
        {
            Console.WriteLine("Enter a number: ");
            int NumAnswer = int.Parse(Console.ReadLine());
            if (NumAnswer >= -10 && NumAnswer <= 10)

            {
                Console.WriteLine($"{NumAnswer} is in range");
            }
            else
            {
                Console.WriteLine($"{NumAnswer} is not on range");
            }
 }
            //Write a method to display the multiplication table(from 1 to 12) of a given integer
         public static void Multiplication( )

        {
            Console.WriteLine("Enter number:");
            int Multiply = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                int result = Multiply * i;
                Console.WriteLine(result);
            }
        }

            //Call the methods to test them in the Main method below
            static void Main(string[] args)
        {
            PrintMethod();

            writing();

            CheckInteger();

            bool isEqual = EqualIntegers(5, 5);
            Console.WriteLine(isEqual);

            CheckNumbers();

            Vote();

            RangeNum();

            Multiplication();






        }


    }
}
