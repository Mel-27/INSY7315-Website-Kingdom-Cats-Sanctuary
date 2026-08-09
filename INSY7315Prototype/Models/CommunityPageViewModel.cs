namespace INSY7315Prototype.Models
{
    public class CommunityPageViewModel
    {
        public List<LostFoundAlert> Alerts { get; set; } = new();
        public List<CommunityPost> Stories { get; set; } = new();
        public ExpertTip FeaturedTip { get; set; } = new();
        public List<BlogArticle> BlogArticles { get; set; } = new();
    }

    public class LostFoundAlert
    {
        public int Id { get; set; }
        public bool IsFound { get; set; }          // false = missing, true = found
        public string PetName { get; set; } = string.Empty;
        public string StatusText { get; set; } = string.Empty;   // e.g. "Last seen in Oak Ridge" / "Safe at Sanctuary"
        public string TimeAgo { get; set; } = string.Empty;      // e.g. "Reported 2h ago"
        public string? PhotoUrl { get; set; }
    }

    public class CommunityPost
    {
        public int Id { get; set; }
        public string AuthorName { get; set; } = string.Empty;
        public string AuthorInitials { get; set; } = string.Empty;
        public string PostedTimeAgo { get; set; } = string.Empty;
        public string? PhotoUrl { get; set; }
        public string Caption { get; set; } = string.Empty;
        public List<string> Tags { get; set; } = new();
        public int Comments { get; set; }
    }

    public class ExpertTip
    {
        public string Badge { get; set; } = "Expert Tip";
        public string Title { get; set; } = string.Empty;
        public string Excerpt { get; set; } = string.Empty;
        public string LinkText { get; set; } = "Read Full Guide";
        public string Url { get; set; } = "#";
    }

    public class BlogArticle
    {
        public int Id { get; set; }
        public string Category { get; set; } = string.Empty;
        public string ReadTime { get; set; } = string.Empty;  
        public string Title { get; set; } = string.Empty;
        public string Excerpt { get; set; } = string.Empty;
        public string? PhotoUrl { get; set; }
        public string Url { get; set; } = "#";
    }

    public class CreatePostRequest
    {
        public string AuthorName { get; set; } = string.Empty;
        public string Caption { get; set; } = string.Empty;
        public string? TagsInput { get; set; }  
        public string? PhotoUrl { get; set; }
    }
}