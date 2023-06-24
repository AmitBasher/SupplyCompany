using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SupplyCompany.Infrastructure.DAL.Configuration
{
    public class SubProductConfig : IEntityTypeConfiguration<SubProduct> {
        public void Configure(EntityTypeBuilder<SubProduct> builder) {

            builder.ToTable("SubProducts");

            builder.HasKey(sp => sp.Id);

            builder.Property(sp => sp.SupplierId)
                .HasColumnName("SupplierId")
                .IsRequired()
                .ValueGeneratedNever()
                .HasConversion(
                    id => id.Value,
                    id => SupplierId.CreateFrom(id));

            builder.Property(sp => sp.ProductId)
                .HasColumnName("ProductId")
                .IsRequired()
                .ValueGeneratedNever()
                .HasConversion(
                    id => id.Value,
                    id => ProductId.CreateFrom(id));

            builder.Property(sp => sp.Id)
                .HasColumnName("SubProductId")
                .IsRequired()
                .ValueGeneratedNever()
                .HasConversion(
                    id => id.Value,
                    id => SubProductId.CreateFrom(id));

            builder.Property(sp => sp.SubTitle)
                .HasColumnName("SubTitle")
                .IsRequired()
                .HasMaxLength(40);

            builder.Property(sp => sp.Price)
                .HasColumnName("Price")
                .IsRequired();

            builder.Property(sp => sp.SupplyAvailability)
                .HasColumnName("SupplyAvailability")
                .IsRequired();

            builder.Property(sp => sp.Discount)
                .HasColumnName("Discount")
                .HasMaxLength(3);

            builder.OwnsOne(sp => sp.Rating, rate => {


                rate.Property(p => p.Value)
                    .HasColumnName("Ratings_Value")
                    .IsRequired();

                rate.Property(p => p.NumRatings)
                    .HasColumnName("Ratings_Number")
                    .IsRequired();
            });

            builder.OwnsMany(sp => sp.Attributes, attributes => {

                attributes.ToTable("SubProductAttributes");

                attributes.WithOwner().HasPrincipalKey(a => a.Id);
                attributes.WithOwner().HasPrincipalKey(a => a.ProductId);
                attributes.WithOwner().HasPrincipalKey(a => a.SupplierId);

                //attributes.HasKey(p=>p.)

                attributes.Property(p => p.Title)
                    .HasColumnName("SubName")
                    .IsRequired()
                    .HasMaxLength(30);

                attributes.Property(p => p.Value)
                    .HasColumnName("SubValue")
                    .IsRequired()
                    .HasMaxLength(200);
            });
        }
    }
}
