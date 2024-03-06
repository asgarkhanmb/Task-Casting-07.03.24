using Casting_Practice.Helpers.Responses;
using Casting_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_Practice.Services.Interfaces
{
    public interface IEmployeeService
    {
        Employee[] GetAll();
        EmployeeResponse GetByid(Employee[] employees, int? id);
        Employee[] Search(Employee [] employess,string searchText); 
    
    }
}
