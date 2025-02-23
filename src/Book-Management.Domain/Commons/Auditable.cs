namespace Book_Management.Domain.Commons
{
    public class Auditable
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

    }
}
