using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int chislo = random.Next(1, 101);
            int popitki = 0;
            int guess = 0;

            Console.WriteLine("Угадайте число от 1 до 100");

            while (guess != chislo)
            {
                Console.Write("Введите число: ");
                guess = Convert.ToInt32(Console.ReadLine());
                popitki++;

                if (guess < chislo)
                {
                    Console.WriteLine("Загаданное число больше");
                }
                else if (guess > chislo)
                {
                    Console.WriteLine("Загаданное число меньше");
                }
            }

            Console.WriteLine($"Поздравляем! Вы угадали число "+chislo+" за "+popitki+" попыток.");
            Console.ReadKey();
        }
    }
}