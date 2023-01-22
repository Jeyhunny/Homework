using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator__overloading__Collections.Controllers
{
    public class EmployeeController
    {
        private readonly IEmployeeService _service;

        public EmployeeController()
        {
            _service = new EmployeeService();
        }

        public void GetEmployeeCountByFiltered()
        {

            DateTime startBirthday = new DateTime(1995, 01, 20);
            DateTime endBirthday = new DateTime(2000, 05, 20);
            double salary = 2000;

            var result = _service.GetEmployeeCountByFiltered(startBirthday, endBirthday, salary);

            Console.WriteLine(result);
        }
    }
}
