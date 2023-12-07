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
	public class BusinessUser
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		public string Username { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public long Contact { get; set; }

		[Required]
		public string Email { get; set; }

		[Required]
		public string AddressLine1 { get; set; }

		[Required]
		public long PinCode { get; set; }

		[Required]
		public byte[] Image { get; set; }

		[Required]
		public byte[] AddressProof { get; set; }


		public string? BusinessRegistrationDetails { get; set; }

		[Required]
		public int BusinessCategoryId { get; set; }

		[ForeignKey("BusinessCategoryId")]
		public BusinessCategory BusinessCategory { get; set; }


	}
}
