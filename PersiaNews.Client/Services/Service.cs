namespace PersiaNews.Client.Services;

using Clients;

internal static class Service
{
    internal static void Host(string[] args) => WebApplication.CreateBuilder(args).Services().Pipeline();

    private static WebApplicationBuilder Services(this WebApplicationBuilder source)
    {
        source.Services.AddHttpClient<BasicInfoService>();
        source.Services.AddHttpClient<NewsCmsService>();
        source.Services.AddRazorPages();
        return source;
    }

    private static void Pipeline(this WebApplicationBuilder source)
    {
        var app = source.Build();
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();
        app.MapRazorPages();
        app.Run();
    }
}
