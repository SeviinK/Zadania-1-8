using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj trzy liczby:");

        Console.Write("Liczba a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Liczba b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Liczba c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double srednia = (a + b + c) / 3;

        Console.WriteLine("Średnia arytmetyczna: " + srednia);

        Console.ReadKey();
    }
}