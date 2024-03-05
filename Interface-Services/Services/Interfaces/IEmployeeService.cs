using Interface_Services.Models;
using Interface_Services.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Services.Services.Interfaces
{
    public interface IEmployeeService
    {
        Employee[] GetAll();
        EmployeeResponse GetById(Employee[] employees,int? id);
        Employee[] Search(Employee[] employees,string name);
    }
}
