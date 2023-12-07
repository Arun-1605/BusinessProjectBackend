using BusinessApp.DbDataHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Models
{
	public class ImageHub
	{
		[Key]
		public int Id { get; set; }

		public byte[]? Image { get; set; }

		public int BusinessdetailId { get; set; }


		[ForeignKey("BusinessdetailId")]
		public BusinessDetails BusinessDetails { get; set; }
	}
}
