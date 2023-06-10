using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wagę [kg]:");
        double waga = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj wzrost [m]:");
        double wzrost = Convert.ToDouble(Console.ReadLine());

        double bmi = waga / (wzrost * wzrost);

        Console.WriteLine("Współczynnik BMI: " + bmi);

        Console.ReadKey();
    }
}