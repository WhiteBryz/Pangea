using System.ComponentModel.DataAnnotations;

namespace Pangea.Model
{
	public class UserAdmin
	{
        public int Id{ get; set; }
        [Required(ErrorMessage = "El nombre es requerido.")]
        [Length(2,50,ErrorMessage = "El nombre no puede ser mayor a 50 caracteres.")]
        public string AdminName { get; set; }
        [Required(ErrorMessage = "La posición es requerida.")]
        [StringLength(20,ErrorMessage = "La posición no puede ser mayor a 20 caracteres.")]
        public string Position { get; set; }
        [Required(ErrorMessage = "Favor de seleccionar el estatus")]
        public Boolean IsActive { get; set; }
    }
}
