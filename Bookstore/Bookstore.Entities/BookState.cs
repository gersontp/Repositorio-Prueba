using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Entities
{
    public class BookState
    {
        public int BookStateId { get; set; }

        public string Description { get; set; }

        public List<Book> Books { get; set; }

        public BookState()
        {
            Books = new List<Book>();
        }
    }
}
