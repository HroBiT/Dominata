using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj rozmiar listy:");
        int size = Convert.ToInt32(Console.ReadLine());

        List<int> lista = new List<int>();

        Random rand = new Random();

        for (int i = 0; i < size; i++)
        {
            int liczba = rand.Next(1, 11);
            lista.Add(liczba);
        }
        int maksymalnaWartosc = 0;
        int licznik = 0;
        int dominanta = 0;

        foreach (int liczba in lista)
        {
            licznik = 0;

            foreach (int element in lista)
            {
                if (element == liczba)
                {
                    licznik++;
                }
            }

            if (licznik > maksymalnaWartosc)
            {
                maksymalnaWartosc = licznik;
                dominanta = liczba;
            }
        }

        Console.WriteLine($"Dominanta zbioru to: {dominanta}, występuje {maksymalnaWartosc} razy.");
    }
}
