using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikacja sprawdza czy dana liczba jest parzysta czy nieparzysta.\n\nPodaj liczbę całkowitą:");
            var userNumber = GetNumber();
            
            if (userNumber % 2 == 0)
            {
                Console.WriteLine("\nPodana liczba jest parzysta.");
            }
            else 
                Console.WriteLine("\nPodana liczba jest nieparzysta.");
        }

        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("\nNie wprowadziłeś poprawnej liczby, spróbuj ponownie.");
                    continue;
                }
                return number;
            }
        }
    }
}
