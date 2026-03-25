using LibraryBlazorApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryBlazorApp.Infrastructure.Data.Configurations;

public class LibraryCardConfig : IEntityTypeConfiguration<LibraryCard>
{
    public void Configure(EntityTypeBuilder<LibraryCard> builder)
    {
        builder.ToTable("LibraryCards");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder.Property(x => x.CreatedAt)
            .HasColumnType("datetime2")
            .IsRequired();

        builder.Property(x => x.CreatedAt)
            .IsRequired();

        builder.HasOne(x => x.Client)
            .WithOne(x => x.LibraryCard)
            .HasForeignKey<LibraryCard>(l => l.ClientId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
