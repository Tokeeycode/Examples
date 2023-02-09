using System;

namespace Example04 {

    class Program {

        static void Main(string[] args) {
            
            double number = 5.1;
			double anotherNumber = 2.25;
			double total;

            //addition
            result = number + anotherNumber;

            //subtraction
            result = number - anotherNumber;

            //multiplication
            result = number * anotherNumber;

            //division
            result = number / anotherNumber;

            //modulus
            result = number % anotherNumber;

            //Warning
            double total = 15 / 4 * 3;
            Console.WriteLine(Total); //or
            Console.WriteLine(Result);

            // The line above results in 9, but the correct result is 11.25.
			// The reason for this is because we are not paying enough attention to the data types.
			// An operation performed with two integers will always return an integer.
			// An operation performed with two doubles will always return a double.
			// An operation performed an integer and a double will always return a double.
			// To fix this problem, we have to convert at least one of the values to double.

            result = Convert.ToDouble(15) / 4 * 3;
            Console.WriteLine(result);


        }
    }
}
   