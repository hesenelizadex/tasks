using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string input2 = Console.ReadLine();
            int a = int.Parse(input);
            int b = int.Parse(input2);


            if (a + b == 30 || a == 30 || b == 30)
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