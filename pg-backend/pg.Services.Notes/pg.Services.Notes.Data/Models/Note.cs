using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace pg.Services.Notes.Data.Models
{
    public class Note
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("Title")]
        public string Title { get; set; }

        [BsonElement("Content")]
        public string Content { get; set; }
    }
}
