using MongoDB.Driver;
using pg.MongoDb.Data.Models;

namespace pg.MongoDb.Data.Database.Context
{
    public interface INoteContext
    {
        IMongoCollection<Note> Notes { get; }
    }
}
