namespace Domain
{
    public abstract class EntityBase
    {
        public int Id { get; protected set; }

        public DateTime Created { get; protected set; }

        public DateTime Updated { get; protected set; }
    }
}
