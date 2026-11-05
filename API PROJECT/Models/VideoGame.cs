namespace API_PROJECT.Models
{
    public class VideoGame
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public VideoGameDetails? VideoGameDetails { get; set; }
    }
}
