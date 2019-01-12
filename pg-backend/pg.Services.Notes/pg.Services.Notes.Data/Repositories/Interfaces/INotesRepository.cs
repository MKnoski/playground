using pg.Services.Notes.Data.Models;
using System.Collections.Generic;

namespace pg.Services.Notes.Data.Repositories.Interfaces
{
    public interface INotesRepository
    {
        List<Note> GetNotes();

        Note GetNote(int id);

        void AddNote(Note note);

        void EditNote(int id, Note note);

        void DeleteNote(int id);
    }
}
