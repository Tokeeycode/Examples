using System;

namespace Example05 {
    class Program {

        static void Main(string[] args)
        {
            /*
            
            Write a console application that performs a mathematical operation of your choice 
            between two user-provided values.
            
            */
            //step 1 Declare variables

            double firstNumber;
            double secondNumber;
            double total;

            //step 2 Perform calculations
            Console.WriteLine("please input two numbers to multiply: ");
            Console.WriteLine("Enter first number: ");
            firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            
            secondNumber = double.Parse(Console.ReadLine());

            //step 3 algorithm
            total = firstNumber * secondNumber;

            //step 4 output the result

            Console.WriteLine("\nThe result is: ");
            Console.WriteLine(total);



        }
    }
}