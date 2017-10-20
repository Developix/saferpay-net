using System;
using System.Collections.Generic;
using System.Text;

namespace SaferPay.Models.PaymentPage
{
    public class PaymentPageCard
	{
		/// <summary>
		/// Masked card number
		/// </summary>
		public string MaskedNumber { get; set; }

		/// <summary>
		/// Year of expiration
		/// </summary>
		public int ExpYear { get; set; }

		/// <summary>
		/// Month of expiration (eg 9 for September)
		/// </summary>
		public int ExpMonth { get; set; }

		/// <summary>
		/// Name of the card holder (if known)
		/// </summary>
		public string HolderName { get; set; }

		/// <summary>
		/// ISO 2-letter country code of the card origin (if available)
		/// </summary>
		public string CountryCode { get; set; }

		/// <summary>
		/// The HashValue, if the hash generation is configured for the customer.
		/// </summary>
		public string HashValue { get; set; }
	}
}
