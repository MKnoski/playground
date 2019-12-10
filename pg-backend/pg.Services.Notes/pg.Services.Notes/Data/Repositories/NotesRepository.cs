using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using MongoDB.Bson;
using MongoDB.Driver;
using pg.MongoDb.Data.Database.Context;
using pg.MongoDb.Data.Models;
using pg.MongoDb.Data.Repositories.Interfaces;

namespace pg.MongoDb.Data.Repositories
{
    public class NotesRepository : INotesRepository
    {
        private readonly INoteContext context;

        public NotesRepository(INoteContext context)
        {
            this.context = context;

            if (!(this.context.Notes.CountDocuments(_ => true) > 0))
            {
                var note = new Note()
                {
                    Title = "Test",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse ultrices vel odio ac porttitor. Sed vel posuere enim, ac elementum lectus. Nam eget tincidunt nisl. Proin ut arcu auctor, ornare mauris id, malesuada diam. Quisque bibendum suscipit ullamcorper. Vestibulum eget varius tortor, lacinia suscipit erat. Mauris luctus lacus odio, non euismod lectus cursus id. Etiam molestie diam mi, id gravida lectus auctor in. Praesent venenatis blandit maximus. Pellentesque commodo augue quis erat efficitur elementum. Sed vitae convallis tellus. Aenean eu orci sed ante molestie dapibus ut vel lacus. Morbi massa orci, commodo in tellus eget, efficitur vehicula est. Phasellus varius condimentum nisi, nec luctus tortor cursus id. Sed bibendum dui sit amet nisi interdum pretium. Sed in odio mauris."
                };

                this.context.Notes.InsertOne(note);
            }
        }

        public List<Note> GetNotes()
        {
            return this.context.Notes.Find(_ => true).ToList();
        }

        public Note GetNote(string id)
        {
            var filter = Builders<Note>.Filter.Eq(m => m.Id, ObjectId.Parse(id));
            return this.context
                    .Notes
                    .Find(filter)
                    .FirstOrDefault();
        }

        public void AddNote(Note note)
        {
            this.context.Notes.InsertOne(note);
        }

        public bool EditNote(string id, Note note)
        {
            var updateResult = this.context
                .Notes
                .ReplaceOne(
                    filter: g => g.Id == ObjectId.Parse(id),
                    replacement: note);

            return updateResult.IsAcknowledged && updateResult.ModifiedCount > 0;
        }

        public bool DeleteNote(string id)
        {
            var filter = Builders<Note>.Filter.Eq(m => m.Id, ObjectId.Parse(id));
            var deleteResult = this.context
                .Notes
                .DeleteOne(filter);
            return deleteResult.IsAcknowledged
                && deleteResult.DeletedCount > 0;
        }
    }
}
