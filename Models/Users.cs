namespace DotNet_Template1.Models
{
    public class Users
    {

        // Columns 
        public int Id { get; set; }
        public string Name { get; set; }


        // Navigation Property
        public ICollection<Tasks> Tasks { get; set; } = new List<Tasks>();
    }
}
