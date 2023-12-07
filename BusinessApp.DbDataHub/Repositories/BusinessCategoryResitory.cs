using BusinessApp.DbDataHub.ApplicationDBContext;
using BusinessApp.DbDataHub.Models;
using BusinessApp.DbDataHub.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.DbDataHub.Repositories
{
	public class BusinessCategoryResitory : Repository<BusinessCategory>, IBusinessCategoryRepository
	{
		private ApplicationDbContext _db;

		public BusinessCategoryResitory(ApplicationDbContext db) : base(db) 
		{
			_db= db;
		}

		public void Update(BusinessCategory obj)
		{
			_db.BusinessCategory.Update(obj);
		}

		
	}
}
