namespace SaferPay.Models
{
	/// <summary>
	/// Card data
	/// </summary>
	public class InitializationCard
	{
		/// <summary>
		/// Card number without separators
		/// </summary>
		public string Number { get; set; }
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
		/// Verification code (CVV, CVC) if applicable
		/// </summary>
		public string VerificationCode { get; set; }
	}
}