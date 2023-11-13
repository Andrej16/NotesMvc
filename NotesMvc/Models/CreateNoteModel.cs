namespace NotesMvc.Models
{
    public class CreateNoteModel
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public bool IsImportant { get; set; }
    }
}
