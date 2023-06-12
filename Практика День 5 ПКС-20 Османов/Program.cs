using System;

namespace ConsoleApp33
{
    using System;
    using System.Collections.Generic;

    public class Employee
    {
        public string fio {get;set;}
        public int Id {get;set;}
        public decimal zarplata {get;set;}
        public string otdel {get;set;}
    }

    public class EmployeeBook
    {
        private List<Employee> employees;

        public EmployeeBook()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void RemoveEmployee(string fullName, int id)
        {
            Employee employee = FindEmployee(fullName, id);
            if (employee != null)
            {
                employees.Remove(employee);
            }
        }

        public void UpdateSalary(string fullName, int id, decimal newSalary)
        {
            Employee employee = FindEmployee(fullName, id);
            if (employee != null)
            {
                employee.zarplata = newSalary;
            }
        }

        public void PrintEmployeesByDepartments()

        {
            Dictionary<string, List<Employee>> employeesByDepartment = GroupEmployeesByDepartment();

            foreach (var department in employeesByDepartment)
            {
                Console.WriteLine($"Отдел: {department.Key}");
                foreach (var employee in department.Value)
                {
                    Console.WriteLine($"ФИО: {employee.fio}");
                    Console.WriteLine($"Зарплата: {employee.zarplata}");
                }
                Console.WriteLine();
            }
        }

        public void UpdateDepartment(string fullName, int id, string newDepartment)
        {
            Employee employee = FindEmployee(fullName, id);
            if (employee != null)
            {
                employee.otdel = newDepartment;
            }
        }

        private Employee FindEmployee(string fullName, int id)
        {
            foreach (var employee in employees)
            {
                if (employee.fio == fullName && employee.Id == id)
                {
                    return employee;
                }
            }
            return null;
        }

        private Dictionary<string, List<Employee>> GroupEmployeesByDepartment()
        {
            Dictionary<string, List<Employee>> employeesByDepartment = new Dictionary<string, List<Employee>>();

            foreach (var employee in employees)
            {
                if (employeesByDepartment.ContainsKey(employee.otdel))
                {
                    employeesByDepartment[employee.otdel].Add(employee);
                }
                else
                {
                    employeesByDepartment[employee.otdel] = new List<Employee> { employee };
                }
            }

            return employeesByDepartment;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBook employeeBook = new EmployeeBook();

            // Добавление новых сотрудников
            employeeBook.AddEmployee(new Employee
            {
                fio = "Иванов Игорь Витальевич",
                Id = 1,
                zarplata = 25000,
                otdel = "Информационные технологии"
            });

            employeeBook.AddEmployee(new Employee
            {
                fio = "Кинжинов Наиль Алиевич",
                Id = 2,
                zarplata = 35000,
                otdel = "Управление делами и контроль"
            });
            employeeBook.AddEmployee(new Employee
            {
                fio = "Петров Сергей Иванович",
                Id = 3,
                zarplata = 40000,
                otdel = "Финансовая политика"
            });
            employeeBook.AddEmployee(new Employee
            {
                fio = "Зайцев Алексей Андреевич",
                Id = 4,
                zarplata = 20000,
                otdel = "Информационно-аналитическая деятельность"
            });
            employeeBook.AddEmployee(new Employee
            {
                fio = "Алексеев Александр Дмитриевич",
                Id = 5,
                zarplata = 30000,
                otdel = "Доходов"
            });

            // Удаление сотрудника
            employeeBook.RemoveEmployee("Петров Сергей Иванович", 3);

            // Изменение зарплаты
            employeeBook.UpdateSalary("Кинжинов Наиль Алиевич", 2, 40000);

            // Изменение отдела
            employeeBook.UpdateDepartment("Алексеев Александр Дмитриевич", 5, "Отдел финансовой политики");

            // Вывод списка сотрудников по отделам
            employeeBook.PrintEmployeesByDepartments();
        }
    }
}