using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SupplyCompany.Infrastructure.DAL.Configuration {
    public class SupplierReviewConfig : IEntityTypeConfiguration<SupplierReview> {
        public void Configure(EntityTypeBuilder<SupplierReview> builder) {
            builder.ToTable("SupplierReviews");
            builder.HasKey(pr => pr.Id);

            builder.Property(sr => sr.Id)
                .HasColumnName("SupplierReviewId")
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => SupplierReviewId.CreateFrom(id));

            builder.Property(sr => sr.CustomerId)
                .HasColumnName("CustomerId")
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => CustomerId.CreateFrom(id));

            builder.Property(sr => sr.SupplierId)
                .HasColumnName("SupplierId")
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => SupplierId.CreateFrom(id));

            builder.Property(sr => sr.SupplyRequestId)
                .HasColumnName("SupplyRequestId")
                .IsRequired()
                .HasConversion(
                    id => id.Value,
                    id => SupplyRequestId.CreateFrom(id));

            builder.Property(sr => sr.Description)
                .HasColumnName("Description")
                .IsRequired(false)
                .HasMaxLength(500);

            builder.OwnsOne(sr => sr.Rating, pr => { pr.Property(p => p.Value); });

            builder.Property(sr => sr.CreatedDateTime)
                .HasColumnName("Created")
                .IsRequired();

            builder.Property(sr => sr.LastModifiedDateTime)
                .HasColumnName("LastModified")
                .IsRequired();
        }
    }
}
