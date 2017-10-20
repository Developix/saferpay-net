namespace SaferPay.Models
{
	public class Brand
	{
		/// <summary>
		/// Alphanumeric id of the payment method / brand
		/// </summary>
		public string PaymentMethod { get; set; }
		/// <summary>
		/// Name of the Brand (Visa, Mastercard, an so on – might change over time). 
		/// Only use it for display, never for parsing and/or mapping! 
		/// Use <see cref="PaymentMethod"/> for parsing and mapping purposes.
		/// </summary>
		public string Name { get; set; }
	}
}