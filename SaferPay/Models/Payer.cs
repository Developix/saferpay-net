namespace SaferPay.Models
{
	public class Payer
	{
		/// <summary>
		/// Language to be used if Saferpay displays something to the payer.
		/// </summary>
		public string LanguageCode { get; set; }
		/// <summary>
		/// IPv4 address of the card holder / payer if available. Dotted quad notation.
		/// </summary>
		public string IpAddress { get; set; }
		public string IpLocation { get; set; }
		/// <summary>
		/// Information on the payers delivery address
		/// </summary>
		public PayerAddress DeliveryAddress { get; set; }
		/// <summary>
		/// Information on the payers billing address
		/// </summary>
		public PayerAddress BillingAddress { get; set; }
	}
}