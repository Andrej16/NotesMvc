namespace Domain
{
    public class NoteRepository
    {
        private static readonly List<Note> _notes = new List<Note>
        {
            new Note() { Id = 1, Title = "First Note", Content = "Content of the first note", Created = DateTime.Now, IsImportant = true },
            new Note() { Id = 2, Title = "Second Note", Content = "Content of the second note", Created = DateTime.Now, IsImportant = false },
            new Note() { Id = 3, Title = "Third Note", Content = "Content of the third note", Created = DateTime.Now, IsImportant = true },
            new Note() { Id = 4, Title = "Fourth Note", Content = "Content of the fourth note", Created = DateTime.Now, IsImportant = false },
            new Note() { Id = 5, Title = "Fifth Note", Content = "Content of the fifth note", Created = DateTime.Now, IsImportant = true },
            new Note() { Id = 6, Title = "Sixth Note", Content = "Content of the sixth note", Created = DateTime.Now, IsImportant = false }
        };

        public List<Note> GetAll() => _notes;

        public Note? GetById(int id) => _notes.FirstOrDefault(n => n.Id == id);

        public void Add(Note note)
        {
            note.Id = _notes.Max(n => n.Id) + 1;
            _notes.Add(note);
        }

        public void Delete(int id)
        {
            var note = GetById(id);
            if (note != null)
            {
                _notes.Remove(note);
            }
        }
    }
}