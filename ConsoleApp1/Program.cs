using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите часы (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите минуты (M): ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите время доставки в минутах (T): ");
            // Используем long, так как T может быть очень большим (до 10^9)
            long T = Convert.ToInt64(Console.ReadLine());

            // 1. Переводим текущее время полностью в минуты и прибавляем время доставки
            long totalMinutes = N * 60 + M + T;

            // 2. Берем остаток от деления на 1440 (столько минут в одних сутках 24*60)
            // Это нужно, чтобы убрать "лишние" полные дни и узнать время в пределах 24 часов
            totalMinutes = totalMinutes % 1440;

            // 3. Вычисляем новые часы и минуты
            int hours = (int)(totalMinutes / 60);
            int minutes = (int)(totalMinutes % 60);

            // 4. Выводим на экран в формате ЧЧ:ММ (с ведущими нулями, если нужно)
            Console.WriteLine($"Время прибытия: {hours:D2}:{minutes:D2}");

            Console.ReadLine(); // Чтобы окно не закрывалось
        }
    }
}
