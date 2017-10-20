namespace SaferPay.Models
{
	public class Notification
	{
		/// <summary>
		/// Email address to which a confirmation email will be sent for 
		/// successful authorizations.
		/// </summary>
		public string MerchantEmail { get; set; }
		/// <summary>
		/// Email address to which a confirmation email will be sent for 
		/// successful authorizations.
		/// </summary>
		public string PayerEmail { get; set; }
		/// <summary>
		/// Url to which Saferpay will send the asynchronous confirmation for 
		/// the transaction. Supported schemes are http and https. You also 
		/// have to make sure to support the GET-method.
		/// </summary>
		public string NotifyUrl { get; set; }
	}
}