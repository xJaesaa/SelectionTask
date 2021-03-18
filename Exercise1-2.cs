using System;

namespace JaesaCodePog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age");
            string ageStr = Console.ReadLine();

            int age = int.Parse(ageStr);

            Console.WriteLine("Enter Your Gender (M, F, NB, Other)");
            string gender = Console.ReadLine();

            if(age >= 18){
                Console.WriteLine("u " + gender + " are an adult");
            }
            else{
                Console.WriteLine("too young, begone " + gender + " child");
            }
            
        }
    }
}
