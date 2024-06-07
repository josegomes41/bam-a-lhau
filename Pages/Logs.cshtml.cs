using Microsoft.AspNetCore.Mvc.RazorPages;
using bamalhau.Models;
using bamalhau.Services;
using Microsoft.AspNetCore.Mvc;

namespace bamalhau.Pages;

public class LogsPageModel : PageModel
{
    private readonly ICosmosService _cosmosService;

    [BindProperty(SupportsGet = true)]
    public string CorrelationId { get; set; }

    public IEnumerable<Log>? Logs { get; set; }

    public int? LogCount { get; set; }


    public LogsPageModel(ICosmosService cosmosService)
    {
        _cosmosService = cosmosService;
    }

    public async Task OnGetAsync()
    {
        Logs ??= await _cosmosService.GetLogsAsync(CorrelationId);
        LogCount = Logs.Count();
    }
}