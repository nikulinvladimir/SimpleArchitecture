using SimpleArchitecture.Web.Interfaces;
using SimpleArchitecture.Web.Networks;
using SimpleArchitecture.Web.Services;
using System.Net;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddTransient<IApiNameNetwork, ApiNameNetwork>();
builder.Services.AddTransient<ISimpleDataService, SimpleDataService>();

builder.Services.AddHttpClient("baseClient")
        .ConfigureHttpClient(client => client.DefaultRequestHeaders.Add("", ""))
        .ConfigurePrimaryHttpMessageHandler(
            () => new HttpClientHandler()
            {
                AllowAutoRedirect = true,
                AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip,
                Proxy = new WebProxy("IP", 5000)
                {
                    Credentials = new NetworkCredential("login", "password")
                }
            });


builder.Services.AddControllers();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
