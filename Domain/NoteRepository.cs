namespace Domain
{
    public class NoteRepository
    {
        private readonly NotesContext _notesContext;

        public NoteRepository(NotesContext notesContext)
        {
            this._notesContext = notesContext;
        }

        public List<Note> GetAll() => _notesContext.Notes.ToList();

        public Note? GetById(int id) => _notesContext.Notes.FirstOrDefault(n => n.Id == id);

        public void Add(Note note)
        {
            _notesContext.Notes.Add(note);

            _notesContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var note = GetById(id);
            if (note != null)
            {
                _notesContext.Notes.Remove(note);
                _notesContext.SaveChanges();
            }
        }
    }
}