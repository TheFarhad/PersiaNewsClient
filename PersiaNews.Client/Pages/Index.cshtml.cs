namespace PersiaNews.Client.Pages;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Clients;
using Models.Dtos;
using Models.Queries;

public class IndexModel : PageModel
{
    private readonly NewsCmsService _newsCmsService;
    public NewsSearchByTitle Model { get; set; }

    public IndexModel(NewsCmsService newsCmsService) => _newsCmsService = newsCmsService;

    public async Task OnGet()
    {
        Model = await _newsCmsService.List(new NewsSearchByTitleQuery());
    }
}