using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IEmployeeService 
    {
        int GetEmployeeCountByFiltered(DateTime startBirthday, DateTime endBirthday, double salary);
       
    }
}
