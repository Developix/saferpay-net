namespace SaferPay.Models
{
	public class InitializationAlias
	{
		/// <summary>
		/// Id / name of the alias. This value is case-insensitive.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Verification code (CVV, CVC) if applicable 
		/// (ie the alias referenced is a card).
		/// </summary>
		public string VerificationCode { get; set; }
	}
}
