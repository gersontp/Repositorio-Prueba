using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Entities
{
    public class BookLevel
    {
        public int BookLevelId { get; set; }

        public string Description { get; set; }

        public List<Book> Books { get; set; }

        public BookLevel()
        {
            Books = new List<Book>();
        }
    }
}
