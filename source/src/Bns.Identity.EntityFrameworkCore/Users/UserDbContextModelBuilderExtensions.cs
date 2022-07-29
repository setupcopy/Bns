using Bns.Identity.Domain.Shared.Users;
using Bns.Identity.Domain.Users;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Bns.Identity.EntityFrameworkCore.Users
{
    public static class UserDbContextModelBuilderExtensions
    {
        public static void ConfigureUser([NotNull] this ModelBuilder builder)
        {
            Check.NotNull(builder,nameof(builder));
            
            builder.Entity<User>(b =>
            {
                b.ToTable("Users");

                b.ConfigureByConvention();

                b.Property(u => u.UserName).IsRequired()
                    .HasMaxLength(UserConsts.MaxUserNameLength)
                    .HasColumnName(nameof(User.UserName));
                b.Property(u => u.Name).IsRequired()
                    .HasMaxLength(UserConsts.MaxNameLength)
                    .HasColumnName(nameof(User.Name));
            });
        }
    }
}
