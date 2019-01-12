using pg.Services.Notes.Data.Models;
using pg.Services.Notes.Data.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace pg.Services.Notes.Data.Repositories
{
    public class NotesRepository : INotesRepository
    {
        private List<Note> notes;

        public NotesRepository()
        {
            this.notes = new List<Note>
            {
                new Note
                {
                    ID = 1,
                    Title = "Title1",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse ultrices vel odio ac porttitor. Sed vel posuere enim, ac elementum lectus. Nam eget tincidunt nisl. Proin ut arcu auctor, ornare mauris id, malesuada diam. Quisque bibendum suscipit ullamcorper. Vestibulum eget varius tortor, lacinia suscipit erat. Mauris luctus lacus odio, non euismod lectus cursus id. Etiam molestie diam mi, id gravida lectus auctor in. Praesent venenatis blandit maximus. Pellentesque commodo augue quis erat efficitur elementum. Sed vitae convallis tellus. Aenean eu orci sed ante molestie dapibus ut vel lacus. Morbi massa orci, commodo in tellus eget, efficitur vehicula est. Phasellus varius condimentum nisi, nec luctus tortor cursus id. Sed bibendum dui sit amet nisi interdum pretium. Sed in odio mauris."
                },
                new Note
                {
                    ID = 2,
                    Title = "Title2",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse ultrices vel odio ac porttitor. Sed vel posuere enim, ac elementum lectus. Nam eget tincidunt nisl. Proin ut arcu auctor, ornare mauris id, malesuada diam. Quisque bibendum suscipit ullamcorper. Vestibulum eget varius tortor, lacinia suscipit erat. Mauris luctus lacus odio, non euismod lectus cursus id. Etiam molestie diam mi, id gravida lectus auctor in. Praesent venenatis blandit maximus. Pellentesque commodo augue quis erat efficitur elementum. Sed vitae convallis tellus. Aenean eu orci sed ante molestie dapibus ut vel lacus. Morbi massa orci, commodo in tellus eget, efficitur vehicula est. Phasellus varius condimentum nisi, nec luctus tortor cursus id. Sed bibendum dui sit amet nisi interdum pretium. Sed in odio mauris."
                },
                new Note
                {
                    ID = 3,
                    Title = "Title3",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse ultrices vel odio ac porttitor. Sed vel posuere enim, ac elementum lectus. Nam eget tincidunt nisl. Proin ut arcu auctor, ornare mauris id, malesuada diam. Quisque bibendum suscipit ullamcorper. Vestibulum eget varius tortor, lacinia suscipit erat. Mauris luctus lacus odio, non euismod lectus cursus id. Etiam molestie diam mi, id gravida lectus auctor in. Praesent venenatis blandit maximus. Pellentesque commodo augue quis erat efficitur elementum. Sed vitae convallis tellus. Aenean eu orci sed ante molestie dapibus ut vel lacus. Morbi massa orci, commodo in tellus eget, efficitur vehicula est. Phasellus varius condimentum nisi, nec luctus tortor cursus id. Sed bibendum dui sit amet nisi interdum pretium. Sed in odio mauris."
                }
            };
        }

        public List<Note> GetNotes()
        {
            return this.notes;
        }

        public Note GetNote(int id)
        {
            return this.notes.SingleOrDefault(n => n.ID == id);
        }

        public void AddNote(Note note)
        {
            this.notes.Add(note);
        }

        public void EditNote(int id, Note note)
        {
            var noteToEdit = this.notes.SingleOrDefault(n => n.ID == id);

            if (noteToEdit != null)
            {
                noteToEdit = note;
            }
        }

        public void DeleteNote(int id)
        {
            var noteToDelete = notes.SingleOrDefault(n => n.ID == id);

            if (noteToDelete != null)
            {
                this.notes.Remove(noteToDelete);
            }
        }
    }
}
