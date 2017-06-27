using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practica1.Models;
using Practica1.Services;

namespace Practica1.Controllers
{
    public class LibraryController : Controller
    {
        private ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService) //prin intermediul am facut leg la niv de controller inte controller si servicii
        {
            _libraryService = libraryService;
        }

        public IActionResult Index()
        {
            /* laborator 2
             var model = new LibraryViewModel();
             model.NumberOfBooks = 10;
             model.Date = DateTime.Now;
             return View(model);
             */

            /* tema facuta de mine!!
            List<LibraryViewModel> books = new List<LibraryViewModel>();
            books.Add(new LibraryViewModel(1, "Luceafarul", "Mihai Eminescu"));
            books.Add(new LibraryViewModel(2, "Ion", "Liviu Rebreanu"));
            books.Add(new LibraryViewModel(3, "Enigma Otiliei", "George Calinescu"));
            books.Add(new LibraryViewModel(4, "D-l Goe", "Ion Luca Caragiale"));
            books.Add(new LibraryViewModel(5, "Morometii", "Marin Preda"));
            return View(books); //trebuie trimis modelul la propriu pentru a putea fi afisate in pagina
            
//in index.cshtml
 @model IEnumerable<Practica1.Models.LibraryViewModel>
<style>
    table { border-collapse: collapse; width: 100%; }
    th, td { text-align: left; padding: 8px;}
    tr:nth-child(even) { background-color: #f2f2f2 }
    th { background-color: #4CAF50; color: white; }
</style>
<table>
    <tr>   <th>Id</th> <th>Name</th> <th>Author</th>    </tr>
    @foreach (var item in Model)
    {
        <tr>   <td> @item.id </td> <td> @item.name </td> <td> @item.author </td>   </tr>
    }
</table>
            */

            
            /* adaugat la practica in ultima parte*/
            var books = _libraryService.GetBooks();

            /*facut la practica*/
            var model = new LibraryViewModel(books);

           // model.Books.Add(new Models.LibraryViewModels.BookViewModel() { Id = 1, Name = "Name#1", Author = "Author@1" });
           // model.Books.Add(new Models.LibraryViewModels.BookViewModel() { Id = 2, Name = "Name#2", Author = "Author@1" });
           // model.Books.Add(new Models.LibraryViewModels.BookViewModel() { Id = 3, Name = "Name#3", Author = "Author@2" });

            return View(model);
        }
    }
}