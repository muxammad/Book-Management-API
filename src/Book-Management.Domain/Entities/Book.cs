using Book_Management.Domain.Commons;

namespace Book_Management.Domain.Entities
{
    public class Book : Auditable
    {
        public string Title { get; set; }
        public DateTime PublicationYear { get; set; }
        public string Author { get; set; }
        public int ViewCount { get; set; }
    }
}
