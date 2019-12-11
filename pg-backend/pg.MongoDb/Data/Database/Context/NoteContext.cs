using Microsoft.Extensions.Options;
using MongoDB.Driver;
using pg.MongoDb.Data.Models;

namespace pg.MongoDb.Data.Database.Context
{
    // change ---> generic
    public class NoteContext : DbContext, INoteContext
    {
        private const string CollectionName = "Notes";

        public NoteContext(IOptions<MongoDbSettings> options) 
            : base(options)
        {
        }

        public IMongoCollection<Note> Notes => base.db.GetCollection<Note>(CollectionName);
    }
}
