namespace PersiaNews.Client.Models.Queries;

public class NewsSearchByTitleQuery
{
    public int Page { get; set; } = 1;
    public int Size { get; set; } = 1;
    public string SortBy { get; set; } = "Id";
    public bool SortAscending { get; set; } = true;
    public bool NeededTotalCount { get; set; } = true;
    public string Title { get; set; } = "";
}
