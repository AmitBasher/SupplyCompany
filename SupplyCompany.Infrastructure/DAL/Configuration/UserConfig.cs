using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SupplyCompany.Infrastructure.DAL.Configuration {
    public class UserConfig : IEntityTypeConfiguration<User> {
        public void Configure(EntityTypeBuilder<User> builder) {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("UserId")
                .ValueGeneratedNever()
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => UserId.CreateFrom(id));

            builder.Property(x => x.FirstName)
                .HasColumnName("FirstName")
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(x => x.LastName)
                .HasColumnName("LastName")
                .IsRequired()
                .HasMaxLength(30);

            builder.HasIndex(x => x.Email)
                .IsUnique()
                .HasDatabaseName("Email")
                .HasFilter(null);

            builder.Property(x => x.Password)
                .HasColumnName("Password")
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(x => x.CreatedDateTime)
                .HasColumnName("Created")
                .IsRequired();

            builder.Property(x => x.LastModifiedDateTime)
                .HasColumnName("LastModified")
                .IsRequired();
        }
    }
}
