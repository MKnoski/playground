using MongoDB.Driver;
using pg.Services.Notes.Data.Models;

namespace pg.Services.Notes.Data.Database.Context
{
    public interface INoteContext
    {
        IMongoCollection<Note> Notes { get; }
    }
}
