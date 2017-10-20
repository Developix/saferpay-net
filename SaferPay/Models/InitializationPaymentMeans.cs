namespace SaferPay.Models
{
	/// <summary>
	/// Information about the means of payment
	/// </summary>
	public class InitializationPaymentMeans
	{
		/// <summary>
		/// Card data
		/// </summary>
		public InitializationCard Card { get; set; }
		/// <summary>
		/// Bank account data for direct debit transactions.
		/// </summary>
		public BankAccount BankAccount { get; set; }
		/// <summary>
		/// Alias data if payment means was registered with Secure Card Data before.
		/// </summary>
		public InitializationAlias Alias { get; set; }
	}
}