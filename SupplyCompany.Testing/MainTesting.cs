using SupplyCompany.Domain.Models.user;
using SupplyCompany.Infrastructure.DAL.Repository;

namespace SupplyCompany.Testing;
[TestClass]
public class MainTesting {
    [TestMethod]
    public void AuthenticationControllerTest() {
        using (var db = new DataContext()) {
            var rep = new UserRepository(db);
            var user = User.Create("amit", "Basher", "Amit@gmail.com", "123456");
            rep.AddUser(user);

            
        }
    }
}