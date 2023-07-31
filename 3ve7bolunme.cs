using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a = int.Parse(input);


            if (a % 3 == 0 && a % 7 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}