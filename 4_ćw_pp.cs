using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj cztery liczby całkowite: a, b, c, d");

        Console.Write("a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.Write("d: ");
        int d = Convert.ToInt32(Console.ReadLine());

        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwiązania");
        }
        else
        {
            int x = (a * d) + (c * b);
            int y = b * d;

            Console.WriteLine("Licznik (x): " + x);
            Console.WriteLine("Mianownik (y): " + y);
        }

        Console.ReadKey();
    }
}