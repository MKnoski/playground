using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace pg.MongoDb.Data.Database
{
    public abstract class DbContext
    {
        protected readonly IMongoDatabase db;

        public DbContext(IOptions<MongoDbSettings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            db = client.GetDatabase(options.Value.Database);
        }
    }
}
