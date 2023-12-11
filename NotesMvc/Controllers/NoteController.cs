using Domain;
using Microsoft.AspNetCore.Mvc;
using NotesMvc.Models;

namespace NotesMvc.Controllers
{
    public class NoteController : Controller
    {
        private readonly NoteRepository _noteRepository;

        public NoteController(NoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public IActionResult Index()
        {
            return View(_noteRepository.GetAll());
        }

        public IActionResult Add()
        {
            return View(new CreateNoteModel());
        }

        [HttpPost]
        public IActionResult Add(CreateNoteModel model)
        {
            _noteRepository.Add(
                Note.Create(
                    _noteRepository.GetAll().Count + 1,
                    model.Title,
                    model.Content,
                    model.IsImportant));

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            _noteRepository.Delete(id);

            return RedirectToAction(nameof(Index));
        }
    }
}