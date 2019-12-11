using System.Collections.Generic;
using pg.MongoDb.Data.Models;

namespace pg.MongoDb.Data.Repositories.Interfaces
{
    public interface INotesRepository
    {
        List<Note> GetNotes();

        Note GetNote(string id);

        void AddNote(Note note);

        bool EditNote(string id, Note note);

        bool DeleteNote(string id);
    }
}
