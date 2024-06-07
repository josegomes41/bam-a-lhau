using bamalhau.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Cosmos;

namespace bamalhau.Services;

public class CosmosService : ICosmosService
{
    private readonly CosmosClient _client;
    private readonly ILogger<CosmosService> _log;

    private static string QUERY_STRING_ALL = "SELECT * FROM Subscription order by Subscription.UpdateDate desc";
    private static string QUERY_LAST_6 = "SELECT top 6 * FROM Subscription order by Subscription.UpdateDate desc";
    public CosmosService(ILogger<CosmosService> log)
        
    {
        _log = log;
        _client = new CosmosClient(
       connectionString: Environment.GetEnvironmentVariable("AZURE_COSMOS_CONNECTIONSTRING"));
    }

    private Container container
    {
        get => _client.GetDatabase("BAM").GetContainer("Subscription");
    }
    private Container logcontainer
    {
        get => _client.GetDatabase("BAM").GetContainer("Log");
    }


    public async Task<IEnumerable<Subscription>> GetSubscriptionsAsync()
    {
        var query = this.container.GetItemQueryIterator<Subscription>(new QueryDefinition(QUERY_STRING_ALL));
        List<Subscription> results = new List<Subscription>();
        while (query.HasMoreResults)
        {
            var response = await query.ReadNextAsync();

            results.AddRange(response.ToList());
        }

        return results;
    }
    

         public async Task<IEnumerable<Subscription>> RetrieveLastSubscriptionsAsync()
    {
        var query = this.container.GetItemQueryIterator<Subscription>(new QueryDefinition(QUERY_LAST_6));
        List<Subscription> results = new List<Subscription>();
        while (query.HasMoreResults)
        {
            var response = await query.ReadNextAsync();

            results.AddRange(response.ToList());
        }

        return results;
    }

    public async Task<IEnumerable<Log>> GetLogsAsync(string correlationID)
    {

        var queryDefinition = new QueryDefinition(
       "SELECT * FROM Log WHERE Log.CorrelationId = @correlationID ORDER BY Log.UpdateDate DESC")
       .WithParameter("@correlationID", correlationID);

        _log.LogWarning(queryDefinition.ToString());

        var query = this.logcontainer.GetItemQueryIterator<Log>(queryDefinition);
        List<Log> results = new List<Log>();
        while (query.HasMoreResults)
        {
            var response = await query.ReadNextAsync();

            results.AddRange(response.ToList());
        }
        Console.WriteLine($"Total items fetched: {results.Count}");
        return results;
    }


}