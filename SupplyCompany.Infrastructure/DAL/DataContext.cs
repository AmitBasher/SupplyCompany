using SupplyCompany.Infrastructure.DAL.Configuration;
using System.Reflection;

namespace SupplyCompany.Infrastructure.DAL;

public sealed class DataContext : DbContext {
    public DataContext() { }//(DbContextOptions<DataContext> op) : base(op) { }//() { }//
    public DbSet<User> Users { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Domain.Models.supplierReview.SupplierReview> SupplierReviews { get; set; }
    public DbSet<Domain.Models.product.Product> Products { get; set; }
    public DbSet<SubProduct> SubProducts { get; set; }
    public DbSet<Domain.Models.productReview.ProductReview> ProductReviews { get; set; }
    public DbSet<Domain.Models.supplyRequest.SupplyRequest> SupplyRequests { get; set; }
    public DbSet<Domain.Models.order.Order> Orders { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder ob)
        => ob.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SupplyCompany;TrustServerCertificate=true;Trusted_Connection=True;");
    protected override void OnModelCreating(ModelBuilder builder) {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}