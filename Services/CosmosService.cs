using bamalhau.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Cosmos;

namespace bamalhau.Services;

public class CosmosService : ICosmosService
{
    private readonly CosmosClient _client;

    private static string QUERY_STRING_ALL = "SELECT * FROM Subscription";
    public CosmosService()
    {
        _client = new CosmosClient(
       connectionString: Environment.GetEnvironmentVariable("AZURE_COSMOS_CONNECTIONSTRING"));
    }

    private Container container
    {
        get => _client.GetDatabase("BAM").GetContainer("Subscription");
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

    public async Task<IEnumerable<Subscription>> GetLogsAsync(string subscriptionId)
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


}