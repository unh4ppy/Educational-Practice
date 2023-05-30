using System;

namespace ConsoleApp3
{

    class Employee
    {
        private static int idCounter = 1;

        private int id;
        private string fullName;
        private int department;
        private double salary;

        public Employee(string fullName, int department, double salary)
        {
            this.id = idCounter++;
            this.fullName = fullName;
            this.department = department;
            this.salary = salary;
        }

        public int Id { get { return id; } }
        public string FullName { get { return fullName; } }
        public int Department { get { return department; } set { department = value; } }
        public double Salary { get { return salary; } set { salary = value; } }

        public override string ToString()
        {
            return $"ID: {id}, Полное имя: {fullName}, Отдел: {department}, Зарплата: {salary}";
        }
    }

    class Program
    {
        private static Employee[] employees = new Employee[10];

        static void Main(string[] args)
        {
            employees[0] = new Employee("Орехов Владислав Петрович", 1, 30000);
            employees[1] = new Employee("Петров Иван Игоревич", 2, 35000);
            employees[2] = new Employee("Кинжинов Наиль Алиевич", 3, 60000);
            employees[3] = new Employee("Иванов Игорь Витальевич", 4, 75000);
            employees[4] = new Employee("Сергеев Александр Денисович", 5, 45000);
            employees[5] = new Employee("Кузнецов Петр Александрович", 6, 50000);
            employees[6] = new Employee("Зайцев Сергей Алексеевич", 7, 55000);

            Console.WriteLine("Все сотрудники:");
            PrintAllEmployees();

            Console.WriteLine($"Общая стоимость месячной заработной платы: {GetTotalSalaryCost()}");

            Employee minSalaryEmployee = GetEmployeeWithMinSalary();
            Console.WriteLine($"Сотрудник с минимальной зарплатой: {minSalaryEmployee}");

            Employee maxSalaryEmployee = GetEmployeeWithMaxSalary();
            Console.WriteLine($"Сотрудник с максимальной зарплатой: {maxSalaryEmployee}");

            Console.WriteLine($"Средняя зарплата: {GetAverageSalary()}");

            Console.WriteLine("Полные имена:");
            PrintAllFullNames();
        }

        private static void PrintAllEmployees()
        {
            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    Console.WriteLine(employee);
                }
            }
        }

        private static double GetTotalSalaryCost()
        {
            double totalSalaryCost = 0;
            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    totalSalaryCost += employee.Salary;
                }
            }
            return totalSalaryCost;
        }

        private static Employee GetEmployeeWithMinSalary()
        {
            Employee minSalaryEmployee = null;
            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    if (minSalaryEmployee == null || employee.Salary < minSalaryEmployee.Salary)
                    {
                        minSalaryEmployee = employee;
                    }
                }
            }
            return minSalaryEmployee;
        }

        private static Employee GetEmployeeWithMaxSalary()
        {
            Employee maxSalaryEmployee = null;
            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    if (maxSalaryEmployee == null || employee.Salary > maxSalaryEmployee.Salary)
                    {
                        maxSalaryEmployee = employee;
                    }
                }
            }
            return maxSalaryEmployee;
        }

        private static double GetAverageSalary()
        {
            double totalSalary = 0;
            int employeeCount = 0;
            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    totalSalary += employee.Salary;
                    employeeCount++;
                }
            }
            return totalSalary / employeeCount;
        }

        private static void PrintAllFullNames()
        {
            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    Console.WriteLine(employee.FullName);
                }
            }
        }
    }
}