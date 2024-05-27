using System.ComponentModel.DataAnnotations;

namespace Pangea.Model
{
	public class Income
	{
        public int Id { get; set; }
		public DateTime RegisterDate { get; set; }
		public DateTime PaidDate { get; set; }
		[Required(ErrorMessage = "Se necesita colocar el mes en que aplica el pago")]
		public int? ApplicableMonth { get; set; }
		[Required(ErrorMessage = "Se necesita colocar el año en que aplica el pago")]
		public int ApplicableYear { get; set; }
        public string OrderNum{ get; set; }
		[Required(ErrorMessage = "Se necesita colocar el método de pago")]
		public string PaidMethod { get; set; }
		[Required(ErrorMessage = "Se necesita colocar una cantidad")]
		[Range(0, double.MaxValue, ErrorMessage = "Colocar una cantidad válida")]
		public double Amount { get; set; }
		public string? PaidStatus { get; set; }
        public string? Comments{ get; set; }

        ////// Propiedades de navegación del EF ///////

        // UserAdmin
        public int UserAdminId { get; set; }
		virtual public UserAdmin? UserAdmin { get; set; }

		// Owners
		public int OwnerId { get; set; }
		virtual public Owner? Owner { get; set; }

		// IncomeConcept
		public int IncomeConceptId { get; set; }
		virtual public IncomeConcept? IncomeConcept { get; set; }

    }
}
