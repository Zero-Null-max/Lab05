using System;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // РІВЕНЬ А: Розрахунок росту бактерій
            Console.WriteLine("=== Рівень А: Ріст популяцій бактерій ===");

            double bacteriaCount;
            while (true)
            {
                Console.Write("Введіть початкову кількість бактерій: ");
                if (double.TryParse(Console.ReadLine(), out bacteriaCount) && bacteriaCount > 0)
                {
                    break;
                }
                Console.WriteLine("Помилка: Введіть коректне додатнє число.");
            }

            double growthRate;
            while (true)
            {
                Console.Write("Введіть відсоток приросту за годину (%): ");
                if (double.TryParse(Console.ReadLine(), out growthRate) && growthRate > 0)
                {
                    break;
                }
                Console.WriteLine("Помилка: Введіть коректне додатнє число.");
            }

            Console.WriteLine("\nНатисни Enter для виходу...");
            Console.ReadLine();
        }
    }
}