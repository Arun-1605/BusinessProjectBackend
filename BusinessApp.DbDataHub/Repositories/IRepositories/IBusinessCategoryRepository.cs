using BusinessApp.DbDataHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.DbDataHub.Repositories.IRepositories
{
	public interface IBusinessCategoryRepository : IRepository<BusinessCategory>
	{
		void Update(BusinessCategory obj);
	}
}
