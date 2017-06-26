using Practica1.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Services
{
    public class LibraryService: ILibraryService
    {
        /*adaugat la practica in ultima parte*/
        public IList<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() {Id=1, Name="Name#1", Author="Author@1"},
                new Book() {Id=2, Name="Name#2", Author="Author@1"},
                new Book() {Id=3, Name="Name#3", Author="Author@2"},
            };
        }
    }
}
