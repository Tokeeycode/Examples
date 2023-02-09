using System;

namespace Example08 {
    class Program {
        static void Main(string[] args){
            // Comparison operators:

            // less than: <
            // less than or equal to: <=
            // greater than: >
            // greater than or equal to: >=
            // equal to: ==
            // not equal to:!=
            
            // 3 > 5 = false
            // 3 < 5 = true
            // 3 >= 5 = true
            // 3 <= 5 = false

            bool result = 3 > 5;
            Console.WriteLine(result);
            
            result = 3 < 5;
            Console.WriteLine(result);

            result = "true" == "True";
            Console.WriteLine(result); //false

            result = "true" == "true";
            Console.WriteLine(result); //true

            result = "true".ToLower() == "True";
            Console.WriteLine(result); //true

            result = 'a' != 'A';
            Console.WriteLine(result); //true




            
        }
    }
}