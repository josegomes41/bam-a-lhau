using bamalhau.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Cosmos;

namespace bamalhau.Services;

public class CosmosService : ICosmosService
{
    private Container _container;
    private static string QUERY_STRING_ALL = "SELECT distinct Subscription.SubscriptionId FROM Subscription";
    public CosmosService(
           CosmosClient dbClient,
           string databaseName,
           string containerName)
    {
        this._container = dbClient.GetContainer(databaseName, containerName);
    }

    public async Task<IEnumerable<string>> GetSubscriptionsList()
    {
        
        var query = this._container.GetItemQueryIterator<string>(new QueryDefinition(QUERY_STRING_ALL));
        List<string> results = new List<string>();
        while (query.HasMoreResults)
        {
            var response = await query.ReadNextAsync();

            results.AddRange(response.ToList());
        }

        return results;

    }
}