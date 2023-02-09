using System;

namespace Example03 {
    class Program
    {
        static void Main(string[] args){
            //DATA TYPE CONVERSION:

            char letter = Convert.ToChar("a");
            letter = char.Parse("a");

            int number = "5";
            number = int.Parse("5");
            int number = Convert.ToInt32("5");

            string text = 5;
            text = int.Parse("5");
            string text = Convert.ToString("5");

            //WARNING:

            double anotherNumber = 5; //same as 5.0
            int oneMoreNumber = Convert.ToInt32(2.5);

            //CASTING:
            oneMoreNumber = (int)2.5;

        }
    }
}