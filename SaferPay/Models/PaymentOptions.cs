namespace SaferPay.Models
{
	public class PaymentOptions
	{
		/// <summary>
		/// Used to flag the transaction as a Pre-Athorization.
		/// </summary>
		/// <remarks>
		/// This type of transaction is only supported with the following Acquiring: 
		/// SIX Payment Services, B+S Card Service, ConCardis, Airplus 
		/// and -after an agreement- with American Express.
		/// </remarks>
		public bool PreAuth { get; set; }
	}
}