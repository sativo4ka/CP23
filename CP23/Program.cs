using System;
using System.Collections.Generic;

namespace CP23
{
    class Program
    {
        static T FindBest<T>(List<T> items) where T : IComparable<T>
        {
            if (items.Count == 0)
                throw new ArgumentException("Список пуст.");

            T best = items[0];

            foreach (T item in items)
            {
                if (item.CompareTo(best) < 0)
                    best = item;
            }

            return best;
        }

        static void Main()
        {
            List<int> scores = new List<int> { 80, 55, 70 };

            Console.WriteLine("Лучший результат в игре:");
            Console.WriteLine(FindBest(scores));

            List<RaceTime> raceTimes = new List<RaceTime>
        {
            new RaceTime(12.4),
            new RaceTime(11.9),
            new RaceTime(13.0)
        };

            Console.WriteLine("\nЛучшее время гонки:");
            Console.WriteLine(FindBest(raceTimes));
        }
    }
}