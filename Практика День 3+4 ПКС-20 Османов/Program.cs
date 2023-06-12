    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApp3
    {
        internal class Employee
        {
            private string _fio;
            private double _salary;
            private int _department;
            private int _id;
            static int count;

            public int Id()
            {
                _id++;
                count = _id;
                return count;
            }

            public Employee(string fio, double salary, int department)
            {

                _fio = fio;
                _salary = salary;
                _department = department;
            }

            public string Fio
            {
                get => _fio;
                set => _fio = value;
            }
            public double Salary
            {
                get => _salary;
                set => _salary = value;
            }
            public int Department
            {
                get => _department;
                set => _department = value;
            }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("fio", 10000, 1);
            List<Employee> employees = new List<Employee>()
            {
                new Employee ("Глухов Арсений Даниилович", 35000, 2),
                new Employee ("Казаков Али Романович", 45000, 1),
                new Employee ("Савицкий Иван Максимович", 55000, 2),
                new Employee ("Суслов Степан Михайлович", 50000, 3),
                new Employee ("Виноградова Алиса Егоровна", 40000, 4),
                new Employee ("Кузнецова Вера Савельевна", 25000, 3),
                new Employee ("Герасимова Ирина Кирилловна", 68000, 5),
                new Employee ("Краснова Асия Артёмовна", 27000, 4),
                new Employee ("Литвинова Александра Тимофеевна", 45000, 5),
                new Employee ("Никитин Серафим Максимович", 60000, 1)

            };

            void zadanie1()
            {
                Console.WriteLine("Задание 1: ");
                foreach (var emp in employees)
                {

                    Console.WriteLine($"ID: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}, Отдел: {emp.Department}");
                }
            }

            void zadanie2()
            {
                Console.WriteLine("Задание 2: ");
                double summa = 0;
                foreach (var emp in employees)
                {
                    summa += emp.Salary;
                }
                Console.WriteLine("Сумма затрат на зарплату в месяц: " + summa);
            }

            void zadanie3()
            {
                Console.WriteLine("Задание 3: ");
                double min = 1111111111;
                foreach (var emp in employees)
                {
                    if (emp.Salary < min)
                    {
                        min = emp.Salary;
                    }
                }
                Console.WriteLine("Минимальная зарплата: " + min);
            }

            void zadanie4()
            {
                Console.WriteLine("Задание 4: ");
                double max = 0;
                foreach (var emp in employees)
                {
                    if (emp.Salary > max)
                    {
                        max = emp.Salary;
                    }
                }
                Console.WriteLine("Максимальная зарплата: " + max);
            }

            void zadanie5()
            {
                Console.WriteLine("Задание 5: ");
                int count = 0;
                double summa = 0;
                foreach (var emp in employees)
                {
                    count++;
                    summa += emp.Salary;
                }

                Console.WriteLine("Среднее значение зарплаты: " + summa / count);
            }

            void zadanie6()
            {
                Console.WriteLine("Задание 6: ");
                foreach (var emp in employees)
                {
                    Console.WriteLine("ФИО: " + emp.Fio);
                }
                Console.ReadKey();
            }

            zadanie1();
            Console.WriteLine();
            zadanie2();
            Console.WriteLine();
            zadanie3();
            Console.WriteLine();
            zadanie4();
            Console.WriteLine();
            zadanie5();
            Console.WriteLine();
            zadanie6();


            // Часть 2


            int N = 1;
            while (N == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Выберите номер задания. Существующие варианты: 1, 2, 3, 4, 5, 6, 7, 8");
                int nomerzadaniya = Convert.ToInt32(Console.ReadLine());
                if (nomerzadaniya == 1) task1(1.1);
                if (nomerzadaniya == 2) task2A();
                if (nomerzadaniya == 3) task2B();
                if (nomerzadaniya == 4) task2C();
                if (nomerzadaniya == 5) task2D(1.1);
                if (nomerzadaniya == 6) task2E();
                if (nomerzadaniya == 7) task3A();
                if (nomerzadaniya == 8) task3B();
            }

            void task1(double argument)
            {
                foreach (var emp in employees)
                {
                    Console.WriteLine("Зарплата " + emp.Fio + " была увеличена до " + emp.Salary * argument);
                }
            }
            void task2A()
            {
                Console.WriteLine("Выберите отдел для определения минимальной зарплаты среди всех работников");
                double a = Convert.ToDouble(Console.ReadLine());
                double min = 1111111111;
                foreach (var emp in employees)
                {
                    if (emp.Salary < min)
                    {
                        if (emp.Department == a)
                        {
                            min = emp.Salary;
                        }
                    }
                }
                Console.WriteLine("Минимальная зарплата по выбранному отделу среди всех работников: " + min);
            }
            void task2B()
            {
                Console.WriteLine("Выберите отдел для определения максимальной зарплаты среди всех работников");
                double a = Convert.ToDouble(Console.ReadLine());
                double max = 0;
                foreach (var emp in employees)
                {

                    if (emp.Salary > max)
                    {
                        if (emp.Department == a)
                        {
                            max = emp.Salary;
                        }

                    }

                }
                Console.WriteLine("Максимальная зарплата по выбранному отделу среди всех работников: " + max);
            }
            void task2C()
            {
                Console.WriteLine("Выберите отдел для определения средней зарплаты среди всех работников");
                int count = 0;
                double sum = 0;
                double a = Convert.ToDouble(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Department == a)
                    {
                        count++;
                        sum += emp.Salary;
                    }
                }

                Console.WriteLine("Средняя зарплата работников выбранного отдела = " + sum / count);
            }
            void task2D(double argument)
            {
                Console.WriteLine("Выберите отдел для увеличения зарплаты по отделу");
                double a = Convert.ToDouble(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Department == a)
                    {
                        Console.WriteLine("Зарплата " + emp.Fio + " была увеличена до: " + emp.Salary * argument);
                    }

                }
            }
            void task2E()
            {
                Console.WriteLine("Выберите отдел, в котором вы хотите информацию о сотрудниках");
                double a = Convert.ToDouble(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Department == a)
                    {

                        Console.WriteLine("ФИО: " + emp.Fio + "; Зарплата - " + emp.Salary);
                    }
                }
            }
            void task3A()
            {
                Console.WriteLine("Вывести работников со всех отделов у которых зарплата менее, чем: ");
                double a = Convert.ToDouble(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Salary < a)
                    {
                        Console.WriteLine("ФИО: " + emp.Fio + "; Зарплата - " + emp.Salary);
                    }
                }
            }
            void task3B()
            {
                Console.WriteLine("Вывести работников со всех отделов у которых зарплата более, чем: ");
                double a = Convert.ToDouble(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Salary > a)
                    {
                        Console.WriteLine("ФИО: " + emp.Fio + "; Зарплата - " + emp.Salary);
                    }
                }
            }
        }
    }
}


