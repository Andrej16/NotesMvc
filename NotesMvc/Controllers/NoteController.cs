using Domain;
using Microsoft.AspNetCore.Mvc;
using NotesMvc.Models;
using System.Diagnostics;

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
            return View();
        }
    }
}