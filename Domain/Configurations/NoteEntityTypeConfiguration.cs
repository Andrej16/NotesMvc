using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configurations
{
    public class NoteEntityTypeConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("Notes");

            builder.HasData(
                Note.Create(1, "First Note", "Content of the first note", true),
                Note.Create(2, "Second Note", "Content of the second note", false),
                Note.Create(3, "Third Note", "Content of the third note", true),
                Note.Create(4, "Fourth Note", "Content of the fourth note", false),
                Note.Create(5, "Fifth Note", "Content of the fifth note", true),
                Note.Create(6, "Sixth Note", "Content of the sixth note", false)
                                                                                                                     );
        }
    }
}