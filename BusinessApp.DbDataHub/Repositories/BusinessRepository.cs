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
    public class BusinessRepository : Repository<Businesses> ,  IBusinessRepository
    {
        private ApplicationDbContext _db;
        public BusinessRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }

        public void Update(Businesses businesses)
        {
            _db.Business.Update(businesses);
        }
    }
}
