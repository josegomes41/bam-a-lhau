using Microsoft.AspNetCore.Mvc.RazorPages;
using bamalhau.Models;
using bamalhau.Services;

namespace bamalhau.Pages;

public class SubscriptionsPageModel : PageModel
{
    private readonly ICosmosService _cosmosService;

    public IEnumerable<Subscription>? Subscriptions { get; set; }

    public SubscriptionsPageModel(ICosmosService cosmosService)
    {
        _cosmosService = cosmosService;
    }

    public async Task OnGetAsync()
    {
        Subscriptions ??= await _cosmosService.GetSubscriptionsAsync();
    }
}