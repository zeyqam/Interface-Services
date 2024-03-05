using Interface_Services.Models;
using Interface_Services.Services;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Services.Controllers
{
    public class EmployeeController
    {
        private readonly EmployeeService _employeeService;
        public EmployeeController()
        {
            _employeeService =  new EmployeeService();
        }
        public void GetAll()
        {
            var employees = _employeeService.GetAll();
            foreach (var employee in employees)
            {
                string result =$"{employee.Name} {employee.Surname} {employee.Age} {employee.Address} {employee.Email} {employee.Birthday.ToString("MM-dd-yyy")}";
                Console.WriteLine(result);
            }

        }
        public void GetById()
        {
            int? id = 100;
            var response=_employeeService.GetById(_employeeService.GetAll(),id);
            if(response.ErorrMessages is null)
            {
                string result = $"{response.Employee.Name} {response.Employee.Surname} {response.Employee.Age} {response.Employee.Address} {response.Employee.Email} {response.Employee.Birthday.ToString("MM-dd-yyy")}";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(response.ErorrMessages);
            }
        }
        public void SearchEmployee(Employee[] employees,string name)
        {
            Employee[] searchResults = _employeeService.Search( employees,name);
            Console.WriteLine("\nSearch Results:");
            foreach (Employee employee in searchResults)
            {
                string result = $"{employee.Name} {employee.Surname} {employee.Age} {employee.Address} {employee.Email} {employee.Birthday.ToString("MM-dd-yyy")}";
                Console.WriteLine(result);
            }
        }
        
    }
}
