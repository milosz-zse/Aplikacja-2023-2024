using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        do
        {
            int numberOfDice;

            while (true)
            {
                Console.Write("Podaj liczbę kostek do rzucenia (od 3 do 10): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out numberOfDice))
                {
                    if (numberOfDice >= 3 && numberOfDice <= 10)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Liczba musi być w przedziale od 3 do 10. Spróbuj ponownie.");
                    }
                }
                else
                {
                    Console.WriteLine("To nie jest poprawna liczba całkowita. Spróbuj ponownie.");
                }
            }

            Random random = new Random();
            int[] results = new int[numberOfDice];

            for (int i = 0; i < numberOfDice; i++)
            {
                results[i] = random.Next(1, 7); 
                Console.WriteLine($"Kostka {i + 1}: {results[i]}");
            }

            int totalPoints = CalculatePoints(results);

            Console.WriteLine($"Suma oczek: {totalPoints}");

            Console.Write("Czy chcesz zagrać ponownie? (t/n): ");
        } while (Console.ReadLine().ToLower() == "t");

        Console.WriteLine("Dziękujemy za grę!");
    }

    static int CalculatePoints(int[] results)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();

        foreach (int result in results)
        {
            if (counts.ContainsKey(result))
            {
                counts[result]++;
            }
            else
            {
                counts[result] = 1;
            }
        }



        int totalPoints = 0;
        foreach (var pair in counts)
        {
            if (pair.Value >= 2)
            {
                totalPoints += pair.Key * pair.Value; 
            }
        }

        return totalPoints;
    }

    // nazwa : CalculatePoints
    // opis :   liczy punkty 
    // parametry : opis parametru results: liczby   
    // zwracany typ i opis : int totalPoints zwraca policznonąliczbe ppunktóqw 
    // autor : Miłosz Michta 
}
