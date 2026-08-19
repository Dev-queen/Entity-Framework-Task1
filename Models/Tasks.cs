namespace DotNet_Template1.Models
{
    public class Tasks
    {
        // Columns
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }

        // Foreign Key
        public int UserId { get; set; }


        // Navigation Property
        public Users? User { get; set; }
    }
}
