using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj współrzędne punktu P(x, y):");

        Console.Write("x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj promień koła r: ");
        double r = Convert.ToDouble(Console.ReadLine());

        bool lezyWKole = CzyPunktWKole(x, y, r);

        if (lezyWKole)
        {
            Console.WriteLine("Punkt P leży w obrębie koła");
        }
        else
        {
            Console.WriteLine("Punkt P nie leży w obrębie koła");
        }

        Console.ReadKey();
    }

    static bool CzyPunktWKole(double x, double y, double r)
    {
        double odleglosc = Math.Sqrt(x * x + y * y);
        return odleglosc <= r;
    }
}