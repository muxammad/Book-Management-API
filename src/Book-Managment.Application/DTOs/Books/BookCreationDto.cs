using Book_Managment.Application.Helper.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Book_Managment.Application.DTOs.Books
{
    public class BookCreationDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public DateTime PublicationYear { get; set; }
    }
}
