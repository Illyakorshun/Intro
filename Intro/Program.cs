using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a six-digit number: ");
        string number = Console.ReadLine();

        if (number.Length != 6 || !int.TryParse(number, out _))
        {
            Console.WriteLine("Error: You must enter a six-digit number.");
            return;
        }

        Console.Write("Enter the first digit position to swap (1 to 6): ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the second digit position to swap (1 to 6): ");
        string input2 = Console.ReadLine();

        if (int.TryParse(input1, out int pos1) && int.TryParse(input2, out int pos2) &&
            pos1 >= 1 && pos1 <= 6 && pos2 >= 1 && pos2 <= 6)
        {
            char[] digits = number.ToCharArray();
            
            char temp = digits[pos1 - 1];
            digits[pos1 - 1] = digits[pos2 - 1];
            digits[pos2 - 1] = temp;

            string result = new string(digits);
            Console.WriteLine($"Result after swapping: {result}");
        }
        else
        {
            Console.WriteLine("Error: Positions must be between 1 and 6.");
        }
    }
}