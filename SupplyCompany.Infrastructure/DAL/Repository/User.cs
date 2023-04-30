using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyCompany.Infrastructure.DAL.Repository {
    public class UserRepository {
        private readonly DataContext _db;
        public UserRepository(DataContext db) {
            _db = db;
        }

    }
}
