using DomainLayer.Models;
using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator__overloading__Collections.Controllers
{
    public class AuthorController
    {
        private readonly AuthorService _service;

        public AuthorController()
        {
            _service = new AuthorService();  
        }

        public void ShowFullNameOfAuthorByFiltered()
        {
            //int age = 40;

            //var result = _service.ShowFullNameOfAuthorByFiltered(age);

            //foreach (var item in result)
            //{
            //        Console.WriteLine($"{item.Name} {item.Surname}");

            //}

            Console.WriteLine("Axtardiginiz yashi daxil edin");
            int age = int.Parse(Console.ReadLine());

            List<Author> result = _service.ShowFullNameOfAuthorByFiltered(age);

            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Name}  {item.Surname} ");
                }
            }

        }
    }
}
