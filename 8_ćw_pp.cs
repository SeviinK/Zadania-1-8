using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj dwie liczby:");
        Console.Write("Liczba 1: ");
        double liczba1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Liczba 2: ");
        double liczba2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wybierz działanie:");
        Console.WriteLine("1 - Dodawanie");
        Console.WriteLine("2 - Odejmowanie");
        Console.WriteLine("3 - Mnożenie");
        Console.WriteLine("4 - Dzielenie");

        Console.Write("Numer działania: ");
        int numerDzialania = Convert.ToInt32(Console.ReadLine());

        string wynik;

        switch (numerDzialania)
        {
            case 1:
                wynik = (liczba1 + liczba2).ToString();
                break;
            case 2:
                wynik = (liczba1 - liczba2).ToString();
                break;
            case 3:
                wynik = (liczba1 * liczba2).ToString();
                break;
            case 4:
                if (liczba2 != 0)
                {
                    wynik = (liczba1 / liczba2).ToString();
                }
                else
                {
                    wynik = $"{liczba1}/0";
                }
                break;
            default:
                Console.WriteLine("Nieprawidłowy numer działania!");
                wynik = "Błąd";
                break;
        }

        Console.WriteLine("Wynik: " + wynik);

        Console.ReadKey();
    }
}