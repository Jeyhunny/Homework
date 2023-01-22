using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class AuthorService : IAuthorService
    {

        public List<Author> ShowFullNameOfAuthorByFiltered(int age)
        {

            var authors = GetAll().FindAll(m => m.Age > age);

            return authors;

        }


        private List<Author> GetAll()
        {
            List<Author> authors = new();

            Author author1 = new Author
            {
                Name = "Konul",
                Surname = "Ibrahimova",
                Age = 26
            };

            Author author2 = new Author
            {
                Name = "Teyyub",
                Surname = "Abbasov",
                Age = 45
            };

            Author author3 = new Author
            {
                Name = "Vahid",
                Surname = "Huseynov",
                Age = 35
            };

            Author author4 = new Author
            {
                Name = "Kenan",
                Surname = "Quliyev",
                Age = 43
            };

            Author author5 = new Author
            {
                Name = "Gulshen",
                Surname = "Abdullayeva",
                Age = 47
            };

            Author author6 = new Author
            {
                Name = "Zehra",
                Surname = "Qurbanova",
                Age = 30
            };

            authors.Add(author1);   
            authors.Add(author2);
            authors.Add(author3);
            authors.Add(author4);
            authors.Add(author5);
            authors.Add(author6);

            return authors;
        }




    }
}
