using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Infrastructure.Data.Configurations.DataSeed;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Data;

public class BlazorLibraryDbContext : DbContext
{
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<LibraryCard> LibraryCards { get; set; }
    public DbSet<Loan> Loans { get; set; }

    public BlazorLibraryDbContext(DbContextOptions<BlazorLibraryDbContext> options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlazorLibraryDbContext).Assembly);

        modelBuilder.SeedBooks();
        modelBuilder.SeedAuthors();
        modelBuilder.SeedClients();
        modelBuilder.SeedAddresses();
        modelBuilder.SeedLibraryCards();
        modelBuilder.SeedLoans();

        base.OnModelCreating(modelBuilder);
    }
}
