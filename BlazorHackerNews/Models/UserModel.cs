#nullable enable

namespace BlazorHackerNews.Models
{
    public class UserModel
    {
        public string? Id { get; set; }
        public string? About { get; set; }
        public int Karma { get; set; }
        public string? Created { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("created_time")]
        public int CreatedTime { get; set; }
    }
}
