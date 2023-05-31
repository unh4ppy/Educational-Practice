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

            void A()
            {
                Console.WriteLine("A: ");
                foreach (var emp in employees)
                {

                    Console.WriteLine($"ID: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}, Отдел: {emp.Department}");
                }
            }

            void B()
            {
                Console.WriteLine("B: ");
                double summa = 0;
                foreach (var emp in employees)
                {
                    summa += emp.Salary;
                }
                Console.WriteLine($"Сумма затрат на зарплату в месяц: {summa}");
            }

            void C()
            {
                Console.WriteLine("C: ");
                double min = 99999999999;
                foreach (var emp in employees)
                {
                    if (emp.Salary < min)
                    {
                        min = emp.Salary;
                    }
                }
                Console.WriteLine("Минимальная зарплата: " + min);
            }

            void D()
            {
                Console.WriteLine("D: ");
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

            void E()
            {
                Console.WriteLine("E: ");
                int count = 0;
                double summa = 0;
                foreach (var emp in employees)
                {
                    count++;
                    summa += emp.Salary;
                }

                Console.WriteLine($"Среднее значение зарплаты: {summa / count}");
            }

            void F()
            {
                Console.WriteLine("F: ");
                foreach (var emp in employees)
                {
                    Console.WriteLine("ФИО: " + emp.Fio);
                }
                Console.ReadKey();
            }

            A();
            Console.WriteLine();
            B();
            Console.WriteLine();
            C();
            Console.WriteLine();
            D();
            Console.WriteLine();
            E();
            Console.WriteLine();
            F();
        }
    }
}

