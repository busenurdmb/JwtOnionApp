using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
using Microsoft.EntityFrameworkCore.Metadata;
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
using Microsoft.EntityFrameworkCore.Metadata;
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
using Microsoft.EntityFrameworkCore.Metadata;
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UdemyJwtApp.Back.Core.Domain;

namespace UdemyJwtApp.Back.Persistance.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasOne(X => X.AppRole).WithMany(X => X.AppUsers).HasForeignKey(X => X.AppRoleId);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

=======
            
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
            
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
            
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        }
    }
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(X => X.Category).WithMany(X => X.Products).HasForeignKey(X => X.CategoryId);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

=======
           
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
           
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
           
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        }
    }
}
