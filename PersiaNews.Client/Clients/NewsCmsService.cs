namespace PersiaNews.Client.Clients;

using System.Text;
using Newtonsoft.Json;
using Models.Dtos;
using Models.Queries;

public class NewsCmsService
{
    private readonly HttpClient _client;

    public NewsCmsService(HttpClient client)
    {
        _client = client;
        client.BaseAddress = new Uri("http://localhost:7770/newscms/");
    }

    public async Task<NewsSearchByTitle> List(NewsSearchByTitleQuery source)
    {
        var jsonBody = JsonConvert.SerializeObject(source);

        var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
        var response = await _client.PostAsync("api/News/list-news", content);

        var jsonResult = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<NewsSearchByTitle>(jsonResult);
        return result;
    }
}
