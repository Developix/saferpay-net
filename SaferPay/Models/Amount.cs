namespace SaferPay.Models
{
	public class Amount
	{
		/// <summary>
		/// Amount in minor unit (CHF 1.00 -> Value=100)
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// ISO 4217 3-letter currency code (CHF, USD, EUR, ...)
		/// </summary>
		public string CurrencyCode { get; set; }
	}
}