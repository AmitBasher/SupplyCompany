using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SupplyCompany.Domain.Models.Common.Relations;

namespace SupplyCompany.Infrastructure.DAL.Configuration;
public class Order_SupplyRequestConfig : IEntityTypeConfiguration<Order_SupplyRequest> {
    public void Configure(EntityTypeBuilder<Order_SupplyRequest> builder) {
        builder.HasKey(p => new { p.OrderId, p.SupplyRequestId });

        builder.Property(os => os.OrderId)
               .HasConversion(
                   id => id.Value,
                   id => OrderId.CreateFrom(id));

        builder.Property(os => os.SupplyRequestId)
               .HasConversion(
                   id => id.Value,
                   id => SupplyRequestId.CreateFrom(id));

    }
}

    
