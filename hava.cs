using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a = int.Parse(input);
            if (a <= 15)
            {
                Console.WriteLine("Hava soyuqdur");
            }
            else if (a > 15 && a < 25)
            {
                Console.WriteLine("Hava mülayimdir");
            }
            else if (a >= 25)
            {
                Console.WriteLine("Hava istidir");
            }

        }
    }
}