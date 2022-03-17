using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee()
            {
                EmployeeName = "Ayhan",
                Surname = "Isgenderzade",
                Salary = 650

            };
            Employee employee2 = new Employee()
            {
                EmployeeName = "Nermin",
                Surname = "Quliyeva",
                Salary = 150

            };
            Employee employee3 = new Employee()
            {
                EmployeeName = "Shahsuvar",
                Surname = "Heyderov",
                Salary = 550

            };
            Employee employee4 = new Employee()
            {
                EmployeeName = "Ayhan",
                Surname = "Isgenderzade",
                Salary = 450
            };
            Department department1 = new Department()
            {
                Name = "Product Decisions",
                EmployeeLimit = 3,
                SalaryLimit = 250
            };
            try
            {
                department1.AddEmployee(employee1);
                department1.AddEmployee(employee2);
                department1.AddEmployee(employee3);
                department1.AddEmployee(employee4);
            }
            catch (Exception)
            {
                Console.WriteLine("Limit asildi");
            }
            foreach (var item in department1.Employees)
            {
                Console.WriteLine(item.GetInfo());
            }
        }
    }
}
