using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.DbDataHub.Models
{
	public class Businesses
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int BusinessId { get; set; }

		public string BusinessName { get; set; }

		public string BusinessDescription { get; set; }

		public int BusinessCategoryId { get; set; }

		[ForeignKey("BusinessCategoryId")]
		public virtual BusinessCategory BusinessCategory { get; set; }





	}
}
