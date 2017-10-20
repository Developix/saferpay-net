using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaferPay.Models.PaymentPage
{
    public class PaymentPageAssertResponse : ResponseBase
    {
		/// <summary>
		/// Information about the transaction
		/// </summary>
		public Transaction Transaction { get; set; }
		/// <summary>
		/// Information about the means of payment
		/// </summary>
		public AuthorizationPaymentMeans PaymentMeans { get; set; }
		/// <summary>
		/// Information about the payer / card holder
		/// </summary>
		public Payer Payer { get; set; }
		/// <summary>
		/// Information about the SCD registration outcome
		/// </summary>
		public RegistrationResult RegistrationResult { get; set; }
		/// <summary>
		/// 3d-secure information if applicable
		/// </summary>
		public ThreeDs ThreeDs { get; set; }
		/// <summary>
		/// Dcc information, if applicable
		/// </summary>
		public Dcc Dcc { get; set; }
    }
}
