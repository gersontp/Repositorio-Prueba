using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Entities
{
    public class Book
    {
        public int BookId { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int BookLevelId { get; set; }
        
        public BookLevel BookLevel { get; set; }

        public int BookStateId { get; set; }

        public BookState BookState { get; set; }

        public List<Tag> Tags { get; set; }

        public Book()
        {
            Tags = new List<Tag>();
        }
    }
}
