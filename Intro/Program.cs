using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter 4 number  :");

        string result = "";

        for (int i = 1; i <= 4; i++)
        {
            Console.Write($"Number {i}: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int digit) && digit >= 0 && digit <= 9)
            {
                result += digit.ToString();
            }
            else
            {
                Console.WriteLine("Enter number!");
                i--;
            }

            Console.WriteLine($"Otvet: {result}");
        }
    }
}