using System.ComponentModel.DataAnnotations;

namespace Pangea.Model
{
	public class IncomeConcept
	{
        public int Id { get; set; }
		[Required(ErrorMessage = "Favor de agregar un concepto")]
		[Length(4,50,ErrorMessage = "La longitud debe ser entre 4 y 50 caracteres.")]
		public string Concept { get; set; }
    }
}
