using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace SupplyCompany.Infrastructure.DAL.Configuration
{
    public class ProductReviewConfig : IEntityTypeConfiguration<Domain.Models.productReview.ProductReview> {
        public void Configure(EntityTypeBuilder<Domain.Models.productReview.ProductReview> builder) {
            builder.ToTable("ProductReviews");
            builder.HasKey(pr => pr.Id);

            builder.Property(pr => pr.Id)
                .HasColumnName("ProductReviewId")
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => ProductReviewId.CreateFrom(id));

            builder.Property(pr => pr.ProductId)
                .HasColumnName("ProductId")
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => ProductId.CreateFrom(id));

            builder.Property(pr => pr.SubProductId)
                .HasColumnName("SubProductId")
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => SubProductId.CreateFrom(id));

            builder.Property(pr => pr.CustomerId)
                .HasColumnName("CustomerId")
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => CustomerId.CreateFrom(id));

            builder.Property(pr => pr.SupplierId)
                .HasColumnName("SupplierId")
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => SupplierId.CreateFrom(id));

            builder.Property(pr => pr.SupplyRequestId)
                .HasColumnName("SupplyRequestId")
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => SupplyRequestId.CreateFrom(id));

            builder.OwnsOne(pr => pr.Rating, pr => { 
                pr.Property(p => p.Value); 
            });

            builder.Property(pr => pr.Desciption)
                .HasColumnName("Description")
                .IsRequired(false)
                .HasMaxLength(500);

            builder.Property(pr => pr.CreatedDateTime)
                .HasColumnName("Created")
                .IsRequired();

            builder.Property(pr => pr.LastModifiedDateTime)
                .HasColumnName("LastModified")
                .IsRequired();
        }
    }
}
