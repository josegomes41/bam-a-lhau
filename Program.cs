using Microsoft.AspNetCore.Localization;
using bamalhau.Services;
using System.Globalization;
using Microsoft.Azure.Cosmos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

using CosmosClient client = new(
    connectionString: Environment.GetEnvironmentVariable("AZURE_COSMOS_CONNECTIONSTRING")!
);

builder.Services.Configure<RouteOptions>(o =>
{
    o.LowercaseUrls = true;
    o.LowercaseQueryStrings = true;
});

builder.Services.AddSingleton<ICosmosService, CosmosService>();

var app = builder.Build();

app.UseRouting();

app.MapRazorPages();

app.UseStaticFiles();

await app.RunAsync();