using System;

namespace CONSTRUCTOR_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            const string const1 = "Your Name is:";
            const string const2 = "Your favorite number is:";
            Console.WriteLine("Enter your name or favorite number:");
            var answer = Console.ReadLine();
            if (float.TryParse(answer, out float x))
            {
                Console.WriteLine(const2);
                Chain newChain = new Chain(x);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(const1);
                Chain newChain = new Chain(answer);
                Console.ReadLine();
            }
        }
    }
}
