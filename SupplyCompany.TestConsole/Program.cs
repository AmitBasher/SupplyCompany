using SupplyCompany.Infrastructure.DAL;

namespace SupplyCompany.TestConsole {
    internal class Program {
        static void Main(string[] args) {
            using (var db = new DataContext()) {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
            }
        }
    }
}