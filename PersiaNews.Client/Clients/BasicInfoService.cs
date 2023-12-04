namespace PersiaNews.Client.Clients;

public class BasicInfoService
{
    private readonly HttpClient _client;

    public BasicInfoService(HttpClient client)
    {
        _client = client;
        client.BaseAddress = new Uri("http://localhost:7770/bi/");
    }
}