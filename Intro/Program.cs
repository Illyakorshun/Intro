using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть число: ");
        string inputValue = Console.ReadLine();

        Console.Write("Введіть відсоток: ");
        string inputPercent = Console.ReadLine();

        if (double.TryParse(inputValue, out double value) && double.TryParse(inputPercent, out double percent))
        {
            double result = value * percent / 100;
            Console.WriteLine($"{percent}% від {value} = {result}");
        }
        else
        {
            Console.WriteLine("Некоректне введення. Введіть числові значення.");
        }
    }
}