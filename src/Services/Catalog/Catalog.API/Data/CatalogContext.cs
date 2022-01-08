using Catalog.API.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("MongoDatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("MongoDatabaseSettings:DatabaseName"));

            Products = database.GetCollection<Product>(configuration.GetValue<string>("MongoDatabaseSettings:CollectionName"));
            //CatalogContextSeed
        }

        public IMongoCollection<Product> Products { get; }
    }

}
