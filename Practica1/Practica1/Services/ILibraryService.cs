using Practica1.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Services
{
    public interface ILibraryService
    {
        /* adaugat la practica in ultima parte*/
        IList<Book> GetBooks();
    }
}
