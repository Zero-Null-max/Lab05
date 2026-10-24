using System;

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // РІВЕНЬ А
            Console.WriteLine("=== Рівень А: Ріст популяцій бактерій ===");
            double bacteriaCount;
            while (true)
            {
                Console.Write("Введіть початкову кількість бактерій: ");
                if (double.TryParse(Console.ReadLine(), out bacteriaCount) && bacteriaCount > 0) break;
                Console.WriteLine("Помилка: Введіть коректне додатнє число.");
            }

            double growthRate;
            while (true)
            {
                Console.Write("Введіть відсоток приросту за годину (%): ");
                if (double.TryParse(Console.ReadLine(), out growthRate) && growthRate > 0) break;
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

            // РІВЕНЬ Б
            Console.WriteLine("=== Рівень Б: Малювання квадрата ===");
            int n;
            while (true)
            {
                Console.Write("Введіть розмір квадрата n (від 3 до 20): ");
                if (int.TryParse(Console.ReadLine(), out n) && n >= 3 && n <= 20) break;
                Console.WriteLine("Помилка: Введіть ціле число від 3 до 20.");
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j || i + j == n - 1)
                    {
                        Console.Write("#");
                    }
                    else if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nНатисни Enter для виходу...");
            Console.ReadLine();
        }
    }
}