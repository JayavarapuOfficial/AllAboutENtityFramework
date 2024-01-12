using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingWiki.Models.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } //required , maxLength 50
        public string LastName { get; set; } //Required
        public DateTime BirthDate { get; set; }
        public string  Location { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
