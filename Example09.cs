using System;

namespace Example09 {
    class Program {
        static void Main(string[] args){
            // Compound boolean expressions

            // AND: &&
            // OR: ||
            // NOT:!

            // (3 < 5) && (1 < 0) = false
            // (3 < 5) || (1 < 0) = true

            bool result = (3 < 5) && (1 < 0);
            Console.WriteLine(result);

            result = (3 < 5) || (1 < 0);
            Console.WriteLine(result);

            result = 3 < 5 && 1 < 0 || 3 != 5;
            Console.WriteLine(result); // = true

            // 3 is less then 5 and 1 is less then 0 or 3 is not equal to 5

            int number1 = 1;
            double number2 = 1.5;

            result = number1 == number2;

            
            
        }
    }
}