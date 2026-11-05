using System.Text.Json.Serialization;

namespace API_PROJECT.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        [JsonIgnore]
        public List<Post> Posts { get; } = [];
    }
}
