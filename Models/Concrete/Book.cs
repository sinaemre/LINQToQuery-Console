using LINQToQuery.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToQuery.Models.Concrete
{
    public class Book : BaseItem<int>
    {
        public override int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Range(0.0, 100000.0)]
        public double Price { get; set; }

        public string GenreId { get; set; }
        public Genre Genre { get; set; }

        public List<BookAuthor> BookAuthors { get; set; }
    }
}
