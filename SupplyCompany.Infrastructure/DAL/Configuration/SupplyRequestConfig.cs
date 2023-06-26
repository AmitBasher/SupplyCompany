using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace SupplyCompany.Infrastructure.DAL.Configuration
{
    public class SupplyRequestConfig : IEntityTypeConfiguration<SupplyRequest> {
        public void Configure(EntityTypeBuilder<SupplyRequest> builder) {
            builder.ToTable("SupplyRequests");

            builder.HasKey(sr =>  sr.Id );

            builder.Property(sr => sr.Id)
                .HasColumnName("SupplyRequestId")
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => SupplyRequestId.CreateFrom(id));

            builder.Property(sr => sr.SubProductId)
                .HasColumnName("SubProductId")
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => SubProductId.CreateFrom(id));

            builder.Property(sr => sr.ProductId)
                .HasColumnName("ProductId")
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => ProductId.CreateFrom(id));

            builder.Property(sr => sr.SupplierId)
                .HasColumnName("SupplierId")
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => SupplierId.CreateFrom(id));

            builder.Property(sr => sr.CustomerId)
                .HasColumnName("CustomerId")
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => CustomerId.CreateFrom(id));

            builder.Property(sr => sr.Quantity)
                .HasColumnName("Quantity")
                .IsRequired();

            builder.Property(sr => sr.Price)
                .HasColumnName("Price")
                .IsRequired();

            builder.Property(sr => sr.Discount)
                .HasColumnName("Discount")
                .IsRequired();

            builder.Property(sr => sr.CreatedDateTime)
                .HasColumnName("Created")
                .IsRequired();

            builder.Property(sr => sr.LastModifiedDateTime)
                .HasColumnName("LastModified")
                .IsRequired();

        //    builder.Property(sr => sr.OrderId)
        //        .IsRequired(false)
        //        .HasConversion(
        //            id => id.Value,
        //            id => OrderId.CreateFrom(id));

        //    builder.Property(sr => sr.ProductReviewId)
        //        .IsRequired(false)
        //        .HasConversion(
        //            id => id.Value,
        //            id => ProductReviewId.CreateFrom(id));

        //    builder.Property(sr => sr.SupplierReviewId)
        //        .IsRequired(false)
        //        .HasConversion(
        //            id => id.Value,
        //            id => SupplierReviewId.CreateFrom(id));
        }
    }
}
