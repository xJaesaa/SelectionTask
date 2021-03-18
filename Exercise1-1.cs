using System;

namespace JaesaCodePog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For testing purposes Username and Password are: 'Bruh'");
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();

            int num1 = int.Parse(num1Str);

            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();

            int num2 = int.Parse(num2Str);

            int answer = num1 + num2;

            if(answer >= 11){
                Console.WriteLine("bro thats higher than 10");
            }
            else if(answer == 10){
                Console.WriteLine("damn u hit 10 ur mad bruh");
            }
            else{
                Console.WriteLine("lower than 10 baby");
            }
            
        }
    }
}
