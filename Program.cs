using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte číslo k umocnění:");
            int mocCislo = int.Parse(Console.ReadLine());
            Console.WriteLine("Výsledek je: "+mocCislo * mocCislo);
            Console.ReadKey();

        }
    }
}
