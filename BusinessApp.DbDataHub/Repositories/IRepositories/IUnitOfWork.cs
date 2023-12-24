using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.DbDataHub.Repositories.IRepositories
{
	public interface IUnitOfWork
	{
		IBusinessCategoryRepository BusinessCategory { get; }

        IBusinessDetailsRepository BusinessDetails { get; }

		IBusinessRepository Business { get; }

        void Save();
	}
}
