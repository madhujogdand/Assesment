using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    internal class EmployeeCRUD
    {
        static void Main(string[] args)
        {
            EmployeeService employeeService = new EmployeeService();

            while (true)
            {
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Update Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. Display Employee By ID");
                Console.WriteLine("5. Display Employee By Name");
                Console.WriteLine("6. Display All Employees");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter employee ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter employee name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter employee salary: ");
                        double salary = double.Parse(Console.ReadLine());

                        employeeService.AddEmployee(new Employees(id, name, salary));
                        Console.WriteLine("Employee added successfully.");
                        break;
                    case 2:
                        Console.Write("Enter employee ID to update: ");
                        int updateId = int.Parse(Console.ReadLine());
                        Console.Write("Enter new employee name: ");
                        string newName = Console.ReadLine();
                        Console.Write("Enter new employee salary: ");
                        double newSalary = double.Parse(Console.ReadLine());

                        employeeService.UpdateEmployee(updateId, new Employees(updateId, newName, newSalary));
                        break;
                    case 3:
                        Console.Write("Enter employee ID to delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        employeeService.DeleteEmployee(deleteId);
                        break;
                    case 4:
                        Console.Write("Enter employee ID to display: ");
                        int displayId = int.Parse(Console.ReadLine());
                        Employees employee = employeeService.GetEmployeeById(displayId);
                        if (employee != null)
                        {
                            Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Salary: {employee.Salary:C}");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found.");
                        }
                        break;
                    case 5:
                        Console.Write("Enter employee Name to display: ");
                        string displayName = Console.ReadLine();
                        Employees empname = employeeService.GetEmployeeByName(displayName);
                        if (empname != null)
                        {
                            Console.WriteLine($"ID: {empname.Id}, Name: {empname.Name}, Salary: {empname.Salary:C}");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found.");
                        }
                        break;
                    case 6:
                        Console.WriteLine("All Employees:");
                        foreach (Employees emp in employeeService.GetAllEmployees())
                        {
                            Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary:C}");
                        }
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        break;
                }
            }
        }
    }
}
