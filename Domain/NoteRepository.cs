namespace Domain
{
    public class NoteRepository
    {
        private static readonly List<Note> _notes = new List<Note>
        {
            Note.Create(1, "First Note", "Content of the first note", true),
            Note.Create(2, "Second Note", "Content of the second note", false),
            Note.Create(3, "Third Note", "Content of the third note", true),
            Note.Create(4, "Fourth Note", "Content of the fourth note", false),
            Note.Create(5, "Fifth Note", "Content of the fifth note", true),
            Note.Create(6, "Sixth Note", "Content of the sixth note", false)
        };

        public List<Note> GetAll() => _notes;

        public Note? GetById(int id) => _notes.FirstOrDefault(n => n.Id == id);

        public void Add(Note note)
        {
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