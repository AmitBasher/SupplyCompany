using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SupplyCompany.Infrastructure.DAL.Configuration {
    public class OrderConfig : IEntityTypeConfiguration<Order> {
        public void Configure(EntityTypeBuilder<Order> builder) {
            builder.ToTable("Orders");

            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id)
                .HasColumnName("OrderId")
                .IsRequired()
                .HasConversion(
                    id=>id.Value,
                    id=> OrderId.CreateFrom(id));

            builder.Property(o => o.CustomerId)
                .HasColumnName("CustomerId")
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => CustomerId.CreateFrom(id));
            
            builder.Property(o => o.SupplierId)
                .HasColumnName("SupplierId")
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => SupplierId.CreateFrom(id));

            builder.OwnsOne(o => o.OrderPriceValue, f => {
                f.Property(p => p.Sum);
            });

            builder.OwnsOne(o => o.ShippingTo);

            builder.Property(o => o.CreatedDateTime);
            //builder.HasMany(o => o.SupplyRequests).WithOne().HasForeignKey(sr => sr.OrderId);
        }
    }
}
