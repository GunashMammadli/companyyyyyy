using System;
using System.ComponentModel;

namespace ConsoleApp36;
internal class Program
{
    static void Main(string[] args)
    {
        //List<Employee> employees = new List<Employee>();
        //{
        //    new Employee() { Name = "Gunash", Surname = "Mammadli", Age = 20, Position = "Developer", Salary = 10000}
        //};

        Company company = new Company();

        char option;
        do
        {
            Console.WriteLine("1. Create an employee");
            Console.WriteLine("2. Get employee details by id");
            Console.WriteLine("3. Get all employees");
            Console.WriteLine("4. Update employee details id");
            Console.WriteLine("5. Delete employee records by id");
            Console.WriteLine("q. Quit app");

            option = Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case '1':
                    Employee employee = new Employee();
                    Console.WriteLine("Enter Name: ");
                    employee.Name = Console.ReadLine();
                    Console.WriteLine("Enter Surname: ");
                    employee.Surname = Console.ReadLine();
                    Console.WriteLine("Enter Age: ");
                    employee.Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Position: ");
                    employee.Position = Console.ReadLine();
                    Console.WriteLine("Enter Salary: ");
                    employee.Salary = Convert.ToInt32(Console.ReadLine());
                    company.AddEmployee(employee);
                    Console.WriteLine("Successfully added!");
                    break;
                case '2':
                    Console.WriteLine("Enter ID: ");
                    int empId = Convert.ToInt32(Console.ReadLine());
                    company.GetEmployeeID(empId);
                    break;
                case '3':
                    company.GetAllEmployee();
                    break;
                case '4':
                   // company.UpdateEmployee(employee);
                    break;
                case '5':
                    //Console.WriteLine("Enter ID: ");
                    //int emplId = Convert.ToInt32(Console.ReadLine());
                    //company.RemoveEmployee(emplId);
                    break;
            }
        } while (option != 'q');
    }
}