using Domain.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class NotesContext : DbContext
    {
        public NotesContext(DbContextOptions<NotesContext> options)
            : base(options)
        {
            
        }

        public DbSet<Note> Notes { get; set; }

        public DbSet<WorkTask> WorkTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WorkTaskEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new NoteEntityTypeConfiguration());
        }
    }
}