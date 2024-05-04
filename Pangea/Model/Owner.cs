using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Pangea.Model
{
	public class Owner
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "El número de casa es obligatorio.")]
		[StringLength(2, ErrorMessage = "El número debe estar entre 1 y 25.")]
		public string? HouseNumber { get; set; }
		[Required(ErrorMessage = "El número de casa es obligatorio.")]
		[StringLength(50, ErrorMessage = "El nombre no puede más grande de 50 caracteres")]
		public string? OwnerName { get; set; }
		[Required(ErrorMessage = "Seleccionar tipo de propietario")]
		public string? OwnerType { get; set; }
		[StringLength(10, ErrorMessage = "Máximo 10 caracteres.")]
		public string? CellphoneNumber { get; set; }
		[StringLength(10, ErrorMessage = "Máximo 10 caracteres.")]
		public string? OtherPhoneNumber { get; set; }
		[DefaultValue(true)]
		public Boolean IsActive { get; set; }
	}
}
