#nullable enable
using System.Collections.Generic;

namespace BlazorHackerNews.Models
{

    public class ItemModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int? Points { get; set; }
        public string? User { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("time_ago")]
        public string? TimeAgo { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("comments_count")]
        public int? CommentsCount { get; set; }
        public string? Content { get; set; }
        public List<ItemModel>? Comments { get; set; }
        public bool? Deleted { get; set; }
        public string? Type { get; set; }
        public string? Url { get; set; }
        public string? Domain { get; set; }
    }
}
