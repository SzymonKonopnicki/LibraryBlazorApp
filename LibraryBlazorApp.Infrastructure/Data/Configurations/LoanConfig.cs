using LibraryBlazorApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryBlazorApp.Infrastructure.Data.Configurations;

public class LoanConfig : IEntityTypeConfiguration<Loan>
{
    public void Configure(EntityTypeBuilder<Loan> builder)
    {
        builder.ToTable("Loans");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder.HasOne(x => x.LibraryCard)
            .WithMany(x => x.Loans)
            .HasForeignKey(x => x.LibraryCardId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Book)
            .WithOne(x => x.Loan)
            .HasForeignKey<Loan>(x => x.BookId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.BorrowDate)
            .HasColumnType("datetime2")
            .IsRequired();

        builder.Property(x => x.ReturnedDate)
            .HasColumnType("datetime2")
            .IsRequired(false);
    }
}
