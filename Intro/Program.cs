using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Number 1 - 100: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (number < 1 || number > 100)
            {
                Console.WriteLine("Enter Number 1 - 100: ");
            }
            else
            {
                bool divisibleBy3 = number % 3 == 0;
                bool divisibleBy5 = number % 5 == 0;

                if (divisibleBy3 && divisibleBy5)
                {
                    Console.WriteLine("FIZZ BUZZ ");
                }
                else if (divisibleBy3)
                {
                    Console.WriteLine("FIZZ");
                }
                else if (divisibleBy5)
                {
                    Console.WriteLine("BUZZ");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }
        else
        {
            Console.WriteLine("Enter Number 1 - 100: ");
        }
}
}