using RestSharp.Deserializers;

namespace RESTfulAPIConsume.Model
{
    public class GitHubRelease
    {
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }
        [DeserializeAs(Name = "created_at")]
        public string CreatedAt { get; set; }
        [DeserializeAs(Name = "published_at")]
        public string PublishedAt { get; set; }
        [DeserializeAs(Name = "author")]
        public Author Author { get; set; }
        [DeserializeAs(Name = "assets")]
        public string[] Assets { get; set; }
    }

    public class Author
    {
        [DeserializeAs(Name = "login")]
        public string Login { get; set; }
    }
}
