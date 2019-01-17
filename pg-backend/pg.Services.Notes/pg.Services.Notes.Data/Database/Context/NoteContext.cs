using Microsoft.Extensions.Options;
using MongoDB.Driver;
using pg.Services.Notes.Data.Models;

namespace pg.Services.Notes.Data.Database.Context
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
