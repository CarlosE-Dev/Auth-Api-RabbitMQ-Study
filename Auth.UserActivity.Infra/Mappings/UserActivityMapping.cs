using Auth.UserActivity.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Auth.UserActivity.Infra.Mappings
{
    public class UserActivityMapping : IEntityTypeConfiguration<UserActivityModel>
    {
        public void Configure(EntityTypeBuilder<UserActivityModel> builder)
        {
            builder.ToTable("AUA_USER_ACTIVITIES");

            builder.HasKey(k => k.UserId);

            builder.Property(p => p.UserEmail)
                .IsRequired()
                    .HasMaxLength(100);

            builder.Property(p => p.UserCompleteName)
                .IsRequired()
                    .HasMaxLength(200);
        }
    }
}
