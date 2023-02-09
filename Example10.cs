using System;

namespace Example10 {
    class Program {
        static void Main(string[] args) {
            // IF STATEMENTS    
            bool condition = 3 < 5;

            Console.WriteLine("line 9 runs.");

            if (condition) {
                //run this if condition is true
                Console.WriteLine("Line 13 does not run.");
            }

            Console.WriteLine ("line 16 runs.");
        }
    }
}
