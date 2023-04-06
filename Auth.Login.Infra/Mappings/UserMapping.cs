using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Auth.Login.Domain.Models;

namespace Auth.Login.Infra.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("AL_USERS");

            builder.HasKey(k => k.Id);

            builder.Property(p => p.Password)
                .IsRequired()
                    .HasMaxLength(50);

            builder.Property(p => p.FirstName)
                .IsRequired()
                    .HasMaxLength(50);

            builder.Property(p => p.LastName)
                .IsRequired()
                    .HasMaxLength(50);
        }
    }
}