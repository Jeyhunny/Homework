using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
       
        public int  GetEmployeeCountByFiltered(DateTime startBirthday, DateTime endBirthday, double salary)
        {
            var employees = GetAll();

            List<Employee> employee = GetAll().FindAll(m => m.Birthday > startBirthday && m.Birthday < endBirthday && m.Salary > salary);

            return employee.Count ;
        }

        private List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee1= new Employee
            {
                Name = "Ceyhun",
                Surname = "Yusifli",
                Birthday = new DateTime(2000,11,24),
                Salary = 2800
            };

            Employee employee2 = new Employee
            {
                Name = "Fuad",
                Surname = "Alakbarov",
                Birthday = new DateTime(1993, 09, 19),
                Salary = 2350
            };

            Employee employee3 = new Employee
            {
                Name = "Shaiq",
                Surname = "Khazimov",
                Birthday = new DateTime(1998, 11,26),
                Salary = 2800
            };

            Employee employee4 = new Employee
            {
                Name = "Aqshin",
                Surname = "Hummetov",
                Birthday = new DateTime(1995, 12, 24),
                Salary = 3000
            };

            Employee employee5 = new Employee
            {
                Name = "Vaqif",
                Surname = "Esedovv",
                Birthday = new DateTime(1990, 03, 25),
                Salary = 1500
            };

            Employee employee6 = new Employee
            {
                Name = "Yaqub",
                Surname = "Abbasov",
                Birthday = new DateTime(2004, 10, 21),
                Salary = 1500
            };

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);

            
            return employees;
        }
    }
}
