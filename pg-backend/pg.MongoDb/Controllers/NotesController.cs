using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using pg.MongoDb.Data.Models;
using pg.MongoDb.Data.Repositories.Interfaces;

namespace pg.MongoDb.Controllers
{
    [Route("api/[controller]")]
    public class NotesController : Controller
    {
        private readonly INotesRepository notesRepository;

        public NotesController(INotesRepository notesRepository)
        {
            this.notesRepository = notesRepository;
        }

        [HttpGet]
        public IEnumerable<Note> Get()
        {
            var notes = this.notesRepository.GetNotes();
            return notes;
        }

        [HttpGet("{id}")]
        public Note Get(string id)
        {
            var note = this.notesRepository.GetNote(id);
            return note;
        }

        [HttpPost]
        public void Post([FromBody]Note note)
        {
            this.notesRepository.AddNote(note);
        }

        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Note note)
        {
            this.notesRepository.EditNote(id, note);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            this.notesRepository.DeleteNote(id);
        }
    }
}
