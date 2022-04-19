using System;

namespace ConsoleApp2._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(lowerRandom, upperRandom);
            
            int lowerRandom = 1;
            int upperRandom = 27;
            int minThreeDigit = 100;
            int maxThreeDigit = 999;
            
            int amountOfNumbers = 0;

            Console.WriteLine(number);
            
            for (int i = minThreeDigit; i < maxThreeDigit; i++)
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
