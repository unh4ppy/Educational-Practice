using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            string qwe = "hello";
            string asd = " world";
            string zxc = qwe + asd;
            Console.WriteLine(zxc);
            Console.ReadKey();

            //Задание 2
            int n = 10;
            int v = 5;
            Console.WriteLine("Сложение:" + (n + v));
            Console.WriteLine("Вычитание:" + (n - v));
            Console.WriteLine("Умножение:" + (n * v));
            Console.WriteLine("Деление:" + (n / v));
            Console.ReadKey();

            //Задание 3
            Console.Write("Введите имя: ");
            string imya = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string familiya = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string otchestvo = Console.ReadLine();
            Console.WriteLine(imya+" "+familiya+" "+otchestvo);
            Console.ReadKey();

            //Задание 4
            int hpp = 1000;
            int atkp = 175;
            int defp = 10;
            int hpm = 700;
            int atkm = 150;
            int defm = 5;
            int hppitog = atkm / defp;
            int hppitog2 = hpp - hppitog;
            int hpmitog = atkp / defm;
            int hpmitog2 = hpm - hpmitog;
            Console.WriteLine("У игрока осталось здоровья: " + hppitog2);
            Console.WriteLine("У монстра осталось здоровья: " + hpmitog2);
            Console.WriteLine("Урона нанёс игрок: " + hpmitog);
            Console.WriteLine("Урона нанёс монстр: " + hppitog);
            Console.ReadKey();

        }
        
    }
}