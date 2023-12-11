namespace Domain;

public class WorkTask : Note
{
    public DateTime Deadline { get; private set; }

    public static WorkTask Create(int id, string title, string content, bool isImportant, DateTime deadline)
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

        WorkTask task = (WorkTask)Note.Create(id, title, content, isImportant);
        task.Deadline = deadline;

        return task;
    }

    public override string Print()
    {
        return $"This is task Id: {Id}, Title: {Title}, Content: {Content}, IsImportant: {IsImportant}, Deadline: {Deadline}";
    }
}
