namespace API_PROJECT.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; } = null!;
        public List<Tag> Tags { get; } = [];
    }
}
