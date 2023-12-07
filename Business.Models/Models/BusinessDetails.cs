using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.DbDataHub.Models
{
	public class BusinessDetails
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int BusinessDetailId { get; set; }

		public long ContactNumber { get; set; }

		public string Owner { get; set; }

		public DateTime PostedOn { get; set; }

		public int BusinessCategoryId { get; set; }

		public int? BusinessId { get; set; }

		[ForeignKey("BusinessCategoryId")]
		public virtual BusinessCategory BusinessCategory { get; set; }

		[ForeignKey("BusinessId")]
		public virtual Businesses Business { get; set; }




	}
}
