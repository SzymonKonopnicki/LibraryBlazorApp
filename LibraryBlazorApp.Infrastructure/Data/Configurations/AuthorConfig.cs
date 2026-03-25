using LibraryBlazorApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryBlazorApp.Infrastructure.Data.Configurations;

public class AuthorConfig : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable("Authors");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder.Property(x => x.CreatedAt)
            .HasColumnType("datetime2")
            .IsRequired();

        builder.Property(x => x.CreatedAt)
            .IsRequired();

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Surname)
            .HasMaxLength(100);

        builder.Property(x => x.Bio)
            .HasMaxLength(250);

        builder.Property(x => x.BirthDate)
            .HasColumnType("datetime2")
            .IsRequired(false);

        builder.Property(x => x.DeathDate)
            .HasColumnType("datetime2")
            .IsRequired(false);

        builder.Property(x => x.Nationality)
            .HasMaxLength(100);
    }
}
