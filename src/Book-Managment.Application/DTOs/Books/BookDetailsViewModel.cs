namespace Book_Managment.Application.DTOs.Books
{
    public class BookDetailsViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public int ViewCount { get; set; }
        public double PopularityScore { get; set; }
    }
}
