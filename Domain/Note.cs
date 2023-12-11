namespace Domain
{
    public class Note : EntityBase
    {
        public string Title { get; private set; } = null!;

        public string Content { get; private set; } = null!;

        public bool IsImportant { get; private set; }

        public static Note Create(int id, string title, string content, bool isImportant)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id must be greater than 0", nameof(id));
            }

            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title cannot be empty", nameof(title));
            }

            if (string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentException("Content cannot be empty", nameof(content));
            }

            return new Note
            {
                Id = id,
                Title = title,
                Content = content,
                Created = DateTime.Now,
                IsImportant = isImportant
            };
        }

        public void Update(string title, string content, bool isImportant)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title cannot be empty", nameof(title));
            }

            if (string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentException("Content cannot be empty", nameof(content));
            }

            Title = title;
            Content = content;
            IsImportant = isImportant;
            Updated = DateTime.Now;
        }

        public virtual string Print()
        {
            return $"This is note Id: {Id}, Title: {Title}, Content: {Content}, IsImportant: {IsImportant}";
        } 
    }
}
