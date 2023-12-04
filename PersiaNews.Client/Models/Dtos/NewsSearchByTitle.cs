namespace PersiaNews.Client.Models.Dtos;

public class NewsSearchByTitle
{
    public List<NewsSearchItem> Items { get; set; } = new List<NewsSearchItem>();
}

public class NewsSearchItem
{
    public long Id { get; set; }
    public Guid Code { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Body { get; set; }
    public List<NewsKeywordInfo> Keywords { get; set; } = new();
}

public class NewsKeywordInfo
{
    public Guid Code { get; set; }
    public string Title { get; set; }
}
