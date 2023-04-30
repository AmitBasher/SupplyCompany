using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SupplyCompany.Infrastructure.DAL.Configuration {
    public class CustomerConfig : IEntityTypeConfiguration<Customer> {
        public void Configure(EntityTypeBuilder<Customer> builder) {
            builder.ToTable("Customers");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("CustomerId")
                .ValueGeneratedNever()
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => CustomerId.CreateFrom(id));

            builder.Property(x => x.UserId)
                .HasColumnName("UserId")
                .ValueGeneratedNever()
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => UserId.CreateFrom(id));

            builder.OwnsOne(p => p.ShippingAddress);
            /*
             * , loca => {
                //loca.ToTable("Customers");
                loca.ToTable("CustomerLocation");

                loca.WithOwner();
                loca.Property<CustomerId>("CustomerId");

                loca.Property(p => p.State)
                    .HasColumnName("Shipping_State")
                    .HasMaxLength(40)
                    .IsRequired();
                loca.Property(p => p.City)
                    .HasColumnName("Shipping_City")
                    .HasMaxLength(40)
                    .IsRequired();
                loca.Property(p => p.Address)
                    .HasColumnName("Shipping_Address")
                    .HasMaxLength(100)
                    .IsRequired();
            }*/
            builder.HasMany(c => c.OrderHistory)
                .WithOne()
                .HasForeignKey(o=>o.CustomerId);
            builder.HasMany(c => c.ProductReviews)
                .WithOne()
                .HasForeignKey(o => o.CustomerId);
            builder.HasMany(c => c.SupplierReviews)
                .WithOne()
                .HasForeignKey(o => o.CustomerId);
            builder.HasMany(c => c.CurrentRequests)
                .WithOne()
                .HasForeignKey(o => o.CustomerId);
        }
    }
}
