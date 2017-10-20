using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaferPay.Models.PaymentPage
{
    public class PaymentPageInitializeResponse : ResponseBase
    {
		/// <summary>
		/// Token for later referencing
		/// </summary>
		public string Token { get; set; }

		/// <summary>
		/// Expiration date / time of the generated token in ISO 8601 format in UTC. 
		/// After this time, the token won’t be accepted for any further action.
		/// </summary>
		public DateTime Expiration { get; set; }

		/// <summary>
		/// Redirecturl for the payment page transaction. 
		/// Simply add this to a "Pay Now"-button or do an automatic redirect.
		/// </summary>
		public string RedirectUrl { get; set; }
    }
}
