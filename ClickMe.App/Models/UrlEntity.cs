namespace ClickMe.App.Models
{
    public sealed class UrlEntity
    {
        public Guid Id { get; set; } 
        public string OriginalUrl { get; set; } = string.Empty;
        public string ShortenedUrl => Guid.NewGuid().ToString().Substring(0, 5);

    }
}
