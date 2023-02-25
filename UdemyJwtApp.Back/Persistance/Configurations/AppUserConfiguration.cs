using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UdemyJwtApp.Back.Core.Domain;

namespace UdemyJwtApp.Back.Persistance.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasOne(X => X.AppRole).WithMany(X => X.AppUsers).HasForeignKey(X => X.AppRoleId);

        }
    }
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(X => X.Category).WithMany(X => X.Products).HasForeignKey(X => X.CategoryId);

        }
    }
}