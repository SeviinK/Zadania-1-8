using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj długości boków trójkąta:");

        Console.Write("Bok 1: ");
        double bok1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Bok 2: ");
        double bok2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Bok 3: ");
        double bok3 = Convert.ToDouble(Console.ReadLine());

        if (CzyTrojkatRownoboczny(bok1, bok2, bok3))
        {
            Console.WriteLine("Można utworzyć trójkąt równoboczny");
        }
        else
        {
            Console.WriteLine("Nie można utworzyć trójkąta równobocznego");
        }

        Console.ReadKey();
    }

    static bool CzyTrojkatRownoboczny(double a, double b, double c)
    {
        return a == b && b == c;
    }
}