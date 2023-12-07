using Business.Models.Models;
using BusinessApp.DbDataHub.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.DbDataHub.ApplicationDBContext
{
	public class ApplicationDbContext : DbContext
	{

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Businesses> Business { get; set; }

		public DbSet<BusinessDetails> BusinessDetails { get; set; }

		public DbSet<BusinessCategory> BusinessCategory { get; set; }

		public DbSet<ImageHub> ImageHub { get; set; }

		public DbSet<BusinessUser> BusinessUser { get; set; }	

	}


}
