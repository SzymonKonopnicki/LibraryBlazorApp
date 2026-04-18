using LibraryBlazorApp.Domain.Models;
using LibraryBlazorApp.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryBlazorApp.Infrastructure.Data.Configurations;

public class ApplicationUserConfig : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder
            .HasOne(x => x.Client)
            .WithOne()
            .HasForeignKey<Client>(x => x.IdentityUserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
