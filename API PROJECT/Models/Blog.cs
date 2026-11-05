namespace API_PROJECT.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Post> Posts { get; set; } = new List<Post>();

    }
}
