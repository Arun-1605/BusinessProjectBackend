using BusinessApp.DbDataHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.DbDataHub.Repositories.IRepositories
{
    public interface IBusinessRepository : IRepository<Businesses>
    {
        void Update(Businesses obj);
    }
}
