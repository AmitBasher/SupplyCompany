using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SupplyCompany.Infrastructure.DAL.Configuration {
    public class ProductConfig : IEntityTypeConfiguration<Product> {
        public void Configure(EntityTypeBuilder<Product> builder) {
            builder.ToTable("Products");

            builder.HasKey(prod => prod.Id);

            builder.Property(p => p.Id)
                .HasColumnName("ProductId")
                .IsRequired()
                .ValueGeneratedNever()
                .HasConversion(
                    id => id.Value,
                    id => ProductId.CreateFrom(id));

            builder.Property(p => p.SupplierId)
                .HasColumnName("SupplierId")
                .IsRequired()
                .ValueGeneratedNever()
                .HasConversion(
                    id => id.Value,
                    id => SupplierId.CreateFrom(id));

            builder.Property(p => p.Name)
                .HasColumnName("Name")
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(p => p.Description)
                .HasColumnName("Description")
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(p => p.CreatedDateTime)
                .HasColumnName("Created")
                .IsRequired();

            builder.Property(p => p.LastModifiedDateTime)
                .HasColumnName("LastModified")
                .IsRequired();

            builder.Ignore(p => p.ratings);

            builder.HasMany(o => o.SubProducts)
                .WithOne()
                .HasForeignKey(p => p.ProductId);

            builder.HasMany(o => o.ProductReviews)
                .WithOne()
                .HasForeignKey(p => p.ProductId);
        }
    }
}
