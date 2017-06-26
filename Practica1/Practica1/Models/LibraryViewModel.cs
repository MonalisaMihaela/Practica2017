using Practica1.Data.Entities;
using Practica1.Models.LibraryViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Models
{
    public class LibraryViewModel
    {
        /*public int NumberOfBooks { set; get; }
        public DateTime Date { set; get; }*/

        /* tema facuta de mine!!!
        public LibraryViewModel(int id, string name, string author)
        {
            this.id = id;
            this.name = name;
            this.author = author;
        }
        public int id { set; get; }
        public string name { set; get; }
        public string author { set; get; }
        */

        /* adaugat la practica in ultima parte*/
        public IList<BookViewModel> Books { get; set; }

        public LibraryViewModel(IList<Book> books)
        {
            Books = new List<BookViewModel>();

            foreach (var book in books)
            {
                var bookViewModel = new BookViewModel()
                {
                    Id = book.Id,
                    Name = book.Name,
                    Author = book.Author
                };

                Books.Add(bookViewModel);
            }
        }
    }
}
