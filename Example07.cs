using System;

namespace Example07 {
    class Program {
        static void Main(string[] args) {

            // string manipulation

            // concatenation
            string example1 = "The number pi is " + Math.PI + ".";
            Console.WriteLine(example1);

            // interpolation ************************** ALWAYS USE
            string example2 = $"the number pi is {Math.PI}.";
            Console.WriteLine(example2);

            // string.format
            string example3 = string.Format("The number pi is {0}. Today is {1}.", Math.PI, "Wednesday");

            Console.WriteLine(example3);

            //string formatters
            string example4 = $"the number pi is {Math.PI:F}.";
            Console.WriteLine(example4);

            //substrings
            string example5 = "C# is a great programming language.";
            Console.WriteLine(example5.Substring(6));
            Console.WriteLine(example5.Substring(6,7));

            //casting patterns
            string example6 = "C# is a GREAT programming language.";
            Console.WriteLine(example6.ToUpper());
            Console.WriteLine(example6.ToLower());

            string example7 = "C# is a GREAT programming language.";
            Console.WriteLine(example7.Contains('a')); //true
            Console.WriteLine(example7.Contains("best")); //false
            Console.WriteLine(example7.Contains("great")); //false
            Console.WriteLine(example7.ToLower().Contains("great")); //true

        }
    }
}