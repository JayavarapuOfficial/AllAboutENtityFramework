using System.ComponentModel.DataAnnotations.Schema;

namespace CodingWiki.Models.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }

        public decimal Price { get; set; }
        [NotMapped]
        public string PriceRange { get; set; }
        //one to one
        public BookDetail BookDetail { get; set; }

        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }
}
