using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Infrastructure.Data.Configurations.DataSeed;
using LibraryBlazorApp.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryBlazorApp.Infrastructure.Data;

public class BlazorLibraryDbContext : IdentityDbContext<ApplicationUser>
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

        string[] guidTab =
        {
            "c7277975-d866-4d1c-84b0-8d9df1ac7058",
            "b5d8b1df-a9cf-4b2a-82ed-2e8538e1bda7",
            "73af2f35-a9b2-40fa-9697-c1dee8166b26",
            "ff49eb66-aefe-412d-8e5f-897f121f7f5d",
            "c1e499f0-e54f-4dad-a579-d865ed8075ef",
            "241b6d78-2354-46b3-8ab8-63c68bbdf631",
            "3a21d428-508c-4a7a-b686-2724879c764a",
            "39a1cce9-9123-4861-bf17-2909a7a1dff6",
            "be32eec5-8f03-4eaa-99d6-b2eebeebfce8",
            "03e12965-b521-4052-894b-e5a7ef44b9d1"
        };


        modelBuilder.SeedAppUser(guidTab);
        modelBuilder.SeedClients(guidTab);
        modelBuilder.SeedRoles();
        modelBuilder.SeedAssignRoles();

        modelBuilder.SeedBooks();
        modelBuilder.SeedAuthors();
        modelBuilder.SeedAddresses();
        modelBuilder.SeedLibraryCards();
        modelBuilder.SeedLoans();

        base.OnModelCreating(modelBuilder);
    }
}
