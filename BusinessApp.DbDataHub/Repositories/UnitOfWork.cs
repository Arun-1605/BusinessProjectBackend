using BusinessApp.DbDataHub.ApplicationDBContext;
using BusinessApp.DbDataHub.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.DbDataHub.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
		private ApplicationDbContext _db;


		public UnitOfWork(ApplicationDbContext db )
		{
			_db= db;
			BusinessCategory = new BusinessCategoryResitory(_db);
			BusinessDetails = new BusinessDetailsRepository(_db);
			Business = new BusinessRepository(_db);

		}

		public IBusinessCategoryRepository BusinessCategory { get; private set; }

		public IBusinessDetailsRepository BusinessDetails { get; private set; }	

		public IBusinessRepository Business { get; private set; }


		public void Save()
		{
			_db.SaveChanges();
		}
	}
}
