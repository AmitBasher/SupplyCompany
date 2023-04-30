using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SupplyCompany.Infrastructure.DAL.Configuration {
    public class SupplierConfig : IEntityTypeConfiguration<Supplier> {
        public void Configure(EntityTypeBuilder<Supplier> builder) {
            builder.ToTable("Suppliers");

            builder.Property(si => si.Id)
                .HasColumnName("SupplierId")
                .ValueGeneratedNever()
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => SupplierId.CreateFrom(id));

            builder.Property(u => u.UserId)
                .HasColumnName("UserId")
                .ValueGeneratedNever()
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => UserId.CreateFrom(id));
            
            builder.OwnsOne(ar => ar.Rating, rate => {
                rate.ToTable("SupplierRatings");

                rate.WithOwner();

                rate.Property<SupplierId>("SupplierId");

                rate.Property(p => p.Value)
                    .HasColumnName("Ratings_Value")
                    .IsRequired();

                rate.Property(p => p.NumRatings)
                    .HasColumnName("Ratings_Number")
                    .IsRequired();
            });
            
            builder.HasMany(p => p.Products)
                .WithOne()
                .HasForeignKey(p => p.SupplierId);

            builder.HasMany(p => p.Reviews)
                .WithOne()
                .HasForeignKey(p => p.SupplierId);

            builder.HasMany(p => p.OrdersHistory)
                .WithOne()
                .HasForeignKey(p => p.SupplierId);

            builder.HasMany(p => p.ProductReviews)
                .WithOne()
                .HasForeignKey(p => p.SupplierId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(p => p.PendingRequests)
                .WithOne()
                .HasForeignKey(p => p.SupplierId);
        }
    }
}
