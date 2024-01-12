using System.ComponentModel.DataAnnotations;

namespace CodingWiki.Models.Models
{
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Location { get; set; }

    }
}
