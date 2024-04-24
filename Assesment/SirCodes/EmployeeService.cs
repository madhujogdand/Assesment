using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    public class EmployeeService
    {
        private List<Employees> employees;

        public EmployeeService()
        {
            employees = new List<Employees>();
        }

        public void AddEmployee(Employees employee)
        {
            employees.Add(employee);
        }

        public void UpdateEmployee(int id, Employees updatedEmployee)
        {
            Employees employee = employees.Find(emp => emp.Id == id);
            if (employee != null)
            {
                employee.Name = updatedEmployee.Name;
                employee.Salary = updatedEmployee.Salary;
                Console.WriteLine("Employee information updated successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        public void DeleteEmployee(int id)
        {
            Employees employee = employees.Find(emp => emp.Id == id);
            if (employee != null)
            {
                employees.Remove(employee);
                Console.WriteLine("Employee deleted successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        public Employees GetEmployeeById(int id)
        {
            return employees.Find(emp => emp.Id == id);
        }

        public Employees GetEmployeeByName(string name)
        {
            return employees.Find(emp => emp.Name == name);
        }

        public List<Employees> GetAllEmployees()
        {
            return employees;
        }
    }
}
