using System;

namespace Lab05
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
                    break;
                Console.WriteLine("Помилка: Введіть коректне додатнє число.");
            }

            double growthRate;
            while (true)
            {
                Console.Write("Введіть відсоток приросту за годину (%): ");
                if (double.TryParse(Console.ReadLine(), out growthRate) && growthRate > 0)
                    break;
                Console.WriteLine("Помилка: Введіть коректне додатнє число.");
            }

            int hours = 0;
            const double MaxBacteria = 1000000;

            Console.WriteLine("\nТаблиця росту за годинами:");
            Console.WriteLine($"Початково (0 год): {bacteriaCount:F0} бактерій");

            while (bacteriaCount <= MaxBacteria)
            {
                hours++;
                bacteriaCount += bacteriaCount * (growthRate / 100.0);
                Console.WriteLine($"Година {hours}: {bacteriaCount:F0} бактерій");
            }

            Console.WriteLine($"Кількість бактерій перевищила 1 млн! Знадобилося годин: {hours}");
            Console.WriteLine("==========================================\n");

            Console.WriteLine("\nНатисни Enter для виходу...");
            Console.ReadLine();
        }
    }
}