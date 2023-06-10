using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj dwie liczby:");

        Console.Write("Liczba 1: ");
        int liczba1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Liczba 2: ");
        int liczba2 = Convert.ToInt32(Console.ReadLine());

        int wieksza = (liczba1 > liczba2) ? liczba1 : liczba2;

        Console.WriteLine("Większa liczba: " + wieksza);

        Console.ReadKey();
    }
}