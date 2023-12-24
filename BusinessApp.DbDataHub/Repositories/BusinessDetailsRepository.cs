using BusinessApp.DbDataHub.ApplicationDBContext;
using BusinessApp.DbDataHub.Models;
using BusinessApp.DbDataHub.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.DbDataHub.Repositories
{
    public class BusinessDetailsRepository : Repository<BusinessDetails>, IBusinessDetailsRepository
    {
        private ApplicationDbContext _db;
        public BusinessDetailsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(BusinessDetails obj)
        {
            _db.BusinessDetails.Update(obj);
        }

    }
}
