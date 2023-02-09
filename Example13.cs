using System;

namespace Example13 {
    class Program {
        static void Main(string[] args) {
            // Switch statements

            int variable = 1;

            switch (variable) {
                case 1:
                Console.WriteLine("value is 1");
                    break;
                case 2:
                Console.WriteLine("value is 2");
                    break;
                case 3:
                Console.WriteLine("value is 3");
                    break;
                default:
                Console.WriteLine("value is not set");
                    break;
            }
        }
    }
}