using System;

namespace JaesaCodePog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For testing purposes Username and Password are: 'bruh'");
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();

            if(username == "bruh")
            {
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();

                if(password == "bruh")
                {
                    Console.WriteLine("Logged in baby");
                }
                else
                {
                    Console.WriteLine("wrong password bruz");
                }
            }
            else{
                Console.WriteLine("Username does not exist");
            }
            
        }
    }
}
