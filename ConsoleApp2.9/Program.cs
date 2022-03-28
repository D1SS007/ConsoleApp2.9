using System;

namespace ConsoleApp2._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 27);
            int amountOfNumbers = 0;

            Console.WriteLine(number);
            
            for (int i = 100; i < 999; i++)
            {
                for(int j = i; j >= 0; j-= number)
                {
                    if (j == 0)
                    {
                        amountOfNumbers++;
                    }
                }                               
            }
            Console.WriteLine(amountOfNumbers);
        }
    }
}
