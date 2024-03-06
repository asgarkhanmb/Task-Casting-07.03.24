using Casting_Practice.Helpers.Constants;
using Casting_Practice.Helpers.Responses;
using Casting_Practice.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_Practice.Controllers
{
    public class EmployeeController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        public object EmployeeResponseMessage { get; private set; }

        public void GetAll()
        {
            var employees = _employeeService.GetAll();
            foreach (var employee in employees)
            {
                string result = $"{employee.Name} {employee.Surname} {employee.Address}" +
                $"{employee.Email} {employee.Age} {employee.Birthday.ToString("MM-dd-yyyy")}";
                Console.WriteLine(result);
            }
        }
        public void GetById()
        {
            int? id = null;
            var response = _employeeService.GetByid(_employeeService.GetAll(), id);
            if (response.ErrorMessage is null)
            {
                string result = $"{response.Employee.Name} {response.Employee.Surname} {response.Employee.Address}" +
              $"{response.Employee.Email} {response.Employee.Age} {response.Employee.Birthday.ToString("MM-dd-yyyy")}";

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }
        }

        public void Search()
        {
            Console.WriteLine("Add search text:");
            string searchText=Console.ReadLine();

            var response =_employeeService.Search(_employeeService.GetAll(), searchText);

            if(response.Length == 0)
            {
                Console.WriteLine(EmployeeResponseMessages.Notfound);
            }
            else
            {
                foreach (var employee in response) 
                {
                    string result = $"{employee.Name} {employee.Surname} {employee.Address}" +
                        $"{employee.Email} {employee.Age} {employee.Birthday.ToString("MM-dd-yyyy")}";
                    Console.WriteLine(result);

                }
            }
        }
       
    }
}
