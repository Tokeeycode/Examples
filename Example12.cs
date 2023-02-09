using System;

namespace Example12 {
    class Program {
        static void Main(string[] args) {
            // IF-ELSE-IF-ELSE Statements:

            bool condition = false;
            bool anotherCondition = false;

            if (condition){
                //run this if condition = true
                Console.WriteLine("line 13 runs.");
            }
            else if (anotherCondition){
                //run this if condition = false AND anotherCondition = true
                Console.WriteLine("line 17 runs.");
            }
            else{
                //run this otherwise
                Console.WriteLine("line 21 runs.");
            }
        }
    }
}