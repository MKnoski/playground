using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pg.Services.Notes.Data.Models;
using pg.Services.Notes.Data.Repositories.Interfaces;

namespace pg.Services.Notes.Controllers
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
        public Note Get(int id)
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
        public void Put(int id, [FromBody]Note note)
        {
            this.notesRepository.EditNote(id, note);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.notesRepository.DeleteNote(id);
        }
    }
}
