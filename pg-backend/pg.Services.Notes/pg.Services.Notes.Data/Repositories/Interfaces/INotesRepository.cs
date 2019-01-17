using pg.Services.Notes.Data.Models;
using System.Collections.Generic;

namespace pg.Services.Notes.Data.Repositories.Interfaces
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
