using System;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                a += 5;
            }
            else if (a < 0)
            {
                a -= 5;
            }
            Console.WriteLine("Результат: " + a);
            
            // Задание 2
            
            Console.WriteLine("Введите три числа: ");
            int q = Convert.ToInt32(Console.ReadLine());
            int w = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            int max = q;
            if (w > max)
            {
                max = w;
            }
            if (e > max)
            {
                max = e;
            }
            Console.WriteLine("Наибольшее число: " + max);

            // Задание 3
            
            Console.WriteLine("Введите три разных числа: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (number1 > 0)
            {
                sum += number1;
            }
            if (number2 > 0)
            {
                sum += number2;
            }
            if (number3 > 0)
            {
                sum += number3;
            }
            Console.WriteLine("Сумма положительных чисел: " + sum);

            // Задание 4
            
            Console.Write("Введите число:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 10)
            {
                x *= 2;
            }
            Console.WriteLine("Результат: " + x);

            // Задание 5
            
            Console.Write("Введите число от 1 до 7: ");
            int daynumber = Convert.ToInt32(Console.ReadLine());
            switch (daynumber)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Некорректный ввод");
                    break;

            }
            Console.ReadKey();

            // Задание 6 

            int number = 200;
            while (number % 17 != 0)
            {
                number++;
            }
            Console.WriteLine(number);

            // Задание 7

            double distance = 10;
            int day = 1;

            while (distance < 20)
            {
                distance *= 1.05;
                day++;
            }

            Console.WriteLine("Человек пробежит 20 км на " + day + " день");

            distance = 10;
            day = 1;

            while (distance < 100)
            {
                distance *= 1.05;
                day++;
            }

            Console.WriteLine("Сумма пробега будет больше 100 км на " + day + " день");

            // Задание 8

            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Факториал числа {0} равен {1}", n, factorial);

            // Задание 9

            Console.Write("Введите натуральное число: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            int i1 = 2;
            while (n1 % i1 != 0)
            {
                i1++;
            }

            Console.WriteLine("Наименьший делитель числа {0}, отличный от 1: {1}", n1, i1);
        }
    }
}